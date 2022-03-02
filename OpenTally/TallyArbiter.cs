using Newtonsoft.Json;
//using Quobject.SocketIoClientDotNet.Client;// socket.io for .NET (Client)
using SocketIOClient;
using Siticone.Desktop.UI.WinForms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace OpenTally
{
    class TallyArbiter
    {

        // JSON Classes
        public static List<Devices> deviceList = new List<Devices>(); //Initialize list
        public static List<DeviceStates> deviceStates = new List<DeviceStates>(); //Initialize list
        public static List<BusOptions> busses = new List<BusOptions>(); //Initialize list
        public static List<Devices> previewDevices = new List<Devices>(); //Initialize list
        public static List<Devices> liveDevices = new List<Devices>(); //Initialize list
        public static bool sceneChanged = false; //Variable to store status of socket_DeviceStates()


        //public static Socket socket;

        public static string lastPreviewSource = null;
        public static string lastLiveSource = null;
        public static bool IsConnected = false;
        public static bool firstConnect = false;


        #region -  Tally Arbiter SocketIO Functions  -

        // SocketIO Connection Handler
        //  Requires: string containing Websocket endpoint, string containing device ID, and a button to indicate connectivity
        public static async Task ConnectAsync(string wsAddress, SiticoneRoundedButton ConnectButton, Config configObj, Label Source1, Label Source2, Label Source3, Label Source4, Label Source5, Label Source6, Label Source7, Label Source8, Label InfoText, Form MainProgramForm, TableLayoutPanel tableLayout1)
        {
            var socket = new SocketIO(wsAddress); // Instantiate the socket.io connection

            UIElements.WSUpdateButton("Connecting...", ConnectButton, Color.Gray, Color.White, "disabled");

            socket.OnConnected += async (sender, e) =>
            {
                await socket.EmitAsync("devices");
                Console.WriteLine("Got to socket_Connected()");
                UIElements.WSUpdateButton("Connected\nLoading...", ConnectButton, Color.Green, Color.White, "disabled");
                IsConnected = true; firstConnect = true;
            };
            socket.OnDisconnected += async (sender, e) =>
            { //Disconnected
                UIElements.WSUpdateButton("Connection\ntimeout.", ConnectButton, Color.Orange, Color.Black, "enabled");
                UIElements.ColorAllLabels(Color.Gray, Source1, Source2, Source3, Source4, Source5, Source6, Source7, Source8, InfoText);
                IsConnected = false;
            };
            socket.OnError += async (sender, e) =>
            {
                UIElements.WSUpdateButton("Not\nconnected.", ConnectButton, Color.Red, Color.White, "enabled");
                IsConnected = false;
                //socket.Off(); //Kill the thread
            };
            socket.On("bus_options", (data) => { socket_BusOptions(data); });
            socket.On("deviceId", (data) => { socket_deviceID(data); });
            socket.On("devices", (data) => { socket_Devices(data); });
            socket.On("device_states", (data) => { socket_DeviceStates(data); });
            socket.On("flash", (data) => { socket_Flash(data); });
            socket.On("reassign", (data) => { socket_Reassign(data); });
            await socket.ConnectAsync();
            await socket.DisconnectAsync();

            async Task socket_BusOptions(object data)
            {
                Console.WriteLine("Got to socket_BusOptions()");
                //Console.WriteLine("Bus Options:\n" + data);

                string dataString = Functions.JSONformat(data);
                busses = JsonConvert.DeserializeObject<List<BusOptions>>(dataString);
            }

            async Task socket_deviceID(object data)
            {
                Console.WriteLine("Got to socket_deviceID()");
                string dataString = Functions.JSONformat(data);
                //Console.WriteLine("Device ID:\n" + data);
            }

            async Task socket_Devices(object data)
            {
                Console.WriteLine("Got to socket_Devices()");
                //Console.WriteLine("Devices:\n" + data);

                string dataString = Functions.JSONformat(data);
                deviceList = JsonConvert.DeserializeObject<List<Devices>>(dataString);//JSON deserialize device data

                for (var i = 0; i < deviceList.Count; i++)// For each device, update Tally Label respectively
                {
                    UIElements.GetControlsOfType<Label>(tableLayout1)[i].WSUpdateControl(() => { UIElements.GetControlsOfType<Label>(tableLayout1)[i].Text = deviceList[i].name; });
                }

                // Establish listener connection. See the following issue for more info:
                // https://github.com/josephdadams/TallyArbiter/pull/204#issuecomment-933751951
                if (firstConnect)// Only do this once upon first establishing connection.
                {
                    foreach (Devices device in deviceList)
                    {
                        listenerClient client = new listenerClient();
                        client.listenerType = "OpenTally_" + device.name.Replace(" ", "_");
                        //client.listenerType = "OpenTally " + device.name;
                        client.deviceId = device.id;
                        client.canBeReassigned = true;
                        client.canBeFlashed = true;
                        client.supportsChat = false;

                        //string deviceObj = "[{\"deviceId\": \"" + device.id + "\", \"listenerType\": \"" + client.listenerType + "\", \"canBeReassigned\": true, \"canBeFlashed\": true, \"supportsChat\": false }]";

                        string deviceObj = JsonConvert.SerializeObject(client);
                        Console.WriteLine(deviceObj);

                        //socket.Emit("listenerclient_connect", device.id, listenerType.Replace(" ", "_"), canBeReassigned, canBeFlashed, supportsChat); //Send client type to TA server
                        await socket.EmitAsync("listenerclient_connect", deviceObj); //Send client type to TA server

                    }
                    firstConnect = false;// We've connected at least once now, so set this to false.
                }

                MainForm.configObj = configObj = Functions.assignConfig(configObj, deviceList);// Assign to all configObjs
                UIElements.WSUpdateButton("Connected.", ConnectButton, Color.Green, Color.White, "disabled");
                UIElements.InitializeLabels(configObj, MainProgramForm, tableLayout1, Source1, Source2, Source3, Source4, Source5, Source6, Source7, Source8, InfoText);

            }

            async Task socket_DeviceStates(object data)
            {
                Console.WriteLine("Got to socket_DeviceStates()");
                //Console.WriteLine("Device States:\n" + data);

                string dataString = Functions.JSONformat(data);//Clean up JSON object
                deviceStates = JsonConvert.DeserializeObject<List<DeviceStates>>(dataString);
                bool mode_preview = false;
                bool mode_program = false;
                sceneChanged = true; //Scene has changed, so set to true

                // Evaluate tally busses and color labels accordingly.
                foreach (DeviceStates state in deviceStates)
                {

                    // First, get mode of each device by bus ID
                    if (getBusTypeById(state.busId) == "preview")
                    {
                        if (state.sources.Count() > 0)
                            {
                            mode_preview = true;
                            if (!previewDevices.Any(item => item.id == state.deviceId)) { previewDevices.Add(new Devices { id = state.deviceId, name = getDeviceNameById(state.deviceId) }); }//If id isn't already in the list, add it
                        }
                        else
                        {
                            mode_preview = false;
                            previewDevices.Remove(previewDevices.SingleOrDefault(item => item.id == state.deviceId));//Remove id from the list
                        }
                    }
                    if (getBusTypeById(state.busId) == "program")
                    {
                        if (state.sources.Count() > 0)
                        {
                            mode_program = true;
                            if (!liveDevices.Any(item => item.id == state.deviceId)) { liveDevices.Add(new Devices { id = state.deviceId, name = getDeviceNameById(state.deviceId) }); }//If id isn't already in the list, add it
                        }
                        else
                        {
                            mode_program = false;
                            liveDevices.Remove(liveDevices.SingleOrDefault(item => item.id == state.deviceId));//Remove id from the list
                        }
                    }

                    // Then, color labels by active mode
                    if (mode_preview && !mode_program)//PREVIEW
                    {
                        //Console.WriteLine("Device " + getDeviceNameById(state.deviceId) + " is in " + getBusTypeById(state.busId));
                        UIElements.RefreshLabels(getDeviceNameById(state.deviceId), Color.Green, configObj, Source1, Source2, Source3, Source4, Source5, Source6, Source7, Source8, InfoText);
                    }
                    else if (!mode_preview && mode_program)//LIVE
                    {
                        //Console.WriteLine("Device " + getDeviceNameById(state.deviceId) + " is in " + getBusTypeById(state.busId));
                        UIElements.RefreshLabels(getDeviceNameById(state.deviceId), Color.Red, configObj, Source1, Source2, Source3, Source4, Source5, Source6, Source7, Source8, InfoText);
                    }
                    else if (mode_preview && mode_program)//LIVE & PREVIEW
                    {
                        //Console.WriteLine("Device " + getDeviceNameById(state.deviceId) + " is in PREVIEW+PROGRAM");
                        if (configObj.cut_bus == "true")//true = Program + Preview = Red Tally; false = Programm + Preview = Yellow Tally
                        {
                            UIElements.RefreshLabels(getDeviceNameById(state.deviceId), Color.Red, configObj, Source1, Source2, Source3, Source4, Source5, Source6, Source7, Source8, InfoText);
                        }
                        else//false = Programm + Preview = Yellow Tally
                        {
                            UIElements.RefreshLabels(getDeviceNameById(state.deviceId), Color.Yellow, configObj, Source1, Source2, Source3, Source4, Source5, Source6, Source7, Source8, InfoText);
                        }
                    }
                    else if (!mode_preview && !mode_program)
                    {
                        //Console.WriteLine("Device " + getDeviceNameById(state.deviceId) + " is out of " + getBusTypeById(state.busId));
                        UIElements.RefreshLabels(getDeviceNameById(state.deviceId), Color.Gray, configObj, Source1, Source2, Source3, Source4, Source5, Source6, Source7, Source8, InfoText);
                    }

                }

                //Console.WriteLine("Live devices:");
                //foreach (Devices device in liveDevices) { Console.WriteLine(device.name); }

                //Console.WriteLine("Preview devices:");
                //foreach (Devices device in previewDevices) { Console.WriteLine(device.name); }

            }

            async Task socket_Flash(object data)
            {
                Console.WriteLine("Got to socket_Flash()");
                Console.WriteLine("Flash data:\n" + data);

                string dataString = Functions.JSONformat(data);//Clean up JSON object
                if (dataString != null)
                {
                    Label label = UIElements.getLabelByDeviceName(getDeviceNameById(dataString), Color.White, configObj, Source1, Source2, Source3, Source4, Source5, Source6, Source7, Source8, InfoText);
                    UIElements.Blink(label, 5);//Blink 5 times
                    UIElements.RefreshLabels(getDeviceNameById(dataString), Color.Gray, configObj, Source1, Source2, Source3, Source4, Source5, Source6, Source7, Source8, InfoText);
                }
                else
                {
                    UIElements.Blink(InfoText, 5);//Blink 5 times
                }
            }

            async Task socket_Reassign(object data)
            {
                Console.WriteLine("Got to socket_Reassign()");
                Console.WriteLine("Reassignment data:\n" + data);
                //socket.Emit("devices");//Get list of devices and device ID's
                string dataString = Functions.JSONformat(data);//Clean up JSON object
            }

            string getBusTypeById(string busId)
            {
                foreach (BusOptions bus in busses)//For each bus (preview/program)
                {
                    if (bus.id == busId) { return bus.type; }
                    //else { Console.WriteLine("getBusTypeById(): Bus with ID " + busId + " not found"); }
                }
                return "invalid";
            }

            string getDeviceNameById(string deviceId)
            {
                foreach (Devices device in deviceList)//For each device in the deviceList
                {
                    if (device.id == deviceId) { return device.name; }
                    //else { Console.WriteLine("getDeviceNameById(): Device with ID " + deviceId + " not found"); }
                }
                return "invalid";
            }
        }

        #endregion


        #region -  Tally Arbiter Test Connection  -

        // Simple SocketIO Connection Test Function
        //  Requires: string containing Websocket endpoint, string containing device ID, and a button to indicate connectivity
        public static void TestConnection(string wsAddress, SiticoneRoundedButton button, Label label)
        {
            label.WSUpdateControl(() => { label.Text = "Testing connection to " + wsAddress; });

            var socket = new SocketIO(wsAddress); // Instantiate the socket.io connection
            UIElements.WSUpdateButton("Connecting...", button, Color.Yellow, Color.Black, "disabled");

            socket.OnConnected += async (sender, e) =>
            {
                UIElements.WSUpdateButton("Connected.", button, Color.Green, Color.White, "disabled");
                label.WSUpdateControl(() => { label.Text = "Successfully connected to " + wsAddress; });
            };
            socket.OnDisconnected += async (sender, e) =>
            { //Disconnected
                UIElements.WSUpdateButton("Connection timeout.", button, Color.Orange, Color.White, "enabled");
                label.WSUpdateControl(() => { label.Text = "Conection to " + wsAddress + " timed out."; });
                IsConnected = false;
            };
            socket.OnError += async (sender, e) =>
            {
                UIElements.WSUpdateButton("Connection failure.", button, Color.Red, Color.White, "enabled");
                label.WSUpdateControl(() => { label.Text = "Conection to " + wsAddress + " failed."; });
                IsConnected = false;
            };

        }


        #endregion

    }
}
