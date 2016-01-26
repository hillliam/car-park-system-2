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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            admin_controles a = new admin_controles();
            a.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            car_park_creator a = new car_park_creator();
            a.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            customer_controles a = new customer_controles();
            a.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            city_display a = new city_display();
            a.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            abooking a = new abooking();
            a.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {

        }
    }
}
