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
    public partial class emergency_selector : Form
    {// add more 
        public emergency_selector()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {//fire
            Program.emergency = true;
            if (Program.coins[0] != null)
            {
                Program.coins[0].calculatecost();
                Program.coins[0].bill = paymenttype.fixedpay;
            }
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {//power out
            Program.emergency = true;
            if (Program.coins[0] != null)
            {
            Program.coins[0].calculatecost();
            Program.coins[0].bill = paymenttype.fixedpay;
            }
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {// repaires
            Program.emergency = true;
            if (Program.coins[0] != null)
            {
            Program.coins[0].calculatecost();
            Program.coins[0].bill = paymenttype.fixedpay;
            }
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {// flood
            Program.emergency = true;
            if (Program.coins[0] != null)
            {
                Program.coins[0].calculatecost();
                Program.coins[0].bill = paymenttype.fixedpay;
            }
            this.Close();
        }
    }
}
