using Siticone.Desktop.UI.WinForms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Xml;

namespace OpenTally
{
    public partial class SetupPopup : Form
    {

        // Socket Variables
        public string wsAddress = "127.0.0.1";
        public string OBSDefaultPort = "4444";
        public string TADefaultPort = "4455";

        // Setup Variables
        public string mode;
        public bool configComplete = false;
        public string cut_bus = "true";
        public static string TallyServerRelay = "Tally Server Relay";
        public static string OBSDirectConnect = "OBS Direct-Connect";
        private Config configObj = new Config();

        // UI Manip Variables
        public float[] LayoutPanelAllRowHeightsPercent = new float[6];
        public float[] LayoutPanelAllRowHeightsPixels = new float[6];
        public float[] LayoutPanelUserConfigRowHeightsPercent = new float[6];
        public float[] LayoutPanelUserConfigRowHeightsPixels = new float[6];

        // Serial vars
        public string[] serialVars;

        public SetupPopup()
        {
            InitializeComponent();

            //OBS.socket.Connected += onConnect;
            //OBS.socket.Disconnected += onDisconnect;
            //OBS.socket.SceneChanged += onSceneChange;

            new SiticoneShadowForm(this);
            new SiticoneDragControl(this);
            DoubleBuffered = true;
            SetStyle(ControlStyles.ResizeRedraw, true);

            new SiticoneDragControl(WiredWirelessLabel);//Make dragable
            new SiticoneDragControl(MessageText);//Make dragable

        }


        #region -  UI Overrides  -
        //This region contains UI override functions to manipulate form on load.

        //Create window resize handle, from https://stackoverflow.com/questions/2575216/how-to-move-and-resize-a-form-without-a-border
        protected override void OnPaint(PaintEventArgs e)
        {
            Rectangle rc = new Rectangle(ClientSize.Width - UIElements.cGrip, ClientSize.Height - UIElements.cGrip, UIElements.cGrip, UIElements.cGrip);
            ControlPaint.DrawSizeGrip(e.Graphics, BackColor, rc);
        }

        //Create window resize handle, from https://stackoverflow.com/questions/2575216/how-to-move-and-resize-a-form-without-a-border
        protected override void WndProc(ref Message m)
        {
            if (m.Msg == 0x84) // Trap WM_NCHITTEST
            {
                Point pos = new Point(m.LParam.ToInt32());
                pos = PointToClient(pos);
                if (pos.X >= ClientSize.Width - UIElements.cGrip && pos.Y >= ClientSize.Height - UIElements.cGrip)
                {
                    m.Result = (IntPtr)17; // HTBOTTOMRIGHT
                    return;
                }
            }
            base.WndProc(ref m);
        }





        #endregion


        #region -  On setupPopup Load  -

        private void SetupPopup_Load(object sender, EventArgs e)
        {

            //Store current row heights before hiding them
            LayoutPanelAllRowHeightsPercent = UIElements.GetRowHeights(LayoutPanelAll);//Store height FOR wireless mode
            LayoutPanelAllRowHeightsPixels = UIElements.GetRowHeights(LayoutPanelAll, "pixels");//Store height FOR wireless mode
            LayoutPanelUserConfigRowHeightsPercent = UIElements.GetRowHeights(LayoutPanelUserConfig);//Store height FOR wireless mode
            LayoutPanelUserConfigRowHeightsPixels = UIElements.GetRowHeights(LayoutPanelUserConfig, "pixels");//Store height FOR wireless mode

            IPAddressComboBox.Items.Add("Local Address");
            IPAddressComboBox.Items.Add("Custom Address");

            PortComboBox.Items.Add("Default Port");
            PortComboBox.Items.Add("Custom Port");

            TestConnectButton.Enabled = true;

            UIElements.GetControlsOfType<SiticoneComboBox>(LayoutPanelSourceUI).ToList().ForEach(element => element.Items.Add(""));//Add blank to all source selections
            UIElements.GetControlsOfType<SiticoneComboBox>(LayoutPanelSourceUI).ToList().ForEach(element => element.SelectedIndex = 0);//Required to avoid null values

            //Config Loading
            try
            {
                configObj = Functions.loadConfigXML(); // Load the XML file, catch if it doesn't exist
            }
            catch
            {

            }


            if (configObj.mode != null)// If there is a config.xml file, configObj.mode won't be null.
            {
                // Set UI depending on mode from config
                if (configObj.mode == OBSDirectConnect)
                {
                    //Initialize for OBSDirectConnect mode
                    Size = MinimumSize = new Size(Width, Height - (int)LayoutPanelAllRowHeightsPixels[2] - (int)LayoutPanelUserConfigRowHeightsPixels[2]);//Resize form to be shorter to accomodate missing controls
                    SetUIOBSDirectConnect(sender, e);//Set UI for OBS Direct Connect mode
                    WiredWirelessToggle.Checked = true;

                }
                else if (configObj.mode == TallyServerRelay)
                {
                    //Initialize for TallyServerRelay mode
                    Size = MinimumSize = new Size(Width, Height - (int)LayoutPanelAllRowHeightsPixels[4]);//Resize form to be shorter
                    SetUITallyServerRelay(sender, e);//Set UI for Tally Server Relay mode using function
                }

                //Set user text fields and combo boxes based on configObj
                if (configObj.wsPort == TADefaultPort || configObj.wsPort == OBSDefaultPort)
                {
                    PortComboBox.SelectedIndex = 0;
                }
                else
                {
                    PortComboBox.SelectedIndex = 1;
                    PortTextBox.Text = configObj.wsPort;
                }
                if (configObj.wsAddress != wsAddress)
                {
                    IPAddressComboBox.SelectedIndex = 1;
                    IPAddressTextBox.Text = configObj.wsAddress;
                }
                else
                {
                    IPAddressComboBox.SelectedIndex = 0;
                }

                // Load items from config into device selections
                PasswordTextBox.Text = configObj.wsPassword;
                SetupPopup.GetDevicesFromConfig(configObj, LayoutPanelSourceUI);
                MessageText.Text = "Loaded devices from offline config.";

            }
            else if (configObj.mode == null)// If there is no config.xml file found, initialize default UI as TallyServerRelay mode
            {
                //Initialize for TallyServerRelay mode
                Size = MinimumSize = new Size(Width, Height - (int)LayoutPanelAllRowHeightsPixels[4]);//Resize form to be shorter
                SetUITallyServerRelay(sender, e);//Set UI for Tally Server Relay mode using function.

                PortTextBox.Text = configObj.wsPort = TADefaultPort;
                IPAddressTextBox.Text = configObj.wsAddress = wsAddress;
                PortComboBox.SelectedIndex = 0;
                IPAddressComboBox.SelectedIndex = 0;
            }

        }

        #endregion


        #region -  Save & Load to/from XML  -

        private void Save_Click(object sender, EventArgs e)
        {

            XmlDocument xmlDoc = new XmlDocument();

            XmlNode Root = xmlDoc.AppendChild(xmlDoc.CreateElement("root"));

            XmlNode Child1 = Root.AppendChild(xmlDoc.CreateElement("Websocket"));
            XmlAttribute ChildAtt1 = Child1.Attributes.Append(xmlDoc.CreateAttribute("password"));
            ChildAtt1.InnerText = Functions.Encrypt(PasswordTextBox.Text, MainForm.pwKey);

            XmlNode Child2 = Root.AppendChild(xmlDoc.CreateElement("Source1"));
            XmlAttribute ChildAtt2 = Child2.Attributes.Append(xmlDoc.CreateAttribute("name"));
            ChildAtt2.InnerText = siticoneComboBox1.SelectedItem.ToString();

            XmlNode Child3 = Root.AppendChild(xmlDoc.CreateElement("Source2"));
            XmlAttribute ChildAtt3 = Child3.Attributes.Append(xmlDoc.CreateAttribute("name"));
            ChildAtt3.InnerText = siticoneComboBox2.SelectedItem.ToString();

            XmlNode Child4 = Root.AppendChild(xmlDoc.CreateElement("Source3"));
            XmlAttribute ChildAtt4 = Child4.Attributes.Append(xmlDoc.CreateAttribute("name"));
            ChildAtt4.InnerText = siticoneComboBox3.SelectedItem.ToString();

            XmlNode Child5 = Root.AppendChild(xmlDoc.CreateElement("Source4"));
            XmlAttribute ChildAtt5 = Child5.Attributes.Append(xmlDoc.CreateAttribute("name"));
            ChildAtt5.InnerText = siticoneComboBox4.SelectedItem.ToString();

            XmlNode Child6 = Root.AppendChild(xmlDoc.CreateElement("Source5"));
            XmlAttribute ChildAtt6 = Child6.Attributes.Append(xmlDoc.CreateAttribute("name"));
            ChildAtt6.InnerText = siticoneComboBox5.SelectedItem.ToString();

            XmlNode Child7 = Root.AppendChild(xmlDoc.CreateElement("Source6"));
            XmlAttribute ChildAtt7 = Child7.Attributes.Append(xmlDoc.CreateAttribute("name"));
            ChildAtt7.InnerText = siticoneComboBox6.SelectedItem.ToString();

            XmlNode Child8 = Root.AppendChild(xmlDoc.CreateElement("Source7"));
            XmlAttribute ChildAtt8 = Child8.Attributes.Append(xmlDoc.CreateAttribute("name"));
            ChildAtt8.InnerText = siticoneComboBox7.SelectedItem.ToString();

            XmlNode Child9 = Root.AppendChild(xmlDoc.CreateElement("Source8"));
            XmlAttribute ChildAtt9 = Child9.Attributes.Append(xmlDoc.CreateAttribute("name"));
            ChildAtt9.InnerText = siticoneComboBox8.SelectedItem.ToString();

            XmlNode Child10 = Root.AppendChild(xmlDoc.CreateElement("WebsocketAddress"));
            XmlAttribute ChildAtt10 = Child10.Attributes.Append(xmlDoc.CreateAttribute("address"));
            ChildAtt10.InnerText = IPAddressTextBox.Text;

            XmlNode Child11 = Root.AppendChild(xmlDoc.CreateElement("WebsocketPort"));
            XmlAttribute ChildAtt11 = Child11.Attributes.Append(xmlDoc.CreateAttribute("port"));
            ChildAtt11.InnerText = PortTextBox.Text;

            XmlNode Child12 = Root.AppendChild(xmlDoc.CreateElement("CutBus"));
            XmlAttribute ChildAtt12 = Child12.Attributes.Append(xmlDoc.CreateAttribute("cutbus"));
            ChildAtt12.InnerText = cut_bus;

            XmlNode Child13 = Root.AppendChild(xmlDoc.CreateElement("Mode"));
            XmlAttribute ChildAtt13 = Child13.Attributes.Append(xmlDoc.CreateAttribute("mode"));
            ChildAtt13.InnerText = mode;

            try
            {
                xmlDoc.Save(Application.StartupPath + "\\config.xml");
                configComplete = true;
            }
            catch
            {
                MessageBox.Show("Unable to save config file.", "Failed to write file", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Close();
        }

        #endregion


        #region -  Button Click Events  -

        private void WiredWirelessToggle_CheckedChanged(object sender, EventArgs e)
        {

            if (WiredWirelessToggle.Checked) //if checked, "OBS Direct-Connect" mode
            {
                SetUIOBSDirectConnect(sender, e);//Set UI for OBS Direct Connect mode
            }
            else //else unchecked, "TALLY SERVER RELAY" mode
            {
                SetUITallyServerRelay(sender, e);//Set UI for Tally Server Relay mode
            }

        }

        private void pwShow_CheckedChanged(object sender, EventArgs e)
        {
            if (pwShow.Checked) //if checked
            {
                PasswordTextBox.UseSystemPasswordChar = false;//Show password in the clear
            }
            else //else unchecked
            {
                PasswordTextBox.UseSystemPasswordChar = true;//Obscure password
            }
        }

        private void wsConnect_Click(object sender, EventArgs e)
        {
            // Set UI depending on mode from config
            if (mode == OBSDirectConnect)
            {
                Console.WriteLine("Testing OBS connection");
                OBS.TestConnection("ws://" + configObj.wsAddress + ":" + configObj.wsPort, configObj.wsPassword, TestConnectButton, MessageText, LayoutPanelSourceUI);
            }
            else if (mode == TallyServerRelay)
            {
                Console.WriteLine("Testing TallyArbiter connection");
                TallyArbiter.TestConnection("http://" + configObj.wsAddress + ":" + configObj.wsPort, TestConnectButton, MessageText);
            }
        }

        private void DeviceInfoButton_Click(object sender, EventArgs e)
        {
            if (Serial.connected) //If device is conected
            {

                // Request info from Arduino
                Serial.port.Write("98,*\r\n");
                Console.WriteLine("Device info requested.");

                // Verify that Arduino was programmed properly
                int count = 0;
                while (count < 5000)
                { // In the time it takes to count to 5000, the confirmation string should be returned from Arduino
                    if (serialVars != null && (serialVars[0] == "98"))
                    {
                        MessageText.Text = "Settings were successfully retrieved from device.";
                        MessageText.BackColor = Color.LightSeaGreen;
                        DeviceInfoPopup deviceInfo = new DeviceInfoPopup(Serial.buffer, serialVars[1], serialVars[2], serialVars[3], serialVars[4], serialVars[5], serialVars[6].Trim());
                        deviceInfo.ShowDialog();
                        break;
                    }
                    else if (serialVars != null && (serialVars[0] != "98" || serialVars[1] == String.Empty || serialVars[2] == String.Empty
                        || serialVars[3] == String.Empty || serialVars[4] == String.Empty || serialVars[5] == String.Empty || serialVars[6] == String.Empty))
                    {
                        MessageText.BackColor = Color.LightYellow;
                        MessageText.Text = "No communication from device, try again.";
                    }
                    serialVars = Serial.LineReceived(Serial.port.ReadExisting());
                    count++;
                }
                Console.WriteLine("End while loop");
                serialVars = null; //Reset serialVars for the next time around

            }
            else
            {
                MessageBox.Show("No device connected.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void DeviceProgramButton_Click(object sender, EventArgs e)
        {
            if (Serial.connected) //If device is conected
            {
                DeviceProgramPopup programmer = new DeviceProgramPopup();
                programmer.ShowDialog();
                if (programmer.SSID != null && programmer.Pass != null && programmer.TAHost != null && programmer.TAPort != null)
                {
                    // Program Arduino
                    Serial.port.Write("99," + programmer.SSID + "," + programmer.Pass + "," + programmer.TAHost + "," + programmer.TAPort + ",*\r\n");
                    Console.WriteLine("Device programmed.");
                }
                else
                {
                    Console.WriteLine("Programmer exited prematurely.");
                }

                // Verify that Arduino was programmed properly
                int count = 0;
                while (count < 5000)
                { // In the time it takes to count to 5000, the confirmation string should be returned from Arduino
                    if (serialVars != null && (serialVars[0] == "99" && serialVars[1] == programmer.SSID && serialVars[2] == programmer.Pass && serialVars[3] == programmer.TAHost && serialVars[4].Trim() == programmer.TAPort))
                    {
                        MessageText.Text = "Settings were successfully sent to device.";
                        MessageText.BackColor = Color.LightSeaGreen;
                        break;
                    }
                    else if (serialVars != null && (serialVars[0] != "99" || serialVars[1] != programmer.SSID || serialVars[2] != programmer.Pass || serialVars[3] != programmer.TAHost || serialVars[4].Trim() != programmer.TAPort))
                    {
                        MessageText.BackColor = Color.LightYellow;
                        MessageText.Text = "No verification from device, try programming again.";
                    }
                    serialVars = Serial.LineReceived(Serial.port.ReadExisting());
                    count++;
                }
                Console.WriteLine("End while loop");
                serialVars = null; //Reset serialVars for the next time around

            }
            else
            {

                MessageBox.Show("No device connected.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        #endregion


        #region -  Misc Events  -

        private void SerialConnectedTimer_Tick(object sender, EventArgs e)
        {
            DeviceInfoButton.Enabled = DeviceProgramButton.Enabled = Serial.connected;//Enable or disable buttons based on serial connectivity
        }

        private void IPAddressComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (IPAddressComboBox.SelectedIndex == 0)
            {
                IPAddressTextBox.Text = configObj.wsAddress = wsAddress;
                IPAddressTextBox.ReadOnly = true;
            }
            else if (IPAddressComboBox.SelectedIndex == 1)
            {
                IPAddressTextBox.Text = configObj.wsAddress;
                IPAddressTextBox.ReadOnly = false;
            }
        }

        private void PortComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (PortComboBox.SelectedIndex == 0)
            {
                PortTextBox.ReadOnly = true;
            }
            else if (PortComboBox.SelectedIndex == 1)
            {
                PortTextBox.ReadOnly = false;
            }

            if (mode == TallyServerRelay)
            {
                PortTextBox.Text = configObj.wsPort = TADefaultPort;
            }
            else if (mode == OBSDirectConnect)
            {
                PortTextBox.Text = configObj.wsPort = OBSDefaultPort;
            }

        }

        private void PasswordTextBox_Leave(object sender, EventArgs e)
        {
            configObj.wsPassword = PasswordTextBox.Text;
        }

        #endregion


        #region -  Validate Inputs  -

        private void IPAddressTextBox_Leave(object sender, EventArgs e)
        {
            bool isValidIP = Functions.ValidateInputs(IPAddressTextBox.Text, "ip_address"); //Check if IP address is valid
            UIElements.UIShowValid(IPAddressTextBox, IPAddressToolTip, isValidIP); //Show UI hints
            if (isValidIP == false) //Show toolitp
            {
                TestConnectButton.Enabled = false;
                Point pt = new Point(0, 0);
                pt.Offset(IPAddressTextBox.Width, 0);
                IPAddressToolTip.Show("Please enter a valid IP address (i.e. 192.168.0.10)", IPAddressTextBox, pt, 5000);
            }
            else if (isValidIP == true)
            {
                configObj.wsAddress = IPAddressTextBox.Text;//Set configObj value
                TestConnectButton.Enabled = true;
                IPAddressTextBox.BorderColor = Color.LightBlue;
                IPAddressTextBox.BorderThickness = 1;
            }
        }

        private void PortTextBox_Leave(object sender, EventArgs e)
        {
            bool isValidPort = Functions.ValidateInputs(PortTextBox.Text, "port"); //Check if port is valid
            UIElements.UIShowValid(PortTextBox, PortToolTip, isValidPort); //Show UI hints
            if (isValidPort == false) //Show tooltip
            {
                TestConnectButton.Enabled = false;
                Point pt = new Point(0, 0);
                pt.Offset(PortTextBox.Width, 0);
                PortToolTip.Show("Please enter a valid port (value between 0 - 65535)", PortTextBox, pt, 5000);
                UIElements.WSUpdateButton("Connect", TestConnectButton, Color.FromArgb(125, 137, 149), Color.White, "enabled");
            }
            else if (isValidPort == true)
            {
                configObj.wsPort = PortTextBox.Text;//set configObj value
                TestConnectButton.Enabled = true;
                PortTextBox.BorderColor = Color.LightBlue;
                PortTextBox.BorderThickness = 1;
            }
        }

        #endregion


        #region -  Wired/Wireless UI Toggle Functions  -

        private void SetUITallyServerRelay(object sender, EventArgs e)
        {
            mode = TallyServerRelay;
            if (TallyArbiter.socket != null) { TallyArbiter.socket.Off(); } //Kill any existing socket

            //Change description text
            WiredWirelessLabel.Text = TallyServerRelay;
            WiredWirelessLabel.Font = UIElements.scaleFont(WiredWirelessLabel);
            IPAddressLabel.Text = "Tally Server IP Address";
            PortLabel.Text = "Tally Server Port";
            MessageText.Text = "";

            //Reset TestConnectButton color and text
            TestConnectButton.WSUpdateControl(() => { TestConnectButton.Text = "Test Connection"; TestConnectButton.FillColor = Color.Gray; });

            //Resize form on toggle
            Size = MinimumSize = new Size(Width, Height - (int)LayoutPanelAllRowHeightsPixels[2] - (int)LayoutPanelUserConfigRowHeightsPixels[2] + (int)LayoutPanelAllRowHeightsPixels[4] + (int)LayoutPanelAllRowHeightsPixels[5]);//Resize form to be shorter to accomodate missing controls

            //Unhide rows using saved row heights FROM wireless mode
            LayoutPanelAll.RowStyles[4].Height = LayoutPanelAllRowHeightsPercent[4];//Show the DeviceInfo, DeviceProgram row

            //Hide rows from UI
            LayoutPanelAll.RowStyles[2].Height = LayoutPanelUserConfig.RowStyles[2].Height = 0;

            //Update port text by reusing state function
            PortComboBox_SelectedIndexChanged(sender, e);
        }

        private void SetUIOBSDirectConnect(object sender, EventArgs e)
        {
            mode = OBSDirectConnect;
            if (TallyArbiter.socket != null) { TallyArbiter.socket.Off(); } //Kill any existing socket

            //Change description text
            WiredWirelessLabel.Text = OBSDirectConnect;
            WiredWirelessLabel.Font = UIElements.scaleFont(WiredWirelessLabel);
            IPAddressLabel.Text = "OBS IP Address";
            PortLabel.Text = "OBS Websocket Port";
            MessageText.Text = "";

            //Reset TestConnectButton color and text
            TestConnectButton.WSUpdateControl(() => { TestConnectButton.Text = "Get Devices"; TestConnectButton.FillColor = Color.Gray; });

            //Resize form on toggle
            Size = MinimumSize = new Size(Width, Height + (int)LayoutPanelAllRowHeightsPixels[2] + (int)LayoutPanelUserConfigRowHeightsPixels[2] - ((int)LayoutPanelAllRowHeightsPixels[4] + (int)LayoutPanelAllRowHeightsPixels[5]));//Resize form to be shorter

            //Unhide rows using saved row heights FROM wired mode
            LayoutPanelAll.RowStyles[2].Height = LayoutPanelAllRowHeightsPercent[2];
            LayoutPanelUserConfig.RowStyles[2].Height = LayoutPanelUserConfigRowHeightsPercent[2];

            //Hide rows from UI
            LayoutPanelAll.RowStyles[4].Height = 0;//Hide the ProgramDeviceLayout and MessageText rows

            //Update port text
            PortComboBox_SelectedIndexChanged(sender, e);

        }

        #endregion


        #region -  OBS Specific Functions  -

        // Queries OBS for list of devices and updates controls accordingly
        // Call it like: SetupPopup.GetDevices(sourceList, ConnectButton, LayoutPanelSourceUI)
        public static void GetDevicesFromOBS(List<OBSWebsocketDotNet.Types.SourceInfo> sourceList, TableLayoutPanel LayoutPanelSourceUI)
        {

            UIElements.GetControlsOfType<SiticoneComboBox>(LayoutPanelSourceUI).ToList().ForEach(element => element.WSUpdateControl(() => { element.Items.Clear(); }));//Threadsafe clear combobox
            UIElements.GetControlsOfType<SiticoneComboBox>(LayoutPanelSourceUI).ToList().ForEach(element => element.WSUpdateControl(() => { element.Items.Add(""); }));//Threadsafe add blank selection

            int i = 1;//Start at 1 so we don't select null value
            foreach (var element in UIElements.GetControlsOfType<SiticoneComboBox>(LayoutPanelSourceUI))// For each comboBox
            {
                foreach (var source in sourceList)// For each device
                {
                    element.WSUpdateControl(() => { element.Items.Add(source.Name); });
                }
                if (i <= sourceList.Count)
                {
                    element.WSUpdateControl(() => { element.SelectedIndex = i; });
                }
                else
                {
                    element.WSUpdateControl(() => { element.SelectedIndex = 0; });
                }
                i++;
            }

        }

        // Queries OBS for list of devices and updates controls accordingly
        // Call it like: SetupPopup.GetDevices(sourceList, ConnectButton, LayoutPanelSourceUI)
        public static void GetDevicesFromConfig(Config configObj, TableLayoutPanel LayoutPanelSourceUI)
        {
            UIElements.GetControlsOfType<SiticoneComboBox>(LayoutPanelSourceUI).ToList().ForEach(element => element.WSUpdateControl(() => { element.Items.Clear(); }));//Threadsafe clear combobox
            UIElements.GetControlsOfType<SiticoneComboBox>(LayoutPanelSourceUI).ToList().ForEach(element => element.WSUpdateControl(() => { element.Items.Add(""); }));//Threadsafe add blank selection
            UIElements.GetControlsOfType<SiticoneComboBox>(LayoutPanelSourceUI).ToList().ForEach(element => element.WSUpdateControl(() => { element.SelectedIndex = 0; }));//Threadsafe add blank selection

            int i = 0;
            foreach (var element in UIElements.GetControlsOfType<SiticoneComboBox>(LayoutPanelSourceUI))// For each comboBox
            {
                for (var j = 0; j < configObj.GetType().GetProperties().Count(); j++)// For each property in configObj
                {
                    if (configObj.GetType().GetProperties()[j].ToString().Contains("source"))//If configObj is a source variable (see ClassObjects.cs -> Config class)
                    {
                        string[] propertyName = configObj.GetType().GetProperties()[j].ToString().Split(' ');
                        string value = Functions.GetPropValue(configObj, propertyName[1]).ToString();
                        //Console.WriteLine("j=" + j + ", i=" + i + " value is " + value);

                        if (!String.IsNullOrEmpty(value))
                        {
                            element.WSUpdateControl(() => { element.Items.Add(Functions.GetPropValue(configObj, propertyName[1])); });//If value is not null, add to ComboBox
                            if (i == j) { element.WSUpdateControl(() => { element.SelectedItem = value; }); }//If indeces match, make the selection
                        }
                    }

                }
                i++;
            }

        }

        //private void onConnect(object sender, EventArgs e)
        //{
        //    BeginInvoke((MethodInvoker)(() =>
        //    {


        //    }));
        //}

        //private void onDisconnect(object sender, EventArgs e)
        //{
        //    BeginInvoke((MethodInvoker)(() =>
        //    {


        //    }));
        //}

        //private void onSceneChange(OBSWebsocket sender, string newSceneName)
        //{
        //    BeginInvoke((MethodInvoker)delegate
        //    {
        //        ////////////// Update Websocket Variables //////////////
        //        string currentLiveScene = OBS.socket.GetCurrentScene().Name; // Get current live scene name
        //        OBS.LiveSceneSources = OBS.socket.GetCurrentScene().Items; // List all sources in current live scene
        //        string currentPreviewScene = OBS.socket.GetPreviewScene().Name; // Get current preview scene name
        //        OBS.previewDevices = OBS.socket.GetPreviewScene().Items; // List all sources in current preview scene
        //        Console.WriteLine(currentLiveScene);
        //        Console.WriteLine(currentPreviewScene);

        //    });
        //}


        #endregion

    }
}
