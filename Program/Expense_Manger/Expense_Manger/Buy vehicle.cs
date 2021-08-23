using DLL_Program;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Expense_Manger
{
    public partial class Buy_vehicle : Form
    {
        public Buy_vehicle()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {

            //Goes to selection form
            this.Hide();
            Selection sl = new Selection();
            sl.Show();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {

            try
            {
                //Object of dll class
                Class_Library classLi = new Class_Library();



                int values = (int.Parse(txtBxModelCar.Text) + int.Parse(txtBxTotalDeposit.Text) / 100 * int.Parse(txtBxPriceVehicle.Text) +
                    int.Parse(txtBxRate.Text) / 100 + int.Parse(txtYears.Text) + int.Parse(txtBxLoan.Text));

                txtBxTotalCost.Text = values.ToString();

            }
            catch (Exception message)
            {
                MessageBox.Show(message.Message);
            }
        }

        private void btnSaveVehicle_Click(object sender, EventArgs e)
        {

            //Checks empty fields
            if (txtBxEstimatedInsurance.Text.Equals("") || txtBxLoan.Text.Equals("") || txtBxModelCar.Text.Equals("") ||
              txtBxPriceVehicle.Text.Equals("") || txtBxLoan.Text.Equals("") || txtBxRate.Text.Equals("") || txtBxTotalDeposit.Text.Equals("")
              || txtYears.Text.Equals(""))
            {
                MessageBox.Show("Please check empty fields", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {

                //Saving to collection
                try
                {
                    List<string> saving = new List<string>();

                    saving.Add(txtBxEstimatedInsurance.Text);
                    saving.Add(txtBxLoan.Text);
                    saving.Add(txtBxModelCar.Text);
                    saving.Add(txtBxPriceVehicle.Text);
                    saving.Add(txtBxRate.Text);
                    saving.Add(txtBxTotalDeposit.Text);
                    saving.Add(txtYears.Text);


                    MessageBox.Show("Costs saved!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception message)
                {
                    MessageBox.Show(message.Message);
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
