using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace car_park_prototype
{
    static class Program
    {
        public static List<coin> coins = new List<coin>();
        public static List<carpark> parks = new List<carpark>();
        public static bool noexit = false;
        public static bool loadenterimage = false; // displays the image of the car at the entrance
        public static bool loadexitimage = false; // displays the image of the car at the exit 
        public static int cutomerindex = 1; // 1 = good customer 2 = bad customer
        public static bool emergency = false;
        public static bool exitopener = false;  //for manual exit opener in case of a power outtage
        public static bool floodstate = false;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
