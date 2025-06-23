using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyVaultCommon;
using Functions_DataLogic;
using System.Windows.Forms;

namespace MyVaultKeepForms
{
    public partial class Initialization : Form
    {
        public Initialization()
        {
            InitializeComponent();
        }

        private void Initialization_Load(object sender, EventArgs e)
        {

        }

        private void confirm_btn_Click(object sender, EventArgs e)
        {
            double deposit;

            if (double.TryParse(deposit_txtbx.Text, out deposit) && deposit >= 0)
            {
                
                MyVaultDetails.Balance = deposit;
                MessageBox.Show("Initial deposit set successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                
                mainDashboard dashboard = new mainDashboard();
                dashboard.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Please enter a valid amount greater than zero.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
