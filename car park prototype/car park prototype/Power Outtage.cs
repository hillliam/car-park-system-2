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
    public partial class Power_Outtage : Form
    {
        public Power_Outtage()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int exitreader = int.Parse(textBox1.Text);
            try
            {
                Program.parks[0].setexitstatus(exitreader,true);
           // Program.parks[0].setexitstatue(true);
            MessageBox.Show("The selected exit has been opened");
            }
            catch (ArgumentOutOfRangeException )
            {
                MessageBox.Show("Please create a carpark first");
                this.Close();
            }
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int exitreader = int.Parse(textBox1.Text);
            try
            {
                Program.parks[0].setexitstatus(exitreader, false);
                // Program.parks[0].setexitstatue(true);
                MessageBox.Show("The selected exit has been closed");
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Please create a carpark first");
                this.Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Program.emergency = false;
            this.Close();
        }

        private void Cam1_Click(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation = "cam1.jpg";
        }

        private void Cam2_Click(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation = "cam2.jpg";
        }

        private void Cam3_Click(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation = "cam3.jpg";
        }

        private void Cam4_Click(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation = "cam4.jpg";
        }
    }
}
