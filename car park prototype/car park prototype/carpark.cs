using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace car_park_prototype
{
    class carpark
    {
        private string name // the name of the car park 
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
        private int floors // the number of floors in the car park 
        {
            get { return floors; }
            set { floors = value; }
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
        private List<int> usedparking // parking by floor level add 1 on floor when parking
        {
            get { return usedparking; }
            set { usedparking = value; }
        }
        private List<int> sparking // secure parking by floor level
        {
            get { return sparking; }
            set { sparking = value; }
        }
        private List<int> usedsparking // secure parking by floor level add 1 on floor when parking
        {
            get { return usedsparking; }
            set { usedsparking = value; }
        }
        public carpark(string name, string city, int exit, int pay, int floors)
        {
            this.name = name;
            this.city = city;
            this.exitnum = exit;
            this.paymachinenum = pay;
            this.floors = floors;
            exits = new List<bool>();
        }
        public string print()
        {
            return name + ", " + city;
        }
        public int getnumbeofparking(int floor)
        {
            return parking[floor];
        }
        public void setparkingbyfloor(int floor, int number)
        { // relies on floor - 1 being added
            parking.Add(number);
        }
        public void setsparkingbyfloor(int floor, int number)
        { // relies on floor - 1 being added
            sparking.Add(number);
        }
        public int getnumbeofsparking(int floor)
        {
            return sparking[floor];
        }
        public int getfreesparking(int floor)
        {
            return sparking[floor] - usedsparking[floor];
        }
        public int getfreeparking(int floor)
        {
            return parking[floor] - usedparking[floor];
        }
        public int getallfreeparking()
        {
            int spaces = 0;
            for (int i = 0; i != floors; i++)
            {
                spaces += getfreeparking(i);
            }
            return spaces;
        }
        public int getallfreesparking()
        {
            int spaces = 0;
            for (int i = 0; i != floors; i++)
            {
                spaces += getfreesparking(i);
            }
            return spaces;
        }
    }
}
