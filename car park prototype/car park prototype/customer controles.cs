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
    public partial class customer_controles : Form
    {
        public customer_controles()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Program.loadenterimage = false;
            secure_parking a = new secure_parking();
            a.Show();
        }

        private void customer_controles_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Program.loadenterimage = false;
            parking a = new parking();
            a.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            pay_system a = new pay_system();
            a.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Program.coins.Add(new coin());
            Program.loadenterimage = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Program.loadexitimage = true;
        }
    }
}
