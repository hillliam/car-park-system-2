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
            textBox1.Text = "insert coin";
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
            timer3.Stop();
            timer3.Start();
            timer2.Stop();
            timer2.Start();
                switch (Program.coins[0].bill)
                {
                    case paymenttype.fulltime:
                        textBox1.Text = (Program.coins[0].spenttime.TotalMinutes * 2.50).ToString(); // Made some changes here
                        break;
                    case paymenttype.fixedpay:
                        textBox1.Text = Program.coins[0].fixedprice.ToString();
                        break;
                    case paymenttype.free:
                        textBox1.Text = "free stay";
                        Program.coins[0].payed = true;
                        break;
                    case paymenttype.discounttime:
                        textBox1.Text = (Program.coins[0].spenttime.TotalMinutes * Program.coins[0].costperhour).ToString(); //Made some changes here
                        break;
                        
                }
        }

        private void button2_Click(object sender, EventArgs e)
        {//pay
            timer3.Stop();
            timer3.Start();
            timer2.Stop();
            timer2.Start();
            textBox1.Text = "payed for";
            Program.coins[0].payed = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {//return coin
            timer3.Stop();
            timer3.Start();
            timer2.Stop();
            timer2.Start();
            textBox1.Text = "insert coin";

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            MessageBox.Show("please interact or the form will close");
        }
    }
}
