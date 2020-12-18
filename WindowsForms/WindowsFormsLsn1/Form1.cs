using System;
using System.Windows.Forms;

namespace WindowsFormsLsn1
{
    public partial class Lesson1 : Form
    {
        public Lesson1()
        {
            InitializeComponent();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Lesson1.\n\n " +
                "Created by C# developer Aleksandr Cuchriajev.\n\n " +
                "Contact email: info.acoptex@gmail.com.\n\n" +
                "Ver.1.0\n\n" +
                "2020 Acoptex.lt All rights reserved.", "About", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            if(cbExercise.Checked&& cbDiet.Checked)
            {
                lblResult.Text = "Your discount is 10%.";
            }
            else if (cbExercise.Checked)
            {
                lblResult.Text = "Your discount is 5%.";
            }
            else
            {
                lblResult.Text = "Your discount is 2%.";
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            lblResult.Text = "Result will be here";
            cbExercise.Checked = false;
            cbDiet.Checked = false;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
