using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 * Purpose: Electricity Bill application for the city power company--CPRG200_Lab2
 * Author: Lindsay
 * Date:Jun 23,2018 
 */

namespace Lindsay_Li_CPRG200_Lab2
{
    public partial class frmCustomers : Form
    {       
        List<Customer> customerList = new List<Customer>(); // empty list

        public frmCustomers()
        {
            InitializeComponent();           
        }

        // when the form is loaded, read the data from the file and display it in the customer list, and display the summary information
        private void frmCustomers_Load(object sender, EventArgs e)
        {
            txtAccountNo.Focus();
            cmbCustomerType.Text = "Residential";  //Residential customer is assumed as default value as the program starts
            customerList= CustomerDB.ReadCustomers();
            DisplayCustomers();
        }

        // Claculate the sum of all the customers' charge amount in the list
        private double SumCharge()
        {
            double sum = 0; //the sum of all the customers' charge amount
            foreach (Customer c in customerList)
                sum += c.ChargeAmount;
            return sum;
        }

        // Claculate the sum of all the residential customers' charge amount in the list
        private double RdlSumCharge()
        {
            double rdlSum = 0; //the sum of all the residential customers' charge amount
            foreach (Customer c in customerList)
                if (c.CustomerType =="R") rdlSum += c.ChargeAmount;
            return rdlSum;
        }

        // Claculate the sum of all the commercial customers' charge amount in the list
        private double CmlSumCharge()
        {
            double cmlSum = 0; //the sum of all the commercial customers' charge amount
            foreach (Customer c in customerList)
                if (c.CustomerType == "C") cmlSum += c.ChargeAmount;
            return cmlSum;
        }

        // Claculate the sum of all the industiral customers' charge amount in the list
        private double IdlSumCharge()
        {
            double idlSum = 0; //the sum of all the industiral customers' charge amount
            foreach (Customer c in customerList)
                if (c.CustomerType == "I") idlSum += c.ChargeAmount;
            return idlSum;
        }

        //display the customerlist and the summary information        
        private void DisplayCustomers()
        {
            lstCustomers.Items.Clear(); //start with empty list box
            foreach (Customer c in customerList)
                lstCustomers.Items.Add(c); //add to the list box
            lblCustomerNum.Text = customerList.Count.ToString();//count the customers
            lblSumCharge.Text = SumCharge().ToString("c");//calculate and display the sum charge amount
            //calculate and display the sum charge amount of different type of the customers
            lblRdlSumCharge.Text = RdlSumCharge().ToString("c");
            lblCmlSumCharge.Text = CmlSumCharge().ToString("c");
            lblIdlSumCharge.Text = IdlSumCharge().ToString("c");
        }

        //save the data to the file when the form is closing
        private void frmCustomers_FormClosing(object sender, FormClosingEventArgs e)
        {
            CustomerDB.SaveCustomers(customerList);
        }

        //when the Add button is clicked, calculate the charge of the usage depending on the customer type and add the data to customer list
        private void btnAdd_Click(object sender, EventArgs e)
        {            
            if (cmbCustomerType.Text == "Residential") // if residential customer
            {
                //validate the input text boxes 
                if (Validator.IsProvided(txtAccountNo, "AccountNo") &&
                    Validator.IsNonNegativeInteger(txtAccountNo, "AccountNo") &&
                    Validator.IsUnique(txtAccountNo, customerList, "AccountNo") &&
                    Validator.IsProvided(txtCustomerName, "Customer Name") &&
                    Validator.IsProvided(txtUsage, "Overall Usage") &&
                    Validator.IsNonNegativeInteger(txtUsage, "Overall Usage"))
                {
                    //create a residential customer and get inputs                 
                    ResidentialCustomer c = new ResidentialCustomer();
                    c.AccountNo = Convert.ToInt32(txtAccountNo.Text);
                    c.CustomerName = txtCustomerName.Text;
                    c.Usage = Convert.ToDouble(txtUsage.Text);
                    c.ChargeAmount = c.CalculateCharge(); // calculate the customer chargeAmount
                    customerList.Add(c); // add the new customer data into the list                       
                    DisplayCustomers();// re-display customers
                    Clear(); //clear for the next entry
                }
            }
            else if (cmbCustomerType.Text == "Commercial") // if commercial customer
            {
                //validate the input text boxes 
                if (Validator.IsProvided(txtAccountNo, "AccountNo") &&
                    Validator.IsNonNegativeInteger(txtAccountNo, "AccountNo") &&
                    Validator.IsUnique(txtAccountNo, customerList, "AccountNo") &&
                    Validator.IsProvided(txtCustomerName, "Customer Name") &&
                    Validator.IsProvided(txtUsage, "Overall Usage") &&
                    Validator.IsNonNegativeInteger(txtUsage, "Overall Usage"))
                {
                    //create a commercial customer
                    CommercialCustomer c = new CommercialCustomer();
                    c.AccountNo = Convert.ToInt32(txtAccountNo.Text);
                    c.CustomerName = txtCustomerName.Text;
                    c.Usage = Convert.ToDouble(txtUsage.Text);
                    c.ChargeAmount = c.CalculateCharge();
                    customerList.Add(c);
                    DisplayCustomers();
                    Clear();
                }
            }
            else // the industrial customer
            {
                //validate the input text boxes
                if (Validator.IsProvided(txtAccountNo, "AccountNo") &&
                    Validator.IsNonNegativeInteger(txtAccountNo, "AccountNo") &&
                    Validator.IsUnique(txtAccountNo, customerList, "AccountNo") &&
                    Validator.IsProvided(txtCustomerName, "Customer Name") &&
                    Validator.IsProvided(txtUsage, "Peak Hours Usage") &&
                    Validator.IsNonNegativeInteger(txtUsage, "Peak Hours Usage") &&
                    Validator.IsProvided(txtOffPeakUsage, "Off-peak Hours Usage") &&
                    Validator.IsNonNegativeInteger(txtOffPeakUsage, "Off-peak Hours Usage"))
                {
                    //create a industrial customer
                    IndustrialCustomer c = new IndustrialCustomer();
                    c.AccountNo = Convert.ToInt32(txtAccountNo.Text);
                    c.CustomerName = txtCustomerName.Text;
                    c.Usage = Convert.ToDouble(txtUsage.Text);
                    c.OffPeakUsage = Convert.ToDouble(txtOffPeakUsage.Text);
                    c.ChargeAmount = c.CalculateCharge();
                    customerList.Add(c);                     
                    DisplayCustomers();
                    Clear();
                }
            }
        }

        //resets the input text boxes and the controls
        private void Clear()
        {
            txtAccountNo.Text = String.Empty;
            txtCustomerName.Text = String.Empty;
            txtUsage.Text = String.Empty;
            txtOffPeakUsage.Text = String.Empty;
            cmbCustomerType.Text = "Residential";
            txtAccountNo.Focus();
        }

        //calls the Clear method when the button is clicked
        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        //terminates the application
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //setting the dispaly for the different type of customer
        private void cmbCustomerType_SelectedIndexChanged(object sender, EventArgs e)
        {            
            if (cmbCustomerType.Text == "Industrial") // if industrial customer
            {
                lblUsage.Text = "Peak Hours Usage"; //switch the lable name
                //show OffPeakUsage input box and relative controls
                lblOffPeak.Visible = true; 
                txtOffPeakUsage.Visible = true; 
                lblOffPeakUnit.Visible = true; 
            }
            else // residential or commercial customer
            {
                lblUsage.Text = "Overall Usage";
                //hidden the OffPeakUsage input box and relative controls
                lblOffPeak.Visible = false;
                txtOffPeakUsage.Visible = false;
                lblOffPeakUnit.Visible = false;
            }
        }
    }
}
