using System;
using System.IO;
using System.IO.Ports;
using System.Collections.Generic;
using System.Windows.Forms;
using OBSWebsocketDotNet;
using System.Drawing;
using System.Xml;
using Siticone.Desktop.UI.WinForms;
using OBSWebsocketDotNet.Types;
//using System.Threading;

namespace OpenTally
{
    class OBS
    {
        public static OBSWebsocket socket = new OBSWebsocket();

        public static string lastLiveScene;
        public static string lastPreviewScene;
        public static List<Devices> previewDevices = new List<Devices>(); //Initialize list
        public static List<Devices> liveDevices = new List<Devices>(); //Initialize list
        public static List<OBSWebsocketDotNet.Types.SourceInfo> AllSources = new List<OBSWebsocketDotNet.Types.SourceInfo>();


        #region -  OBS Test Connection  -

        // Simple SocketIO Connection Test Function
        //  Requires: string containing Websocket endpoint, string containing device ID, and a button to indicate connectivity
        public static void TestConnection(string wsAddress, string wsPassword, SiticoneRoundedButton button, Label label, TableLayoutPanel LayoutPanelSourceUI)
        {
            label.WSUpdateControl(() => { label.Text = "Testing connection to " + wsAddress; });

            UIElements.WSUpdateButton("Connecting...", button, Color.Yellow, Color.Black, "disabled");

            try
            {

                socket.WSTimeout = TimeSpan.FromSeconds(1);
                socket.Connect(wsAddress, wsPassword);
                if (socket.IsConnected)
                {
                    label.WSUpdateControl(() => { label.Text = "Successfully connected to " + wsAddress; });
                    SetupPopup.GetDevicesFromOBS(socket.GetSourcesList(), LayoutPanelSourceUI);
                    UIElements.WSUpdateButton("Got device list.\nClick to refresh.", button, Color.Green, Color.White, "enabled");
                    //sourceList = socket.GetSourcesList();
                }
                else
                {
                    UIElements.WSUpdateButton("Connection\ntimeout.", button, Color.Red, Color.White, "enabled");
                    label.WSUpdateControl(() => { label.Text = "Conection to " + wsAddress + " timed out."; });
                }
            }
            catch(OBSWebsocketDotNet.AuthFailureException)
            {
                UIElements.WSUpdateButton("Authentication\nfailure.", button, Color.Orange, Color.White, "enabled");
            }
            catch (ErrorResponseException ex)
            {
                MessageBox.Show("Connect failed : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

        }
        #endregion


        #region -  OBS Connection Broker  -

        // Simple SocketIO Connection Test Function
        //  Requires: string containing Websocket endpoint, string containing device ID, and a button to indicate connectivity
        //  This function should only be called from MainProgram
        public static void Connect(string wsAddress, string wsPassword, SiticoneRoundedButton ConnectButton, Config configObj, Label Source1, Label Source2, Label Source3, Label Source4, Label Source5, Label Source6, Label Source7, Label Source8, Label InfoText, Form MainProgram, TableLayoutPanel tableLayout2)
        {

            UIElements.WSUpdateButton("Connecting...", ConnectButton, Color.Yellow, Color.Black, "disabled");

            try
            {
                socket.WSTimeout = TimeSpan.FromSeconds(1);// Set timeout
                socket.Connect(wsAddress, wsPassword);// Attempt to connect to main websocket
                if (socket.IsConnected)
                {
                    UIElements.WSUpdateButton("Connected.", ConnectButton, Color.Green, Color.White, "disabled");
                    UIElements.InitializeLabels(configObj, MainProgram, tableLayout2, Source1, Source2, Source3, Source4, Source5, Source6, Source7, Source8, InfoText);
                }
                else
                {
                    UIElements.WSUpdateButton("Connection\ntimeout.", ConnectButton, Color.Red, Color.White, "enabled");
                }
            }
            catch (OBSWebsocketDotNet.AuthFailureException)
            {
                UIElements.WSUpdateButton("Authentication\nfailure.", ConnectButton, Color.Orange, Color.White, "enabled");
            }
            catch (ErrorResponseException ex)
            {
                MessageBox.Show("Connect failed : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

        }

        #endregion


    }
}
