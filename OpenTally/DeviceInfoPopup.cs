using Siticone.Desktop.UI.WinForms;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace OpenTally
{
    public partial class DeviceInfoPopup : Form
    {
        public DeviceInfoPopup(string SerialBuffer, string SSID, string Pass, string TAHost, string TAPort, string deviceID, string deviceName)
        {
            InitializeComponent();

            new SiticoneShadowForm(this);
            new SiticoneDragControl(this);
            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.ResizeRedraw, true);

            UIElements.GetControlsOfType<Label>(this).ToList().ForEach(element => new SiticoneDragControl(element));// Make all labels dragabble

            label5.Text = SSID;
            label6.Text = Pass;
            label7.Text = TAHost;
            label8.Text = TAPort;
            label10.Text = deviceID;
            label12.Text = deviceName;
            Logs.Text = SerialBuffer;
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


    }
}
