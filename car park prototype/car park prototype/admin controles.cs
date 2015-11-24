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
        {// stop exit
            Program.noexit = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {// start emergency
            Program.emergency = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {// find coin with number plate

        }
    }
}
