namespace WindowsFormsAppMultipleWindows
{
    partial class FrmIntro
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
            this.BtnWelcome = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnWelcome
            // 
            this.BtnWelcome.Location = new System.Drawing.Point(117, 95);
            this.BtnWelcome.Name = "BtnWelcome";
            this.BtnWelcome.Size = new System.Drawing.Size(75, 23);
            this.BtnWelcome.TabIndex = 0;
            this.BtnWelcome.Text = "Welcome";
            this.BtnWelcome.UseVisualStyleBackColor = true;
            this.BtnWelcome.Click += new System.EventHandler(this.BtnWelcome_Click);
            // 
            // FrmIntro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(316, 193);
            this.Controls.Add(this.BtnWelcome);
            this.Name = "FrmIntro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Multiple windows";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnWelcome;
    }
}

