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
    public class ResidentialCustomer : Customer
    {
        const double BASECHARGE_RDL = 6; //the base charge for Residential customer 
        const double RATE_RDL = 0.052; // the rate for each additional usage for Residential customer

        // constructor
        public ResidentialCustomer(string t = "R", int a = 0, string n = "Unknown", double u = 0) : base(t, a, n, u) { } //calls base class constructor

        //public methods
        //calculate the charge amount
        private double CalculateChargeRdl()
        {         
            return BASECHARGE_RDL + RATE_RDL * Usage;
        }

        //override inherited methods
        public override double CalculateCharge()
        {
            return base.CalculateCharge() + CalculateChargeRdl();
        }
    }
}
