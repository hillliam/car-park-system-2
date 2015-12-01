﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace car_park_prototype
{
    enum paymenttype
    {
        fulltime,       // default
        fixedpay,       // company a
        discounttime,   // company b
        free            // in emergency all customers get free stay
    }
    class coin
    {
        public int id; // the id of the coin
        public string carplate; // the number plate of the car
        public paymenttype bill; // the type of payment the pay system will want
        public bool payed; // has the time being payed
        public DateTime entertime; // the time the car enterd the car park
        public TimeSpan spenttime; // the time spent in the car park from entering to inserting coin into pay machine
        public double costperhour; // if discounttime then use this instead of default
        public double fixedprice; // if fixedpay then use this

    }
}
