using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppUsingRadiobuttons
{
    public partial class RadioButtonsInGroup : Form
    {
        public RadioButtonsInGroup()
        {
            InitializeComponent();
        }

        private void RbtnSad_CheckedChanged(object sender, EventArgs e)
        {
            PbxSad.Visible = true;
            PbxHappy.Visible = false;
        }

        private void RbtnHappy_CheckedChanged(object sender, EventArgs e)
        {
            PbxSad.Visible = false;
            PbxHappy.Visible = true;
        }

        private void RbtnSun_CheckedChanged(object sender, EventArgs e)
        {
            PbxSun.Visible = true;
            PbxRain.Visible = false;
        }

        private void RbtnRain_CheckedChanged(object sender, EventArgs e)
        {
            PbxSun.Visible = false;
            PbxRain.Visible = true;
        }
    }
}
