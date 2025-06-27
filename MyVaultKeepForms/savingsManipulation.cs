using MyVaultCommon;
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
            string name = name_txbx.Text.Trim();

            if (double.TryParse(amount_txbx.Text, out double amount) && amount <= MyVaultDetails.Balance)
            {
                
                if (string.IsNullOrWhiteSpace(name))
                {
                    MessageBox.Show("Please enter a valid savings name.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                bool success = Functions_BusinessLogic.SavingsProcess.createSavings(Functions_BusinessLogic.TransactionActions.Savings, name, amount);

                if (success)
                {
                    MessageBox.Show($"Successfully added {amount.ToString("C2")} to '{name}' savings.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    amount_txbx.Clear();
                    name_txbx.Clear();
                }
                else
                {
                    MessageBox.Show("Transaction failed. Insufficient balance.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }else if (amount > MyVaultDetails.Balance)
            {
                MessageBox.Show("Transaction failed. Insufficient balance.", "Insufficient Balance", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
 }

        private void update_btn_Click(object sender, EventArgs e)
        {
            string name = name_txbx.Text.Trim();

            if (string.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("Please enter a valid savings name.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!double.TryParse(amount_txbx.Text, out double amount) || amount <= 0)
            {
                MessageBox.Show("Please enter a valid, positive amount.", "Invalid Amount", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (amount > MyVaultDetails.Balance)
            {
                MessageBox.Show("Transaction failed. Insufficient balance.", "Insufficient Balance", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            List<string> savingsList = Functions_DataLogic.MyVaultData.GetSavingsList();
            double existingAmount = 0;
            bool found = false;

            foreach (var entry in savingsList)
            {
                if (entry.StartsWith(name + " PHP:"))
                {
                    string[] parts = entry.Split("PHP: ");
                    if (parts.Length == 2 && double.TryParse(parts[1], out double parsedAmount))
                    {
                        existingAmount = parsedAmount;
                        found = true;
                        break;
                    }
                }
            }

            if (!found)
            {
                MessageBox.Show($"Savings with name '{name}' was not found.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            double newTotal = existingAmount + amount;

            bool success = Functions_BusinessLogic.SavingsProcess.updateSavings(
                Functions_BusinessLogic.TransactionActions.Savings,
                name,
                name,
                newTotal);

            if (success)
            {
                MyVaultDetails.Balance -= amount; 
                MessageBox.Show($"Successfully added {amount.ToString("C2")} to '{name}' savings. New Total: {newTotal.ToString("C2")}",
                                "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                amount_txbx.Clear();
                name_txbx.Clear();
            }
            else
            {
                MessageBox.Show("Failed to update savings.", "Update Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            string name = name_txbx.Text.Trim();

            if (string.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("Please enter a valid savings name to delete.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var confirm = MessageBox.Show($"Are you sure you want to delete '{name}' savings?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (confirm == DialogResult.Yes)
            {

                List<string> savingsList = Functions_DataLogic.MyVaultData.GetSavingsList();
                double amountToRestore = 0;

                foreach (var entry in savingsList)
                {
                    if (entry.StartsWith(name + " PHP:"))
                    {
                        string[] parts = entry.Split("PHP: ");
                        if (parts.Length == 2 && double.TryParse(parts[1], out double parsedAmount))
                        {
                            amountToRestore = parsedAmount;
                            break;
                        }
                    }
                }

                bool success = Functions_BusinessLogic.SavingsProcess.deleteSavings(Functions_BusinessLogic.TransactionActions.Savings, name, amountToRestore);

                if (success)
                {
                    MessageBox.Show($"Successfully deleted '{name}' savings and returned {amountToRestore.ToString("C2")} to your balance.",
                                    "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    amount_txbx.Clear();
                    name_txbx.Clear();
                }
                else
                {
                    MessageBox.Show("Savings not found or could not be deleted.", "Delete Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }
    }
}
