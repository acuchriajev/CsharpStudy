using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsLsn2
{
    public partial class Lesson2 : Form
    {
        DateTime dateSet = DateTime.Parse("12.10.2020");
        public Lesson2()
        {
            InitializeComponent();

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Lesson2.\n\n " +
                "Created by C# developer Aleksandr Cuchriajev.\n\n " +
                "Contact email: info.acoptex@gmail.com.\n\n" +
                "Ver.1.0\n\n" +
                "2020 Acoptex.lt All rights reserved.", "About", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            if (dateTimePicker1.Value.Date < dateSet || dateTimePicker1.Value.Date > dateSet)
            {
                lblResult.Text = "No discount for you";
            }
            else
            {
                lblResult.Text = "Discount 15%";
            }
        }
    }
}
