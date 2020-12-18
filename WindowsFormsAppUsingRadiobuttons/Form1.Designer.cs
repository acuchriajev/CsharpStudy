namespace WindowsFormsAppUsingRadiobuttons
{
    partial class RadioButtonsInGroup
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
            this.GbxMoods = new System.Windows.Forms.GroupBox();
            this.GbxWeather = new System.Windows.Forms.GroupBox();
            this.RbtnSad = new System.Windows.Forms.RadioButton();
            this.RbtnHappy = new System.Windows.Forms.RadioButton();
            this.RbtnSun = new System.Windows.Forms.RadioButton();
            this.RbtnRain = new System.Windows.Forms.RadioButton();
            this.PbxSad = new System.Windows.Forms.PictureBox();
            this.PbxHappy = new System.Windows.Forms.PictureBox();
            this.PbxSun = new System.Windows.Forms.PictureBox();
            this.PbxRain = new System.Windows.Forms.PictureBox();
            this.GbxMoods.SuspendLayout();
            this.GbxWeather.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbxSad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxHappy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxSun)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxRain)).BeginInit();
            this.SuspendLayout();
            // 
            // GbxMoods
            // 
            this.GbxMoods.Controls.Add(this.RbtnHappy);
            this.GbxMoods.Controls.Add(this.RbtnSad);
            this.GbxMoods.Location = new System.Drawing.Point(43, 26);
            this.GbxMoods.Name = "GbxMoods";
            this.GbxMoods.Size = new System.Drawing.Size(200, 100);
            this.GbxMoods.TabIndex = 0;
            this.GbxMoods.TabStop = false;
            this.GbxMoods.Text = "Moods";
            // 
            // GbxWeather
            // 
            this.GbxWeather.Controls.Add(this.RbtnRain);
            this.GbxWeather.Controls.Add(this.RbtnSun);
            this.GbxWeather.Location = new System.Drawing.Point(43, 150);
            this.GbxWeather.Name = "GbxWeather";
            this.GbxWeather.Size = new System.Drawing.Size(200, 100);
            this.GbxWeather.TabIndex = 1;
            this.GbxWeather.TabStop = false;
            this.GbxWeather.Text = "Weather";
            // 
            // RbtnSad
            // 
            this.RbtnSad.AutoSize = true;
            this.RbtnSad.Location = new System.Drawing.Point(18, 32);
            this.RbtnSad.Name = "RbtnSad";
            this.RbtnSad.Size = new System.Drawing.Size(44, 17);
            this.RbtnSad.TabIndex = 0;
            this.RbtnSad.TabStop = true;
            this.RbtnSad.Text = "Sad";
            this.RbtnSad.UseVisualStyleBackColor = true;
            this.RbtnSad.CheckedChanged += new System.EventHandler(this.RbtnSad_CheckedChanged);
            // 
            // RbtnHappy
            // 
            this.RbtnHappy.AutoSize = true;
            this.RbtnHappy.Location = new System.Drawing.Point(18, 56);
            this.RbtnHappy.Name = "RbtnHappy";
            this.RbtnHappy.Size = new System.Drawing.Size(56, 17);
            this.RbtnHappy.TabIndex = 1;
            this.RbtnHappy.TabStop = true;
            this.RbtnHappy.Text = "Happy";
            this.RbtnHappy.UseVisualStyleBackColor = true;
            this.RbtnHappy.CheckedChanged += new System.EventHandler(this.RbtnHappy_CheckedChanged);
            // 
            // RbtnSun
            // 
            this.RbtnSun.AutoSize = true;
            this.RbtnSun.Location = new System.Drawing.Point(18, 34);
            this.RbtnSun.Name = "RbtnSun";
            this.RbtnSun.Size = new System.Drawing.Size(44, 17);
            this.RbtnSun.TabIndex = 0;
            this.RbtnSun.TabStop = true;
            this.RbtnSun.Text = "Sun";
            this.RbtnSun.UseVisualStyleBackColor = true;
            this.RbtnSun.CheckedChanged += new System.EventHandler(this.RbtnSun_CheckedChanged);
            // 
            // RbtnRain
            // 
            this.RbtnRain.AutoSize = true;
            this.RbtnRain.Location = new System.Drawing.Point(18, 58);
            this.RbtnRain.Name = "RbtnRain";
            this.RbtnRain.Size = new System.Drawing.Size(47, 17);
            this.RbtnRain.TabIndex = 1;
            this.RbtnRain.TabStop = true;
            this.RbtnRain.Text = "Rain";
            this.RbtnRain.UseVisualStyleBackColor = true;
            this.RbtnRain.CheckedChanged += new System.EventHandler(this.RbtnRain_CheckedChanged);
            // 
            // PbxSad
            // 
            this.PbxSad.Image = global::WindowsFormsAppUsingRadiobuttons.Properties.Resources.sad;
            this.PbxSad.Location = new System.Drawing.Point(305, 34);
            this.PbxSad.Name = "PbxSad";
            this.PbxSad.Size = new System.Drawing.Size(42, 41);
            this.PbxSad.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbxSad.TabIndex = 2;
            this.PbxSad.TabStop = false;
            this.PbxSad.Visible = false;
            // 
            // PbxHappy
            // 
            this.PbxHappy.Image = global::WindowsFormsAppUsingRadiobuttons.Properties.Resources.happy;
            this.PbxHappy.Location = new System.Drawing.Point(305, 82);
            this.PbxHappy.Name = "PbxHappy";
            this.PbxHappy.Size = new System.Drawing.Size(42, 44);
            this.PbxHappy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbxHappy.TabIndex = 3;
            this.PbxHappy.TabStop = false;
            this.PbxHappy.Visible = false;
            // 
            // PbxSun
            // 
            this.PbxSun.Image = global::WindowsFormsAppUsingRadiobuttons.Properties.Resources.sun;
            this.PbxSun.Location = new System.Drawing.Point(305, 159);
            this.PbxSun.Name = "PbxSun";
            this.PbxSun.Size = new System.Drawing.Size(42, 42);
            this.PbxSun.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbxSun.TabIndex = 4;
            this.PbxSun.TabStop = false;
            this.PbxSun.Visible = false;
            // 
            // PbxRain
            // 
            this.PbxRain.Image = global::WindowsFormsAppUsingRadiobuttons.Properties.Resources.rain;
            this.PbxRain.Location = new System.Drawing.Point(305, 208);
            this.PbxRain.Name = "PbxRain";
            this.PbxRain.Size = new System.Drawing.Size(42, 42);
            this.PbxRain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbxRain.TabIndex = 5;
            this.PbxRain.TabStop = false;
            this.PbxRain.Visible = false;
            // 
            // RadioButtonsInGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(411, 283);
            this.Controls.Add(this.PbxRain);
            this.Controls.Add(this.PbxSun);
            this.Controls.Add(this.PbxHappy);
            this.Controls.Add(this.PbxSad);
            this.Controls.Add(this.GbxWeather);
            this.Controls.Add(this.GbxMoods);
            this.Name = "RadioButtonsInGroup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Radio buttons in Group";
            this.GbxMoods.ResumeLayout(false);
            this.GbxMoods.PerformLayout();
            this.GbxWeather.ResumeLayout(false);
            this.GbxWeather.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbxSad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxHappy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxSun)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxRain)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GbxMoods;
        private System.Windows.Forms.RadioButton RbtnHappy;
        private System.Windows.Forms.RadioButton RbtnSad;
        private System.Windows.Forms.GroupBox GbxWeather;
        private System.Windows.Forms.RadioButton RbtnRain;
        private System.Windows.Forms.RadioButton RbtnSun;
        private System.Windows.Forms.PictureBox PbxSad;
        private System.Windows.Forms.PictureBox PbxHappy;
        private System.Windows.Forms.PictureBox PbxSun;
        private System.Windows.Forms.PictureBox PbxRain;
    }
}

