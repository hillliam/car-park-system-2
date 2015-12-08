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
    public partial class discount : Form
    {
        public discount()
        {
            InitializeComponent();
            textBox1.Text = "insert coin";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("coin returned");
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {// set coin to fixed price
            Program.coins[0].bill = paymenttype.fixedpay;
            Program.coins[0].fixedprice = 3.20;
        }

        private void button3_Click(object sender, EventArgs e)
        {// set coin to reduced rate
            Program.coins[0].bill = paymenttype.discounttime;
            Program.coins[0].costperhour = 0.50;
        }

        private void button4_Click(object sender, EventArgs e)
        {// set coin to free
            Program.coins[0].bill = paymenttype.free;
        }

        private void button1_Click(object sender, EventArgs e)
        {// get coin
           textBox1.Text ="coin for car nv56 qyc";

        }
    }
}
