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
    public partial class pay_system : Form
    {
        public pay_system()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Program.emergency)
            {
                textBox1.Text = "no payment applowed";
            }
        }
    }
}
