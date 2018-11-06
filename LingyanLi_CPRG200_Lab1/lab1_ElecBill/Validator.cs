using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab1_ElecBill
{
    public static class Validator
    {   
        //test if text box contains anything
        public static bool IsProvided(TextBox inputBox, string name)
        {
            bool result = true; //"innocent until proven guilty"

            if (inputBox.Text == "")// bad!
            {
                result = false;
                MessageBox.Show("Please enter the " + name);
                inputBox.Focus();
            }
            return result;
        }

        //test if text box contains non negative integer value
        public static bool IsNonNegativeInteger(TextBox inputBox, string name)
        {
            bool result = true;
            int val; // to capture value from TryParse
            if (!Int32.TryParse(inputBox.Text, out val))
            {
                result = false;
                MessageBox.Show(name + " must be a whole number. Please enter again.");
                inputBox.SelectAll();
                inputBox.Focus();
            }
            else // it is an integer
            {
                if (val < 0) //bad
                {
                    result = false;
                    MessageBox.Show(name + " should not be negative number. Please enter again.");
                    inputBox.SelectAll();
                    inputBox.Focus();
                }
            }
            return result;
        }
    }
}
