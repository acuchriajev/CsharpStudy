using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppMenu
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void redToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Red;
        }

        private void blueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Blue;
        }

        private void greenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Green;
        }

        private void bigToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Width = 1000;
            this.Height = 520;
        }

        private void smallToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Width = 350;
            this.Height = 125;
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Width = 520;
            this.Height = 350;

        }
    }
}
