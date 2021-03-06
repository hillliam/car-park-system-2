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
    public partial class admin_controles : Form
    {
        private bool displayerror = true;
        public admin_controles()
        {
            InitializeComponent();
            populatecarparks();
        }
        private void populatecarparks()
        {
            comboBox1.Items.Add(Program.parks[0].print());
        }

        private void timer1_Tick(object sender, EventArgs e)
        {// update enter and exit status
            listBox1.Items.Clear();
            for (int i = 0; i != Program.parks[0].exitnum; i++)
                listBox1.Items.Add("exit " + i.ToString() + " status is " + Program.parks[0].getexitstatus(i).ToString());
            if (Program.loadenterimage)
            {
                if (Program.cutomerindex == 1)
                    pictureBox1.ImageLocation = "1.jpg";
                else if (Program.cutomerindex == 2)
                    pictureBox1.ImageLocation = "2.jpg";
            }
            else
            {
                pictureBox1.Image = null;
            }
            if (Program.loadexitimage)
            {
                if (Program.cutomerindex == 1 && Program.coins[0].code == "recognition")
                    pictureBox2.ImageLocation = "1.jpg";
                else if (Program.cutomerindex == 2 && Program.coins[0].code == "recognition")
                    pictureBox2.ImageLocation = "3.jpg";
                if (Program.cutomerindex == 2 && displayerror)
                {
                    MessageBox.Show("a different driver is attempting to exit the carpark with a customers car");
                }
            }
            else
            {
                pictureBox2.Image = null;
            }
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
            try
            {
                if (Program.coins[0] != null)
                {
                    MessageBox.Show("coin created for numberplate: nv56 qyc");
                }
                else
                {
                    MessageBox.Show("no coin found for car");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("no car in car park");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {// return to normal
            Program.emergency = false;
            Program.noexit = false;
        }
    }
}
