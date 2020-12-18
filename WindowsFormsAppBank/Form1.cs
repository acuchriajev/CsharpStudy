using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppBank
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        int age;
        string yourName;
        double pay;

        private void BtnGo_Click(object sender, EventArgs e)
        {
           

            age = 15;
            yourName = "Alex";
            pay = 25.23D;

            MessageBox.Show("Your age is " + age.ToString());
            MessageBox.Show("Your name is " + yourName);
            MessageBox.Show("Your pay is " + pay.ToString());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Your age is " + age.ToString());
        }
    }
}
