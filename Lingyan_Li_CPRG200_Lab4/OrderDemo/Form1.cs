using Lingyan_Li_CPRG200_Lab4;
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
 * Purpose: CPRG200_Lab4
 * Author: Lindsay
 * Date:July 17,2018 
 */
namespace OrderDemo
{
    public partial class Form1 : Form
    {
        Order newOrder; // current order
        Order oldOrder; // to reserve data before updated (original order data)        
        List<Order> orders;// list of all customers
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            try
            {
                orders = OrderDB.GetOrders(); // get the order list
                // add items to the orderID combobox
                foreach (var order in orders)
                {
                    orderIDComboBox.Items.Add(order.OrderID);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while loading order data: " + ex.Message,
                    ex.GetType().ToString());
            }            
        }

        // make some controls enable when update button clicked
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            dtpShippedDate.Enabled = true;
            btnSave.Enabled = true;
        }

        // save the current shippedDate
        private void btnSave_Click(object sender, EventArgs e)
        {
            bool update = false;
            if (dtpShippedDate.Checked) // has value
            {
                newOrder.ShippedDate = dtpShippedDate.Value; // get the new value
                // validate ShippedDate
                if (oldOrder.OrderDate != null) // has value
                {
                    if (oldOrder.RequiredDate != null) //has value
                    {
                        if (oldOrder.OrderDate <= newOrder.ShippedDate &&
                            oldOrder.RequiredDate >= newOrder.ShippedDate)
                        {   //the new value for ShippedDate should not be earlier than OrderDate and no later than RequiredDate
                            update = true;
                        }
                        else
                        {
                            update = false;
                            MessageBox.Show("ShippedDate should not be earlier than OrderDate or later than RequiredDate");
                        }
                    }
                    else // only requiredDate is unknown
                    {
                        if (oldOrder.OrderDate <= newOrder.ShippedDate) { update = true; }
                        else MessageBox.Show("ShippedDate should not be earlier than OrderDate");
                    }
                }
                else
                {
                    if (oldOrder.RequiredDate != null)  // only OrderDate is unknown
                    {
                        if (oldOrder.RequiredDate >= newOrder.ShippedDate) { update = true; }
                        else MessageBox.Show("ShippedDate should not be later than RequiredDate");
                    }
                    else update = true; // both OrderDate and RequiredDate are unknown, shippedDate don't need to be validated
                }                           
            }
            else // shippedDate is unknown
            {
                newOrder.ShippedDate = null;
                update = true;
            }
            if (update)
            {
                bool success = OrderDB.UpdateOrder(oldOrder, newOrder);
                if (update)
                {
                    MessageBox.Show("ShippedDate upated successfully!");
                }
                else
                {
                    MessageBox.Show("ShippedDate upated failed!");
                }
            }
            btnSave.Enabled = false;
        }


        // an order is selected, and only relevant order details for the selected order is displayed at any time
        private void orderIDComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            dtpShippedDate.Enabled = false;
            btnUpdate.Enabled = true; // can update shippedDate
            //display the selected order
            foreach (var order in orders)
            {
                if (orderIDComboBox.Text == order.OrderID.ToString())
                {
                    newOrder = oldOrder = order.CopyOrder(); // make separate copys before update
                    txtcustomerID.Text = order.CustomerID;
                   
                    txtOrderDate.Text = (order.OrderDate == null) ? null : Convert.ToDateTime(order.OrderDate).ToShortDateString();
                    txtRequiredDate.Text = (order.RequiredDate == null)? null : Convert.ToDateTime(order.RequiredDate).ToShortDateString();

                    if (order.ShippedDate != null)
                    {
                        dtpShippedDate.Text = order.ShippedDate.ToString();
                    }
                    else //ShippedDate is null
                    {
                        dtpShippedDate.Checked = false;
                    }
                    
                }
            }
            // get the list of orderDetail
            List<OrderDetail> orderDetails = OrderDetailDB.GetOrderDetails();            
            lvOrdDetails.Items.Clear();//clear the list box
            int i = 0; // the index of the subItems
            decimal orderTotal = 0; // the total amount of each order
            //relevant order details for the selected order is displayed
            foreach (var orderDetail in orderDetails)
            {
                if (orderIDComboBox.Text == orderDetail.OrderID.ToString())
                {
                    lvOrdDetails.Items.Add(orderDetail.OrderID.ToString());
                    lvOrdDetails.Items[i].SubItems.Add(orderDetail.ProductID.ToString());
                    lvOrdDetails.Items[i].SubItems.Add(orderDetail.Quantity.ToString());
                    lvOrdDetails.Items[i].SubItems.Add(orderDetail.UnitPrice.ToString("c"));
                    lvOrdDetails.Items[i].SubItems.Add(orderDetail.Discount.ToString("p0"));
                    lvOrdDetails.Items[i].SubItems.Add(orderDetail.OrderAmount.ToString("c"));
                    orderTotal += orderDetail.OrderAmount;
                    i++;
                }                   
            }
            txtTotalAmount.Text = orderTotal.ToString("c");
        }

        // exit the application
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
