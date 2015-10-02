using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace MobileAppProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textBox1.Text = "look here";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Thread(ShowInfo).Start();
        }
        void ShowInfo()
        {

            Action a = () => textBox1.Text =   Program.getDrId(); ;
            BeginInvoke(a);
        }
    }
}
