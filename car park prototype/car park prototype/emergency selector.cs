﻿using System;
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
            //program.emergency = true;
            //if (program.coins[0] != null)
            //{
            //    program.coins[0].calculatecost();
            //    program.coins[0].bill = paymenttype.fixedpay;
            //}
            //this.close();
            Fire_emergency fire = new Fire_emergency();
            fire.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {//power out
            Program.emergency = true;
            Power_Outtage power = new Power_Outtage();
            power.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {// repaires
            Program.emergency = true;
            //if (Program.coins[0] != null)
            //{
            //Program.coins[0].calculatecost();
            //Program.coins[0].bill = paymenttype.fixedpay;
            //}
            Injuries injury = new Injuries();
            injury.Show();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {// flood
            //Program.emergency = true;
            //if (Program.coins[0] != null)
            //{
            //    Program.coins[0].calculatecost();
            //    Program.coins[0].bill = paymenttype.fixedpay;
            //}
            Flood flood = new Flood();
            flood.Show();
            this.Close();
        }
    }
}
