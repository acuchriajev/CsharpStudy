namespace WindowsFormsAppScrollBars
{
    partial class FrmScrollBars
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
            this.Hsb = new System.Windows.Forms.HScrollBar();
            this.Vsb = new System.Windows.Forms.VScrollBar();
            this.LblHorizontalNumber = new System.Windows.Forms.Label();
            this.LblVerticalNumber = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Hsb
            // 
            this.Hsb.LargeChange = 1;
            this.Hsb.Location = new System.Drawing.Point(33, 20);
            this.Hsb.Maximum = 50;
            this.Hsb.Name = "Hsb";
            this.Hsb.Size = new System.Drawing.Size(146, 22);
            this.Hsb.TabIndex = 0;
            this.Hsb.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBar1_Scroll);
            // 
            // Vsb
            // 
            this.Vsb.LargeChange = 1;
            this.Vsb.Location = new System.Drawing.Point(350, 56);
            this.Vsb.Name = "Vsb";
            this.Vsb.Size = new System.Drawing.Size(19, 245);
            this.Vsb.TabIndex = 1;
            this.Vsb.Scroll += new System.Windows.Forms.ScrollEventHandler(this.Vsb_Scroll);
            // 
            // LblHorizontalNumber
            // 
            this.LblHorizontalNumber.AutoSize = true;
            this.LblHorizontalNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LblHorizontalNumber.Location = new System.Drawing.Point(75, 70);
            this.LblHorizontalNumber.Name = "LblHorizontalNumber";
            this.LblHorizontalNumber.Size = new System.Drawing.Size(51, 55);
            this.LblHorizontalNumber.TabIndex = 2;
            this.LblHorizontalNumber.Text = "0";
            // 
            // LblVerticalNumber
            // 
            this.LblVerticalNumber.AutoSize = true;
            this.LblVerticalNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LblVerticalNumber.Location = new System.Drawing.Point(244, 149);
            this.LblVerticalNumber.Name = "LblVerticalNumber";
            this.LblVerticalNumber.Size = new System.Drawing.Size(51, 55);
            this.LblVerticalNumber.TabIndex = 3;
            this.LblVerticalNumber.Text = "0";
            // 
            // FrmScrollBars
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 310);
            this.Controls.Add(this.LblVerticalNumber);
            this.Controls.Add(this.LblHorizontalNumber);
            this.Controls.Add(this.Vsb);
            this.Controls.Add(this.Hsb);
            this.Name = "FrmScrollBars";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Scroll Bars";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.HScrollBar Hsb;
        private System.Windows.Forms.VScrollBar Vsb;
        private System.Windows.Forms.Label LblHorizontalNumber;
        private System.Windows.Forms.Label LblVerticalNumber;
    }
}

