using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace car_park_prototype
{
    class carpark
    {
        private string name // the name of the carpark 
        {
            get { return name; }
            set { name = value; }
        }
        private string city // the city it is in
        {
            get { return city; }
            set { city = value; }
        }
        private bool openenter // status of the entrance true = open false = closed
        {
            get { return openenter; }
            set { openenter = value; }
        }
        private int exitnum // number of exits
        {
            get { return exitnum; }
            set { exitnum = value; }
        }
        private int paymachinenum // the number of pay machine
        {
            get {return paymachinenum;}
            set { paymachinenum = value; }
        }
        private List<bool> exits // status of exits true = open false = closed
        {
            get { return exits; }
            set { exits = value; }
        }
        private List<int> parking // parking by floor level
        {
            get { return parking; }
            set { parking = value; }
        }
        private List<int> sparking // secure parking by floor level
        {
            get { return sparking; }
            set { sparking = value; }
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
