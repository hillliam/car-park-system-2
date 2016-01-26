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
    public partial class floor_display : Form
    {
        public floor_display()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i != Program.parks[0].floors; i++)
            {
                listBox1.Items.Add("floor "+ i.ToString() + " has " + Program.parks[0].getfreeparking(i).ToString() + " spaces available");
            }
            for (int i = 0; i != Program.parks[0].floors; i++)
            {
                listBox1.Items.Add("floor " + i.ToString() + " has " + Program.parks[0].getfreesparking(i).ToString() + " secure spaces available");
            }
        }

    }
}
