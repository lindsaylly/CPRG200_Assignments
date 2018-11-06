using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Purpose: Electricity Bill application for the city power company--CPRG200_Lab2
 * Author: Lindsay
 * Date:Jun 23,2018 
 */

namespace Lindsay_Li_CPRG200_Lab2
{

    public class CommercialCustomer : Customer
    {
        const double RATE = 0.045; //the rate for each additional usage
        const double FIRST_RANGE = 1000; //the range for the base charge
        const double BASECHARGE = 60;//the base charge

        // constructor
        public CommercialCustomer(string t = "C", int a = 0, string n = "Unknown", double u = 0) : base(t, a, n, u) //calls base class constructor
        {
        }

        //public methods
        //calculate the charge amount
        private double CalculateChargeCml()
        {    
            if (Usage <= FIRST_RANGE) return BASECHARGE; // get the charge when the usage within the base rang
            else return BASECHARGE + RATE * (Usage - FIRST_RANGE);
        }

        //override inherited methods
        public override double CalculateCharge()
        {
            return base.CalculateCharge() + CalculateChargeCml();
        }
    }
}
