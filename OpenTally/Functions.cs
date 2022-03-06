using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Deployment.Application;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Xml;

namespace OpenTally
{
    class Functions
    {

        // Serial Variables
        public bool serialConnected = false;
        public string comPort = null;
        public string[] serialVars;


        // Thanks https://stackoverflow.com/questions/1344221/how-can-i-generate-random-alphanumeric-strings
        public static Random random = new Random();
        public static string RandomString(int length)
        {
            const string chars = "abcdefghijklmnopqrstuvwxyz0123456789";
            return new string(Enumerable.Range(1, length).Select(_ => chars[random.Next(chars.Length)]).ToArray());
        }


        #region -  Config File Manipulation  -

        // ########## Config File ########## //
        public static Config loadConfigXML()
        {
            Config configObj = new Config();

            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(Application.StartupPath + "\\config.xml");
            XmlNode first = xmlDoc.SelectSingleNode("root/Source1");
            configObj.source1 = first.Attributes["name"].Value;
            XmlNode second = xmlDoc.SelectSingleNode("root/Source2");
            configObj.source2 = second.Attributes["name"].Value;
            XmlNode third = xmlDoc.SelectSingleNode("root/Source3");
            configObj.source3 = third.Attributes["name"].Value;
            XmlNode fourth = xmlDoc.SelectSingleNode("root/Source4");
            configObj.source4 = fourth.Attributes["name"].Value;
            XmlNode fifth = xmlDoc.SelectSingleNode("root/Source5");
            configObj.source5 = fifth.Attributes["name"].Value;
            XmlNode sixth = xmlDoc.SelectSingleNode("root/Source6");
            configObj.source6 = sixth.Attributes["name"].Value;
            XmlNode seventh = xmlDoc.SelectSingleNode("root/Source7");
            configObj.source7 = seventh.Attributes["name"].Value;
            XmlNode eighth = xmlDoc.SelectSingleNode("root/Source8");
            configObj.source8 = eighth.Attributes["name"].Value;
            XmlNode wesPass = xmlDoc.SelectSingleNode("root/Websocket");
            configObj.wsPassword = Decrypt(wesPass.Attributes["password"].Value, MainForm.pwKey);
            XmlNode wesPort = xmlDoc.SelectSingleNode("root/WebsocketPort");
            configObj.wsPort = wesPort.Attributes["port"].Value;
            XmlNode wesAddress = xmlDoc.SelectSingleNode("root/WebsocketAddress");
            configObj.wsAddress = wesAddress.Attributes["address"].Value;
            XmlNode CutBus = xmlDoc.SelectSingleNode("root/CutBus");
            configObj.cut_bus = CutBus.Attributes["cutbus"].Value;
            XmlNode Mode = xmlDoc.SelectSingleNode("root/Mode");
            configObj.mode = Mode.Attributes["mode"].Value;

            return configObj;
        }

        public static Config assignConfig(Config configObj, List<Devices> deviceList)
        {
            configObj = new Config();//Clear out configObj since it may have OBS values left in it
            for (var j = 0; j < deviceList.Count; j++)// For each device, update Tally Label respectively
            {
                if (configObj.GetType().GetProperties()[j].ToString().Contains("source") && j <= configObj.GetType().GetProperties().Count())//If configObj is a source variable (see ClassObjects.cs -> Config class)
                {
                    string[] propertyName = configObj.GetType().GetProperties()[j].ToString().Split(' ');
                    //Console.WriteLine("configObj at index " + j + "=" + propertyName[1]);
                    configObj.GetType().GetProperty(propertyName[1]).SetValue(configObj, deviceList[j].name, null);
                }
            }
            return configObj;
        }

        #endregion


        #region -  Input Validations  -

        public static bool ValidateInputs(string addr, string type)
        {
            string pattern = "";
            if (type == "ip_address")
            {
                pattern = @"^([1-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])(\.([0-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])){3}$";
            }
            else if (type == "port")
            {
                pattern = @"^([0-9]{1,4}|[1-5][0-9]{4}|6[0-4][0-9]{3}|65[0-4][0-9]{2}|655[0-2][0-9]|6553[0-5])$";
            }

            Regex check = new Regex(pattern);
            bool valid = false;

            if (addr == "")
            {
                valid = false;
            }
            else
            {
                valid = check.IsMatch(addr, 0);
            }
            return valid;
        }

        #endregion


        #region -  Reflective Functions  -

        public static object GetPropValue(object src, string propName)
        {
            return src.GetType().GetProperty(propName).GetValue(src, null);
        }

        // Returns deploment application information
        // Thanks to https://stackoverflow.com/questions/6493715/how-to-get-the-current-product-version-in-c
        public static string CurrentVersion
        {
            get
            {
                return ApplicationDeployment.IsNetworkDeployed
                       ? ApplicationDeployment.CurrentDeployment.CurrentVersion.ToString()
                       : Assembly.GetExecutingAssembly().GetName().Version.ToString();
            }
        }

        #endregion


        #region -  Tally Functions  -

        public static int countSources(Config configObj)
        {
            int count = 0;
            foreach (PropertyInfo obj in configObj.GetType().GetProperties())
            {
                //Console.WriteLine(propertyInfo);
                object value = obj.GetValue(configObj, null);
                if (obj.ToString().Contains("source") && value != null && !string.IsNullOrEmpty(value.ToString()))//If configObj is a source variable (see ClassObjects.cs -> Config class)
                {
                    count++;//iterate counter
                }
            }
            return count;
        }

        public static List<Devices> toDeviceList(List<OBSWebsocketDotNet.Types.SceneItem> sceneItems)
        {
            List<Devices> tmp = new List<Devices>(); //Initialize list
            foreach (var source in sceneItems)
            {
                tmp.Add(new Devices { id = source.ID.ToString(), name = source.SourceName });//Add to new List<Devices> format
            }
            return tmp;
        }


        #endregion


        #region -  Hashing, Encryption, Decryption  -

        // Password Hashing. Not used because I don't have a good way to "decrypt" a hashed password once it is hashed...
        // See here: https://stackoverflow.com/questions/4181198/how-to-hash-a-password

        // Password AES Encryption
        // Thanks to: https://stackoverflow.com/questions/32972126/creating-decrypt-passwords-with-salt-iv
        public static string Encrypt(string plainTextPass, string encryptionKey)
        {
            byte[] originalBytes = Encoding.UTF8.GetBytes(plainTextPass);
            byte[] encryptedBytes = null;
            byte[] passwordBytes = Encoding.UTF8.GetBytes(encryptionKey);

            // Hash the password with SHA256
            passwordBytes = SHA256.Create().ComputeHash(passwordBytes);

            // Generating salt bytes
            byte[] saltBytes = GenerateRandomBytes();

            // Appending salt bytes to original bytes
            byte[] bytesToBeEncrypted = new byte[saltBytes.Length + originalBytes.Length];
            for (int i = 0; i < saltBytes.Length; i++)
            {
                bytesToBeEncrypted[i] = saltBytes[i];
            }
            for (int i = 0; i < originalBytes.Length; i++)
            {
                bytesToBeEncrypted[i + saltBytes.Length] = originalBytes[i];
            }

            encryptedBytes = AES_Encrypt(bytesToBeEncrypted, passwordBytes);

            return Convert.ToBase64String(encryptedBytes);
        }

        private static string Decrypt(string decryptedPass, string decryptionKey)
        {
            byte[] bytesToBeDecrypted = Convert.FromBase64String(decryptedPass);
            byte[] passwordBytes = Encoding.UTF8.GetBytes(decryptionKey);

            // Hash the password with SHA256
            passwordBytes = SHA256.Create().ComputeHash(passwordBytes);

            byte[] decryptedBytes = AES_Decrypt(bytesToBeDecrypted, passwordBytes);

            // Getting the size of salt
            int _saltSize = 4;

            // Removing salt bytes, retrieving original bytes
            byte[] originalBytes = new byte[decryptedBytes.Length - _saltSize];
            for (int i = _saltSize; i < decryptedBytes.Length; i++)
            {
                originalBytes[i - _saltSize] = decryptedBytes[i];
            }

            return Encoding.UTF8.GetString(originalBytes);
        }

        public static byte[] GenerateRandomBytes()
        {
            int _saltSize = 4;
            byte[] ba = new byte[_saltSize];
            RNGCryptoServiceProvider.Create().GetBytes(ba);
            return ba;
        }

        public static byte[] AES_Encrypt(byte[] bytesToBeEncrypted, byte[] keyBytes)
        {
            byte[] encryptedBytes = null;

            // The salt bytes must be at least 8 bytes. Change to add entropy.
            byte[] saltBytes = new byte[] { 4, 2, 1, 8, 3, 4, 1, 6 };

            using (MemoryStream ms = new MemoryStream())
            {
                using (RijndaelManaged AES = new RijndaelManaged())
                {
                    AES.KeySize = 256;
                    AES.BlockSize = 128;

                    var key = new Rfc2898DeriveBytes(keyBytes, saltBytes, 1000);
                    AES.Key = key.GetBytes(AES.KeySize / 8);
                    AES.IV = key.GetBytes(AES.BlockSize / 8);

                    AES.Mode = CipherMode.CBC;

                    using (var cs = new CryptoStream(ms, AES.CreateEncryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(bytesToBeEncrypted, 0, bytesToBeEncrypted.Length);
                        cs.Close();
                    }
                    encryptedBytes = ms.ToArray();
                }
            }

            return encryptedBytes;
        }

        private static byte[] AES_Decrypt(byte[] bytesToBeDecrypted, byte[] keyBytes)
        {
            byte[] decryptedBytes = null;

            // The salt bytes from the encryption function.
            byte[] saltBytes = new byte[] { 4, 2, 1, 8, 3, 4, 1, 6 };

            using (MemoryStream ms = new MemoryStream())
            {
                using (RijndaelManaged AES = new RijndaelManaged())
                {
                    AES.KeySize = 256;
                    AES.BlockSize = 128;

                    var key = new Rfc2898DeriveBytes(keyBytes, saltBytes, 1000);
                    AES.Key = key.GetBytes(AES.KeySize / 8);
                    AES.IV = key.GetBytes(AES.BlockSize / 8);

                    AES.Mode = CipherMode.CBC;

                    using (var cs = new CryptoStream(ms, AES.CreateDecryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(bytesToBeDecrypted, 0, bytesToBeDecrypted.Length);
                        cs.Close();
                    }
                    decryptedBytes = ms.ToArray();
                }
            }

            return decryptedBytes;
        }

        public static string loadEncryptionKey()
        {
            object key = null;
            string keypath = "Software\\OpenTally";
            RegistryKey regkey = Registry.CurrentUser.OpenSubKey(keypath, true);
            if (regkey != null)// if root key exists, continue
            {
                key = regkey.GetValue("PWKey");//Load subkey
                if (key != null) { return key.ToString(); }
                else { return null; }// Return null if subkey doesn't exist
            }
            else
            {
                return null;// Return null if root key doesn't exist
            }
        }

        public static void setEncryptionKey(string key)
        {
            // If registry key does not exist, create it under \HKEY_CURRENT_USER\SOFTWARE\OpenTally to store password encryption key.
            Microsoft.Win32.RegistryKey regkey = Microsoft.Win32.Registry.CurrentUser.OpenSubKey("Software", true);
            regkey.CreateSubKey("OpenTally"); regkey = regkey.OpenSubKey("OpenTally", true);// Create and open the key
            regkey.SetValue("PWKey", key);// Set the key
            regkey.Close();
        }

        #endregion


        #region -  Misc functions  -

        //This function is simple. It takes in an object, probably a JSON object like the one below and trims the
        //outer brackets to make it Newtonsoft JSON kosher:
        /* Example Bus Options:
        [ <<- THIS BRACKET IS TRIMMED
            {
		    "id": "e393251c",
		    "label": "Preview",
		    "type": "preview",
		    "color": "#3fe481",
		    "priority": 50
            }
        ] <<- THIS BRACKET IS TRIMMED
        */
        public static string JSONformat(object data) {
            string s = data.ToString().Substring(1, data.ToString().Length - 2);//Simply trims outermost brackets from JSON string.
            return s;
        }

        // https://stackoverflow.com/questions/2094239/swap-two-items-in-listt
        // Call it like (no returns): Functions.Swap(deviceList, oldDeviceIndex, newDeviceIndex);
        public static void Swap<T>(IList<T> list, int indexA, int indexB)
        {
            T tmp = list[indexA];
            list[indexA] = list[indexB];
            list[indexB] = tmp;
        }

        #endregion

    }
}
