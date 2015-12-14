using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace car_park_prototype
{
    class carpark
    {
        private string name; // the name of the car park 
        private string city; // the city it is in
        private bool openenter; // status of the entrance true = open false = closed
        public int exitnum; // number of exits
        public int paymachinenum; // the number of pay machine
        public int floors; // the number of floors in the car park 
        private List<bool> exits; // status of exits true = open false = closed

        private List<int> parking; // parking by floor level
        private List<int> usedparking; // parking by floor level add 1 on floor when parking
        private List<int> sparking; // secure parking by floor level
        private List<int> usedsparking; // secure parking by floor level add 1 on floor when parking
        public carpark(string name, string city, int exit, int pay, int floors)
        {
            this.name = name;
            this.city = city;
            this.exitnum = exit;
            this.paymachinenum = pay;
            this.floors = floors;
            exits = new List<bool>();
            parking = new List<int>();
            usedparking = new List<int>();
            sparking = new List<int>();
            usedsparking = new List<int>();
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
            usedparking.Add(0);

        }
        public void setsparkingbyfloor(int floor, int number)
        { // relies on floor - 1 being added
            sparking.Add(number);
            usedsparking.Add(0);
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
        public void ocupyspot(int floor)
        {
            usedparking[floor]++;
        }
        public void freespot(int floor)
        {
            usedparking[floor]++;
        }
        public void ocupysspot(int floor)
        {
            usedsparking[floor]++;
        }
        public void freesspot(int floor)
        {
            usedsparking[floor]++;
        }
    }
}
