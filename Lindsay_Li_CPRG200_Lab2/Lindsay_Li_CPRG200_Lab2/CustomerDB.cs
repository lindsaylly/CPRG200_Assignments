using System;
using System.Collections.Generic;
using System.IO;
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
    public static class CustomerDB
    {
        const string path = "Customers.txt"; // the file's name
        /// <summary>
        /// Reads data from the file if exists; or creates an empty file
        /// </summary>
        /// <returns>
        /// List of customers if file existed, or empty list otherwise
        /// </returns>
        public static List<Customer> ReadCustomers()
        {
            List<Customer> customers = new List<Customer>(); //empty list
            FileStream fs = null;
            StreamReader sr = null;

            // for reading
            string line; //the read line
            string[] parts; // the split string array
            try
            {
                // open the file for reading (the very first time, the file does not exist)
                fs = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Read);
                sr = new StreamReader(fs);
                // read data
                while (!sr.EndOfStream) // while there is still data
                {
                    line = sr.ReadLine();
                    parts = line.Split(','); //split where commas are
                    // creat another customer and add to the list
                    Customer c = new Customer();
                    c.CustomerType = parts[0];
                    c.AccountNo = Convert.ToInt32(parts[1]);
                    c.CustomerName = parts[2];
                    c.ChargeAmount = Convert.ToDouble(parts[3]);              
                    customers.Add(c);
                }
            }
            catch (Exception ex)
            {
                throw ex; // pass it to the calling code
            }
            finally
            {
                if (sr != null) sr.Close();
            }
            return customers;
        }

        // save the list to the file
        public static void SaveCustomers(List<Customer> customers)
        {
            FileStream fs = null;
            StreamWriter sw = null;
            try
            {
                // open the file for writng; overwrite old content
                fs = new FileStream(path, FileMode.Create, FileAccess.Write);
                sw = new StreamWriter(fs);

                // save data
                foreach (Customer c in customers)
                    sw.WriteLine(c.ToFileLine());
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (sw != null) sw.Close();
            }
        }
    }
}
