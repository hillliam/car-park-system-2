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
    public partial class secure_parking: Form
    {
        private int click = 0;
        private int selectedf = -1;
        private int selectedspot = -1;
        public secure_parking()
        {
            InitializeComponent();
            populatefloor();
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

        private void button3_Click(object sender, EventArgs e)
        {// lock
            if (Program.coins[0].code == "")
                Program.coins[0].code = textBox1.Text;
            else
                MessageBox.Show("spot is locked");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (Program.coins[0].code == "")
                MessageBox.Show("already unlocked");
            else
                if (textBox1.Text == Program.coins[0].code)
                    Program.coins[0].code = "";
                else
                    MessageBox.Show("invalid code");
        }

        private void button1_Click(object sender, EventArgs e)
        {//park
            if (Program.coins[0].code == "")
            {
                MessageBox.Show("please set code to park the car");
            }
            else
            {
                Program.parks[0].ocupysspot(selectedf);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {//leave
            if (Program.coins[0].code != "")
            {
                if (click == 0)
                {
                    MessageBox.Show("please unlock parking spot before leaving");
                    click++;
                }
                else
                {
                    MessageBox.Show("alarm activated");
                }
            }
            else
            {
                Program.parks[0].freesspot(selectedf);
            }
        }
    }
}
