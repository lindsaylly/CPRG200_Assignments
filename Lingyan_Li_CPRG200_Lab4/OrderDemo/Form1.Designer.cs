namespace OrderDemo
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label customerIDLabel;
            System.Windows.Forms.Label orderDateLabel;
            System.Windows.Forms.Label orderIDLabel;
            System.Windows.Forms.Label requiredDateLabel;
            System.Windows.Forms.Label shippedDateLabel;
            this.lvOrdDetails = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.txtcustomerID = new System.Windows.Forms.TextBox();
            this.txtOrderDate = new System.Windows.Forms.TextBox();
            this.orderIDComboBox = new System.Windows.Forms.ComboBox();
            this.txtRequiredDate = new System.Windows.Forms.TextBox();
            this.dtpShippedDate = new System.Windows.Forms.DateTimePicker();
            this.txtTotalAmount = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.orderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.orderDetailBindingSource = new System.Windows.Forms.BindingSource(this.components);
            customerIDLabel = new System.Windows.Forms.Label();
            orderDateLabel = new System.Windows.Forms.Label();
            orderIDLabel = new System.Windows.Forms.Label();
            requiredDateLabel = new System.Windows.Forms.Label();
            shippedDateLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderDetailBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // customerIDLabel
            // 
            customerIDLabel.AutoSize = true;
            customerIDLabel.Location = new System.Drawing.Point(81, 101);
            customerIDLabel.Name = "customerIDLabel";
            customerIDLabel.Size = new System.Drawing.Size(68, 13);
            customerIDLabel.TabIndex = 44;
            customerIDLabel.Text = "Customer ID:";
            // 
            // orderDateLabel
            // 
            orderDateLabel.AutoSize = true;
            orderDateLabel.Location = new System.Drawing.Point(81, 127);
            orderDateLabel.Name = "orderDateLabel";
            orderDateLabel.Size = new System.Drawing.Size(62, 13);
            orderDateLabel.TabIndex = 46;
            orderDateLabel.Text = "Order Date:";
            // 
            // orderIDLabel
            // 
            orderIDLabel.AutoSize = true;
            orderIDLabel.Location = new System.Drawing.Point(81, 67);
            orderIDLabel.Name = "orderIDLabel";
            orderIDLabel.Size = new System.Drawing.Size(50, 13);
            orderIDLabel.TabIndex = 48;
            orderIDLabel.Text = "Order ID:";
            // 
            // requiredDateLabel
            // 
            requiredDateLabel.AutoSize = true;
            requiredDateLabel.Location = new System.Drawing.Point(81, 160);
            requiredDateLabel.Name = "requiredDateLabel";
            requiredDateLabel.Size = new System.Drawing.Size(79, 13);
            requiredDateLabel.TabIndex = 50;
            requiredDateLabel.Text = "Required Date:";
            // 
            // shippedDateLabel
            // 
            shippedDateLabel.AutoSize = true;
            shippedDateLabel.Location = new System.Drawing.Point(81, 189);
            shippedDateLabel.Name = "shippedDateLabel";
            shippedDateLabel.Size = new System.Drawing.Size(75, 13);
            shippedDateLabel.TabIndex = 52;
            shippedDateLabel.Text = "Shipped Date:";
            // 
            // lvOrdDetails
            // 
            this.lvOrdDetails.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.lvOrdDetails.Enabled = false;
            this.lvOrdDetails.Location = new System.Drawing.Point(84, 257);
            this.lvOrdDetails.Name = "lvOrdDetails";
            this.lvOrdDetails.Size = new System.Drawing.Size(503, 218);
            this.lvOrdDetails.TabIndex = 11;
            this.lvOrdDetails.UseCompatibleStateImageBehavior = false;
            this.lvOrdDetails.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Order ID";
            this.columnHeader1.Width = 80;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Product ID";
            this.columnHeader2.Width = 80;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Quantity";
            this.columnHeader3.Width = 80;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Unit Price";
            this.columnHeader4.Width = 80;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Discount";
            this.columnHeader5.Width = 80;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Order Amount";
            this.columnHeader6.Width = 100;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Enabled = false;
            this.btnUpdate.Location = new System.Drawing.Point(105, 12);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(55, 23);
            this.btnUpdate.TabIndex = 42;
            this.btnUpdate.Text = "&Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnSave
            // 
            this.btnSave.Enabled = false;
            this.btnSave.Location = new System.Drawing.Point(177, 12);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(61, 23);
            this.btnSave.TabIndex = 43;
            this.btnSave.Text = "&Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(253, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(61, 23);
            this.btnExit.TabIndex = 44;
            this.btnExit.Text = "&Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // txtcustomerID
            // 
            this.txtcustomerID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.orderBindingSource, "CustomerID", true));
            this.txtcustomerID.Location = new System.Drawing.Point(166, 98);
            this.txtcustomerID.Name = "txtcustomerID";
            this.txtcustomerID.ReadOnly = true;
            this.txtcustomerID.Size = new System.Drawing.Size(130, 20);
            this.txtcustomerID.TabIndex = 45;
            // 
            // txtOrderDate
            // 
            this.txtOrderDate.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.orderBindingSource, "OrderDate", true));
            this.txtOrderDate.Location = new System.Drawing.Point(166, 124);
            this.txtOrderDate.Name = "txtOrderDate";
            this.txtOrderDate.ReadOnly = true;
            this.txtOrderDate.Size = new System.Drawing.Size(130, 20);
            this.txtOrderDate.TabIndex = 47;
            // 
            // orderIDComboBox
            // 
            this.orderIDComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.orderBindingSource, "OrderID", true));
            this.orderIDComboBox.FormattingEnabled = true;
            this.orderIDComboBox.Location = new System.Drawing.Point(166, 64);
            this.orderIDComboBox.Name = "orderIDComboBox";
            this.orderIDComboBox.Size = new System.Drawing.Size(130, 21);
            this.orderIDComboBox.TabIndex = 49;
            this.orderIDComboBox.SelectedIndexChanged += new System.EventHandler(this.orderIDComboBox_SelectedIndexChanged);
            // 
            // txtRequiredDate
            // 
            this.txtRequiredDate.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.orderBindingSource, "RequiredDate", true));
            this.txtRequiredDate.Location = new System.Drawing.Point(166, 157);
            this.txtRequiredDate.Name = "txtRequiredDate";
            this.txtRequiredDate.ReadOnly = true;
            this.txtRequiredDate.Size = new System.Drawing.Size(130, 20);
            this.txtRequiredDate.TabIndex = 51;
            // 
            // dtpShippedDate
            // 
            this.dtpShippedDate.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.orderBindingSource, "ShippedDate", true));
            this.dtpShippedDate.Enabled = false;
            this.dtpShippedDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpShippedDate.Location = new System.Drawing.Point(166, 187);
            this.dtpShippedDate.Name = "dtpShippedDate";
            this.dtpShippedDate.ShowCheckBox = true;
            this.dtpShippedDate.Size = new System.Drawing.Size(130, 20);
            this.dtpShippedDate.TabIndex = 53;
            // 
            // txtTotalAmount
            // 
            this.txtTotalAmount.Location = new System.Drawing.Point(166, 218);
            this.txtTotalAmount.Name = "txtTotalAmount";
            this.txtTotalAmount.ReadOnly = true;
            this.txtTotalAmount.Size = new System.Drawing.Size(130, 20);
            this.txtTotalAmount.TabIndex = 54;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(81, 219);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 55;
            this.label1.Text = "Total Amount:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(302, 192);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 13);
            this.label2.TabIndex = 56;
            this.label2.Text = "unchecked means null";
            // 
            // orderBindingSource
            // 
            this.orderBindingSource.DataSource = typeof(Lingyan_Li_CPRG200_Lab4.Order);
            // 
            // orderDetailBindingSource
            // 
            this.orderDetailBindingSource.DataSource = typeof(Lingyan_Li_CPRG200_Lab4.OrderDetail);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 504);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTotalAmount);
            this.Controls.Add(customerIDLabel);
            this.Controls.Add(this.txtcustomerID);
            this.Controls.Add(orderDateLabel);
            this.Controls.Add(this.txtOrderDate);
            this.Controls.Add(orderIDLabel);
            this.Controls.Add(this.orderIDComboBox);
            this.Controls.Add(requiredDateLabel);
            this.Controls.Add(this.txtRequiredDate);
            this.Controls.Add(shippedDateLabel);
            this.Controls.Add(this.dtpShippedDate);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.lvOrdDetails);
            this.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.orderBindingSource, "OrderID", true));
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderDetailBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource orderBindingSource;
        private System.Windows.Forms.BindingSource orderDetailBindingSource;
        private System.Windows.Forms.ListView lvOrdDetails;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txtcustomerID;
        private System.Windows.Forms.TextBox txtOrderDate;
        private System.Windows.Forms.ComboBox orderIDComboBox;
        private System.Windows.Forms.TextBox txtRequiredDate;
        private System.Windows.Forms.DateTimePicker dtpShippedDate;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.TextBox txtTotalAmount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

