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
    public partial class Injuries : Form
    {
        public Injuries()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("emegency vehicle are on it's way!");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < Program.parks[0].exitnum; i++)
                {
                    Program.parks[0].setexitstatus(i, false);
                }
                MessageBox.Show("All Exit Have been closed successfully");
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("create a car park first");
                this.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Program.emergency = false;
            this.Close();
        }
    }
}
