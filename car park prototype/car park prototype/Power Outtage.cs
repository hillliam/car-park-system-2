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
            if (Program.parks[0] == null)
            {
                MessageBox.Show("Please create a carpark first");
            }
            //Program.parks[exitreader].setexitstatue(false);
            MessageBox.Show("The selected exit has been closed");
        }
    }
}
