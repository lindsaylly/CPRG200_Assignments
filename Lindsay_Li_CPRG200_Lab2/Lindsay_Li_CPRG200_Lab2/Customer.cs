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
    public class Customer
    {
        // private data and public accessors
        public int AccountNo { get; set; }

        public string CustomerName { get; set; }

        public string CustomerType { get; set; }

        public double Usage { get; set; }

        private double chargeAmount;
        public double ChargeAmount
        {
            get { return chargeAmount; }
            set { chargeAmount = (value < 0) ? 0 : value; } // validate the chargeAmount only could be positive numeric.
        }

        //constructor
        public Customer(string t = "Unknown",int a = 0, string n="Unknown", double u=0)
        {
            CustomerType = t;
            AccountNo = a;
            CustomerName = n;            
            Usage = u;
        }

        //pubulic methods
        //calculate the charge amount
        public virtual double CalculateCharge()
        {
            return 0;
        }

        //override the method of ToString that returns a display string
        public override string ToString()
        {
            return CustomerType + ", " + AccountNo.ToString() + ", " + CustomerName + " -- " + ChargeAmount.ToString("c");
        }

        //return a display string that is used as writing a line in a file
        public string ToFileLine()
        {
            return CustomerType + "," + AccountNo.ToString() + "," + CustomerName + "," + ChargeAmount.ToString();
        }
    }
}
