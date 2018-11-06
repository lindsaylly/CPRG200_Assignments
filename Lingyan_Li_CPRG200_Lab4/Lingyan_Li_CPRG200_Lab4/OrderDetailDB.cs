using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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
    public static class OrderDetailDB
    {
        public static SqlConnection GetConnection()
        {
            return new SqlConnection(@"Data Source=localhost\sqlexpress;Initial Catalog=Northwind;Integrated Security=True");
        }

        public static List<OrderDetail> GetOrderDetails()
        {
            List<OrderDetail> orderDetails = new List<OrderDetail>();
            OrderDetail orderDetail;
            SqlConnection con = GetConnection();
            string selectSmt = "SELECT OrderID, ProductID, UnitPrice, Quantity, Discount " +
                                     "FROM [Order Details] ORDER BY OrderID";
            SqlCommand selectCmd = new SqlCommand(selectSmt, con);

            try
            {
                con.Open();
                SqlDataReader dr = selectCmd.ExecuteReader();
                while (dr.Read())
                {
                    orderDetail = new OrderDetail();
                    orderDetail.OrderID = (int)dr["OrderID"];
                    orderDetail.ProductID= (int)dr["ProductID"];
                    orderDetail.UnitPrice = (decimal)dr["UnitPrice"];// the data type in SQL Server is money
                    orderDetail.Quantity = (short)dr["Quantity"]; // the data type in SQL Server is smllint
                    orderDetail.Discount = (Single)(dr["Discount"]); // the data type in SQL Server is real
                    orderDetail.CalculateOrderAmount();
                    orderDetails.Add(orderDetail);
                }
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
            }
            return orderDetails;
        }


        


    }
}
