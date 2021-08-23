using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using DLL_Program;

namespace Expense_Manger
{
    public partial class Expense_menager : Form
    {

        public static List<int> saveCosts = new List<int>();
        public static List<int> monthlyExpenses = new List<int>();
        public Expense_menager()
        {
            InitializeComponent();
        }

  

        private void btnSelections_Click(object sender, EventArgs e)
        {

            //Opens the selections form
            this.Hide();
            Selection select = new Selection();
            select.ShowDialog();
        }

        private void btnCalculate_Click_1(object sender, EventArgs e)
        {

            if (txtBxIncome.Text.Equals("") || txtBxTax.Text.Equals("")
                || txtBxGroce.Text.Equals("") || txtBxWaterLights.Text.Equals("") ||
                txtBxTravelCosts.Text.Equals("") || txtBxCellPhoneBill.Text.Equals("") || txtBxOthersEp.Text.Equals("")
                || txtMontlyRent.Text.Equals(""))
            {
                MessageBox.Show("Check empty text area!", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                //Create an object class of the dll class library
                Class_Library library = new Class_Library();

                try
                {
                    int getValues;


                    //Accessing the method from the  dll class library
                    getValues = library.addMonthlyExpenses(int.Parse(txtBxIncome.Text), int.Parse(txtBxTax.Text)
                        , int.Parse(txtBxGroce.Text), int.Parse(txtBxWaterLights.Text)
                        , int.Parse(txtBxTravelCosts.Text), int.Parse(txtBxCellPhoneBill.Text)
                        , int.Parse(txtBxOthersEp.Text), int.Parse(txtMontlyRent.Text));


                    //shows the total
                    txtBxTotalExpenses.Text = getValues.ToString();
                }
                catch (Exception a)
                {
                    MessageBox.Show(a.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
              
        }

        private void btnSaving_Click(object sender, EventArgs e)
        {
            //SAving


            if (txtBxIncome.Text.Equals("") || txtBxTax.Text.Equals("")
                || txtBxGroce.Text.Equals("") || txtBxWaterLights.Text.Equals("") ||
                txtBxTravelCosts.Text.Equals("") || txtBxCellPhoneBill.Text.Equals("") || txtBxOthersEp.Text.Equals("")
                || txtMontlyRent.Text.Equals(""))
            {
                MessageBox.Show("Check empty text area!", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                try
                {
                   

                    monthlyExpenses.Add(int.Parse(txtBxIncome.Text));
                    monthlyExpenses.Add(int.Parse(txtBxTax.Text));
                    monthlyExpenses.Add(int.Parse(txtBxGroce.Text));
                    monthlyExpenses.Add(int.Parse(txtBxWaterLights.Text));
                    monthlyExpenses.Add(int.Parse(txtBxTravelCosts.Text));
                    monthlyExpenses.Add(int.Parse(txtBxCellPhoneBill.Text));
                    monthlyExpenses.Add(int.Parse(txtBxOthersEp.Text));
                    monthlyExpenses.Add(int.Parse(txtMontlyRent.Text));
                    monthlyExpenses.Add(int.Parse(txtBxTotalExpenses.Text));

                    MessageBox.Show("Information saved", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);


                    foreach (int v in monthlyExpenses)
                    {

                     
                       
                    }
                }
                catch (Exception mes)
                {

                    MessageBox.Show("Are you sure the total has been saved? " + mes.Message, "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtBxDeposit.Text.Equals("") || txtBxInterest.Text.Equals("")
              || txtBxMonthPAy.Text.Equals("") || txtBxPrice.Text.Equals(""))
            {
                MessageBox.Show("Cannot calculate with empty fields!", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                //Calculating

                //Object of dll class
                Class_Library CL = new Class_Library();

                try
                {
                    int answer;

                    answer = CL.property_Expenses(int.Parse(txtBxPrice.Text), int.Parse(txtBxDeposit.Text)
                        , int.Parse(txtBxInterest.Text), int.Parse(txtBxMonthPAy.Text));


                    txtBxTotalProperty.Text = answer.ToString();//Shows the calculated amount



                    //Checking for approval
                    if (saveCosts[0] > monthlyExpenses[0])
                    {
                        MessageBox.Show("Approval of the home loan is unlikely", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                    {
                        MessageBox.Show("Approval of the home loan is likely", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void btnSavePropertyInfo_Click(object sender, EventArgs e)
        {
            if (txtBxDeposit.Text.Equals("") || txtBxInterest.Text.Equals("")
               || txtBxMonthPAy.Text.Equals("") || txtBxPrice.Text.Equals(""))
            {
                MessageBox.Show("Cannot proceed with empty fields!", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                //Saving to generic collection
            

                saveCosts.Add(int.Parse(txtBxPrice.Text));
                saveCosts.Add(int.Parse(txtBxMonthPAy.Text));
                saveCosts.Add(int.Parse(txtBxInterest.Text));
                saveCosts.Add(int.Parse(txtBxDeposit.Text));

                MessageBox.Show("Saved successfully!", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);

                button1.Enabled = true;

            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtBxCellPhoneBill.Clear();     
            txtBxGroce.Clear();
            txtBxIncome.Clear();  
            txtBxOthersEp.Clear();
            txtBxTax.Clear();
            txtBxWaterLights.Clear();
            txtMontlyRent.Clear();
            txtBxTravelCosts.Clear();

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
