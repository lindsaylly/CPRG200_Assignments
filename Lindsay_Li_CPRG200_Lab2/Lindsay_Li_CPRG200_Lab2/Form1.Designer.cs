namespace Lindsay_Li_CPRG200_Lab2
{
    partial class frmCustomers
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
            this.lstCustomers = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbCustomerType = new System.Windows.Forms.ComboBox();
            this.txtAccountNo = new System.Windows.Forms.TextBox();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblOffPeakUnit = new System.Windows.Forms.Label();
            this.txtOffPeakUsage = new System.Windows.Forms.TextBox();
            this.lblOffPeak = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtUsage = new System.Windows.Forms.TextBox();
            this.lblUsage = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblIdlSumCharge = new System.Windows.Forms.Label();
            this.lblCmlSumCharge = new System.Windows.Forms.Label();
            this.lblRdlSumCharge = new System.Windows.Forms.Label();
            this.lblSumCharge = new System.Windows.Forms.Label();
            this.lblCustomerNum = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstCustomers
            // 
            this.lstCustomers.FormattingEnabled = true;
            this.lstCustomers.ItemHeight = 20;
            this.lstCustomers.Location = new System.Drawing.Point(476, 117);
            this.lstCustomers.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lstCustomers.Name = "lstCustomers";
            this.lstCustomers.Size = new System.Drawing.Size(350, 524);
            this.lstCustomers.Sorted = true;
            this.lstCustomers.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 121);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Customer Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(80, 81);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "AccountNo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 36);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Customer Type";
            // 
            // cmbCustomerType
            // 
            this.cmbCustomerType.FormattingEnabled = true;
            this.cmbCustomerType.Items.AddRange(new object[] {
            "Commercial",
            "Industrial",
            "Residential"});
            this.cmbCustomerType.Location = new System.Drawing.Point(184, 36);
            this.cmbCustomerType.Name = "cmbCustomerType";
            this.cmbCustomerType.Size = new System.Drawing.Size(136, 28);
            this.cmbCustomerType.Sorted = true;
            this.cmbCustomerType.TabIndex = 4;
            this.cmbCustomerType.SelectedIndexChanged += new System.EventHandler(this.cmbCustomerType_SelectedIndexChanged);
            // 
            // txtAccountNo
            // 
            this.txtAccountNo.Location = new System.Drawing.Point(184, 78);
            this.txtAccountNo.Name = "txtAccountNo";
            this.txtAccountNo.Size = new System.Drawing.Size(136, 26);
            this.txtAccountNo.TabIndex = 5;
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Location = new System.Drawing.Point(184, 121);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(136, 26);
            this.txtCustomerName.TabIndex = 6;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnAdd.Location = new System.Drawing.Point(23, 267);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(92, 35);
            this.btnAdd.TabIndex = 13;
            this.btnAdd.Text = "&Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(303, 25);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(306, 32);
            this.label8.TabIndex = 16;
            this.label8.Text = "City Powder Company";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnExit);
            this.groupBox1.Controls.Add(this.btnClear);
            this.groupBox1.Controls.Add(this.lblOffPeakUnit);
            this.groupBox1.Controls.Add(this.txtCustomerName);
            this.groupBox1.Controls.Add(this.txtOffPeakUsage);
            this.groupBox1.Controls.Add(this.cmbCustomerType);
            this.groupBox1.Controls.Add(this.txtAccountNo);
            this.groupBox1.Controls.Add(this.lblOffPeak);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtUsage);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lblUsage);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Location = new System.Drawing.Point(52, 76);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(388, 324);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "New Customer";
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Goldenrod;
            this.btnExit.Location = new System.Drawing.Point(275, 267);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(92, 35);
            this.btnExit.TabIndex = 15;
            this.btnExit.Text = "&Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.YellowGreen;
            this.btnClear.Location = new System.Drawing.Point(152, 267);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(92, 35);
            this.btnClear.TabIndex = 14;
            this.btnClear.Text = "&Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lblOffPeakUnit
            // 
            this.lblOffPeakUnit.AutoSize = true;
            this.lblOffPeakUnit.Location = new System.Drawing.Point(326, 218);
            this.lblOffPeakUnit.Name = "lblOffPeakUnit";
            this.lblOffPeakUnit.Size = new System.Drawing.Size(41, 20);
            this.lblOffPeakUnit.TabIndex = 12;
            this.lblOffPeakUnit.Text = "kWh";
            // 
            // txtOffPeakUsage
            // 
            this.txtOffPeakUsage.Location = new System.Drawing.Point(184, 212);
            this.txtOffPeakUsage.Name = "txtOffPeakUsage";
            this.txtOffPeakUsage.Size = new System.Drawing.Size(136, 26);
            this.txtOffPeakUsage.TabIndex = 11;
            // 
            // lblOffPeak
            // 
            this.lblOffPeak.AutoSize = true;
            this.lblOffPeak.Location = new System.Drawing.Point(8, 218);
            this.lblOffPeak.Name = "lblOffPeak";
            this.lblOffPeak.Size = new System.Drawing.Size(169, 20);
            this.lblOffPeak.TabIndex = 10;
            this.lblOffPeak.Text = "Off-peak Hours Usage";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(326, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "kWh";
            // 
            // txtUsage
            // 
            this.txtUsage.Location = new System.Drawing.Point(184, 167);
            this.txtUsage.Name = "txtUsage";
            this.txtUsage.Size = new System.Drawing.Size(136, 26);
            this.txtUsage.TabIndex = 8;
            // 
            // lblUsage
            // 
            this.lblUsage.Location = new System.Drawing.Point(24, 170);
            this.lblUsage.Name = "lblUsage";
            this.lblUsage.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblUsage.Size = new System.Drawing.Size(147, 20);
            this.lblUsage.TabIndex = 7;
            this.lblUsage.Text = "Overall Usage";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(63, 78);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(158, 20);
            this.label9.TabIndex = 18;
            this.label9.Text = "Sum Charge Amount";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(136, 32);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(87, 20);
            this.label10.TabIndex = 20;
            this.label10.Text = "#Customer";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(19, 122);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(204, 20);
            this.label11.TabIndex = 22;
            this.label11.Text = "Residential Charge Amount";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(17, 164);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(208, 20);
            this.label12.TabIndex = 23;
            this.label12.Text = "Commercial Charge Amount";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(37, 206);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(190, 20);
            this.label13.TabIndex = 24;
            this.label13.Text = "Industrial Charge Amount";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblIdlSumCharge);
            this.groupBox2.Controls.Add(this.lblCmlSumCharge);
            this.groupBox2.Controls.Add(this.lblRdlSumCharge);
            this.groupBox2.Controls.Add(this.lblSumCharge);
            this.groupBox2.Controls.Add(this.lblCustomerNum);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Location = new System.Drawing.Point(52, 415);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(388, 250);
            this.groupBox2.TabIndex = 28;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Summary";
            // 
            // lblIdlSumCharge
            // 
            this.lblIdlSumCharge.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblIdlSumCharge.Location = new System.Drawing.Point(237, 204);
            this.lblIdlSumCharge.Name = "lblIdlSumCharge";
            this.lblIdlSumCharge.Size = new System.Drawing.Size(111, 32);
            this.lblIdlSumCharge.TabIndex = 29;
            // 
            // lblCmlSumCharge
            // 
            this.lblCmlSumCharge.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCmlSumCharge.Location = new System.Drawing.Point(237, 163);
            this.lblCmlSumCharge.Name = "lblCmlSumCharge";
            this.lblCmlSumCharge.Size = new System.Drawing.Size(111, 32);
            this.lblCmlSumCharge.TabIndex = 28;
            // 
            // lblRdlSumCharge
            // 
            this.lblRdlSumCharge.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblRdlSumCharge.Location = new System.Drawing.Point(237, 121);
            this.lblRdlSumCharge.Name = "lblRdlSumCharge";
            this.lblRdlSumCharge.Size = new System.Drawing.Size(111, 32);
            this.lblRdlSumCharge.TabIndex = 27;
            // 
            // lblSumCharge
            // 
            this.lblSumCharge.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSumCharge.Location = new System.Drawing.Point(237, 77);
            this.lblSumCharge.Name = "lblSumCharge";
            this.lblSumCharge.Size = new System.Drawing.Size(111, 32);
            this.lblSumCharge.TabIndex = 26;
            // 
            // lblCustomerNum
            // 
            this.lblCustomerNum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCustomerNum.Location = new System.Drawing.Point(237, 31);
            this.lblCustomerNum.Name = "lblCustomerNum";
            this.lblCustomerNum.Size = new System.Drawing.Size(111, 32);
            this.lblCustomerNum.TabIndex = 25;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(472, 92);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(259, 20);
            this.label7.TabIndex = 29;
            this.label7.Text = "Customer List With Charge Amount";
            // 
            // frmCustomers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.ClientSize = new System.Drawing.Size(898, 692);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lstCustomers);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmCustomers";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmCustomers_FormClosing);
            this.Load += new System.EventHandler(this.frmCustomers_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstCustomers;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbCustomerType;
        private System.Windows.Forms.TextBox txtAccountNo;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblOffPeakUnit;
        private System.Windows.Forms.TextBox txtOffPeakUsage;
        private System.Windows.Forms.Label lblOffPeak;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtUsage;
        private System.Windows.Forms.Label lblUsage;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblCustomerNum;
        private System.Windows.Forms.Label lblIdlSumCharge;
        private System.Windows.Forms.Label lblCmlSumCharge;
        private System.Windows.Forms.Label lblRdlSumCharge;
        private System.Windows.Forms.Label lblSumCharge;
    }
}

