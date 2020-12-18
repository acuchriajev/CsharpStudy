using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppScrollBars
{
    public partial class FrmScrollBars : Form
    {
        public FrmScrollBars()
        {
            InitializeComponent();
        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            LblHorizontalNumber.Text = Hsb.Value.ToString();
        }

        private void Vsb_Scroll(object sender, ScrollEventArgs e)
        {
            LblVerticalNumber.Text = Vsb.Value.ToString();
        }
    }
}
