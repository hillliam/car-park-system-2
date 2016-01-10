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
    public partial class admin_controles : Form
    {
        public admin_controles()
        {
            InitializeComponent();
            populatecarparks();
        }
        private void populatecarparks()
        { 

        }

        private void timer1_Tick(object sender, EventArgs e)
        {// update enter and exit status

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {// load that car park

        }

        private void button2_Click(object sender, EventArgs e)
        {// allow exit and enterance
            Program.noexit = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {// start emergency
            //Program.emergency = true;
            //Program.noexit = true;
            emergency_selector emergency = new emergency_selector();
            emergency.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {// find coin with number plate
            if (Program.coins[0] != null)
            {
                MessageBox.Show("coin created for numberplate: nv56 qyc");
            }
            else
            {
                MessageBox.Show("no coin found for car");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {// return to normal
            Program.emergency = false;
            Program.noexit = false;
        }
    }
}
