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
    public partial class Flood : Form
    {
        public Flood()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Flood barrier Activated in the ground floor");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("People are being warn about the flood!");
            Program.floodstate = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Program.floodstate = false;
            this.Close();
        }
    }
}
