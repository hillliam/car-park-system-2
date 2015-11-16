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
        private int id // the id of the coin
        {
            get { return id; }
            set { id = value; }
        }
        private string carplate // the number plate of the car
        {
            get { return carplate; }
            set { carplate = value; }
        }
        private paymenttype bill // the type of payment the pay system will want
        {
            get { return bill; }
            set { bill = value; }
        }
        private bool payed // has the time being payed
        {
            get { return payed; }
            set { payed = value; }
        }
        private TimeSpan spenttime // the time spent in the car park from entering to inserting coin into pay machine
        {
            get { return spenttime; }
            set { spenttime = value; }
        }
        private double costperhour // if discounttime then use this instead of default
        {
            get { return costperhour; }
            set { costperhour = value; }
        }
        private double fixedprice // if fixedpay then use this
        {
            get { return fixedprice; }
            set { fixedprice = value; }
        }
    }
}
