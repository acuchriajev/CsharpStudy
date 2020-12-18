using System.Drawing;
namespace WindowsFormsAppHelloWorld
{
    partial class HelloWorldApp
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
            this.LblText = new System.Windows.Forms.Label();
            this.TbxUsername = new System.Windows.Forms.TextBox();
            this.BtnEnter = new System.Windows.Forms.Button();
            this.BtnClose = new System.Windows.Forms.Button();
            this.PicWelcome = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PicWelcome)).BeginInit();
            this.SuspendLayout();
            // 
            // LblText
            // 
            this.LblText.AutoSize = true;
            this.LblText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LblText.Location = new System.Drawing.Point(47, 32);
            this.LblText.Name = "LblText";
            this.LblText.Size = new System.Drawing.Size(263, 25);
            this.LblText.TabIndex = 0;
            this.LblText.Text = "Welcome to Hello World App";
            this.LblText.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // TbxUsername
            // 
            this.TbxUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TbxUsername.Location = new System.Drawing.Point(73, 74);
            this.TbxUsername.Name = "TbxUsername";
            this.TbxUsername.Size = new System.Drawing.Size(199, 30);
            this.TbxUsername.TabIndex = 1;
            // 
            // BtnEnter
            // 
            this.BtnEnter.Location = new System.Drawing.Point(73, 273);
            this.BtnEnter.Name = "BtnEnter";
            this.BtnEnter.Size = new System.Drawing.Size(75, 23);
            this.BtnEnter.TabIndex = 3;
            this.BtnEnter.Text = "Enter";
            this.BtnEnter.UseVisualStyleBackColor = true;
            this.BtnEnter.Click += new System.EventHandler(this.BtnEnter_Click);
            // 
            // BtnClose
            // 
            this.BtnClose.Location = new System.Drawing.Point(197, 273);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(75, 23);
            this.BtnClose.TabIndex = 4;
            this.BtnClose.Text = "Close";
            this.BtnClose.UseVisualStyleBackColor = true;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // PicWelcome
            // 
            this.PicWelcome.Image = global::WindowsFormsAppHelloWorld.Properties.Resources._30_days;
            this.PicWelcome.Location = new System.Drawing.Point(88, 110);
            this.PicWelcome.Name = "PicWelcome";
            this.PicWelcome.Size = new System.Drawing.Size(172, 157);
            this.PicWelcome.TabIndex = 2;
            this.PicWelcome.TabStop = false;
            // 
            // HelloWorldApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(367, 337);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.BtnEnter);
            this.Controls.Add(this.PicWelcome);
            this.Controls.Add(this.TbxUsername);
            this.Controls.Add(this.LblText);
            this.Name = "HelloWorldApp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hello World App";
            ((System.ComponentModel.ISupportInitialize)(this.PicWelcome)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblText;
        private System.Windows.Forms.TextBox TbxUsername;
        private System.Windows.Forms.PictureBox PicWelcome;
        private System.Windows.Forms.Button BtnEnter;
        private System.Windows.Forms.Button BtnClose;
    }
}

