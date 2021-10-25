using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Management;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Xml;
using Newtonsoft.Json;
using Quobject.SocketIoClientDotNet.Client;// socket.io for .NET (Client)
using Siticone.Desktop.UI.WinForms;
using System.Reflection;
using System.Diagnostics;

namespace OpenTally
{

    public partial class MainForm : Form
    {


        //## Global Variables ##//
        private int PreviewsButton_ClickCount = 1;
        public int lastbutton2State = 1;

        // Config
        public static Config configObj = new Config();

        // Socket Variables
        public string deviceID = "";
        public string wsAddress = "127.0.0.1";
        public string OBSDefaultPort = "4444";
        public string TADefaultPort = "4455";
        public static bool previews;

        
        public MainForm()
        {
            InitializeComponent();

            Serial.port = new SerialPort("COM10", 115200, Parity.None, 8, StopBits.One);

            new SiticoneShadowForm(this);
            new SiticoneDragControl(this);
            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.ResizeRedraw, true);

        }

        #region -  Initialization  -
        // On Load
        private void MainProgram_Load(object sender, EventArgs e)
        {
            DeviceInfoButton.Enabled = Serial.connected;//Enable\Disable buttons based on serial connectivity
            
            //Initialize form with only 1 row of tally labels. Adding more than 4 devices/sources will drop down second row.
            this.Size = this.MinimumSize = new Size(this.Width, this.Height - (int)tableLayout2.RowStyles[1].Height);//Resize this
            tableLayout2.RowStyles[1].Height = 0;

            //Config Loading
            try
            {
                configObj = Functions.loadConfigXML(); // Load the XML file, catch if it doesn't exist
            }
            catch (FileNotFoundException) //if Config doesn't exist, show setupPopup
            {
                SetupButton_Click(sender, e);//Simulate setup button click
            }
            catch
            {

            }
            
            ServerConnectionHandler();//Server Connections
            UIElements.GetControlsOfType<Label>(this).ToList().ForEach(element => new SiticoneDragControl(element));//Make all labels dragabble
            InfoText.Text = "OpenTally v" + Functions.CurrentVersion;//Show version info

        }
        #endregion


        #region -  UI Overrides  -
        //This region contains UI override functions to manipulate form on load.

        //Create window resize handle, from https://stackoverflow.com/questions/2575216/how-to-move-and-resize-a-form-without-a-border
        protected override void OnPaint(PaintEventArgs e)
        {
            Rectangle rc = new Rectangle(this.ClientSize.Width - UIElements.cGrip, this.ClientSize.Height - UIElements.cGrip, UIElements.cGrip, UIElements.cGrip);
            ControlPaint.DrawSizeGrip(e.Graphics, this.BackColor, rc);
        }

        //Create window resize handle, from https://stackoverflow.com/questions/2575216/how-to-move-and-resize-a-form-without-a-border
        protected override void WndProc(ref Message m)
        {
            if (m.Msg == 0x84) // Trap WM_NCHITTEST
            {
                Point pos = new Point(m.LParam.ToInt32());
                pos = this.PointToClient(pos);
                if (pos.X >= this.ClientSize.Width - UIElements.cGrip && pos.Y >= this.ClientSize.Height - UIElements.cGrip)
                {
                    m.Result = (IntPtr)17; // HTBOTTOMRIGHT
                    return;
                }
            }
            base.WndProc(ref m);
        }





        #endregion


        #region -  Button Click Events  -

        private void TrayIcon_Click(object sender, EventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
        }

        private void SetupButton_Click(object sender, EventArgs e)
        {
            SetupPopup setItUp = new SetupPopup();
            setItUp.ShowDialog();
            if (setItUp.configComplete == true)
            {
                MessageText.Text = "New config loaded.";
                configObj = Functions.loadConfigXML();
                ServerConnectionHandler();
            }
        }

        private void MainProgram_Resize(object sender, EventArgs e)
        {
            if (FormWindowState.Minimized == this.WindowState)
            {
                TrayIcon.Visible = true;
                this.Hide();
            }
            else if (FormWindowState.Normal == this.WindowState)
            {
                TrayIcon.Visible = false;
            }
        }

        private void ServerConnectButton_Click(object sender, EventArgs e)
        {
            ServerConnectionHandler();
        }

        public void ProgramButton_Click(object sender, EventArgs e)
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
                    if (Serial.vars != null && (Serial.vars[0] == "99" && Serial.vars[1] == programmer.SSID && Serial.vars[2] == programmer.Pass && Serial.vars[3] == programmer.TAHost && Serial.vars[4].Trim() == programmer.TAPort))
                    {
                        MessageText.Text = "Settings were successfully sent to device.";
                        MessageText.BackColor = Color.LightSeaGreen;
                        break;
                    }
                    else if (Serial.vars != null && (Serial.vars[0] != "99" || Serial.vars[1] != programmer.SSID || Serial.vars[2] != programmer.Pass || Serial.vars[3] != programmer.TAHost || Serial.vars[4].Trim() != programmer.TAPort))
                    {
                        MessageText.BackColor = Color.LightYellow;
                        MessageText.Text = "No verification from device, try programming again.";
                    }
                    Serial.vars = Serial.LineReceived(Serial.port.ReadExisting());
                    count++;
                }
                Console.WriteLine("End while loop");
                Serial.vars = null; //Reset Serial.vars for the next time around

            }
            else
            {
                MessageBox.Show("No device connected.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void DeviceInfoButton_Click(object sender, EventArgs e)
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
                    if (Serial.vars != null && (Serial.vars[0] == "98"))
                    {
                        MessageText.Text = "Settings were successfully retrieved from device.";
                        MessageText.BackColor = Color.LightSeaGreen;
                        DeviceInfoPopup deviceInfo = new DeviceInfoPopup(Serial.buffer, Serial.vars[1], Serial.vars[2], Serial.vars[3], Serial.vars[4], Serial.vars[5], Serial.vars[6].Trim());
                        deviceInfo.ShowDialog();
                        break;
                    }
                    else if (Serial.vars != null && (Serial.vars[0] != "98" || Serial.vars[1] == String.Empty || Serial.vars[2] == String.Empty
                        || Serial.vars[3] == String.Empty || Serial.vars[4] == String.Empty || Serial.vars[5] == String.Empty || Serial.vars[6] == String.Empty))
                    {
                        Serial.buffer += Serial.vars[0]; //Append read serial lines to buffer variable
                        MessageText.BackColor = Color.LightYellow;
                        MessageText.Text = "No communication from device, try again.";
                    }
                    Serial.vars = Serial.LineReceived(Serial.port.ReadExisting());
                    count++;
                }
                Console.WriteLine("End while loop");
                Serial.vars = null; //Reset Serial.vars for the next time around

            }
            else
            {
                MessageBox.Show("No device connected.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void PreviewsButton_Click(object sender, EventArgs e)
        {
            if (PreviewsButton_ClickCount % 2 == 0) //If PreviewsButton_ClickCount is even
            {
                PreviewsButton.Text = "Previews ON";
                previews = true;
            }
            else                             //If PreviewsButton_ClickCount is odd
            {
                PreviewsButton.Text = "Previews OFF";
                previews = false;
            }
            PreviewsButton_ClickCount = PreviewsButton_ClickCount + 1;
        }

        #endregion


        #region -  Server Connection Handler  -

        private void ServerConnectionHandler ()
        {
            UIElements.ColorAllLabels(Color.Gray, Source1, Source2, Source3, Source4, Source5, Source6, Source7, Source8, null); //Gray out all labels

            if (configObj.mode == SetupPopup.TallyServerRelay)
            {
                TallyArbiter.Connect("http://" + configObj.wsAddress + ":" + configObj.wsPort, ServerConnectButton, configObj, Source1, Source2, Source3, Source4, Source5, Source6, Source7, Source8, MessageText, this, tableLayout2);
                pollOBS.Enabled = false;//Disable pollOBS timer
                pollTA.Enabled = true;//Enable pollTA timer
            }
            else if (configObj.mode == SetupPopup.OBSDirectConnect)
            {
                OBS.Connect("ws://" + configObj.wsAddress + ":" + configObj.wsPort, configObj.wsPassword, ServerConnectButton, configObj, Source1, Source2, Source3, Source4, Source5, Source6, Source7, Source8, MessageText, this, tableLayout2);
                if (TallyArbiter.socket != null) { TallyArbiter.socket.Emit("disconnect"); TallyArbiter.socket.Off(); Console.WriteLine("Ended socketIO connection"); }//Disable socketIO connection, if one exists
                pollOBS.Enabled = true;//Enable pollOBS timer
                pollTA.Enabled = false;//Disable pollTA timer
                OBS.lastLiveScene = OBS.lastPreviewScene = "";//reset last scenes to force a refresh.
            }
        }

        #endregion


        #region -  Serial Events  -

        private void serialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {

            // Great resource for C# serial: https://www.codeproject.com/Articles/678025/Serial-Comms-in-Csharp-for-Beginners
            string SerialBuffer = Serial.port.ReadExisting();
            BeginInvoke(new Serial.LineReceivedEvent(Serial.LineReceived), SerialBuffer);

        }

        private void DetectSerialTimer_Tick(object sender, EventArgs e)
        {
            string comPort = Serial.DetectDevice(Serial.devicePIDs); // Detect when client is connected using PID's

            try
            {
                if (comPort != null && !Serial.connected)
                {
                    Serial.ConnectSerial(Serial.port, comPort);
                    DeviceInfoButton.Enabled = Serial.connected = true;//Enable\Disable buttons based on serial connectivity

                    PortText.Font = UIElements.setFontSize(PortText, 10);
                    PortText.Text = comPort;
                    PortText.BackColor = Color.Green;
                }
                else if (comPort == null)
                {
                    Serial.port.Close();
                    DeviceInfoButton.Enabled = Serial.connected = false;//Enable\Disable buttons based on serial connectivity

                    PortText.Font = UIElements.setFontSize(PortText, 7.5);
                    PortText.Text = comPort;
                    PortText.BackColor = Color.Transparent;
                }
            }
            catch (System.InvalidOperationException)
            {
                Console.WriteLine("No serial connection established.");
                comPort = null;
                Serial.connected = false;
                PortText.Font = UIElements.setFontSize(PortText, 7.5);
                PortText.Text = "Disconnected";
                PortText.BackColor = Color.Transparent;
            }
            catch
            {

            }
            //Console.WriteLine("Serial connected: " + Serial.connected + " Com Port: " + comPort);
        }

        #endregion


        #region -  OBS Websocket Polling and Serial Events  -

        private void pollOBS_Tick(object sender, EventArgs e)
        {
            try //try even if serial port is closed
            {

                // Prevent running of websockets if config file doesn't exist.
                // Otherwise these values initialize as nulls, and everything crashes.
                if (OBS.socket.IsConnected)
                {

                    ////////////// Update Websocket Variables //////////////
                    string currentLiveScene = OBS.socket.GetCurrentScene().Name; // Get current live scene name
                    OBS.liveDevices = Functions.toDeviceList(OBS.socket.GetCurrentScene().Items); // List all sources in current live scene
                    string currentPreviewScene = OBS.socket.GetPreviewScene().Name; // Get current preview scene name
                    OBS.previewDevices = Functions.toDeviceList(OBS.socket.GetPreviewScene().Items); // List all sources in current preview scene

                    ////////////// LIVE //////////////
                    if (currentLiveScene != OBS.lastLiveScene && OBS.liveDevices != null && OBS.previewDevices != null) //If live scene state changes
                    {
                        Console.WriteLine("Live state has changed"); //Debugging
                        // Update live label colors for UI app
                        UIElements.ColorAllLabels(Color.Gray, Source1, Source2, Source3, Source4, Source5, Source6, Source7, Source8, MessageText); //Gray out all labels
                        if (PreviewsButton.Text == "Previews ON")
                        { //Refresh preview labels
                            foreach (var source in OBS.previewDevices) { UIElements.RefreshLabels(source.name, Color.Green, configObj, Source1, Source2, Source3, Source4, Source5, Source6, Source7, Source8, MessageText); }
                        }
                        foreach (var source in OBS.liveDevices) { UIElements.RefreshLabels(source.name, Color.Red, configObj, Source1, Source2, Source3, Source4, Source5, Source6, Source7, Source8, MessageText); }

                        // Send write (LIVE)
                        Serial.Send(Serial.port, configObj, OBS.liveDevices, "live");

                        OBS.lastLiveScene = currentLiveScene; // Finally, update scene state
                    }
                    else if (OBS.liveDevices == null && OBS.previewDevices == null)
                    {
                        UIElements.ColorAllLabels(Color.Gray, Source1, Source2, Source3, Source4, Source5, Source6, Source7, Source8, MessageText); //Gray out all labels
                        UIElements.WSUpdateButton("Not\nconnected.", ServerConnectButton, Color.Red, Color.White, "enabled"); // Connection timed out?
                    }

                    ////////////// PREVIEWS //////////////
                    if (previews) // If previews are turned ON
                    {
                        // Update previews after prieview on/off is toggled
                        if (lastbutton2State != PreviewsButton_ClickCount)
                        {
                            Console.WriteLine("Previews on."); //Debugging
                            foreach (var source in OBS.previewDevices) { UIElements.RefreshLabels(source.name, Color.Green, configObj, Source1, Source2, Source3, Source4, Source5, Source6, Source7, Source8, MessageText); } //Refresh preview labels
                            foreach (var source in OBS.liveDevices) { UIElements.RefreshLabels(source.name, Color.Red, configObj, Source1, Source2, Source3, Source4, Source5, Source6, Source7, Source8, MessageText); } //Set label colors for live sources
                            lastbutton2State = PreviewsButton_ClickCount; //Update lastbutton2State

                            // Notify Arduino of the change
                            Serial.Send(Serial.port, configObj, OBS.previewDevices, "preview");
                        }

                        // Update preview label colors for UI app
                        if (currentPreviewScene != OBS.lastPreviewScene && OBS.liveDevices != null && OBS.previewDevices != null) //If preview scene state changes
                        {
                            Console.WriteLine("Preview state has changed"); //Debugging
                            UIElements.ColorAllLabels(Color.Gray, Source1, Source2, Source3, Source4, Source5, Source6, Source7, Source8, MessageText);
                            foreach (var source in OBS.previewDevices) { UIElements.RefreshLabels(source.name, Color.Green, configObj, Source1, Source2, Source3, Source4, Source5, Source6, Source7, Source8, MessageText); } //Set label colors for preview sources
                            foreach (var source in OBS.liveDevices) { UIElements.RefreshLabels(source.name, Color.Red, configObj, Source1, Source2, Source3, Source4, Source5, Source6, Source7, Source8, MessageText); } //Set label colors for live sources
                            OBS.lastPreviewScene = currentPreviewScene; //Update preview scene state

                            // Serial writes (PREVIEW)
                            Serial.Send(Serial.port, configObj, OBS.previewDevices, "preview");

                        }

                    }//end if previews ON check
                    else // Previews are toggled off
                    {
                        if (lastbutton2State != PreviewsButton_ClickCount) // If preview on/off toggle changes
                        {
                            Console.WriteLine("Previews off."); //Debugging
                            UIElements.ColorAllLabels(Color.Gray, Source1, Source2, Source3, Source4, Source5, Source6, Source7, Source8, MessageText); //Gray out all labels
                            foreach (var source in OBS.liveDevices) { UIElements.RefreshLabels(source.name, Color.Red, configObj, Source1, Source2, Source3, Source4, Source5, Source6, Source7, Source8, MessageText); } //Set label colors for live sources
                            lastbutton2State = PreviewsButton_ClickCount; //Update lastbutton2State

                            // Notify Arduino of the change by nulling out previews
                            Serial.Send(Serial.port, configObj, null, "preview");
                        }
                    }//end else previews ON check

                    if (Serial.connected) { Serial.port.Write(".*\r\n"); } // Send keepalive bit to Arduino

                }//end OBS.socket.isConnected check
            }
            catch (System.NullReferenceException)
            {
                UIElements.ColorAllLabels(Color.Gray, Source1, Source2, Source3, Source4, Source5, Source6, Source7, Source8, MessageText); //Gray out all labels
                UIElements.WSUpdateButton("Not\nconnected.", ServerConnectButton, Color.Red, Color.White, "enabled"); // Connection timed out?
            }
            catch (System.InvalidOperationException)
            {
                Console.WriteLine("No serial connection established.");
            }
            catch
            {

            }

        }

        #endregion


        #region -  TallyArbiter Serial Events  -

        private void pollTA_Tick(object sender, EventArgs e)
        {
            try //try even if serial port is closed
            {

                if (TallyArbiter.IsConnected && Serial.connected)
                {

                    ////////////// SCENE CHANGE STATE CHECK //////////////
                    if (TallyArbiter.sceneChanged && TallyArbiter.previewDevices != null && TallyArbiter.liveDevices != null) //If live scene state changes
                    {
                        Console.WriteLine("Live/Preview state has changed"); //Debugging

                        // Send write (LIVE)
                        Serial.Send(Serial.port, configObj, TallyArbiter.liveDevices, "live");


                        if (PreviewsButton.Text == "Previews ON") // If previews are turned ON
                        {
                            // Send write (PREVIEW)
                            Serial.Send(Serial.port, configObj, TallyArbiter.previewDevices, "preview");
                        }

                        TallyArbiter.sceneChanged = false; // Finally, update scene changed check to false
                    }

                    ////////////// PREVIEW BUTTON TOGGLES //////////////
                    if (PreviewsButton.Text == "Previews ON") // If previews are turned ON
                    {
                        // Update previews after prieview on/off is toggled
                        if (lastbutton2State != PreviewsButton_ClickCount)
                        {
                            Console.WriteLine("Previews on."); //Debugging
                            lastbutton2State = PreviewsButton_ClickCount; //Update lastbutton2State

                            // Notify Arduino of the change
                            Serial.Send(Serial.port, configObj, TallyArbiter.previewDevices, "preview");
                        }

                    }//end if previews ON check
                    else // Previews are toggled off
                    {
                        if (lastbutton2State != PreviewsButton_ClickCount) // If preview on/off toggle changes
                        {
                            Console.WriteLine("Previews off."); //Debugging
                            lastbutton2State = PreviewsButton_ClickCount; //Update lastbutton2State

                            // Notify Arduino of the change
                            Serial.Send(Serial.port, configObj, null, "preview");

                        }
                    }//end else previews ON check

                    if (Serial.connected) { Serial.port.Write(".*\r\n"); } // Send keepalive bit to Arduino

                }//end Serial and TallyArbiter connection check.

            }
            catch (System.NullReferenceException)
            {

            }
            catch (System.InvalidOperationException)
            {
                Console.WriteLine("No serial connection established.");
            }
            catch
            {

            }
        }
        
        #endregion

    }

}
