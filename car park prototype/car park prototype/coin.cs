using System;
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
        private int id; // the id of the coin
        private string carplate; // the number plate of the car
        private paymenttype bill; // the type of payment the pay system will want
        private bool payed; // has the time being payed
        private TimeSpan spenttime; // the time spent in the car park from entering to inserting coin into pay machine
        private double costperhour; // if discounttime then use this instead of default
        private double fixedprice; // if fixedpay then use this
    }
}
