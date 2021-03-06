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
    public partial class abooking : Form
    {
        private int selectedf = -1;
        private int selectedspot = -1;
        public abooking()
        {
            InitializeComponent();
            populatefloor();
        }

        private void abooking_Load(object sender, EventArgs e)
        {

        }
        private void populatefloor()
        {
            listBox1.Items.Clear();
            for (int i = 0; i != Program.parks[0].floors; i++)
            {
                listBox1.Items.Add("floor " + i.ToString());
            }
        }
        private void populatespot()
        {
            if (selectedf != -1)
            {
                listBox2.Items.Clear();
                for (int i = 0; i != Program.parks[0].getfreeparking(selectedf); i++)
                {
                    listBox2.Items.Add("spot " + i.ToString());
                }
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedf = listBox1.SelectedIndex;
            populatespot();
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedspot = listBox2.SelectedIndex;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Program.parks[0].ocupyspot(selectedf);
            Random a = new Random();
            MessageBox.Show("your reservation number is " + a.Next(10000));
        }
    }
}
