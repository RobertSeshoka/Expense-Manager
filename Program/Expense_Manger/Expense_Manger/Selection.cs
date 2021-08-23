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
    public partial class Selection : Form
    {
        public Selection()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {

            //Opens expense menager form
            this.Hide();
            Expense_menager em = new Expense_menager();
            em.ShowDialog();
        }

    

        private void btnVehicle_Click(object sender, EventArgs e)
        {
            //Opens buy vehicle form
            this.Hide();
            Buy_vehicle property = new Buy_vehicle();
            property.ShowDialog();
        }
    }
}
