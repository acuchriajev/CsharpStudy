using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsLsn3
{
    public partial class Lesson3 : Form
    {
        public Lesson3()
        {
            InitializeComponent();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Lesson3.\n\n " +
               "Created by C# developer Aleksandr Cuchriajev.\n\n " +
               "Contact email: info.acoptex@gmail.com.\n\n" +
               "Ver.1.0\n\n" +
               "2020 Acoptex.lt All rights reserved.", "About", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void btnCalculateAverage_Click(object sender, EventArgs e)
        {
            try
            {
                double num1 = Convert.ToDouble(tbxFirst.Text);
                double num2 = Convert.ToDouble(tbxSecond.Text);
                Result.Text = Convert.ToString((num1 + num2) / 2);
            }
            catch
            {
                MessageBox.Show("Use numbers only", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Reset();
            }
        }

        private void Reset()
        {
            tbxFirst.Text = "";
            tbxSecond.Text = "";
            Result.Text = "Your result will be here";
            
        }
    }
}
