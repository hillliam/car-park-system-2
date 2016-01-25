using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace car_park_prototype
{
    public partial class city_display : Form
    {
        public city_display()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Program.emergency)
            {
                textBox1.Text = "Emergency In Progress".ToString();
                textBox2.Text = "Please use other Carparks".ToString();
            }
            else
            {
                textBox1.Text = Program.parks[0].getallfreeparking().ToString();
                textBox2.Text = Program.parks[0].getallfreesparking().ToString();
            }
        }

        private void city_display_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            

        }
    }
}
