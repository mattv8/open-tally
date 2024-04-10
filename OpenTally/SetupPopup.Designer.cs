namespace OpenTally
{
    partial class SetupPopup
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SetupPopup));
            this.LayoutPanelAll = new System.Windows.Forms.TableLayoutPanel();
            this.Menu = new System.Windows.Forms.TableLayoutPanel();
            this.WiredWirelessToggle = new Siticone.Desktop.UI.WinForms.SiticoneToggleSwitch();
            this.CloseButton = new Siticone.Desktop.UI.WinForms.SiticoneControlBox();
            this.WiredWirelessLabel = new System.Windows.Forms.Label();
            this.LayoutPanelUserConfig = new System.Windows.Forms.TableLayoutPanel();
            this.IPAddressLabel = new System.Windows.Forms.Label();
            this.PortLabel = new System.Windows.Forms.Label();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.PortTextBox = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.PortComboBox = new Siticone.Desktop.UI.WinForms.SiticoneComboBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.IPAddressTextBox = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.IPAddressComboBox = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.PasswordTextBox = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.pwShow = new Siticone.Desktop.UI.WinForms.SiticoneImageCheckBox();
            this.LayoutPanelSourceUI = new System.Windows.Forms.TableLayoutPanel();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.siticoneComboBox4 = new Siticone.Desktop.UI.WinForms.SiticoneComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.siticoneComboBox3 = new Siticone.Desktop.UI.WinForms.SiticoneComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.siticoneComboBox2 = new Siticone.Desktop.UI.WinForms.SiticoneComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.siticoneComboBox1 = new Siticone.Desktop.UI.WinForms.SiticoneComboBox();
            this.siticoneComboBox5 = new Siticone.Desktop.UI.WinForms.SiticoneComboBox();
            this.siticoneComboBox6 = new Siticone.Desktop.UI.WinForms.SiticoneComboBox();
            this.siticoneComboBox7 = new Siticone.Desktop.UI.WinForms.SiticoneComboBox();
            this.siticoneComboBox8 = new Siticone.Desktop.UI.WinForms.SiticoneComboBox();
            this.ProgramDeviceLayout = new System.Windows.Forms.TableLayoutPanel();
            this.SerialConnectionLabel = new System.Windows.Forms.Label();
            this.DeviceInfoButton = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.DeviceProgramButton = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.MessageText = new System.Windows.Forms.Label();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.TestConnectButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.IPAddressToolTip = new Siticone.Desktop.UI.WinForms.SiticoneHtmlToolTip();
            this.PortToolTip = new Siticone.Desktop.UI.WinForms.SiticoneHtmlToolTip();
            this.SerialConnectedTimer = new System.Windows.Forms.Timer(this.components);
            this.LayoutPanelAll.SuspendLayout();
            this.Menu.SuspendLayout();
            this.LayoutPanelUserConfig.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.LayoutPanelSourceUI.SuspendLayout();
            this.ProgramDeviceLayout.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // LayoutPanelAll
            // 
            this.LayoutPanelAll.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LayoutPanelAll.ColumnCount = 1;
            this.LayoutPanelAll.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.LayoutPanelAll.Controls.Add(this.Menu, 0, 0);
            this.LayoutPanelAll.Controls.Add(this.LayoutPanelUserConfig, 0, 1);
            this.LayoutPanelAll.Controls.Add(this.LayoutPanelSourceUI, 0, 2);
            this.LayoutPanelAll.Controls.Add(this.ProgramDeviceLayout, 0, 4);
            this.LayoutPanelAll.Controls.Add(this.MessageText, 0, 5);
            this.LayoutPanelAll.Controls.Add(this.tableLayoutPanel5, 0, 3);
            this.LayoutPanelAll.Location = new System.Drawing.Point(8, 8);
            this.LayoutPanelAll.Margin = new System.Windows.Forms.Padding(0);
            this.LayoutPanelAll.Name = "LayoutPanelAll";
            this.LayoutPanelAll.RowCount = 6;
            this.LayoutPanelAll.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.LayoutPanelAll.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 31.37775F));
            this.LayoutPanelAll.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40.09217F));
            this.LayoutPanelAll.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.52074F));
            this.LayoutPanelAll.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.80556F));
            this.LayoutPanelAll.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.861111F));
            this.LayoutPanelAll.Size = new System.Drawing.Size(615, 723);
            this.LayoutPanelAll.TabIndex = 0;
            // 
            // Menu
            // 
            this.Menu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Menu.ColumnCount = 3;
            this.Menu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.Menu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.Menu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 54F));
            this.Menu.Controls.Add(this.WiredWirelessToggle, 0, 0);
            this.Menu.Controls.Add(this.CloseButton, 2, 0);
            this.Menu.Controls.Add(this.WiredWirelessLabel, 1, 0);
            this.Menu.ForeColor = System.Drawing.Color.White;
            this.Menu.Location = new System.Drawing.Point(0, 0);
            this.Menu.Margin = new System.Windows.Forms.Padding(0);
            this.Menu.MaximumSize = new System.Drawing.Size(0, 77);
            this.Menu.Name = "Menu";
            this.Menu.RowCount = 1;
            this.Menu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.Menu.Size = new System.Drawing.Size(615, 55);
            this.Menu.TabIndex = 18;
            // 
            // WiredWirelessToggle
            // 
            this.WiredWirelessToggle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.WiredWirelessToggle.Animated = true;
            this.WiredWirelessToggle.AutoRoundedCorners = true;
            this.WiredWirelessToggle.BackColor = System.Drawing.Color.Transparent;
            this.WiredWirelessToggle.CheckedState.BorderColor = System.Drawing.Color.DarkOrchid;
            this.WiredWirelessToggle.CheckedState.BorderRadius = 21;
            this.WiredWirelessToggle.CheckedState.FillColor = System.Drawing.Color.DarkOrchid;
            this.WiredWirelessToggle.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.WiredWirelessToggle.CheckedState.InnerBorderRadius = 17;
            this.WiredWirelessToggle.CheckedState.InnerColor = System.Drawing.Color.White;
            this.WiredWirelessToggle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.WiredWirelessToggle.Location = new System.Drawing.Point(4, 5);
            this.WiredWirelessToggle.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.WiredWirelessToggle.Name = "WiredWirelessToggle";
            this.WiredWirelessToggle.Size = new System.Drawing.Size(92, 45);
            this.WiredWirelessToggle.TabIndex = 14;
            this.WiredWirelessToggle.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(213)))), ((int)(((byte)(217)))));
            this.WiredWirelessToggle.UncheckedState.BorderRadius = 21;
            this.WiredWirelessToggle.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(213)))), ((int)(((byte)(217)))));
            this.WiredWirelessToggle.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.WiredWirelessToggle.UncheckedState.InnerBorderRadius = 17;
            this.WiredWirelessToggle.UncheckedState.InnerColor = System.Drawing.Color.White;
            this.WiredWirelessToggle.Click += new System.EventHandler(this.WiredWirelessToggle_CheckedChanged);
            // 
            // CloseButton
            // 
            this.CloseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseButton.BackColor = System.Drawing.Color.Transparent;
            this.CloseButton.CustomIconSize = 12F;
            this.CloseButton.FillColor = System.Drawing.Color.Gray;
            this.CloseButton.HoverState.IconColor = System.Drawing.Color.Red;
            this.CloseButton.IconColor = System.Drawing.Color.White;
            this.CloseButton.Location = new System.Drawing.Point(565, 5);
            this.CloseButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(46, 45);
            this.CloseButton.TabIndex = 17;
            // 
            // WiredWirelessLabel
            // 
            this.WiredWirelessLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.WiredWirelessLabel.AutoSize = true;
            this.WiredWirelessLabel.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WiredWirelessLabel.ForeColor = System.Drawing.Color.Black;
            this.WiredWirelessLabel.Location = new System.Drawing.Point(104, 0);
            this.WiredWirelessLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.WiredWirelessLabel.Name = "WiredWirelessLabel";
            this.WiredWirelessLabel.Size = new System.Drawing.Size(453, 55);
            this.WiredWirelessLabel.TabIndex = 18;
            this.WiredWirelessLabel.Text = "TALLY SERVER RELAY";
            this.WiredWirelessLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LayoutPanelUserConfig
            // 
            this.LayoutPanelUserConfig.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LayoutPanelUserConfig.ColumnCount = 2;
            this.LayoutPanelUserConfig.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.LayoutPanelUserConfig.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.LayoutPanelUserConfig.Controls.Add(this.IPAddressLabel, 0, 0);
            this.LayoutPanelUserConfig.Controls.Add(this.PortLabel, 0, 1);
            this.LayoutPanelUserConfig.Controls.Add(this.PasswordLabel, 0, 2);
            this.LayoutPanelUserConfig.Controls.Add(this.tableLayoutPanel4, 1, 1);
            this.LayoutPanelUserConfig.Controls.Add(this.tableLayoutPanel3, 1, 0);
            this.LayoutPanelUserConfig.Controls.Add(this.tableLayoutPanel1, 1, 2);
            this.LayoutPanelUserConfig.ForeColor = System.Drawing.Color.White;
            this.LayoutPanelUserConfig.Location = new System.Drawing.Point(0, 55);
            this.LayoutPanelUserConfig.Margin = new System.Windows.Forms.Padding(0);
            this.LayoutPanelUserConfig.MinimumSize = new System.Drawing.Size(0, 166);
            this.LayoutPanelUserConfig.Name = "LayoutPanelUserConfig";
            this.LayoutPanelUserConfig.RowCount = 3;
            this.LayoutPanelUserConfig.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.LayoutPanelUserConfig.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.LayoutPanelUserConfig.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.LayoutPanelUserConfig.Size = new System.Drawing.Size(615, 210);
            this.LayoutPanelUserConfig.TabIndex = 29;
            // 
            // IPAddressLabel
            // 
            this.IPAddressLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.IPAddressLabel.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IPAddressLabel.ForeColor = System.Drawing.Color.Black;
            this.IPAddressLabel.Location = new System.Drawing.Point(4, 0);
            this.IPAddressLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.IPAddressLabel.Name = "IPAddressLabel";
            this.IPAddressLabel.Size = new System.Drawing.Size(176, 65);
            this.IPAddressLabel.TabIndex = 11;
            this.IPAddressLabel.Text = "Tally Server IP address:";
            this.IPAddressLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // PortLabel
            // 
            this.PortLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PortLabel.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PortLabel.ForeColor = System.Drawing.Color.Black;
            this.PortLabel.Location = new System.Drawing.Point(4, 70);
            this.PortLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PortLabel.Name = "PortLabel";
            this.PortLabel.Size = new System.Drawing.Size(176, 65);
            this.PortLabel.TabIndex = 12;
            this.PortLabel.Text = "Tally Server port:";
            this.PortLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PasswordLabel.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordLabel.ForeColor = System.Drawing.Color.Black;
            this.PasswordLabel.Location = new System.Drawing.Point(4, 140);
            this.PasswordLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(176, 69);
            this.PasswordLabel.TabIndex = 9;
            this.PasswordLabel.Text = "OBS Websocket Password:";
            this.PasswordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel4.AutoSize = true;
            this.tableLayoutPanel4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 52F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48F));
            this.tableLayoutPanel4.Controls.Add(this.PortTextBox, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.PortComboBox, 0, 0);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(184, 70);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel4.MinimumSize = new System.Drawing.Size(0, 65);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 88F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(431, 70);
            this.tableLayoutPanel4.TabIndex = 14;
            // 
            // PortTextBox
            // 
            this.PortTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PortTextBox.BackColor = System.Drawing.Color.Transparent;
            this.PortTextBox.BorderRadius = 10;
            this.PortTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PortTextBox.DefaultText = "";
            this.PortTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.PortTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.PortTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PortTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PortTextBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(213)))), ((int)(((byte)(217)))));
            this.PortTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PortTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.PortTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PortTextBox.Location = new System.Drawing.Point(228, 5);
            this.PortTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PortTextBox.MinimumSize = new System.Drawing.Size(0, 55);
            this.PortTextBox.Name = "PortTextBox";
            this.PortTextBox.PasswordChar = '\0';
            this.PortTextBox.PlaceholderText = "";
            this.PortTextBox.SelectedText = "";
            this.PortTextBox.Size = new System.Drawing.Size(199, 55);
            this.PortTextBox.TabIndex = 1;
            this.PortTextBox.Leave += new System.EventHandler(this.PortTextBox_Leave);
            this.PortTextBox.MouseEnter += new System.EventHandler(this.PortTextBox_Leave);
            // 
            // PortComboBox
            // 
            this.PortComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PortComboBox.AutoRoundedCorners = true;
            this.PortComboBox.BackColor = System.Drawing.Color.Transparent;
            this.PortComboBox.BorderRadius = 17;
            this.PortComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.PortComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PortComboBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(213)))), ((int)(((byte)(217)))));
            this.PortComboBox.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PortComboBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PortComboBox.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PortComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.PortComboBox.ItemHeight = 30;
            this.PortComboBox.Location = new System.Drawing.Point(4, 5);
            this.PortComboBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PortComboBox.Name = "PortComboBox";
            this.PortComboBox.Size = new System.Drawing.Size(216, 36);
            this.PortComboBox.TabIndex = 0;
            this.PortComboBox.SelectedIndexChanged += new System.EventHandler(this.PortComboBox_SelectedIndexChanged);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 52F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48F));
            this.tableLayoutPanel3.Controls.Add(this.IPAddressTextBox, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.IPAddressComboBox, 0, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(184, 0);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel3.MinimumSize = new System.Drawing.Size(0, 65);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 88F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(431, 70);
            this.tableLayoutPanel3.TabIndex = 13;
            // 
            // IPAddressTextBox
            // 
            this.IPAddressTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.IPAddressTextBox.BackColor = System.Drawing.Color.Transparent;
            this.IPAddressTextBox.BorderRadius = 10;
            this.IPAddressTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.IPAddressTextBox.DefaultText = "";
            this.IPAddressTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.IPAddressTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.IPAddressTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.IPAddressTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.IPAddressTextBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(213)))), ((int)(((byte)(217)))));
            this.IPAddressTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.IPAddressTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.IPAddressTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.IPAddressTextBox.Location = new System.Drawing.Point(228, 5);
            this.IPAddressTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.IPAddressTextBox.MinimumSize = new System.Drawing.Size(0, 55);
            this.IPAddressTextBox.Name = "IPAddressTextBox";
            this.IPAddressTextBox.PasswordChar = '\0';
            this.IPAddressTextBox.PlaceholderText = "";
            this.IPAddressTextBox.SelectedText = "";
            this.IPAddressTextBox.Size = new System.Drawing.Size(199, 55);
            this.IPAddressTextBox.TabIndex = 19;
            this.IPAddressTextBox.Leave += new System.EventHandler(this.IPAddressTextBox_Leave);
            this.IPAddressTextBox.MouseEnter += new System.EventHandler(this.IPAddressTextBox_Leave);
            // 
            // IPAddressComboBox
            // 
            this.IPAddressComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.IPAddressComboBox.BackColor = System.Drawing.Color.White;
            this.IPAddressComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.IPAddressComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.IPAddressComboBox.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.IPAddressComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.IPAddressComboBox.ItemHeight = 30;
            this.IPAddressComboBox.Location = new System.Drawing.Point(4, 5);
            this.IPAddressComboBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.IPAddressComboBox.Name = "IPAddressComboBox";
            this.IPAddressComboBox.Size = new System.Drawing.Size(216, 36);
            this.IPAddressComboBox.TabIndex = 19;
            this.IPAddressComboBox.SelectedIndexChanged += new System.EventHandler(this.IPAddressComboBox_SelectedIndexChanged);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 54F));
            this.tableLayoutPanel1.Controls.Add(this.PasswordTextBox, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.pwShow, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(184, 140);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(431, 70);
            this.tableLayoutPanel1.TabIndex = 15;
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PasswordTextBox.BackColor = System.Drawing.Color.Transparent;
            this.PasswordTextBox.BorderRadius = 10;
            this.PasswordTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PasswordTextBox.DefaultText = "";
            this.PasswordTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.PasswordTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.PasswordTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PasswordTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PasswordTextBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(213)))), ((int)(((byte)(217)))));
            this.PasswordTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PasswordTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.PasswordTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PasswordTextBox.Location = new System.Drawing.Point(4, 5);
            this.PasswordTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PasswordTextBox.MaximumSize = new System.Drawing.Size(0, 65);
            this.PasswordTextBox.MinimumSize = new System.Drawing.Size(0, 55);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.PasswordChar = '●';
            this.PasswordTextBox.PlaceholderText = "";
            this.PasswordTextBox.SelectedText = "";
            this.PasswordTextBox.Size = new System.Drawing.Size(369, 55);
            this.PasswordTextBox.TabIndex = 15;
            this.PasswordTextBox.UseSystemPasswordChar = true;
            this.PasswordTextBox.Leave += new System.EventHandler(this.PasswordTextBox_Leave);
            // 
            // pwShow
            // 
            this.pwShow.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pwShow.CheckedState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            this.pwShow.CheckedState.ImageSize = new System.Drawing.Size(30, 30);
            this.pwShow.HoverState.ImageSize = new System.Drawing.Size(30, 30);
            this.pwShow.Image = ((System.Drawing.Image)(resources.GetObject("pwShow.Image")));
            this.pwShow.ImageOffset = new System.Drawing.Point(0, 0);
            this.pwShow.ImageRotate = 0F;
            this.pwShow.ImageSize = new System.Drawing.Size(30, 30);
            this.pwShow.Location = new System.Drawing.Point(381, 5);
            this.pwShow.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pwShow.Name = "pwShow";
            this.pwShow.Size = new System.Drawing.Size(46, 60);
            this.pwShow.TabIndex = 16;
            this.pwShow.CheckedChanged += new System.EventHandler(this.pwShow_CheckedChanged);
            // 
            // LayoutPanelSourceUI
            // 
            this.LayoutPanelSourceUI.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LayoutPanelSourceUI.ColumnCount = 4;
            this.LayoutPanelSourceUI.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 112F));
            this.LayoutPanelSourceUI.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.LayoutPanelSourceUI.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 112F));
            this.LayoutPanelSourceUI.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.LayoutPanelSourceUI.Controls.Add(this.label9, 2, 3);
            this.LayoutPanelSourceUI.Controls.Add(this.label8, 2, 2);
            this.LayoutPanelSourceUI.Controls.Add(this.label7, 2, 1);
            this.LayoutPanelSourceUI.Controls.Add(this.label6, 2, 0);
            this.LayoutPanelSourceUI.Controls.Add(this.label1, 0, 0);
            this.LayoutPanelSourceUI.Controls.Add(this.siticoneComboBox4, 1, 3);
            this.LayoutPanelSourceUI.Controls.Add(this.label2, 0, 1);
            this.LayoutPanelSourceUI.Controls.Add(this.siticoneComboBox3, 1, 2);
            this.LayoutPanelSourceUI.Controls.Add(this.label3, 0, 2);
            this.LayoutPanelSourceUI.Controls.Add(this.siticoneComboBox2, 1, 1);
            this.LayoutPanelSourceUI.Controls.Add(this.label4, 0, 3);
            this.LayoutPanelSourceUI.Controls.Add(this.siticoneComboBox1, 1, 0);
            this.LayoutPanelSourceUI.Controls.Add(this.siticoneComboBox5, 3, 0);
            this.LayoutPanelSourceUI.Controls.Add(this.siticoneComboBox6, 3, 1);
            this.LayoutPanelSourceUI.Controls.Add(this.siticoneComboBox7, 3, 2);
            this.LayoutPanelSourceUI.Controls.Add(this.siticoneComboBox8, 3, 3);
            this.LayoutPanelSourceUI.ForeColor = System.Drawing.Color.White;
            this.LayoutPanelSourceUI.Location = new System.Drawing.Point(0, 265);
            this.LayoutPanelSourceUI.Margin = new System.Windows.Forms.Padding(0);
            this.LayoutPanelSourceUI.Name = "LayoutPanelSourceUI";
            this.LayoutPanelSourceUI.RowCount = 4;
            this.LayoutPanelSourceUI.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.LayoutPanelSourceUI.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.LayoutPanelSourceUI.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.LayoutPanelSourceUI.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.LayoutPanelSourceUI.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.LayoutPanelSourceUI.Size = new System.Drawing.Size(615, 268);
            this.LayoutPanelSourceUI.TabIndex = 28;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(311, 201);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Padding = new System.Windows.Forms.Padding(0, 15, 0, 15);
            this.label9.Size = new System.Drawing.Size(104, 48);
            this.label9.TabIndex = 34;
            this.label9.Text = "Source 8:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(311, 134);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Padding = new System.Windows.Forms.Padding(0, 15, 0, 15);
            this.label8.Size = new System.Drawing.Size(104, 48);
            this.label8.TabIndex = 33;
            this.label8.Text = "Source 7:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(311, 67);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Padding = new System.Windows.Forms.Padding(0, 15, 0, 15);
            this.label7.Size = new System.Drawing.Size(104, 48);
            this.label7.TabIndex = 32;
            this.label7.Text = "Source 6:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(311, 0);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Padding = new System.Windows.Forms.Padding(0, 15, 0, 15);
            this.label6.Size = new System.Drawing.Size(104, 48);
            this.label6.TabIndex = 31;
            this.label6.Text = "Source 5:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(4, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(0, 15, 0, 15);
            this.label1.Size = new System.Drawing.Size(104, 48);
            this.label1.TabIndex = 0;
            this.label1.Text = "Source 1:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // siticoneComboBox4
            // 
            this.siticoneComboBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.siticoneComboBox4.BackColor = System.Drawing.Color.Transparent;
            this.siticoneComboBox4.BorderRadius = 10;
            this.siticoneComboBox4.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.siticoneComboBox4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.siticoneComboBox4.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(213)))), ((int)(((byte)(217)))));
            this.siticoneComboBox4.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.siticoneComboBox4.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.siticoneComboBox4.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.siticoneComboBox4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.siticoneComboBox4.ItemHeight = 30;
            this.siticoneComboBox4.Location = new System.Drawing.Point(116, 206);
            this.siticoneComboBox4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.siticoneComboBox4.Name = "siticoneComboBox4";
            this.siticoneComboBox4.Size = new System.Drawing.Size(187, 36);
            this.siticoneComboBox4.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(4, 67);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(0, 15, 0, 15);
            this.label2.Size = new System.Drawing.Size(104, 48);
            this.label2.TabIndex = 1;
            this.label2.Text = "Source 2:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // siticoneComboBox3
            // 
            this.siticoneComboBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.siticoneComboBox3.BackColor = System.Drawing.Color.Transparent;
            this.siticoneComboBox3.BorderRadius = 10;
            this.siticoneComboBox3.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.siticoneComboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.siticoneComboBox3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(213)))), ((int)(((byte)(217)))));
            this.siticoneComboBox3.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.siticoneComboBox3.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.siticoneComboBox3.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.siticoneComboBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.siticoneComboBox3.ItemHeight = 30;
            this.siticoneComboBox3.Location = new System.Drawing.Point(116, 139);
            this.siticoneComboBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.siticoneComboBox3.Name = "siticoneComboBox3";
            this.siticoneComboBox3.Size = new System.Drawing.Size(187, 36);
            this.siticoneComboBox3.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(4, 134);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(0, 15, 0, 15);
            this.label3.Size = new System.Drawing.Size(104, 48);
            this.label3.TabIndex = 3;
            this.label3.Text = "Source 3:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // siticoneComboBox2
            // 
            this.siticoneComboBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.siticoneComboBox2.BackColor = System.Drawing.Color.Transparent;
            this.siticoneComboBox2.BorderRadius = 10;
            this.siticoneComboBox2.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.siticoneComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.siticoneComboBox2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(213)))), ((int)(((byte)(217)))));
            this.siticoneComboBox2.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.siticoneComboBox2.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.siticoneComboBox2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.siticoneComboBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.siticoneComboBox2.ItemHeight = 30;
            this.siticoneComboBox2.Location = new System.Drawing.Point(116, 72);
            this.siticoneComboBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.siticoneComboBox2.Name = "siticoneComboBox2";
            this.siticoneComboBox2.Size = new System.Drawing.Size(187, 36);
            this.siticoneComboBox2.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(4, 201);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(0, 15, 0, 15);
            this.label4.Size = new System.Drawing.Size(104, 48);
            this.label4.TabIndex = 4;
            this.label4.Text = "Source 4:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // siticoneComboBox1
            // 
            this.siticoneComboBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.siticoneComboBox1.BackColor = System.Drawing.Color.Transparent;
            this.siticoneComboBox1.BorderRadius = 10;
            this.siticoneComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.siticoneComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.siticoneComboBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(213)))), ((int)(((byte)(217)))));
            this.siticoneComboBox1.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.siticoneComboBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.siticoneComboBox1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.siticoneComboBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.siticoneComboBox1.ItemHeight = 30;
            this.siticoneComboBox1.Location = new System.Drawing.Point(116, 5);
            this.siticoneComboBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.siticoneComboBox1.Name = "siticoneComboBox1";
            this.siticoneComboBox1.Size = new System.Drawing.Size(187, 36);
            this.siticoneComboBox1.TabIndex = 23;
            // 
            // siticoneComboBox5
            // 
            this.siticoneComboBox5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.siticoneComboBox5.BackColor = System.Drawing.Color.Transparent;
            this.siticoneComboBox5.BorderRadius = 10;
            this.siticoneComboBox5.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.siticoneComboBox5.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.siticoneComboBox5.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(213)))), ((int)(((byte)(217)))));
            this.siticoneComboBox5.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.siticoneComboBox5.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.siticoneComboBox5.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.siticoneComboBox5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.siticoneComboBox5.ItemHeight = 30;
            this.siticoneComboBox5.Location = new System.Drawing.Point(423, 5);
            this.siticoneComboBox5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.siticoneComboBox5.Name = "siticoneComboBox5";
            this.siticoneComboBox5.Size = new System.Drawing.Size(188, 36);
            this.siticoneComboBox5.TabIndex = 27;
            // 
            // siticoneComboBox6
            // 
            this.siticoneComboBox6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.siticoneComboBox6.BackColor = System.Drawing.Color.Transparent;
            this.siticoneComboBox6.BorderRadius = 10;
            this.siticoneComboBox6.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.siticoneComboBox6.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.siticoneComboBox6.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(213)))), ((int)(((byte)(217)))));
            this.siticoneComboBox6.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.siticoneComboBox6.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.siticoneComboBox6.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.siticoneComboBox6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.siticoneComboBox6.ItemHeight = 30;
            this.siticoneComboBox6.Location = new System.Drawing.Point(423, 72);
            this.siticoneComboBox6.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.siticoneComboBox6.Name = "siticoneComboBox6";
            this.siticoneComboBox6.Size = new System.Drawing.Size(188, 36);
            this.siticoneComboBox6.TabIndex = 28;
            // 
            // siticoneComboBox7
            // 
            this.siticoneComboBox7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.siticoneComboBox7.BackColor = System.Drawing.Color.Transparent;
            this.siticoneComboBox7.BorderRadius = 10;
            this.siticoneComboBox7.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.siticoneComboBox7.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.siticoneComboBox7.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(213)))), ((int)(((byte)(217)))));
            this.siticoneComboBox7.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.siticoneComboBox7.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.siticoneComboBox7.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.siticoneComboBox7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.siticoneComboBox7.ItemHeight = 30;
            this.siticoneComboBox7.Location = new System.Drawing.Point(423, 139);
            this.siticoneComboBox7.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.siticoneComboBox7.Name = "siticoneComboBox7";
            this.siticoneComboBox7.Size = new System.Drawing.Size(188, 36);
            this.siticoneComboBox7.TabIndex = 29;
            // 
            // siticoneComboBox8
            // 
            this.siticoneComboBox8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.siticoneComboBox8.BackColor = System.Drawing.Color.Transparent;
            this.siticoneComboBox8.BorderRadius = 10;
            this.siticoneComboBox8.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.siticoneComboBox8.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.siticoneComboBox8.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(213)))), ((int)(((byte)(217)))));
            this.siticoneComboBox8.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.siticoneComboBox8.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.siticoneComboBox8.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.siticoneComboBox8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.siticoneComboBox8.ItemHeight = 30;
            this.siticoneComboBox8.Location = new System.Drawing.Point(423, 206);
            this.siticoneComboBox8.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.siticoneComboBox8.Name = "siticoneComboBox8";
            this.siticoneComboBox8.Size = new System.Drawing.Size(188, 36);
            this.siticoneComboBox8.TabIndex = 30;
            // 
            // ProgramDeviceLayout
            // 
            this.ProgramDeviceLayout.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ProgramDeviceLayout.ColumnCount = 3;
            this.ProgramDeviceLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34.43526F));
            this.ProgramDeviceLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.2314F));
            this.ProgramDeviceLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.ProgramDeviceLayout.Controls.Add(this.SerialConnectionLabel, 0, 0);
            this.ProgramDeviceLayout.Controls.Add(this.DeviceInfoButton, 1, 0);
            this.ProgramDeviceLayout.Controls.Add(this.DeviceProgramButton, 2, 0);
            this.ProgramDeviceLayout.Location = new System.Drawing.Point(0, 610);
            this.ProgramDeviceLayout.Margin = new System.Windows.Forms.Padding(0);
            this.ProgramDeviceLayout.Name = "ProgramDeviceLayout";
            this.ProgramDeviceLayout.RowCount = 1;
            this.ProgramDeviceLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ProgramDeviceLayout.Size = new System.Drawing.Size(615, 79);
            this.ProgramDeviceLayout.TabIndex = 22;
            // 
            // SerialConnectionLabel
            // 
            this.SerialConnectionLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SerialConnectionLabel.AutoSize = true;
            this.SerialConnectionLabel.Location = new System.Drawing.Point(8, 8);
            this.SerialConnectionLabel.Margin = new System.Windows.Forms.Padding(8);
            this.SerialConnectionLabel.Name = "SerialConnectionLabel";
            this.SerialConnectionLabel.Size = new System.Drawing.Size(195, 63);
            this.SerialConnectionLabel.TabIndex = 0;
            this.SerialConnectionLabel.Text = "Tally Device Connectivity";
            this.SerialConnectionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DeviceInfoButton
            // 
            this.DeviceInfoButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DeviceInfoButton.BackColor = System.Drawing.Color.Transparent;
            this.DeviceInfoButton.BorderRadius = 10;
            this.DeviceInfoButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.DeviceInfoButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.DeviceInfoButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.DeviceInfoButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.DeviceInfoButton.FillColor = System.Drawing.Color.Gray;
            this.DeviceInfoButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeviceInfoButton.ForeColor = System.Drawing.Color.White;
            this.DeviceInfoButton.Location = new System.Drawing.Point(219, 8);
            this.DeviceInfoButton.Margin = new System.Windows.Forms.Padding(8);
            this.DeviceInfoButton.MaximumSize = new System.Drawing.Size(0, 65);
            this.DeviceInfoButton.Name = "DeviceInfoButton";
            this.DeviceInfoButton.Size = new System.Drawing.Size(182, 63);
            this.DeviceInfoButton.TabIndex = 1;
            this.DeviceInfoButton.Text = "Device Info";
            this.DeviceInfoButton.Click += new System.EventHandler(this.DeviceInfoButton_Click);
            // 
            // DeviceProgramButton
            // 
            this.DeviceProgramButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DeviceProgramButton.BackColor = System.Drawing.Color.Transparent;
            this.DeviceProgramButton.BorderRadius = 10;
            this.DeviceProgramButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.DeviceProgramButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.DeviceProgramButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.DeviceProgramButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.DeviceProgramButton.FillColor = System.Drawing.Color.Gray;
            this.DeviceProgramButton.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.DeviceProgramButton.ForeColor = System.Drawing.Color.White;
            this.DeviceProgramButton.Location = new System.Drawing.Point(417, 8);
            this.DeviceProgramButton.Margin = new System.Windows.Forms.Padding(8);
            this.DeviceProgramButton.MaximumSize = new System.Drawing.Size(0, 65);
            this.DeviceProgramButton.Name = "DeviceProgramButton";
            this.DeviceProgramButton.Size = new System.Drawing.Size(190, 63);
            this.DeviceProgramButton.TabIndex = 2;
            this.DeviceProgramButton.Text = "Program Device";
            this.DeviceProgramButton.Click += new System.EventHandler(this.DeviceProgramButton_Click);
            // 
            // MessageText
            // 
            this.MessageText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MessageText.Cursor = System.Windows.Forms.Cursors.Default;
            this.MessageText.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MessageText.Location = new System.Drawing.Point(4, 689);
            this.MessageText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MessageText.Name = "MessageText";
            this.MessageText.Size = new System.Drawing.Size(607, 34);
            this.MessageText.TabIndex = 21;
            this.MessageText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Controls.Add(this.TestConnectButton, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.SaveButton, 1, 0);
            this.tableLayoutPanel5.Location = new System.Drawing.Point(0, 533);
            this.tableLayoutPanel5.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(615, 77);
            this.tableLayoutPanel5.TabIndex = 15;
            // 
            // TestConnectButton
            // 
            this.TestConnectButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TestConnectButton.BackColor = System.Drawing.Color.Transparent;
            this.TestConnectButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TestConnectButton.ForeColor = System.Drawing.Color.White;
            this.TestConnectButton.Location = new System.Drawing.Point(4, 5);
            this.TestConnectButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TestConnectButton.MaximumSize = new System.Drawing.Size(0, 65);
            this.TestConnectButton.Name = "TestConnectButton";
            this.TestConnectButton.Size = new System.Drawing.Size(299, 65);
            this.TestConnectButton.TabIndex = 20;
            this.TestConnectButton.Text = "Test Connection";
            this.TestConnectButton.UseVisualStyleBackColor = false;
            this.TestConnectButton.Click += new System.EventHandler(this.wsConnect_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SaveButton.BackColor = System.Drawing.Color.Transparent;
            this.SaveButton.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.SaveButton.ForeColor = System.Drawing.Color.White;
            this.SaveButton.Location = new System.Drawing.Point(311, 5);
            this.SaveButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SaveButton.MaximumSize = new System.Drawing.Size(0, 65);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(300, 65);
            this.SaveButton.TabIndex = 24;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = false;
            this.SaveButton.Click += new System.EventHandler(this.Save_Click);
            // 
            // IPAddressToolTip
            // 
            this.IPAddressToolTip.AllowLinksHandling = true;
            this.IPAddressToolTip.MaximumSize = new System.Drawing.Size(0, 0);
            // 
            // PortToolTip
            // 
            this.PortToolTip.AllowLinksHandling = true;
            this.PortToolTip.MaximumSize = new System.Drawing.Size(0, 0);
            // 
            // SerialConnectedTimer
            // 
            this.SerialConnectedTimer.Enabled = true;
            this.SerialConnectedTimer.Tick += new System.EventHandler(this.SerialConnectedTimer_Tick);
            // 
            // SetupPopup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(630, 738);
            this.Controls.Add(this.LayoutPanelAll);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimumSize = new System.Drawing.Size(630, 738);
            this.Name = "SetupPopup";
            this.Text = "Setup";
            this.Load += new System.EventHandler(this.SetupPopup_Load);
            this.LayoutPanelAll.ResumeLayout(false);
            this.Menu.ResumeLayout(false);
            this.Menu.PerformLayout();
            this.LayoutPanelUserConfig.ResumeLayout(false);
            this.LayoutPanelUserConfig.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.LayoutPanelSourceUI.ResumeLayout(false);
            this.LayoutPanelSourceUI.PerformLayout();
            this.ProgramDeviceLayout.ResumeLayout(false);
            this.ProgramDeviceLayout.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel LayoutPanelAll;
        private System.Windows.Forms.TableLayoutPanel Menu;
        private Siticone.Desktop.UI.WinForms.SiticoneToggleSwitch WiredWirelessToggle;
        private Siticone.Desktop.UI.WinForms.SiticoneControlBox CloseButton;
        private System.Windows.Forms.Label WiredWirelessLabel;
        private System.Windows.Forms.TableLayoutPanel LayoutPanelUserConfig;
        private System.Windows.Forms.Label IPAddressLabel;
        private System.Windows.Forms.Label PortLabel;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.TableLayoutPanel LayoutPanelSourceUI;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private Siticone.Desktop.UI.WinForms.SiticoneComboBox siticoneComboBox4;
        private System.Windows.Forms.Label label2;
        private Siticone.Desktop.UI.WinForms.SiticoneComboBox siticoneComboBox3;
        private System.Windows.Forms.Label label3;
        private Siticone.Desktop.UI.WinForms.SiticoneComboBox siticoneComboBox2;
        private System.Windows.Forms.Label label4;
        private Siticone.Desktop.UI.WinForms.SiticoneComboBox siticoneComboBox1;
        private Siticone.Desktop.UI.WinForms.SiticoneComboBox siticoneComboBox5;
        private Siticone.Desktop.UI.WinForms.SiticoneComboBox siticoneComboBox6;
        private Siticone.Desktop.UI.WinForms.SiticoneComboBox siticoneComboBox7;
        private Siticone.Desktop.UI.WinForms.SiticoneComboBox siticoneComboBox8;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.TableLayoutPanel ProgramDeviceLayout;
        private System.Windows.Forms.Label SerialConnectionLabel;
        private System.Windows.Forms.Label MessageText;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox PortTextBox;
        private Siticone.Desktop.UI.WinForms.SiticoneComboBox PortComboBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox IPAddressTextBox;
        private System.Windows.Forms.ComboBox IPAddressComboBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Button TestConnectButton;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox PasswordTextBox;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlToolTip IPAddressToolTip;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlToolTip PortToolTip;
        private Siticone.Desktop.UI.WinForms.SiticoneButton DeviceInfoButton;
        private Siticone.Desktop.UI.WinForms.SiticoneButton DeviceProgramButton;
        private System.Windows.Forms.Timer SerialConnectedTimer;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Siticone.Desktop.UI.WinForms.SiticoneImageCheckBox pwShow;
    }
}