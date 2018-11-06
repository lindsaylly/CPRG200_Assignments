using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Purpose: CPRG200_Lab4
 * Author: Lindsay
 * Date:July 17,2018 
 */
namespace Lingyan_Li_CPRG200_Lab4
{
    public class Order
    {
        public int OrderID { get; set; }
        public string CustomerID { get; set; }
        public DateTime? OrderDate { get; set; }
        public DateTime? RequiredDate { get; set; }
        public DateTime? ShippedDate { get; set; }

        public Order CopyOrder()
        {
            Order copy = new Order();
            copy.OrderID = OrderID; //this customer's ID
            copy.CustomerID = CustomerID;
            copy.OrderDate = OrderDate;
            copy.RequiredDate = RequiredDate;
            copy.ShippedDate = ShippedDate;
            return copy;
        }

    }
}
