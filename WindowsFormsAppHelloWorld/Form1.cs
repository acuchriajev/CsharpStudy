using System;
using System.Windows.Forms;

namespace WindowsFormsAppHelloWorld
{
    public partial class HelloWorldApp : Form
    {
        public HelloWorldApp()
        {
            InitializeComponent();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnEnter_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello world!!!", "Hello world");
        }
    }
}
