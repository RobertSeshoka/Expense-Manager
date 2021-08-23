namespace Expense_Manger
{
    partial class Expense_menager
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
            this.txtBxTax = new System.Windows.Forms.TextBox();
            this.txtBxIncome = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.txtMontlyRent = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnSaving = new System.Windows.Forms.Button();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.txtBxTotalExpenses = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.txtBxOthersEp = new System.Windows.Forms.TextBox();
            this.txtBxCellPhoneBill = new System.Windows.Forms.TextBox();
            this.txtBxTravelCosts = new System.Windows.Forms.TextBox();
            this.txtBxWaterLights = new System.Windows.Forms.TextBox();
            this.txtBxGroce = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.btnSelections = new System.Windows.Forms.Button();
            this.btnSavePropertyInfo = new System.Windows.Forms.Button();
            this.txtBxTotalProperty = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtBxMonthPAy = new System.Windows.Forms.TextBox();
            this.txtBxInterest = new System.Windows.Forms.TextBox();
            this.txtBxDeposit = new System.Windows.Forms.TextBox();
            this.txtBxPrice = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBxTax
            // 
            this.txtBxTax.BackColor = System.Drawing.Color.White;
            this.txtBxTax.Location = new System.Drawing.Point(262, 66);
            this.txtBxTax.Name = "txtBxTax";
            this.txtBxTax.Size = new System.Drawing.Size(139, 20);
            this.txtBxTax.TabIndex = 35;
            // 
            // txtBxIncome
            // 
            this.txtBxIncome.BackColor = System.Drawing.Color.White;
            this.txtBxIncome.Location = new System.Drawing.Point(262, 21);
            this.txtBxIncome.Name = "txtBxIncome";
            this.txtBxIncome.Size = new System.Drawing.Size(139, 20);
            this.txtBxIncome.TabIndex = 34;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(36, 21);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(143, 32);
            this.label16.TabIndex = 32;
            this.label16.Text = "Gross monthly income \r\n(before deductions). ";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(37, 70);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(197, 16);
            this.label17.TabIndex = 33;
            this.label17.Text = "Estimated monthly tax deducted";
            // 
            // txtMontlyRent
            // 
            this.txtMontlyRent.Location = new System.Drawing.Point(262, 280);
            this.txtMontlyRent.Name = "txtMontlyRent";
            this.txtMontlyRent.Size = new System.Drawing.Size(139, 20);
            this.txtMontlyRent.TabIndex = 53;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(39, 283);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 16);
            this.label8.TabIndex = 52;
            this.label8.Text = "Rent";
            // 
            // btnSaving
            // 
            this.btnSaving.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.btnSaving.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSaving.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSaving.Location = new System.Drawing.Point(53, 358);
            this.btnSaving.Name = "btnSaving";
            this.btnSaving.Size = new System.Drawing.Size(130, 39);
            this.btnSaving.TabIndex = 51;
            this.btnSaving.Text = "Save";
            this.btnSaving.UseVisualStyleBackColor = false;
            this.btnSaving.Click += new System.EventHandler(this.btnSaving_Click);
            // 
            // btnCalculate
            // 
            this.btnCalculate.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.btnCalculate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCalculate.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCalculate.Location = new System.Drawing.Point(264, 358);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(130, 39);
            this.btnCalculate.TabIndex = 50;
            this.btnCalculate.Text = "Calculate ";
            this.btnCalculate.UseVisualStyleBackColor = false;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click_1);
            // 
            // txtBxTotalExpenses
            // 
            this.txtBxTotalExpenses.Enabled = false;
            this.txtBxTotalExpenses.Location = new System.Drawing.Point(264, 318);
            this.txtBxTotalExpenses.Name = "txtBxTotalExpenses";
            this.txtBxTotalExpenses.Size = new System.Drawing.Size(139, 20);
            this.txtBxTotalExpenses.TabIndex = 49;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(39, 324);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(42, 16);
            this.label18.TabIndex = 48;
            this.label18.Text = "Total:";
            // 
            // txtBxOthersEp
            // 
            this.txtBxOthersEp.Location = new System.Drawing.Point(262, 247);
            this.txtBxOthersEp.Name = "txtBxOthersEp";
            this.txtBxOthersEp.Size = new System.Drawing.Size(139, 20);
            this.txtBxOthersEp.TabIndex = 47;
            // 
            // txtBxCellPhoneBill
            // 
            this.txtBxCellPhoneBill.Location = new System.Drawing.Point(262, 213);
            this.txtBxCellPhoneBill.Name = "txtBxCellPhoneBill";
            this.txtBxCellPhoneBill.Size = new System.Drawing.Size(139, 20);
            this.txtBxCellPhoneBill.TabIndex = 46;
            // 
            // txtBxTravelCosts
            // 
            this.txtBxTravelCosts.Location = new System.Drawing.Point(262, 179);
            this.txtBxTravelCosts.Name = "txtBxTravelCosts";
            this.txtBxTravelCosts.Size = new System.Drawing.Size(139, 20);
            this.txtBxTravelCosts.TabIndex = 45;
            // 
            // txtBxWaterLights
            // 
            this.txtBxWaterLights.Location = new System.Drawing.Point(262, 141);
            this.txtBxWaterLights.Name = "txtBxWaterLights";
            this.txtBxWaterLights.Size = new System.Drawing.Size(139, 20);
            this.txtBxWaterLights.TabIndex = 44;
            // 
            // txtBxGroce
            // 
            this.txtBxGroce.Location = new System.Drawing.Point(262, 106);
            this.txtBxGroce.Name = "txtBxGroce";
            this.txtBxGroce.Size = new System.Drawing.Size(139, 20);
            this.txtBxGroce.TabIndex = 42;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClear.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnClear.Location = new System.Drawing.Point(53, 424);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(130, 34);
            this.btnClear.TabIndex = 43;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(37, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 16);
            this.label3.TabIndex = 36;
            this.label3.Text = "Groceries ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(37, 249);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 16);
            this.label6.TabIndex = 41;
            this.label6.Text = "Other expenses";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(37, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 16);
            this.label4.TabIndex = 37;
            this.label4.Text = "Water and lights";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(37, 212);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(158, 16);
            this.label5.TabIndex = 40;
            this.label5.Text = "Cell phoneand& telephone";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(37, 178);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(183, 16);
            this.label7.TabIndex = 39;
            this.label7.Text = "Travel costs (including petrol)";
            // 
            // btnSelections
            // 
            this.btnSelections.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.btnSelections.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSelections.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSelections.Location = new System.Drawing.Point(262, 424);
            this.btnSelections.Name = "btnSelections";
            this.btnSelections.Size = new System.Drawing.Size(130, 34);
            this.btnSelections.TabIndex = 54;
            this.btnSelections.Text = "Selections";
            this.btnSelections.UseVisualStyleBackColor = false;
            this.btnSelections.Click += new System.EventHandler(this.btnSelections_Click);
            // 
            // btnSavePropertyInfo
            // 
            this.btnSavePropertyInfo.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.btnSavePropertyInfo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSavePropertyInfo.ForeColor = System.Drawing.Color.Black;
            this.btnSavePropertyInfo.Location = new System.Drawing.Point(239, 813);
            this.btnSavePropertyInfo.Name = "btnSavePropertyInfo";
            this.btnSavePropertyInfo.Size = new System.Drawing.Size(76, 32);
            this.btnSavePropertyInfo.TabIndex = 67;
            this.btnSavePropertyInfo.Text = "Save ";
            this.btnSavePropertyInfo.UseVisualStyleBackColor = false;
            this.btnSavePropertyInfo.Click += new System.EventHandler(this.btnSavePropertyInfo_Click);
            // 
            // txtBxTotalProperty
            // 
            this.txtBxTotalProperty.Enabled = false;
            this.txtBxTotalProperty.Location = new System.Drawing.Point(145, 752);
            this.txtBxTotalProperty.Name = "txtBxTotalProperty";
            this.txtBxTotalProperty.Size = new System.Drawing.Size(153, 20);
            this.txtBxTotalProperty.TabIndex = 66;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(50, 756);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(42, 16);
            this.label20.TabIndex = 65;
            this.label20.Text = "Total:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.button1.Enabled = false;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(52, 813);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 32);
            this.button1.TabIndex = 64;
            this.button1.Text = "Compute";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtBxMonthPAy
            // 
            this.txtBxMonthPAy.Location = new System.Drawing.Point(38, 702);
            this.txtBxMonthPAy.Name = "txtBxMonthPAy";
            this.txtBxMonthPAy.Size = new System.Drawing.Size(153, 20);
            this.txtBxMonthPAy.TabIndex = 63;
            // 
            // txtBxInterest
            // 
            this.txtBxInterest.Location = new System.Drawing.Point(239, 624);
            this.txtBxInterest.Name = "txtBxInterest";
            this.txtBxInterest.Size = new System.Drawing.Size(153, 20);
            this.txtBxInterest.TabIndex = 62;
            // 
            // txtBxDeposit
            // 
            this.txtBxDeposit.Location = new System.Drawing.Point(239, 702);
            this.txtBxDeposit.Name = "txtBxDeposit";
            this.txtBxDeposit.Size = new System.Drawing.Size(153, 20);
            this.txtBxDeposit.TabIndex = 61;
            // 
            // txtBxPrice
            // 
            this.txtBxPrice.Location = new System.Drawing.Point(38, 624);
            this.txtBxPrice.Name = "txtBxPrice";
            this.txtBxPrice.Size = new System.Drawing.Size(153, 20);
            this.txtBxPrice.TabIndex = 60;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(28, 668);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(171, 32);
            this.label10.TabIndex = 59;
            this.label10.Text = "Number of months to repay \r\n(between 240 and 360)";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(236, 590);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(163, 16);
            this.label9.TabIndex = 58;
            this.label9.Text = "Interest rate (percentage). ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(236, 683);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 16);
            this.label1.TabIndex = 57;
            this.label1.Text = "Total deposit (%)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(35, 595);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 16);
            this.label2.TabIndex = 56;
            this.label2.Text = "Purchase price of property";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(127, 548);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(131, 24);
            this.label11.TabIndex = 69;
            this.label11.Text = "Buy property";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(35, 505);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(314, 24);
            this.label12.TabIndex = 70;
            this.label12.Text = "--------------------------------------";
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnExit.Location = new System.Drawing.Point(167, 464);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(130, 34);
            this.btnExit.TabIndex = 71;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Expense_menager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(427, 513);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btnSavePropertyInfo);
            this.Controls.Add(this.txtBxTotalProperty);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtBxMonthPAy);
            this.Controls.Add(this.txtBxInterest);
            this.Controls.Add(this.txtBxDeposit);
            this.Controls.Add(this.txtBxPrice);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSelections);
            this.Controls.Add(this.txtMontlyRent);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnSaving);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtBxTotalExpenses);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.txtBxOthersEp);
            this.Controls.Add(this.txtBxCellPhoneBill);
            this.Controls.Add(this.txtBxTravelCosts);
            this.Controls.Add(this.txtBxWaterLights);
            this.Controls.Add(this.txtBxGroce);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtBxTax);
            this.Controls.Add(this.txtBxIncome);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label17);
            this.Name = "Expense_menager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Expense_menager";
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource bindingSource1;
        public System.Windows.Forms.TextBox txtBxTax;
        protected System.Windows.Forms.TextBox txtBxIncome;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        public System.Windows.Forms.TextBox txtMontlyRent;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnSaving;
        private System.Windows.Forms.Button btnCalculate;
        public System.Windows.Forms.TextBox txtBxTotalExpenses;
        private System.Windows.Forms.Label label18;
        public System.Windows.Forms.TextBox txtBxOthersEp;
        public System.Windows.Forms.TextBox txtBxCellPhoneBill;
        public System.Windows.Forms.TextBox txtBxTravelCosts;
        public System.Windows.Forms.TextBox txtBxWaterLights;
        public System.Windows.Forms.TextBox txtBxGroce;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnSelections;
        private System.Windows.Forms.Button btnSavePropertyInfo;
        private System.Windows.Forms.TextBox txtBxTotalProperty;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtBxMonthPAy;
        private System.Windows.Forms.TextBox txtBxInterest;
        private System.Windows.Forms.TextBox txtBxDeposit;
        private System.Windows.Forms.TextBox txtBxPrice;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnExit;
    }
}