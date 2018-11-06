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
    public static class OrderDB
    {
        public static SqlConnection GetConnection()
        {
            return new SqlConnection(@"Data Source=localhost\sqlexpress;Initial Catalog=Northwind;Integrated Security=True");
        }

        public static List<Order> GetOrders()
        {
            List<Order> orders = new List<Order>();
            Order order;
            SqlConnection con = GetConnection();
            string selectSmt = "SELECT OrderID, CustomerID, OrderDate, RequiredDate, ShippedDate " +
                                     "FROM Orders " +
                                     "ORDER BY OrderID";
            SqlCommand selectCmd = new SqlCommand(selectSmt, con);

            try
            {
                con.Open();
                SqlDataReader dr = selectCmd.ExecuteReader();
                while (dr.Read())
                {
                    order = new Order();
                    order.OrderID = (int)dr["OrderID"];
                    order.CustomerID = dr["CustomerID"].ToString();
                    order.OrderDate = dr["OrderDate"] as DateTime?;                   
                    order.RequiredDate = dr["RequiredDate"] as DateTime?;
                    order.ShippedDate = dr["ShippedDate"] as DateTime?;

                    orders.Add(order);
                }
            }
            catch(SqlException ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
            }
            return orders;
        }

        /// <summary>
        /// Updates existing order record
        /// </summary>
        /// <param name="oldOrder">data before update</param>
        /// <param name="newOrder">new data for the update</param>
        /// <returns>indicator of success</returns>
        public static bool UpdateOrder(Order oldOrder, Order newOrder)
        {
            SqlConnection con = GetConnection();
            string updateStatement = "UPDATE Orders " +
                                     "SET ShippedDate = @NewShippedDate " +
                                     "WHERE OrderID = @OldOrderID " +
                                     "AND CustomerID = @OldCustomerID " +
                                     "AND OrderDate = @OldOrderDate " +
                                     "AND RequiredDate = @OldRequiredDate " +
                                     "AND ShippedDate = @OldShippedDate";
            SqlCommand cmd = new SqlCommand(updateStatement, con);
            cmd.Parameters.AddWithValue("@NewShippedDate", newOrder.ShippedDate);
            cmd.Parameters.AddWithValue("@OldOrderID", oldOrder.OrderID);
            cmd.Parameters.AddWithValue("@OldCustomerID", oldOrder.CustomerID);            
            cmd.Parameters.AddWithValue("@OldOrderDate", oldOrder.OrderDate);
            cmd.Parameters.AddWithValue("@OldRequiredDate", oldOrder.RequiredDate);
            cmd.Parameters.AddWithValue("@OldShippedDate", oldOrder.ShippedDate);
            try
            {
                con.Open();
                int count = cmd.ExecuteNonQuery();
                if (count > 0) return true;
                else return false;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
            }
        }
    }
}
