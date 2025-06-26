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
using Functions_BusinessLogic;
using MyVaultCommon;

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
            view_lbl.Text = mode == ViewActions.Transactions ? "Transaction History:" : "Savings:";

        }


        private void back_btn_Click(object sender, EventArgs e)
        {
            mainDashboard dashboard = new mainDashboard();
            dashboard.Show();
            this.Hide();

        }

        private void view_lstbx_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void View_Activated(object sender, EventArgs e)
        {
            view_lstbx.Items.Clear();

            if (mode == ViewActions.Transactions)
            {
                view_lstbx.Items.AddRange(MyVaultData.GetTransactionList().ToArray());
            }
            else if (mode == ViewActions.Savings)
            {
                view_lstbx.Items.AddRange(MyVaultData.GetSavingsList().ToArray());
            }
        }
    }
}
