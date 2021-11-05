using Siticone.Desktop.UI.WinForms;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace OpenTally
{
    public partial class DeviceProgramPopup : Form
    {

        // Public variables
        public string networkSSID = "TallyServer";
        public string networkPass = "123456";
        public string TAHost = "10.1.1.1";
        public string TAPort = "4455";
        public bool programComplete = false;
        public int lastSelectedIndex;

        // UI Manip Variables
        public float[] lastRowHeight = new float[10]; //Store row heights

        public DeviceProgramPopup()
        {
            InitializeComponent();

            new SiticoneShadowForm(this);
            new SiticoneDragControl(this);
            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.ResizeRedraw, true);

            DefaultCustomComboBox.Items.Add("Default");
            DefaultCustomComboBox.Items.Add("Custom");
            DefaultCustomComboBox.SelectedIndex = 0;
            UIElements.GetControlsOfType<SiticoneTextBox>(this.tableLayout1).ToList().ForEach(element => element.Enabled = false);//Disable text input

            siticoneTextBox1.Text = networkSSID;
            siticoneTextBox2.Text = networkPass;
            siticoneTextBox3.Text = TAHost;
            siticoneTextBox4.Text = TAPort;

            DefaultMode();
        }


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


        #region -  Validate Inputs  -

        private void IPAddressTextBox_Leave(object sender, EventArgs e)
        {
            bool isValidIP = Functions.ValidateInputs(siticoneTextBox3.Text, "ip_address"); //Check if IP address is valid
            UIElements.UIShowValid(siticoneTextBox3, IPAddressToolTip, isValidIP); //Show UI hints
            if (isValidIP == false) //Show toolitp
            {
                SendToDeviceButton.Enabled = false;
                Point pt = new Point(0, 0);
                pt.Offset(siticoneTextBox3.Width, 0);
                IPAddressToolTip.Show("Please enter a valid IP address (i.e. 192.168.0.10)", siticoneTextBox3, pt, 5000);
            }
            else if (isValidIP == true)
            {
                SendToDeviceButton.Enabled = true;
                siticoneTextBox3.BorderColor = Color.LightBlue;
                siticoneTextBox3.BorderThickness = 1;
            }
        }

        private void PortTextBox_Leave(object sender, EventArgs e)
        {
            bool isValidPort = Functions.ValidateInputs(siticoneTextBox4.Text, "port"); //Check if port is valid
            UIElements.UIShowValid(siticoneTextBox4, PortToolTip, isValidPort); //Show UI hints
            if (isValidPort == false) //Show tooltip
            {
                SendToDeviceButton.Enabled = false;
                Point pt = new Point(0, 0);
                pt.Offset(siticoneTextBox4.Width, 0);
                PortToolTip.Show("Please enter a valid port (value between 0 - 65535)", siticoneTextBox4, pt, 5000);
            }
            else if (isValidPort == true)
            {
                SendToDeviceButton.Enabled = true;
                siticoneTextBox4.BorderColor = Color.LightBlue;
                siticoneTextBox4.BorderThickness = 1;
            }
        }

        #endregion

        #region -  Button Clicks  -

        private void SendToDeviceButton_Click(object sender, EventArgs e)
        {
            networkSSID = siticoneTextBox1.Text;
            networkPass = siticoneTextBox2.Text;
            TAHost = siticoneTextBox3.Text;
            TAPort = siticoneTextBox4.Text;

            if (networkSSID == "" || networkPass == "" || TAHost == "" || TAPort == "")
            {
                MessageBox.Show("Field(s) cannot be blank.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                this.Close();
            }
        }

        private void DefaultCustomComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lastSelectedIndex != DefaultCustomComboBox.SelectedIndex)//If selected index state changes
            {
                if (DefaultCustomComboBox.SelectedIndex == 1)//Custom
                {
                    CustomMode();
                }
                else if (DefaultCustomComboBox.SelectedIndex == 0)//Default
                {
                    DefaultMode();
                }
            }
        }

        #endregion

        public string SSID { get { return (networkSSID); } }
        public string Pass { get { return (networkPass); } }
        public string Port { get { return (TAPort); } }
        public string Host { get { return (TAHost); } }


        #region -  Local Functions  -

        private void CustomMode()
        {
            UIElements.GetControlsOfType<SiticoneTextBox>(this.tableLayout1).ToList().ForEach(element => element.Enabled = true);//Enable text input
            this.Size = new Size(this.Width, this.Height + (int)lastRowHeight[2]);//Resize form
            tableLayout1.RowStyles[2].Height = lastRowHeight[2]; //Hide Wi-Fi password row
            lastSelectedIndex = DefaultCustomComboBox.SelectedIndex;
        }

        private void DefaultMode()
        {
            UIElements.GetControlsOfType<SiticoneTextBox>(this.tableLayout1).ToList().ForEach(element => element.Enabled = false);//Disable text input
                                                                                                                                  // Store current row heights before hiding them
            for (int i = 0; i < tableLayout1.RowCount; i++)//Default
            {
                lastRowHeight[i] = tableLayout1.RowStyles[i].Height;
                //Console.WriteLine("Row " + i + "=" + lastRowHeight[i]);
            }
            this.Size = new Size(this.Width, this.Height - (int)tableLayout1.RowStyles[2].Height);//Resize form
            tableLayout1.RowStyles[2].Height = 0; //Hide Wi-Fi password row
            lastSelectedIndex = DefaultCustomComboBox.SelectedIndex;
        }

        #endregion
    }
}
