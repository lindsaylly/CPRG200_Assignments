using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 * Purpose: Electricity Bill application for the city power company
 * Author: Lindsay
 * Date:Jun 14,2018 
 */

namespace lab1_ElecBill
{
    public partial class Form1 : Form
    {
        const double BASECHARGE_RDL = 6; //the base charge for Residential customer 
        const double BASECHARGE_CML = 60;//the base charge for Commertial  customer 
        const double BASECHARGE_IDL_PEAK = 76; //the base charge in peak hours for Industrial customer 
        const double BASECHARGE_IDL_OFFPEAK = 40; //the base charge in off-peak hours for Industrial customer
        const double FIRST_RANGE = 1000; //the range for the base charge
        const double RATE_RDL = 0.052; // the rate for each additional usage for Residential customer
        const double RATE_CML = 0.045; //the rate for each additional usage for Commertial customer
        const double RATE_IDL_PEAK = 0.065;//the rate for each additional usage for Industrial customer in peak hours
        const double RATE_IDL_OFFPEAK = 0.028;//the rate for each additional usage for Industrial customer in off-peak hours
        public Form1()
        {
            InitializeComponent();
            btnRdl.Checked = true;  //Residential customer is assumed as default as the program starts
        }

        //calculate the charge of the usage depending on the customer type
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double totalcharge = 0; // the total charge of the usage   
            if (btnRdl.Checked) // check the customer type is Residential or not
            {   
                //validate the text box 
                if (Validator.IsProvided(txtUsage, "Overall Usage") &&
                    Validator.IsNonNegativeInteger(txtUsage, "Overall Usage"))
                {
                    // calculate the charge for resdential customer
                    totalcharge = CalculateCharge_Rdl(txtUsage);
                }
            }
            else if (btnCml.Checked) // check the customer type is Commertial or not
            {
                //validate the text box 
                if (Validator.IsProvided(txtUsage, "Overall Usage") &&
                    Validator.IsNonNegativeInteger(txtUsage, "Overall Usage"))
                {
                    // calculate the charge for commertial customer
                    totalcharge = CalculateCharge_Cml(txtUsage);
                }
            }
            else // the Industrial customer
            {
                //validate the text boxes
                if (Validator.IsProvided(txtUsage, "Peak hours Usage") &&
                   Validator.IsNonNegativeInteger(txtUsage, "Peak hours Usage") &&
                   Validator.IsProvided(txtOffPeakUsage, "Off-peak hours usage") &&
                   Validator.IsNonNegativeInteger(txtOffPeakUsage, "Off-peak hours usage"))
                {
                    // calculate the charge for industrial customer
                    totalcharge = CalculateCharge_Idl(txtUsage, txtOffPeakUsage);
                }
            }
            //display the totalcharge in currency format
            txtCharge.Text = totalcharge.ToString("c");          
        }

        //calculate the charge for Residential customer
        private double CalculateCharge_Rdl(TextBox inputBox)
        {
            double charge; //the total charge
            double usage; //the amount of overall usage            
            usage = Convert.ToDouble(inputBox.Text); //get the usage
            charge = BASECHARGE_RDL + RATE_RDL * usage;
            return charge;
        }

        //calculate the charge for Commertial customer
        private double CalculateCharge_Cml(TextBox inputBox)
        {
            double charge;//the total charge
            double usage;//the amount of overall usage 
            usage = Convert.ToDouble(inputBox.Text); //get the usage           
            if (usage <= FIRST_RANGE) charge = BASECHARGE_CML; // get the charge when the usage within the base rang
            else charge = BASECHARGE_CML + RATE_CML * (usage - FIRST_RANGE);
            return charge;
        }

        //calculate the charge for Industrial customer
        private double CalculateCharge_Idl(TextBox inputBox1, TextBox inputBox2)
        {
            double charge;//the charge
            double usage; //the amount of peak hours usage 
            double offPeakUsage; //the amount of off-peak hours usage            
            usage = Convert.ToDouble(inputBox1.Text);
            offPeakUsage = Convert.ToDouble(inputBox2.Text);
            //calculate the charge of the usage occurred during peak hours
            if (usage <= FIRST_RANGE) charge = BASECHARGE_IDL_PEAK;
            else charge = BASECHARGE_IDL_PEAK + RATE_IDL_PEAK * (usage - FIRST_RANGE);
            //the total charge
            if (offPeakUsage <= FIRST_RANGE)  charge += BASECHARGE_IDL_OFFPEAK;
            else charge += (BASECHARGE_IDL_OFFPEAK + RATE_IDL_OFFPEAK * (offPeakUsage - FIRST_RANGE));
            return charge;
        }

        //erease the input and output data, and resets the control as when the application starts
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtUsage.Text = String.Empty;
            txtOffPeakUsage.Text = String.Empty;
            txtCharge.Text = String.Empty;
            btnRdl.Checked = true;
            txtUsage.Focus();
        }

        //terminates the application
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        
        //setting the dispaly for Residential customer
        private void btnRdl_CheckedChanged(object sender, EventArgs e)
        {           
            lblUsage.Text = "Overall Usage:"; 
            lblOffpeak.Visible = false; //hide the lable
            txtOffPeakUsage.Visible = false; //hide the text box
            lblOffpeakUnit.Visible = false;//hide the lable
            txtUsage.Focus();
        }

        //setting the dispaly for Commertial customer
        private void btnCml_CheckedChanged(object sender, EventArgs e)
        {
            lblUsage.Text = "Overall Usage:";
            lblOffpeak.Visible = false;
            txtOffPeakUsage.Visible = false;
            lblOffpeakUnit.Visible = false;
            txtUsage.Focus();
        }

        //setting the dispaly for Industrial customer
        private void btnIdl_CheckedChanged(object sender, EventArgs e)
        {
            lblUsage.Text = "Peak Hours usage:";
            lblOffpeak.Visible = true; //display the lable
            txtOffPeakUsage.Visible = true; //display the text box
            lblOffpeakUnit.Visible = true; //display the lable
            txtUsage.Focus();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtUsage.Focus();
        }
    }
}
