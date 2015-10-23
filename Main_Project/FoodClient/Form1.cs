using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FoodClient.ServiceReference1;
namespace FoodClient
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            var p = new FoodClient.ServiceReference1.Service1Client();
            p.GetAllFood();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
