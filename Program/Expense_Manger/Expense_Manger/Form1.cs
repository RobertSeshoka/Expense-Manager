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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Expense_menager p = new Expense_menager();
            p.ShowDialog();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var print = new welcome.welcomeMessage();
            print.program();

        }
    }



    public abstract class welcome
    {
        public virtual void program()
        {
            
        }



        public class welcomeMessage : welcome
        {
            public override void program()
            {
              
                MessageBox.Show("Welcome to the program that manages expenses", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                base.program();
            }
        }
    }
}
