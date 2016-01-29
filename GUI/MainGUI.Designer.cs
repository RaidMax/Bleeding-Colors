namespace ArduinoApp
{
    partial class GUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GUI));
            this.colorPicker = new System.Windows.Forms.ColorDialog();
            this.RedChannelValue = new System.Windows.Forms.TextBox();
            this.BlueChannelValue = new System.Windows.Forms.TextBox();
            this.GreenChannelValue = new System.Windows.Forms.TextBox();
            this.RedChannelLabel = new System.Windows.Forms.Label();
            this.GreenChannelLable = new System.Windows.Forms.Label();
            this.BlueChannelLabel = new System.Windows.Forms.Label();
            this.WhiteChannelLabel = new System.Windows.Forms.Label();
            this.WhiteChannelValue = new System.Windows.Forms.TextBox();
            this.SetColor = new System.Windows.Forms.Button();
            this.logoImage = new System.Windows.Forms.PictureBox();
            this.logoImageText = new System.Windows.Forms.PictureBox();
            this.closeButton = new System.Windows.Forms.PictureBox();
            this.minimizeButton = new System.Windows.Forms.PictureBox();
            this.comPortList = new System.Windows.Forms.ListBox();
            this.comPortListLabel = new System.Windows.Forms.Label();
            this.whiteTrackBar = new System.Windows.Forms.TrackBar();
            this.blueTrackBar = new System.Windows.Forms.TrackBar();
            this.greenTrackBar = new System.Windows.Forms.TrackBar();
            this.redTrackBar = new System.Windows.Forms.TrackBar();
            this.livePreview = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.logoImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoImageText)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimizeButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.whiteTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blueTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.redTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.livePreview)).BeginInit();
            this.SuspendLayout();
            // 
            // colorPicker
            // 
            this.colorPicker.AnyColor = true;
            this.colorPicker.FullOpen = true;
            // 
            // RedChannelValue
            // 
            this.RedChannelValue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(103)))), ((int)(((byte)(103)))));
            this.RedChannelValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RedChannelValue.ForeColor = System.Drawing.Color.White;
            this.RedChannelValue.Location = new System.Drawing.Point(47, 75);
            this.RedChannelValue.MaxLength = 3;
            this.RedChannelValue.Name = "RedChannelValue";
            this.RedChannelValue.Size = new System.Drawing.Size(33, 20);
            this.RedChannelValue.TabIndex = 1;
            this.RedChannelValue.Text = "0";
            this.RedChannelValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.RedChannelValue.TextChanged += new System.EventHandler(this.RedChannelValue_TextChanged);
            // 
            // BlueChannelValue
            // 
            this.BlueChannelValue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(103)))), ((int)(((byte)(103)))));
            this.BlueChannelValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BlueChannelValue.ForeColor = System.Drawing.Color.White;
            this.BlueChannelValue.Location = new System.Drawing.Point(47, 127);
            this.BlueChannelValue.MaxLength = 3;
            this.BlueChannelValue.Name = "BlueChannelValue";
            this.BlueChannelValue.Size = new System.Drawing.Size(33, 20);
            this.BlueChannelValue.TabIndex = 3;
            this.BlueChannelValue.Text = "0";
            this.BlueChannelValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.BlueChannelValue.TextChanged += new System.EventHandler(this.BlueChannelValue_TextChanged);
            // 
            // GreenChannelValue
            // 
            this.GreenChannelValue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(103)))), ((int)(((byte)(103)))));
            this.GreenChannelValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.GreenChannelValue.ForeColor = System.Drawing.Color.White;
            this.GreenChannelValue.Location = new System.Drawing.Point(47, 101);
            this.GreenChannelValue.MaxLength = 3;
            this.GreenChannelValue.Name = "GreenChannelValue";
            this.GreenChannelValue.Size = new System.Drawing.Size(33, 20);
            this.GreenChannelValue.TabIndex = 2;
            this.GreenChannelValue.Text = "0";
            this.GreenChannelValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.GreenChannelValue.TextChanged += new System.EventHandler(this.GreenChannelValue_TextChanged);
            // 
            // RedChannelLabel
            // 
            this.RedChannelLabel.AutoSize = true;
            this.RedChannelLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.RedChannelLabel.ForeColor = System.Drawing.Color.Red;
            this.RedChannelLabel.Location = new System.Drawing.Point(26, 77);
            this.RedChannelLabel.Name = "RedChannelLabel";
            this.RedChannelLabel.Size = new System.Drawing.Size(15, 13);
            this.RedChannelLabel.TabIndex = 4;
            this.RedChannelLabel.Text = "R";
            this.RedChannelLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GreenChannelLable
            // 
            this.GreenChannelLable.AutoSize = true;
            this.GreenChannelLable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.GreenChannelLable.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(175)))), ((int)(((byte)(0)))));
            this.GreenChannelLable.Location = new System.Drawing.Point(26, 103);
            this.GreenChannelLable.Name = "GreenChannelLable";
            this.GreenChannelLable.Size = new System.Drawing.Size(15, 13);
            this.GreenChannelLable.TabIndex = 5;
            this.GreenChannelLable.Text = "G";
            this.GreenChannelLable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BlueChannelLabel
            // 
            this.BlueChannelLabel.AutoSize = true;
            this.BlueChannelLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.BlueChannelLabel.ForeColor = System.Drawing.Color.DodgerBlue;
            this.BlueChannelLabel.Location = new System.Drawing.Point(26, 129);
            this.BlueChannelLabel.Name = "BlueChannelLabel";
            this.BlueChannelLabel.Size = new System.Drawing.Size(14, 13);
            this.BlueChannelLabel.TabIndex = 6;
            this.BlueChannelLabel.Text = "B";
            this.BlueChannelLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // WhiteChannelLabel
            // 
            this.WhiteChannelLabel.AutoSize = true;
            this.WhiteChannelLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.WhiteChannelLabel.ForeColor = System.Drawing.Color.White;
            this.WhiteChannelLabel.Location = new System.Drawing.Point(26, 155);
            this.WhiteChannelLabel.Name = "WhiteChannelLabel";
            this.WhiteChannelLabel.Size = new System.Drawing.Size(18, 13);
            this.WhiteChannelLabel.TabIndex = 8;
            this.WhiteChannelLabel.Text = "W";
            this.WhiteChannelLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // WhiteChannelValue
            // 
            this.WhiteChannelValue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(103)))), ((int)(((byte)(103)))));
            this.WhiteChannelValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.WhiteChannelValue.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.WhiteChannelValue.ForeColor = System.Drawing.Color.White;
            this.WhiteChannelValue.Location = new System.Drawing.Point(47, 153);
            this.WhiteChannelValue.MaxLength = 3;
            this.WhiteChannelValue.Name = "WhiteChannelValue";
            this.WhiteChannelValue.Size = new System.Drawing.Size(33, 20);
            this.WhiteChannelValue.TabIndex = 4;
            this.WhiteChannelValue.Text = "0";
            this.WhiteChannelValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.WhiteChannelValue.TextChanged += new System.EventHandler(this.WhiteChannelValue_TextChanged);
            // 
            // SetColor
            // 
            this.SetColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(76)))));
            this.SetColor.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SetColor.ForeColor = System.Drawing.Color.White;
            this.SetColor.Location = new System.Drawing.Point(289, 186);
            this.SetColor.Name = "SetColor";
            this.SetColor.Size = new System.Drawing.Size(85, 23);
            this.SetColor.TabIndex = 5;
            this.SetColor.Text = "Set";
            this.SetColor.UseVisualStyleBackColor = false;
            // 
            // logoImage
            // 
            this.logoImage.BackColor = System.Drawing.Color.Transparent;
            this.logoImage.Image = global::InterfaceGUI.Properties.Resources.ICON_APPLICATION;
            this.logoImage.Location = new System.Drawing.Point(5, 9);
            this.logoImage.Margin = new System.Windows.Forms.Padding(0);
            this.logoImage.Name = "logoImage";
            this.logoImage.Size = new System.Drawing.Size(42, 42);
            this.logoImage.TabIndex = 10;
            this.logoImage.TabStop = false;
            // 
            // logoImageText
            // 
            this.logoImageText.BackColor = System.Drawing.Color.Transparent;
            this.logoImageText.Image = global::InterfaceGUI.Properties.Resources.INTERFACE_TITLE;
            this.logoImageText.Location = new System.Drawing.Point(59, 16);
            this.logoImageText.Name = "logoImageText";
            this.logoImageText.Size = new System.Drawing.Size(220, 35);
            this.logoImageText.TabIndex = 11;
            this.logoImageText.TabStop = false;
            this.logoImageText.Click += new System.EventHandler(this.logoImageText_Click);
            // 
            // closeButton
            // 
            this.closeButton.BackColor = System.Drawing.Color.Transparent;
            this.closeButton.BackgroundImage = global::InterfaceGUI.Properties.Resources.BUTTON_CLOSE;
            this.closeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeButton.Location = new System.Drawing.Point(356, 16);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(32, 32);
            this.closeButton.TabIndex = 12;
            this.closeButton.TabStop = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            this.closeButton.MouseEnter += new System.EventHandler(this.closeButton_MouseEnter);
            this.closeButton.MouseLeave += new System.EventHandler(this.closeButton_MouseLeave);
            // 
            // minimizeButton
            // 
            this.minimizeButton.BackColor = System.Drawing.Color.Transparent;
            this.minimizeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.minimizeButton.BackgroundImage = global::InterfaceGUI.Properties.Resources.BUTTON_MINIMIZE;
            this.minimizeButton.Location = new System.Drawing.Point(318, 16);
            this.minimizeButton.Name = "minimizeButton";
            this.minimizeButton.Size = new System.Drawing.Size(32, 32);
            this.minimizeButton.TabIndex = 13;
            this.minimizeButton.TabStop = false;
            this.minimizeButton.Click += new System.EventHandler(this.minimizeButton_Click);
            this.minimizeButton.MouseEnter += new System.EventHandler(this.minimizeButton_MouseEnter);
            this.minimizeButton.MouseLeave += new System.EventHandler(this.minimizeButton_MouseLeave);
            // 
            // comPortList
            // 
            this.comPortList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(103)))), ((int)(((byte)(103)))));
            this.comPortList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.comPortList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comPortList.ForeColor = System.Drawing.Color.White;
            this.comPortList.FormattingEnabled = true;
            this.comPortList.ItemHeight = 20;
            this.comPortList.Location = new System.Drawing.Point(12, 564);
            this.comPortList.Name = "comPortList";
            this.comPortList.Size = new System.Drawing.Size(120, 100);
            this.comPortList.TabIndex = 14;
            this.comPortList.SelectedValueChanged += new System.EventHandler(this.comPortList_SelectedValueChanged);
            // 
            // comPortListLabel
            // 
            this.comPortListLabel.AutoSize = true;
            this.comPortListLabel.BackColor = System.Drawing.Color.Transparent;
            this.comPortListLabel.ForeColor = System.Drawing.Color.White;
            this.comPortListLabel.Location = new System.Drawing.Point(36, 545);
            this.comPortListLabel.Margin = new System.Windows.Forms.Padding(5);
            this.comPortListLabel.Name = "comPortListLabel";
            this.comPortListLabel.Size = new System.Drawing.Size(77, 13);
            this.comPortListLabel.TabIndex = 15;
            this.comPortListLabel.Text = "Available Ports";
            // 
            // whiteTrackBar
            // 
            this.whiteTrackBar.AutoSize = false;
            this.whiteTrackBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(76)))));
            this.whiteTrackBar.LargeChange = 20;
            this.whiteTrackBar.Location = new System.Drawing.Point(119, 153);
            this.whiteTrackBar.Maximum = 255;
            this.whiteTrackBar.Name = "whiteTrackBar";
            this.whiteTrackBar.Size = new System.Drawing.Size(255, 20);
            this.whiteTrackBar.TabIndex = 19;
            this.whiteTrackBar.TickFrequency = 15;
            this.whiteTrackBar.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // blueTrackBar
            // 
            this.blueTrackBar.AutoSize = false;
            this.blueTrackBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(76)))));
            this.blueTrackBar.LargeChange = 20;
            this.blueTrackBar.Location = new System.Drawing.Point(119, 127);
            this.blueTrackBar.Maximum = 255;
            this.blueTrackBar.Name = "blueTrackBar";
            this.blueTrackBar.Size = new System.Drawing.Size(255, 20);
            this.blueTrackBar.TabIndex = 18;
            this.blueTrackBar.TickFrequency = 15;
            this.blueTrackBar.Scroll += new System.EventHandler(this.blueTrackBar_Scroll);
            // 
            // greenTrackBar
            // 
            this.greenTrackBar.AutoSize = false;
            this.greenTrackBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(76)))));
            this.greenTrackBar.LargeChange = 20;
            this.greenTrackBar.Location = new System.Drawing.Point(119, 101);
            this.greenTrackBar.Maximum = 255;
            this.greenTrackBar.Name = "greenTrackBar";
            this.greenTrackBar.Size = new System.Drawing.Size(255, 20);
            this.greenTrackBar.TabIndex = 17;
            this.greenTrackBar.TickFrequency = 15;
            this.greenTrackBar.Scroll += new System.EventHandler(this.greenTrackBar_Scroll);
            // 
            // redTrackBar
            // 
            this.redTrackBar.AutoSize = false;
            this.redTrackBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(76)))));
            this.redTrackBar.Cursor = System.Windows.Forms.Cursors.Default;
            this.redTrackBar.LargeChange = 20;
            this.redTrackBar.Location = new System.Drawing.Point(119, 75);
            this.redTrackBar.Maximum = 255;
            this.redTrackBar.Name = "redTrackBar";
            this.redTrackBar.Size = new System.Drawing.Size(255, 20);
            this.redTrackBar.TabIndex = 16;
            this.redTrackBar.TickFrequency = 15;
            this.redTrackBar.Scroll += new System.EventHandler(this.redTrackBar_Scroll);
            // 
            // livePreview
            // 
            this.livePreview.BackColor = System.Drawing.Color.Black;
            this.livePreview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.livePreview.Cursor = System.Windows.Forms.Cursors.Hand;
            this.livePreview.Location = new System.Drawing.Point(86, 76);
            this.livePreview.Name = "livePreview";
            this.livePreview.Size = new System.Drawing.Size(27, 97);
            this.livePreview.TabIndex = 20;
            this.livePreview.TabStop = false;
            this.livePreview.Click += new System.EventHandler(this.livePreview_Click);
            // 
            // GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.BackgroundImage = global::InterfaceGUI.Properties.Resources.INTERFACE_BG_MAIN;
            this.ClientSize = new System.Drawing.Size(400, 700);
            this.Controls.Add(this.livePreview);
            this.Controls.Add(this.redTrackBar);
            this.Controls.Add(this.greenTrackBar);
            this.Controls.Add(this.blueTrackBar);
            this.Controls.Add(this.whiteTrackBar);
            this.Controls.Add(this.comPortListLabel);
            this.Controls.Add(this.comPortList);
            this.Controls.Add(this.minimizeButton);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.logoImageText);
            this.Controls.Add(this.logoImage);
            this.Controls.Add(this.SetColor);
            this.Controls.Add(this.WhiteChannelLabel);
            this.Controls.Add(this.WhiteChannelValue);
            this.Controls.Add(this.BlueChannelLabel);
            this.Controls.Add(this.GreenChannelLable);
            this.Controls.Add(this.RedChannelLabel);
            this.Controls.Add(this.GreenChannelValue);
            this.Controls.Add(this.BlueChannelValue);
            this.Controls.Add(this.RedChannelValue);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(400, 700);
            this.MinimumSize = new System.Drawing.Size(400, 700);
            this.Name = "GUI";
            this.Text = "Interface GUI";
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.GUI_MouseClick);
            ((System.ComponentModel.ISupportInitialize)(this.logoImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoImageText)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimizeButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.whiteTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blueTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.redTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.livePreview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ColorDialog colorPicker;
        private System.Windows.Forms.TextBox RedChannelValue;
        private System.Windows.Forms.TextBox BlueChannelValue;
        private System.Windows.Forms.TextBox GreenChannelValue;
        private System.Windows.Forms.Label RedChannelLabel;
        private System.Windows.Forms.Label GreenChannelLable;
        private System.Windows.Forms.Label BlueChannelLabel;
        private System.Windows.Forms.Label WhiteChannelLabel;
        private System.Windows.Forms.TextBox WhiteChannelValue;
        private System.Windows.Forms.Button SetColor;
        private System.Windows.Forms.PictureBox logoImage;
        private System.Windows.Forms.PictureBox logoImageText;
        private System.Windows.Forms.PictureBox closeButton;
        private System.Windows.Forms.PictureBox minimizeButton;
        public System.Windows.Forms.ListBox comPortList;
        private System.Windows.Forms.Label comPortListLabel;
        private System.Windows.Forms.TrackBar whiteTrackBar;
        private System.Windows.Forms.TrackBar blueTrackBar;
        private System.Windows.Forms.TrackBar greenTrackBar;
        private System.Windows.Forms.TrackBar redTrackBar;
        private System.Windows.Forms.PictureBox livePreview;
    }
}

