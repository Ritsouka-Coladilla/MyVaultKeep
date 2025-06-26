using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using MyVaultCommon;
using Functions_DataLogic;
using Functions_BusinessLogic;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyVaultKeepForms
{
    public partial class mainDashboard : Form
    {
        public mainDashboard()
        {
            InitializeComponent();
        }

        private void mainDashboard_Load(object sender, EventArgs e)
        {
            RefreshCurrentBal();
        }

        private void RefreshCurrentBal()
        {
            displbal_txbx.Text = MyVaultDetails.Balance.ToString("C2");

        }

        private void displbal_txbx_TextChanged(object sender, EventArgs e)
        {

        }

        private void deposit_btn_Click(object sender, EventArgs e)
        {
            var depositForm = new enterAmount(enterAmount.TransactionActions.Deposit);
            depositForm.ShowDialog();
            RefreshCurrentBal();

        }

        private void withdraw_btn_Click(object sender, EventArgs e)
        {
            var withdrawForm = new enterAmount(enterAmount.TransactionActions.Withdraw);
            withdrawForm.ShowDialog();
            RefreshCurrentBal();

        }

        private void crtsavings_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            savingsManipulation savingsForm = new savingsManipulation();
            savingsForm.ShowDialog();
           
        }

        private void vwSavings_btn_Click(object sender, EventArgs e)
        {
            var savingsForm = new View(View.ViewActions.Savings);
            savingsForm.ShowDialog();
            this.Hide();
        }

        private void trnsctHist_btn_Click(object sender, EventArgs e)
        {
            var transactionForm = new View(View.ViewActions.Transactions);
            transactionForm.ShowDialog();
            this.Hide();

        }

        private void expenses_btn_Click_1(object sender, EventArgs e)
        {
            expenses expensesForm = new expenses();
            expensesForm.ShowDialog();
            this.Hide();
        }
    }
}
