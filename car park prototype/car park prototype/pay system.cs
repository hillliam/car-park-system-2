using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

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
                textBox1.Text = "no payment allowed";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {// coin
            int id = int.Parse(textBox2.Text);
            bool found = false;
            coin foundcoin= null;
            foreach (coin a in Program.coins)
            {
                if (a.id == id)
                {
                    foundcoin = a;
                    found = true;
                }
            }
            if (found)
            {
                switch (foundcoin.bill)
                {
                    case paymenttype.fulltime:
                        textBox1.Text = foundcoin.;
                        break;
                    case paymenttype.fixedpay:
                        textBox1.Text = foundcoin.fixedprice.ToString();
                        break;
                    case paymenttype.free:
                        textBox1.Text = "free stay";
                        foundcoin.payed = true;
                        break;
                    case paymenttype.discounttime:
                        textBox1.Text = foundcoin.;
                        break;
                        
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {//pay
            textBox1.Text = "payed for";
        }

        private void button3_Click(object sender, EventArgs e)
        {//return coin
            textBox1.Text = "insert coin";
            textBox2.Text = "";
        }
    }
}
