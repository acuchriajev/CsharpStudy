using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppMultipleWindows
{
    public partial class FrmIntro : Form
    {
        public FrmIntro()
        {
            InitializeComponent();
        }

        private void BtnWelcome_Click(object sender, EventArgs e)
        {
            FrmNextWindow x = new FrmNextWindow();
            x.Show();
        }
    }
}
