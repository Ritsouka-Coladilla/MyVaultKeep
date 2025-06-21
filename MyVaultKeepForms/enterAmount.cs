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
    public partial class enterAmount : Form
    {
        public enum TransactionActions
        {
            Deposit,
            Withdraw
        }
        private TransactionActions mode;

        public enterAmount(TransactionActions actions)
        {
            InitializeComponent();
            mode = actions;
        }

        private void enterAmount_Load(object sender, EventArgs e)
        {
            amount_lbl.Text = mode == TransactionActions.Deposit ? "Enter Deposit Amount:" : "Enter Withdrawal Amount:";
        }

        private void enterAmount_btn_Click(object sender, EventArgs e)
        {
            if (double.TryParse(enteredAmount_txbx.Text, out double amount) && amount > 0)
            {
                bool success = Functions_BusinessLogic.DepositAndWithdrawal.VaultProcess(
                     mode == TransactionActions.Deposit
                     ? Functions_BusinessLogic.TransactionActions.Deposit
                     : Functions_BusinessLogic.TransactionActions.Withdraw, amount
 );

                if (success)
                {
                    MessageBox.Show($"Transaction of PHP {amount} was successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Transaction failed. Insufficient balance or invalid input.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }
    }
}

        
    

