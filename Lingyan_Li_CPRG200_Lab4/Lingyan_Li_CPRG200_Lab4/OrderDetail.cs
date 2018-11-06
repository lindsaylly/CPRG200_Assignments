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
    public class OrderDetail
    {
        public int OrderID { get; set; }
        public int ProductID { get; set; }
        public decimal UnitPrice { get; set; }
        public short Quantity { get; set; }
        public Single Discount { get; set; }
        public decimal OrderAmount { get; set; }

        public decimal CalculateOrderAmount()
        {
            return OrderAmount = UnitPrice * (decimal)(1 - Discount) * Quantity;
        }
    }
}
