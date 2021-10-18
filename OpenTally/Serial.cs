using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Management;
using System.Text.RegularExpressions;
using System.Timers;
using System.Windows.Forms;
using System.Xml;
using Newtonsoft.Json;
using Quobject.SocketIoClientDotNet.Client;// socket.io for .NET (Client)
using Siticone.Desktop.UI.WinForms;

namespace OpenTally
{
    class Serial
    {

        // Serial vars
        public static SerialPort port;
        public static string[] vars;
        public static bool connected = false;
        public static string buffer; //Variable to store serial buffer

        // Parent ID for the Silicon Labs CP210x USB to UART Bridge (TinyPico) and the Arduino Micro respectively
        //  See also: https://docs.microsoft.com/en-us/windows-hardware/drivers/install/standard-usb-identifiers
        //  This is preferable to deviceCaption in case the computer doesn't have USB drivers installed.
        public static string[] devicePIDs = { "VID_10C4&PID_EA60", "VID_2341&PID_8037&MI_00" };

        #region -  Serial Events  -

        public delegate string[] LineReceivedEvent(string line);
        public static string[] LineReceived(string line)
        {
            if (line.Trim() != "") { Console.WriteLine("From Arduino: " + line); }
            string[] serialLines = line.Split(','); //Split data received if comma delimited
            return serialLines;
            //foreach (var name in Serial.vars) { Console.WriteLine(name); }
        }

        public static string DetectDevice(string[] deviceNames)
        {
            string comPort = null;
            using (var searcher = new ManagementObjectSearcher("SELECT * FROM WIN32_SerialPort"))
            {
                var ports = searcher.Get().Cast<ManagementBaseObject>().ToList();// See https://docs.microsoft.com/en-us/windows/win32/cimwin32prov/win32-serialport for all class objects

                foreach (var port in ports)
                {
                    foreach (string pid in devicePIDs)
                    {
                        if (port["PNPDeviceID"].ToString().Contains(pid))// Using the USB parent ID property so Arduino USB drivers are unneeded.
                        {
                            comPort = port["DeviceID"].ToString();
                        }
                    }
                    //Console.WriteLine("Port: " + port["DeviceID"] + " Port caption: " + port["Caption"] + " Port PID: " + port["PNPDeviceID"]);
                }
            }
            return comPort;
        }

        public static void ConnectSerial(SerialPort serialPort, string comPort)
        {
            try
            {
                if (comPort != null)
                {
                    serialPort.PortName = comPort;
                    //MainProgram.serialPort.ReadTimeout = 500;
                    //MainProgram.serialPort.WriteTimeout = 500;
                    serialPort.Open(); //Try opening the port to test connectivity
                }
            }
            catch
            {
            }
        }

        // Call it like: foreach ( var source in OBS.liveDevices) { Serial.Send(Serial.port, configObj, source.name); }
        //           or: 
        public static void Send(SerialPort serialPort, Config configObj, List<Devices> deviceList, string bus)
        {
            if (connected) //Send only if device is connected
            {
                if (bus == "live") { serialPort.Write("51,"); } // Send live state change bit to Arduino}
                else if (bus == "preview") { serialPort.Write("50,"); } // Send live state change bit to Arduino}

                if (deviceList != null)
                {
                    foreach (var device in deviceList)
                    {
                        if (device.name == configObj.source1) { serialPort.Write("0,"); }
                        else if (device.name == configObj.source2) { serialPort.Write("1,"); }
                        else if (device.name == configObj.source3) { serialPort.Write("2,"); }
                        else if (device.name == configObj.source4) { serialPort.Write("3,"); }
                        else if (device.name == configObj.source5) { serialPort.Write("4,"); }
                        else if (device.name == configObj.source6) { serialPort.Write("5,"); }
                        else if (device.name == configObj.source7) { serialPort.Write("6,"); }
                        else if (device.name == configObj.source8) { serialPort.Write("7,"); }
                        else { serialPort.Write("9,"); } //Out of range bit
                    }
                }

                serialPort.Write("*\r\n"); // Send stop bit
            }
        }

        // TODO: CREATE TIMER PROGRAMMATICALLY AND MOVE IT FROM THE MAINPROGRAM FORM CODE
        //// Creating timer programmatically
        //public static void Timer()
        //{
        //    System.Timers.Timer aTimer = new System.Timers.Timer();
        //    aTimer.Elapsed += new ElapsedEventHandler(DetectSerial);
        //    aTimer.Interval = 1*1000;//Milliseconds
        //    aTimer.Enabled = true;
        //}

        //// Here's what will happen when timer elapsed event is raised from Serial.Timer() function.
        //private static void DetectSerial(object source, ElapsedEventArgs e)
        //{
        //    string comPort = DetectDevice(deviceNames); // Detect when client is connected

        //    try
        //    {
        //        if (comPort != null && !connected)
        //        {
        //            ConnectSerial(port, comPort);
        //            DeviceInfoButton.Enabled = Serial.connected = true;//Enable\Disable buttons based on serial connectivity

        //            PortText.Font = UIElements.setFontSize(PortText, 10);
        //            PortText.Text = comPort;
        //            PortText.BackColor = Color.Green;
        //        }
        //        else if (comPort == null)
        //        {
        //            port.Close();
        //            DeviceInfoButton.Enabled = connected = false;//Enable\Disable buttons based on serial connectivity

        //            PortText.Font = UIElements.setFontSize(PortText, 7.5);
        //            PortText.Text = comPort;
        //            PortText.BackColor = Color.Transparent;
        //        }
        //    }
        //    catch (System.InvalidOperationException)
        //    {
        //        Console.WriteLine("No serial connection established.");
        //        comPort = null;
        //        connected = false;
        //        PortText.Font = UIElements.setFontSize(PortText, 7.5);
        //        PortText.Text = "Disconnected";
        //        PortText.BackColor = Color.Transparent;
        //    }
        //    catch
        //    {

        //    }
        //    //Console.WriteLine("Serial connected: " + Serial.connected+ " Com Port: "+comPort);

        //}



        #endregion



    }
}
