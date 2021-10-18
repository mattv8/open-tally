namespace OpenTally
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tableLayout1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayout3 = new System.Windows.Forms.TableLayoutPanel();
            this.ServerConnectButton = new Siticone.Desktop.UI.WinForms.SiticoneRoundedButton();
            this.PortText = new System.Windows.Forms.Label();
            this.DeviceInfoButton = new Siticone.Desktop.UI.WinForms.SiticoneRoundedButton();
            this.SetupButton = new Siticone.Desktop.UI.WinForms.SiticoneRoundedButton();
            this.tableLayout2 = new System.Windows.Forms.TableLayoutPanel();
            this.Source5 = new System.Windows.Forms.Label();
            this.Source6 = new System.Windows.Forms.Label();
            this.Source7 = new System.Windows.Forms.Label();
            this.Source8 = new System.Windows.Forms.Label();
            this.Source2 = new System.Windows.Forms.Label();
            this.Source3 = new System.Windows.Forms.Label();
            this.Source4 = new System.Windows.Forms.Label();
            this.Source1 = new System.Windows.Forms.Label();
            this.tableLayout4 = new System.Windows.Forms.TableLayoutPanel();
            this.CloseButton = new Siticone.Desktop.UI.WinForms.SiticoneControlBox();
            this.MinimizeButton = new Siticone.Desktop.UI.WinForms.SiticoneControlBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.MessageText = new System.Windows.Forms.Label();
            this.InfoText = new System.Windows.Forms.Label();
            this.PreviewsButton = new Siticone.Desktop.UI.WinForms.SiticoneRoundedButton();
            this.TrayIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.DetectSerialTimer = new System.Windows.Forms.Timer(this.components);
            this.pollOBS = new System.Windows.Forms.Timer(this.components);
            this.pollTA = new System.Windows.Forms.Timer(this.components);
            this.tableLayout1.SuspendLayout();
            this.tableLayout3.SuspendLayout();
            this.tableLayout2.SuspendLayout();
            this.tableLayout4.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayout1
            // 
            this.tableLayout1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayout1.ColumnCount = 1;
            this.tableLayout1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayout1.Controls.Add(this.tableLayout3, 0, 3);
            this.tableLayout1.Controls.Add(this.tableLayout2, 0, 1);
            this.tableLayout1.Controls.Add(this.tableLayout4, 0, 0);
            this.tableLayout1.Controls.Add(this.PreviewsButton, 0, 2);
            this.tableLayout1.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.tableLayout1.Location = new System.Drawing.Point(5, 5);
            this.tableLayout1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayout1.Name = "tableLayout1";
            this.tableLayout1.RowCount = 4;
            this.tableLayout1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableLayout1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayout1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableLayout1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableLayout1.Size = new System.Drawing.Size(390, 240);
            this.tableLayout1.TabIndex = 10;
            // 
            // tableLayout3
            // 
            this.tableLayout3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayout3.AutoSize = true;
            this.tableLayout3.ColumnCount = 4;
            this.tableLayout3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayout3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayout3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayout3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayout3.Controls.Add(this.ServerConnectButton, 0, 0);
            this.tableLayout3.Controls.Add(this.PortText, 0, 0);
            this.tableLayout3.Controls.Add(this.DeviceInfoButton, 2, 0);
            this.tableLayout3.Controls.Add(this.SetupButton, 3, 0);
            this.tableLayout3.Location = new System.Drawing.Point(0, 204);
            this.tableLayout3.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayout3.Name = "tableLayout3";
            this.tableLayout3.RowCount = 1;
            this.tableLayout3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayout3.Size = new System.Drawing.Size(390, 36);
            this.tableLayout3.TabIndex = 11;
            // 
            // ServerConnectButton
            // 
            this.ServerConnectButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ServerConnectButton.BackColor = System.Drawing.Color.Transparent;
            this.ServerConnectButton.BorderRadius = 14;
            this.ServerConnectButton.CheckedState.Parent = this.ServerConnectButton;
            this.ServerConnectButton.CustomImages.Parent = this.ServerConnectButton;
            this.ServerConnectButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ServerConnectButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ServerConnectButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ServerConnectButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ServerConnectButton.DisabledState.Parent = this.ServerConnectButton;
            this.ServerConnectButton.FillColor = System.Drawing.Color.Gray;
            this.ServerConnectButton.Font = new System.Drawing.Font("Segoe UI", 7F);
            this.ServerConnectButton.ForeColor = System.Drawing.Color.White;
            this.ServerConnectButton.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(213)))), ((int)(((byte)(217)))));
            this.ServerConnectButton.HoverState.Parent = this.ServerConnectButton;
            this.ServerConnectButton.Location = new System.Drawing.Point(100, 3);
            this.ServerConnectButton.Name = "ServerConnectButton";
            this.ServerConnectButton.ShadowDecoration.Parent = this.ServerConnectButton;
            this.ServerConnectButton.Size = new System.Drawing.Size(91, 30);
            this.ServerConnectButton.TabIndex = 15;
            this.ServerConnectButton.Text = "Tally Server Connection";
            this.ServerConnectButton.Click += new System.EventHandler(this.ServerConnectButton_Click);
            // 
            // PortText
            // 
            this.PortText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PortText.AutoSize = true;
            this.PortText.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PortText.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.PortText.Location = new System.Drawing.Point(3, 3);
            this.PortText.Margin = new System.Windows.Forms.Padding(3);
            this.PortText.MaximumSize = new System.Drawing.Size(0, 27);
            this.PortText.MinimumSize = new System.Drawing.Size(0, 27);
            this.PortText.Name = "PortText";
            this.PortText.Size = new System.Drawing.Size(91, 27);
            this.PortText.TabIndex = 8;
            this.PortText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DeviceInfoButton
            // 
            this.DeviceInfoButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DeviceInfoButton.BackColor = System.Drawing.Color.Transparent;
            this.DeviceInfoButton.BorderRadius = 14;
            this.DeviceInfoButton.CheckedState.Parent = this.DeviceInfoButton;
            this.DeviceInfoButton.CustomImages.Parent = this.DeviceInfoButton;
            this.DeviceInfoButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.DeviceInfoButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.DeviceInfoButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.DeviceInfoButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.DeviceInfoButton.DisabledState.Parent = this.DeviceInfoButton;
            this.DeviceInfoButton.FillColor = System.Drawing.Color.Gray;
            this.DeviceInfoButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.DeviceInfoButton.ForeColor = System.Drawing.Color.White;
            this.DeviceInfoButton.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(213)))), ((int)(((byte)(217)))));
            this.DeviceInfoButton.HoverState.Parent = this.DeviceInfoButton;
            this.DeviceInfoButton.Location = new System.Drawing.Point(197, 3);
            this.DeviceInfoButton.Name = "DeviceInfoButton";
            this.DeviceInfoButton.ShadowDecoration.Parent = this.DeviceInfoButton;
            this.DeviceInfoButton.Size = new System.Drawing.Size(91, 30);
            this.DeviceInfoButton.TabIndex = 14;
            this.DeviceInfoButton.Text = "Device Info";
            this.DeviceInfoButton.Click += new System.EventHandler(this.DeviceInfoButton_Click);
            // 
            // SetupButton
            // 
            this.SetupButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SetupButton.BackColor = System.Drawing.Color.Transparent;
            this.SetupButton.BorderRadius = 14;
            this.SetupButton.CheckedState.Parent = this.SetupButton;
            this.SetupButton.CustomImages.Parent = this.SetupButton;
            this.SetupButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.SetupButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.SetupButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.SetupButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.SetupButton.DisabledState.Parent = this.SetupButton;
            this.SetupButton.FillColor = System.Drawing.Color.Gray;
            this.SetupButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.SetupButton.ForeColor = System.Drawing.Color.White;
            this.SetupButton.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(213)))), ((int)(((byte)(217)))));
            this.SetupButton.HoverState.Parent = this.SetupButton;
            this.SetupButton.Location = new System.Drawing.Point(294, 3);
            this.SetupButton.Name = "SetupButton";
            this.SetupButton.ShadowDecoration.Parent = this.SetupButton;
            this.SetupButton.Size = new System.Drawing.Size(93, 30);
            this.SetupButton.TabIndex = 12;
            this.SetupButton.Text = "Setup";
            this.SetupButton.Click += new System.EventHandler(this.SetupButton_Click);
            // 
            // tableLayout2
            // 
            this.tableLayout2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayout2.AutoSize = true;
            this.tableLayout2.ColumnCount = 4;
            this.tableLayout2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayout2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayout2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayout2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayout2.Controls.Add(this.Source5, 0, 1);
            this.tableLayout2.Controls.Add(this.Source6, 0, 1);
            this.tableLayout2.Controls.Add(this.Source7, 0, 1);
            this.tableLayout2.Controls.Add(this.Source8, 0, 1);
            this.tableLayout2.Controls.Add(this.Source2, 1, 0);
            this.tableLayout2.Controls.Add(this.Source3, 2, 0);
            this.tableLayout2.Controls.Add(this.Source4, 3, 0);
            this.tableLayout2.Controls.Add(this.Source1, 0, 0);
            this.tableLayout2.Location = new System.Drawing.Point(0, 36);
            this.tableLayout2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayout2.MinimumSize = new System.Drawing.Size(300, 53);
            this.tableLayout2.Name = "tableLayout2";
            this.tableLayout2.RowCount = 2;
            this.tableLayout2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayout2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayout2.Size = new System.Drawing.Size(390, 132);
            this.tableLayout2.TabIndex = 10;
            // 
            // Source5
            // 
            this.Source5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Source5.AutoSize = true;
            this.Source5.BackColor = System.Drawing.Color.Gray;
            this.Source5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.Source5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Source5.Location = new System.Drawing.Point(3, 70);
            this.Source5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Source5.MinimumSize = new System.Drawing.Size(62, 44);
            this.Source5.Name = "Source5";
            this.Source5.Size = new System.Drawing.Size(91, 58);
            this.Source5.TabIndex = 7;
            this.Source5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Source6
            // 
            this.Source6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Source6.AutoSize = true;
            this.Source6.BackColor = System.Drawing.Color.Gray;
            this.Source6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.Source6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Source6.Location = new System.Drawing.Point(100, 70);
            this.Source6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Source6.MinimumSize = new System.Drawing.Size(62, 44);
            this.Source6.Name = "Source6";
            this.Source6.Size = new System.Drawing.Size(91, 58);
            this.Source6.TabIndex = 6;
            this.Source6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Source7
            // 
            this.Source7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Source7.AutoSize = true;
            this.Source7.BackColor = System.Drawing.Color.Gray;
            this.Source7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.Source7.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Source7.Location = new System.Drawing.Point(197, 70);
            this.Source7.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Source7.MinimumSize = new System.Drawing.Size(62, 44);
            this.Source7.Name = "Source7";
            this.Source7.Size = new System.Drawing.Size(91, 58);
            this.Source7.TabIndex = 5;
            this.Source7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Source8
            // 
            this.Source8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Source8.AutoSize = true;
            this.Source8.BackColor = System.Drawing.Color.Gray;
            this.Source8.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.Source8.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Source8.Location = new System.Drawing.Point(294, 70);
            this.Source8.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Source8.MinimumSize = new System.Drawing.Size(62, 44);
            this.Source8.Name = "Source8";
            this.Source8.Size = new System.Drawing.Size(93, 58);
            this.Source8.TabIndex = 4;
            this.Source8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Source2
            // 
            this.Source2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Source2.AutoSize = true;
            this.Source2.BackColor = System.Drawing.Color.Gray;
            this.Source2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.Source2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Source2.Location = new System.Drawing.Point(100, 4);
            this.Source2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Source2.MinimumSize = new System.Drawing.Size(62, 44);
            this.Source2.Name = "Source2";
            this.Source2.Size = new System.Drawing.Size(91, 58);
            this.Source2.TabIndex = 1;
            this.Source2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Source3
            // 
            this.Source3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Source3.AutoSize = true;
            this.Source3.BackColor = System.Drawing.Color.Gray;
            this.Source3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.Source3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Source3.Location = new System.Drawing.Point(197, 4);
            this.Source3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Source3.MinimumSize = new System.Drawing.Size(62, 44);
            this.Source3.Name = "Source3";
            this.Source3.Size = new System.Drawing.Size(91, 58);
            this.Source3.TabIndex = 2;
            this.Source3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Source4
            // 
            this.Source4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Source4.AutoSize = true;
            this.Source4.BackColor = System.Drawing.Color.Gray;
            this.Source4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.Source4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Source4.Location = new System.Drawing.Point(294, 4);
            this.Source4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Source4.MinimumSize = new System.Drawing.Size(62, 44);
            this.Source4.Name = "Source4";
            this.Source4.Size = new System.Drawing.Size(93, 58);
            this.Source4.TabIndex = 3;
            this.Source4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Source1
            // 
            this.Source1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Source1.AutoSize = true;
            this.Source1.BackColor = System.Drawing.Color.Gray;
            this.Source1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.Source1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Source1.Location = new System.Drawing.Point(3, 4);
            this.Source1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Source1.MinimumSize = new System.Drawing.Size(62, 44);
            this.Source1.Name = "Source1";
            this.Source1.Size = new System.Drawing.Size(91, 58);
            this.Source1.TabIndex = 0;
            this.Source1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayout4
            // 
            this.tableLayout4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayout4.ColumnCount = 3;
            this.tableLayout4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayout4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableLayout4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableLayout4.Controls.Add(this.CloseButton, 2, 0);
            this.tableLayout4.Controls.Add(this.MinimizeButton, 1, 0);
            this.tableLayout4.Controls.Add(this.tableLayoutPanel1, 0, 0);
            this.tableLayout4.Location = new System.Drawing.Point(0, 0);
            this.tableLayout4.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayout4.Name = "tableLayout4";
            this.tableLayout4.RowCount = 1;
            this.tableLayout4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayout4.Size = new System.Drawing.Size(390, 36);
            this.tableLayout4.TabIndex = 12;
            // 
            // CloseButton
            // 
            this.CloseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseButton.FillColor = System.Drawing.Color.Gray;
            this.CloseButton.HoverState.IconColor = System.Drawing.Color.Red;
            this.CloseButton.HoverState.Parent = this.CloseButton;
            this.CloseButton.IconColor = System.Drawing.Color.White;
            this.CloseButton.Location = new System.Drawing.Point(357, 3);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.ShadowDecoration.Parent = this.CloseButton;
            this.CloseButton.Size = new System.Drawing.Size(30, 30);
            this.CloseButton.TabIndex = 0;
            // 
            // MinimizeButton
            // 
            this.MinimizeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MinimizeButton.ControlBoxType = Siticone.Desktop.UI.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.MinimizeButton.FillColor = System.Drawing.Color.Gray;
            this.MinimizeButton.HoverState.IconColor = System.Drawing.Color.Red;
            this.MinimizeButton.HoverState.Parent = this.MinimizeButton;
            this.MinimizeButton.IconColor = System.Drawing.Color.White;
            this.MinimizeButton.Location = new System.Drawing.Point(321, 3);
            this.MinimizeButton.Name = "MinimizeButton";
            this.MinimizeButton.ShadowDecoration.Parent = this.MinimizeButton;
            this.MinimizeButton.Size = new System.Drawing.Size(30, 30);
            this.MinimizeButton.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.MessageText, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.InfoText, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(318, 36);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // MessageText
            // 
            this.MessageText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MessageText.AutoSize = true;
            this.MessageText.BackColor = System.Drawing.Color.Transparent;
            this.MessageText.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.MessageText.Location = new System.Drawing.Point(4, 21);
            this.MessageText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MessageText.MaximumSize = new System.Drawing.Size(0, 15);
            this.MessageText.MinimumSize = new System.Drawing.Size(0, 15);
            this.MessageText.Name = "MessageText";
            this.MessageText.Size = new System.Drawing.Size(310, 15);
            this.MessageText.TabIndex = 0;
            // 
            // InfoText
            // 
            this.InfoText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.InfoText.AutoSize = true;
            this.InfoText.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InfoText.ForeColor = System.Drawing.Color.Gray;
            this.InfoText.Location = new System.Drawing.Point(4, 0);
            this.InfoText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.InfoText.Name = "InfoText";
            this.InfoText.Size = new System.Drawing.Size(310, 18);
            this.InfoText.TabIndex = 1;
            // 
            // PreviewsButton
            // 
            this.PreviewsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PreviewsButton.BackColor = System.Drawing.Color.Transparent;
            this.PreviewsButton.BorderRadius = 14;
            this.PreviewsButton.CheckedState.Parent = this.PreviewsButton;
            this.PreviewsButton.CustomImages.Parent = this.PreviewsButton;
            this.PreviewsButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.PreviewsButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.PreviewsButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.PreviewsButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.PreviewsButton.DisabledState.Parent = this.PreviewsButton;
            this.PreviewsButton.FillColor = System.Drawing.Color.Gray;
            this.PreviewsButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.PreviewsButton.ForeColor = System.Drawing.Color.White;
            this.PreviewsButton.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(213)))), ((int)(((byte)(217)))));
            this.PreviewsButton.HoverState.Parent = this.PreviewsButton;
            this.PreviewsButton.Location = new System.Drawing.Point(3, 171);
            this.PreviewsButton.Name = "PreviewsButton";
            this.PreviewsButton.ShadowDecoration.Parent = this.PreviewsButton;
            this.PreviewsButton.Size = new System.Drawing.Size(384, 30);
            this.PreviewsButton.TabIndex = 13;
            this.PreviewsButton.Text = "Previews ON";
            this.PreviewsButton.Click += new System.EventHandler(this.PreviewsButton_Click);
            // 
            // TrayIcon
            // 
            this.TrayIcon.BalloonTipText = "Open Tally is running in the background.";
            this.TrayIcon.BalloonTipTitle = "Open Tally";
            this.TrayIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("TrayIcon.Icon")));
            this.TrayIcon.Text = "Open Tally";
            this.TrayIcon.Visible = true;
            this.TrayIcon.Click += new System.EventHandler(this.TrayIcon_Click);
            // 
            // DetectSerialTimer
            // 
            this.DetectSerialTimer.Enabled = true;
            this.DetectSerialTimer.Interval = 1000;
            this.DetectSerialTimer.Tick += new System.EventHandler(this.DetectSerialTimer_Tick);
            // 
            // pollOBS
            // 
            this.pollOBS.Tick += new System.EventHandler(this.pollOBS_Tick);
            // 
            // pollTA
            // 
            this.pollTA.Tick += new System.EventHandler(this.pollTA_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(400, 250);
            this.Controls.Add(this.tableLayout1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(400, 250);
            this.Name = "MainForm";
            this.Text = "Tally Pro 0.1";
            this.Load += new System.EventHandler(this.MainProgram_Load);
            this.Resize += new System.EventHandler(this.MainProgram_Resize);
            this.tableLayout1.ResumeLayout(false);
            this.tableLayout1.PerformLayout();
            this.tableLayout3.ResumeLayout(false);
            this.tableLayout3.PerformLayout();
            this.tableLayout2.ResumeLayout(false);
            this.tableLayout2.PerformLayout();
            this.tableLayout4.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayout1;
        private System.Windows.Forms.TableLayoutPanel tableLayout2;
        private System.Windows.Forms.TableLayoutPanel tableLayout3;
        private System.Windows.Forms.Label PortText;
        private System.Windows.Forms.TableLayoutPanel tableLayout4;
        private Siticone.Desktop.UI.WinForms.SiticoneControlBox CloseButton;
        private Siticone.Desktop.UI.WinForms.SiticoneControlBox MinimizeButton;
        private System.Windows.Forms.Label MessageText;
        private Siticone.Desktop.UI.WinForms.SiticoneRoundedButton SetupButton;
        private System.Windows.Forms.NotifyIcon TrayIcon;
        private Siticone.Desktop.UI.WinForms.SiticoneRoundedButton DeviceInfoButton;
        private Siticone.Desktop.UI.WinForms.SiticoneRoundedButton PreviewsButton;
        private System.Windows.Forms.Label Source5;
        private System.Windows.Forms.Label Source6;
        private System.Windows.Forms.Label Source7;
        private System.Windows.Forms.Label Source2;
        private System.Windows.Forms.Label Source3;
        private System.Windows.Forms.Label Source4;
        private System.Windows.Forms.Label Source1;
        private System.Windows.Forms.Label Source8;
        private System.Windows.Forms.Timer DetectSerialTimer;
        private Siticone.Desktop.UI.WinForms.SiticoneRoundedButton ServerConnectButton;
        private System.Windows.Forms.Timer pollOBS;
        private System.Windows.Forms.Timer pollTA;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label InfoText;
    }
}

