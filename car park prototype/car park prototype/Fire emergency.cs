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
    public partial class Fire_emergency : Form
    {
        System.Media.SoundPlayer playr = new System.Media.SoundPlayer(@"C:\Users\Teto Sama\Downloads\Music\alarm_beep.wav");
        public Fire_emergency()
        {
            InitializeComponent();
            textBox1.Text = counter.ToString();
        }
        int counter = 0; 
      
        private void increment_Click(object sender, EventArgs e)
        {
            if (counter == 12)
            {
                Program.emergency = true;
                MessageBox.Show("Alarm has Sounded");
                playr.PlayLooping();
            }

            textBox1.Text = counter.ToString();
            counter++;
        }

        private void Decrement_Click(object sender, EventArgs e)
        {
            if (counter < 0)
                counter = 0;
            textBox1.Text = counter.ToString();
            counter--;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Sprinkler_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer playr2 = new System.Media.SoundPlayer(@"C:\Users\Teto Sama\Downloads\Music\rain-01.wav");
            playr2.Play();
            playr.LoadTimeout=10000;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Program.emergency = false;
        }

        


    }
}
