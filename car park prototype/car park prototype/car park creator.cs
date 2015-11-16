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
    public partial class car_park_creator : Form
    {
        public car_park_creator()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Program.parks.Add(new carpark(textBox1.Text, textBox2.Text, int.Parse(textBox3.Text), int.Parse(textBox7.Text), int.Parse(textBox4.Text)));
        }

        private void button3_Click(object sender, EventArgs e)
        {// load list of car parks
            populatecarparks()
        }
        private void populatecarparks()
        {
            foreach (carpark a in Program.parks)
            {
                listBox1.Items.Add(a.print());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
