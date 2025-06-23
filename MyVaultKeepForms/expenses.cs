using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyVaultCommon;
using Functions_BusinessLogic;

namespace MyVaultKeepForms
{
    public partial class expenses : Form
    {
        public expenses()
        {
            InitializeComponent();
        }

        private void expenses_Load(object sender, EventArgs e)
        {
            // Populate ComboBox with expense types
            expenses_cmbx.Items.Clear();
            expenses_cmbx.Items.AddRange(new string[]
            {
                "Food/Groceries",
                "Transportation",
                "Utilities",
                "Rent",
                "Others"
            });
            expenses_cmbx.SelectedIndex = 0; 
        }

        private void confirm_btn_Click(object sender, EventArgs e)
        {
            if (double.TryParse(amount_txbx.Text, out double amount) && amount > 0)
            {
                MyVaultDetails.EnterExpenses = expenses_cmbx.SelectedIndex + 1; 

                bool success = ExpensesProcess.initializeExpenses(TransactionActions.Expenses, amount);

                if (success)
                {
                    MessageBox.Show("Expense recorded successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    amount_txbx.Clear();
                    mainDashboard dashboard = new mainDashboard();
                    dashboard.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Insufficient balance or invalid input.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid numeric amount.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            mainDashboard dashboard = new mainDashboard();
            dashboard.Show();
            this.Hide();
        }

        private void expenses_cmbx_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
