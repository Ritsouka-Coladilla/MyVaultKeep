using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyVaultKeepForms
{
    public partial class savingsManipulation : Form
    {
        public savingsManipulation()
        {
            InitializeComponent();
        }

        private void savingsManipulation_Load(object sender, EventArgs e)
        {

        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            mainDashboard dashboard = new mainDashboard();
            dashboard.Show();
            this.Hide();
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            if (double.TryParse(amount_txbx.Text, out double amount) && amount > 0)
            {
                string name = name_txbx.Text.Trim();

                if (string.IsNullOrWhiteSpace(name))
                {
                    MessageBox.Show("Please enter a valid savings name.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                Functions_DataLogic.MyVaultData.SetName(name);

                bool success = Functions_BusinessLogic.SavingsProcess.createSavings(Functions_BusinessLogic.TransactionActions.Savings,amount);

                if (success)
                {
                    MessageBox.Show($"Successfully added {amount.ToString("C2")} to '{name}' savings.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    amount_txbx.Clear();
                    name_txbx.Clear();
                }
                else
                {
                    MessageBox.Show("Transaction failed. Insufficient balance.");
                }
            }
        }

        private void update_btn_Click(object sender, EventArgs e)
        {

        }

        private void delete_btn_Click(object sender, EventArgs e)
        {

        }
    }
}
