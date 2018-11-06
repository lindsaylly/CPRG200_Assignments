namespace lab1_ElecBill
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
            this.txtUsage = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.txtCharge = new System.Windows.Forms.TextBox();
            this.lblUsage = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnRdl = new System.Windows.Forms.RadioButton();
            this.btnCml = new System.Windows.Forms.RadioButton();
            this.btnIdl = new System.Windows.Forms.RadioButton();
            this.txtOffPeakUsage = new System.Windows.Forms.TextBox();
            this.lblOffpeak = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblOffpeakUnit = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtUsage
            // 
            this.txtUsage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsage.Location = new System.Drawing.Point(219, 43);
            this.txtUsage.Name = "txtUsage";
            this.txtUsage.Size = new System.Drawing.Size(145, 26);
            this.txtUsage.TabIndex = 0;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(186, 379);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(104, 29);
            this.btnCalculate.TabIndex = 2;
            this.btnCalculate.Text = "&Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // txtCharge
            // 
            this.txtCharge.BackColor = System.Drawing.Color.Bisque;
            this.txtCharge.Enabled = false;
            this.txtCharge.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCharge.Location = new System.Drawing.Point(219, 162);
            this.txtCharge.Name = "txtCharge";
            this.txtCharge.Size = new System.Drawing.Size(145, 26);
            this.txtCharge.TabIndex = 3;
            // 
            // lblUsage
            // 
            this.lblUsage.AutoSize = true;
            this.lblUsage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsage.Location = new System.Drawing.Point(48, 43);
            this.lblUsage.Name = "lblUsage";
            this.lblUsage.Size = new System.Drawing.Size(99, 20);
            this.lblUsage.TabIndex = 4;
            this.lblUsage.Text = "Your usage: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(46, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Total charge:";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(524, 379);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(104, 29);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "&Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(353, 379);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(104, 29);
            this.btnClear.TabIndex = 7;
            this.btnClear.Text = "&Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnRdl
            // 
            this.btnRdl.AutoSize = true;
            this.btnRdl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRdl.Location = new System.Drawing.Point(27, 63);
            this.btnRdl.Name = "btnRdl";
            this.btnRdl.Size = new System.Drawing.Size(106, 24);
            this.btnRdl.TabIndex = 8;
            this.btnRdl.TabStop = true;
            this.btnRdl.Text = "Residential";
            this.btnRdl.UseVisualStyleBackColor = true;
            this.btnRdl.CheckedChanged += new System.EventHandler(this.btnRdl_CheckedChanged);
            // 
            // btnCml
            // 
            this.btnCml.AutoSize = true;
            this.btnCml.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCml.Location = new System.Drawing.Point(27, 104);
            this.btnCml.Name = "btnCml";
            this.btnCml.Size = new System.Drawing.Size(107, 24);
            this.btnCml.TabIndex = 9;
            this.btnCml.TabStop = true;
            this.btnCml.Text = "Commertial";
            this.btnCml.UseVisualStyleBackColor = true;
            this.btnCml.CheckedChanged += new System.EventHandler(this.btnCml_CheckedChanged);
            // 
            // btnIdl
            // 
            this.btnIdl.AutoSize = true;
            this.btnIdl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIdl.Location = new System.Drawing.Point(27, 148);
            this.btnIdl.Name = "btnIdl";
            this.btnIdl.Size = new System.Drawing.Size(92, 24);
            this.btnIdl.TabIndex = 10;
            this.btnIdl.TabStop = true;
            this.btnIdl.Text = "Industrial";
            this.btnIdl.UseVisualStyleBackColor = true;
            this.btnIdl.CheckedChanged += new System.EventHandler(this.btnIdl_CheckedChanged);
            // 
            // txtOffPeakUsage
            // 
            this.txtOffPeakUsage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOffPeakUsage.Location = new System.Drawing.Point(219, 93);
            this.txtOffPeakUsage.Name = "txtOffPeakUsage";
            this.txtOffPeakUsage.Size = new System.Drawing.Size(145, 26);
            this.txtOffPeakUsage.TabIndex = 14;
            // 
            // lblOffpeak
            // 
            this.lblOffpeak.AutoSize = true;
            this.lblOffpeak.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOffpeak.Location = new System.Drawing.Point(46, 93);
            this.lblOffpeak.Name = "lblOffpeak";
            this.lblOffpeak.Size = new System.Drawing.Size(167, 20);
            this.lblOffpeak.TabIndex = 15;
            this.lblOffpeak.Text = "Off-peak hours usage:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnIdl);
            this.groupBox1.Controls.Add(this.btnCml);
            this.groupBox1.Controls.Add(this.btnRdl);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(72, 112);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(192, 229);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Customer type:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.lblOffpeakUnit);
            this.groupBox2.Controls.Add(this.lblOffpeak);
            this.groupBox2.Controls.Add(this.txtOffPeakUsage);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.lblUsage);
            this.groupBox2.Controls.Add(this.txtCharge);
            this.groupBox2.Controls.Add(this.txtUsage);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(275, 112);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(428, 229);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Customer Bill";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(370, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 20);
            this.label4.TabIndex = 18;
            this.label4.Text = "kWh";
            // 
            // lblOffpeakUnit
            // 
            this.lblOffpeakUnit.AutoSize = true;
            this.lblOffpeakUnit.Location = new System.Drawing.Point(370, 96);
            this.lblOffpeakUnit.Name = "lblOffpeakUnit";
            this.lblOffpeakUnit.Size = new System.Drawing.Size(41, 20);
            this.lblOffpeakUnit.TabIndex = 17;
            this.lblOffpeakUnit.Text = "kWh";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(270, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(254, 28);
            this.label3.TabIndex = 18;
            this.label3.Text = "City Power Company";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCalculate);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUsage;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.TextBox txtCharge;
        private System.Windows.Forms.Label lblUsage;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.RadioButton btnRdl;
        private System.Windows.Forms.RadioButton btnCml;
        private System.Windows.Forms.RadioButton btnIdl;
        private System.Windows.Forms.TextBox txtOffPeakUsage;
        private System.Windows.Forms.Label lblOffpeak;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblOffpeakUnit;
        private System.Windows.Forms.Label label3;
    }
}

