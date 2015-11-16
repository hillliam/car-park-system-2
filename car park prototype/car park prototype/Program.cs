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
        public static bool emergency = false;
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
