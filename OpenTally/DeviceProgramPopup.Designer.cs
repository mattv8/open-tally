namespace OpenTally
{
    partial class DeviceProgramPopup
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
            this.SendToDeviceButton = new System.Windows.Forms.Button();
            this.tableLayout1 = new System.Windows.Forms.TableLayoutPanel();
            this.DefaultCustomComboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.siticoneTextBox4 = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.siticoneTextBox3 = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.siticoneTextBox2 = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.siticoneTextBox1 = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.IPAddressToolTip = new Siticone.Desktop.UI.WinForms.SiticoneHtmlToolTip();
            this.PortToolTip = new Siticone.Desktop.UI.WinForms.SiticoneHtmlToolTip();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayout4 = new System.Windows.Forms.TableLayoutPanel();
            this.CloseButton = new Siticone.Desktop.UI.WinForms.SiticoneControlBox();
            this.tableLayout1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayout4.SuspendLayout();
            this.SuspendLayout();
            // 
            // SendToDeviceButton
            // 
            this.SendToDeviceButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            //this.SendToDeviceButton.BorderRadius = 16;
            //this.SendToDeviceButton.CheckedState.Parent = this.SendToDeviceButton;
            //this.SendToDeviceButton.CustomImages.Parent = this.SendToDeviceButton;
            //this.SendToDeviceButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            //this.SendToDeviceButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            //this.SendToDeviceButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            //this.SendToDeviceButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            //this.SendToDeviceButton.DisabledState.Parent = this.SendToDeviceButton;
            //this.SendToDeviceButton.FillColor = System.Drawing.Color.Gray;
            this.SendToDeviceButton.Font = new System.Drawing.Font("Trebuchet MS", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SendToDeviceButton.ForeColor = System.Drawing.Color.White;
            //this.SendToDeviceButton.HoverState.Parent = this.SendToDeviceButton;
            this.SendToDeviceButton.Location = new System.Drawing.Point(134, 3);
            this.SendToDeviceButton.MaximumSize = new System.Drawing.Size(0, 36);
            this.SendToDeviceButton.Name = "SendToDeviceButton";
            //this.SendToDeviceButton.ShadowDecoration.Parent = this.SendToDeviceButton;
            this.SendToDeviceButton.Size = new System.Drawing.Size(243, 34);
            this.SendToDeviceButton.TabIndex = 12;
            this.SendToDeviceButton.Text = "Send To Device";
            this.SendToDeviceButton.Click += new System.EventHandler(this.SendToDeviceButton_Click);
            // 
            // tableLayout1
            // 
            this.tableLayout1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayout1.ColumnCount = 2;
            this.tableLayout1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34.73055F));
            this.tableLayout1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65.26945F));
            this.tableLayout1.Controls.Add(this.DefaultCustomComboBox, 0, 0);
            this.tableLayout1.Controls.Add(this.SendToDeviceButton, 1, 0);
            this.tableLayout1.Controls.Add(this.label4, 0, 4);
            this.tableLayout1.Controls.Add(this.siticoneTextBox4, 1, 4);
            this.tableLayout1.Controls.Add(this.label3, 0, 3);
            this.tableLayout1.Controls.Add(this.siticoneTextBox3, 1, 3);
            this.tableLayout1.Controls.Add(this.label2, 0, 2);
            this.tableLayout1.Controls.Add(this.siticoneTextBox2, 1, 2);
            this.tableLayout1.Controls.Add(this.label1, 0, 1);
            this.tableLayout1.Controls.Add(this.siticoneTextBox1, 1, 1);
            this.tableLayout1.Location = new System.Drawing.Point(0, 36);
            this.tableLayout1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayout1.Name = "tableLayout1";
            this.tableLayout1.RowCount = 5;
            this.tableLayout1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayout1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayout1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayout1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayout1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayout1.Size = new System.Drawing.Size(380, 204);
            this.tableLayout1.TabIndex = 13;
            // 
            // DefaultCustomComboBox
            // 
            this.DefaultCustomComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DefaultCustomComboBox.BackColor = System.Drawing.Color.Transparent;
            //this.DefaultCustomComboBox.BorderRadius = 17;
            this.DefaultCustomComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.DefaultCustomComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            //this.DefaultCustomComboBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(213)))), ((int)(((byte)(217)))));
            //this.DefaultCustomComboBox.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            //this.DefaultCustomComboBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            //this.DefaultCustomComboBox.FocusedState.Parent = this.DefaultCustomComboBox;
            this.DefaultCustomComboBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.DefaultCustomComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            //this.DefaultCustomComboBox.HoverState.Parent = this.DefaultCustomComboBox;
            this.DefaultCustomComboBox.ItemHeight = 30;
            //this.DefaultCustomComboBox.ItemsAppearance.Parent = this.DefaultCustomComboBox;
            this.DefaultCustomComboBox.Location = new System.Drawing.Point(3, 3);
            this.DefaultCustomComboBox.Name = "DefaultCustomComboBox";
            //this.DefaultCustomComboBox.ShadowDecoration.Parent = this.DefaultCustomComboBox;
            this.DefaultCustomComboBox.Size = new System.Drawing.Size(125, 36);
            this.DefaultCustomComboBox.TabIndex = 8;
            this.DefaultCustomComboBox.SelectedIndexChanged += new System.EventHandler(this.DefaultCustomComboBox_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(21, 170);
            this.label4.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 18);
            this.label4.TabIndex = 7;
            this.label4.Text = "Tally Server Port:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // siticoneTextBox4
            // 
            this.siticoneTextBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.siticoneTextBox4.BorderRadius = 10;
            this.siticoneTextBox4.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.siticoneTextBox4.DefaultText = "";
            this.siticoneTextBox4.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.siticoneTextBox4.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.siticoneTextBox4.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.siticoneTextBox4.DisabledState.Parent = this.siticoneTextBox4;
            this.siticoneTextBox4.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.siticoneTextBox4.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(213)))), ((int)(((byte)(217)))));
            this.siticoneTextBox4.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.siticoneTextBox4.FocusedState.Parent = this.siticoneTextBox4;
            this.siticoneTextBox4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.siticoneTextBox4.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.siticoneTextBox4.HoverState.Parent = this.siticoneTextBox4;
            this.siticoneTextBox4.Location = new System.Drawing.Point(134, 163);
            this.siticoneTextBox4.MaximumSize = new System.Drawing.Size(0, 42);
            this.siticoneTextBox4.Name = "siticoneTextBox4";
            this.siticoneTextBox4.PasswordChar = '\0';
            this.siticoneTextBox4.PlaceholderText = "";
            this.siticoneTextBox4.SelectedText = "";
            this.siticoneTextBox4.ShadowDecoration.Parent = this.siticoneTextBox4;
            this.siticoneTextBox4.Size = new System.Drawing.Size(243, 38);
            this.siticoneTextBox4.TabIndex = 3;
            this.siticoneTextBox4.Leave += new System.EventHandler(this.PortTextBox_Leave);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(33, 130);
            this.label3.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "Tally Server IP:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // siticoneTextBox3
            // 
            this.siticoneTextBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.siticoneTextBox3.BorderRadius = 10;
            this.siticoneTextBox3.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.siticoneTextBox3.DefaultText = "";
            this.siticoneTextBox3.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.siticoneTextBox3.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.siticoneTextBox3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.siticoneTextBox3.DisabledState.Parent = this.siticoneTextBox3;
            this.siticoneTextBox3.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.siticoneTextBox3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(213)))), ((int)(((byte)(217)))));
            this.siticoneTextBox3.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.siticoneTextBox3.FocusedState.Parent = this.siticoneTextBox3;
            this.siticoneTextBox3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.siticoneTextBox3.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.siticoneTextBox3.HoverState.Parent = this.siticoneTextBox3;
            this.siticoneTextBox3.Location = new System.Drawing.Point(134, 123);
            this.siticoneTextBox3.MaximumSize = new System.Drawing.Size(0, 42);
            this.siticoneTextBox3.Name = "siticoneTextBox3";
            this.siticoneTextBox3.PasswordChar = '\0';
            this.siticoneTextBox3.PlaceholderText = "";
            this.siticoneTextBox3.SelectedText = "";
            this.siticoneTextBox3.ShadowDecoration.Parent = this.siticoneTextBox3;
            this.siticoneTextBox3.Size = new System.Drawing.Size(243, 34);
            this.siticoneTextBox3.TabIndex = 2;
            this.siticoneTextBox3.Leave += new System.EventHandler(this.IPAddressTextBox_Leave);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 90);
            this.label2.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "Wi-Fi Password:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // siticoneTextBox2
            // 
            this.siticoneTextBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.siticoneTextBox2.BorderRadius = 10;
            this.siticoneTextBox2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.siticoneTextBox2.DefaultText = "";
            this.siticoneTextBox2.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.siticoneTextBox2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.siticoneTextBox2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.siticoneTextBox2.DisabledState.Parent = this.siticoneTextBox2;
            this.siticoneTextBox2.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.siticoneTextBox2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(213)))), ((int)(((byte)(217)))));
            this.siticoneTextBox2.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.siticoneTextBox2.FocusedState.Parent = this.siticoneTextBox2;
            this.siticoneTextBox2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.siticoneTextBox2.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.siticoneTextBox2.HoverState.Parent = this.siticoneTextBox2;
            this.siticoneTextBox2.Location = new System.Drawing.Point(134, 83);
            this.siticoneTextBox2.MaximumSize = new System.Drawing.Size(0, 42);
            this.siticoneTextBox2.Name = "siticoneTextBox2";
            this.siticoneTextBox2.PasswordChar = '\0';
            this.siticoneTextBox2.PlaceholderText = "";
            this.siticoneTextBox2.SelectedText = "";
            this.siticoneTextBox2.ShadowDecoration.Parent = this.siticoneTextBox2;
            this.siticoneTextBox2.Size = new System.Drawing.Size(243, 34);
            this.siticoneTextBox2.TabIndex = 1;
            this.siticoneTextBox2.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(53, 50);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "Wi-Fi SSID:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // siticoneTextBox1
            // 
            this.siticoneTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.siticoneTextBox1.BorderRadius = 10;
            this.siticoneTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.siticoneTextBox1.DefaultText = "";
            this.siticoneTextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.siticoneTextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.siticoneTextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.siticoneTextBox1.DisabledState.Parent = this.siticoneTextBox1;
            this.siticoneTextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.siticoneTextBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(213)))), ((int)(((byte)(217)))));
            this.siticoneTextBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.siticoneTextBox1.FocusedState.Parent = this.siticoneTextBox1;
            this.siticoneTextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.siticoneTextBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.siticoneTextBox1.HoverState.Parent = this.siticoneTextBox1;
            this.siticoneTextBox1.Location = new System.Drawing.Point(134, 43);
            this.siticoneTextBox1.MaximumSize = new System.Drawing.Size(0, 42);
            this.siticoneTextBox1.Name = "siticoneTextBox1";
            this.siticoneTextBox1.PasswordChar = '\0';
            this.siticoneTextBox1.PlaceholderText = "";
            this.siticoneTextBox1.SelectedText = "";
            this.siticoneTextBox1.ShadowDecoration.Parent = this.siticoneTextBox1;
            this.siticoneTextBox1.Size = new System.Drawing.Size(243, 34);
            this.siticoneTextBox1.TabIndex = 0;
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
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayout4, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayout1, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(10, 10);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(380, 240);
            this.tableLayoutPanel1.TabIndex = 14;
            // 
            // tableLayout4
            // 
            this.tableLayout4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayout4.ColumnCount = 3;
            this.tableLayout4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayout4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tableLayout4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableLayout4.Controls.Add(this.CloseButton, 2, 0);
            this.tableLayout4.Location = new System.Drawing.Point(0, 0);
            this.tableLayout4.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayout4.Name = "tableLayout4";
            this.tableLayout4.RowCount = 1;
            this.tableLayout4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayout4.Size = new System.Drawing.Size(380, 36);
            this.tableLayout4.TabIndex = 15;
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
            this.CloseButton.Location = new System.Drawing.Point(347, 3);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.ShadowDecoration.Parent = this.CloseButton;
            this.CloseButton.Size = new System.Drawing.Size(30, 30);
            this.CloseButton.TabIndex = 0;
            // 
            // DeviceProgramPopup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(400, 260);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(1000, 1000);
            this.MinimumSize = new System.Drawing.Size(400, 260);
            this.Name = "DeviceProgramPopup";
            this.Text = "Program Device";
            this.tableLayout1.ResumeLayout(false);
            this.tableLayout1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayout4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button SendToDeviceButton;
        private System.Windows.Forms.TableLayoutPanel tableLayout1;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox siticoneTextBox1;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox siticoneTextBox2;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox siticoneTextBox3;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox siticoneTextBox4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox DefaultCustomComboBox;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlToolTip IPAddressToolTip;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlToolTip PortToolTip;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayout4;
        private Siticone.Desktop.UI.WinForms.SiticoneControlBox CloseButton;
    }
}