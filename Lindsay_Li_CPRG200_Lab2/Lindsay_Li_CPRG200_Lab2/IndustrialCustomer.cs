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
    public class IndustrialCustomer : Customer
    {
        const double FIRST_RANGE = 1000; //the range for the base charge
        const double BASECHARGE_PEAK = 76; //the base charge in peak hours 
        const double BASECHARGE_OFFPEAK = 40; //the base charge in off-peak hours
        const double RATE_PEAK = 0.065;//the rate for each additional usage in peak hours
        const double RATE_OFFPEAK = 0.028;//the rate for each additional usage in off-peak hours

        //added data (the usage for off-peak hours)
        public double OffPeakUsage { get; set; }

        // constructor
        public IndustrialCustomer(string t = "I", int a = 0, string n = "Unknown", double u = 0, double o = 0 ) : base(t, a, n, u) //calls base class constructor
        {
            OffPeakUsage = o ;
        }

        //public methods
        //calculate the charge amount
        private double CalculateChargeIdl()
        {
            double charge = 0;    
            //calculate the charge of the usage occurred during peak hours
            if (Usage <= FIRST_RANGE) charge = BASECHARGE_PEAK;
            else charge = BASECHARGE_PEAK + RATE_PEAK * (Usage - FIRST_RANGE);
            //the total charge
            if (OffPeakUsage <= FIRST_RANGE) charge += BASECHARGE_OFFPEAK;
            else charge += (BASECHARGE_OFFPEAK + RATE_OFFPEAK * (OffPeakUsage - FIRST_RANGE));
            return charge;
        }

        //override inherited method
        public override double CalculateCharge()
        {
            return base.CalculateCharge() + CalculateChargeIdl();
        }
    }
}
