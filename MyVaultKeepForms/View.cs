using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Functions_DataLogic;

namespace MyVaultKeepForms
{
    public partial class View : Form
    {
        public enum ViewActions
        {
            Transactions,
            Savings
        }

        private ViewActions mode;

        public View(ViewActions view)
        {
            InitializeComponent();
            mode = view;
        }

        private void View_Load(object sender, EventArgs e)
        {
            if (mode == ViewActions.Transactions)
            {
                view_lbl.Text = "Transaction History";
                view_lstbx.Items.AddRange(MyVaultData.GetTransactionList().ToArray());
            }
            else if (mode == ViewActions.Savings)
            {
                view_lbl.Text = "Active Savings";
                view_lstbx.Items.AddRange(MyVaultData.GetSavingsList().ToArray());
            }
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            mainDashboard dashboard = new mainDashboard();
            dashboard.Show();
            this.Hide();
            
        }
    }
}
