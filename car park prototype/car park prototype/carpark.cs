using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace car_park_prototype
{
    class carpark
    {
        private string name
        {
            get { return name; }
            set { name = value; }
        }
        private int exitnum
        {
            get { return exitnum; }
            set { exitnum = value; }
        }
        private int paymachinenum
        {
            get {return paymachinenum;}
            set { paymachinenum = value; }
        }
        private List<bool> exits
        {
            get { return exits; }
            set { exits = value; }
        }
        public carpark(string name, int exit, int pay)
        {
            this.name = name;
            this.exitnum = exit;
            this.paymachinenum = pay;
            exits = new List<bool>();
        }
    }
}
