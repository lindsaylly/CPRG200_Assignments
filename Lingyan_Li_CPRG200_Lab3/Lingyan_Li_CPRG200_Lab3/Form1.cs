using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;// ADO.NET Sql Server data provider
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 * Purpose: CPRG200_Lab3
 * Author: Lindsay
 * Date:July 13,2018 
 */

namespace Lingyan_Li_CPRG200_Lab3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // user clicks on Save button
        private void productsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            try
            {
                this.productsBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.northwindDataSet);
            }
            catch (DBConcurrencyException)
            {
                MessageBox.Show("Another user changed data. Try again", "Concurrency Exception");
                this.productsTableAdapter.Fill(this.northwindDataSet.Products);
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Database error while saving: " + ex.Message, ex.GetType().ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Other error while saving: " + ex.Message, ex.GetType().ToString());
            }


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                // loads order_Details data into data set
                this.order_DetailsTableAdapter.Fill(this.northwindDataSet.Order_Details);
                // loads categories data into data set
                this.categoriesTableAdapter.Fill(this.northwindDataSet.Categories);
                // loads suppliers data into data set
                this.suppliersTableAdapter.Fill(this.northwindDataSet.Suppliers);
                // loads products data into data set
                this.productsTableAdapter.Fill(this.northwindDataSet.Products);
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Database error while loading: " + ex.Message, ex.GetType().ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Other error while loading: " + ex.Message, ex.GetType().ToString());
            }
        }

        // finds product with given ID
        private void fillByProdIDToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                int productID = Convert.ToInt32(productIDToolStripTextBox.Text);
                this.productsTableAdapter.FillByProdID(this.northwindDataSet.Products, productID);
                if (northwindDataSet.Products.Count == 0) //none
                    MessageBox.Show("No product with this ID", "Information");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }

        }
    }
}
