
namespace MyVaultKeepForms
{
    partial class mainDashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            balance_lbl = new Label();
            displbal_txbx = new TextBox();
            deposit_btn = new Button();
            withdraw_btn = new Button();
            vwSavings_btn = new Button();
            crtsavings_btn = new Button();
            expenses_btn = new Button();
            trnsctHist_btn = new Button();
            SuspendLayout();
            // 
            // balance_lbl
            // 
            balance_lbl.AutoSize = true;
            balance_lbl.BackColor = Color.Transparent;
            balance_lbl.Font = new Font("Microsoft YaHei", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            balance_lbl.Location = new Point(31, 21);
            balance_lbl.Name = "balance_lbl";
            balance_lbl.Size = new Size(90, 27);
            balance_lbl.TabIndex = 0;
            balance_lbl.Text = "Balance:";
            // 
            // displbal_txbx
            // 
            displbal_txbx.Font = new Font("Microsoft YaHei", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            displbal_txbx.Location = new Point(127, 20);
            displbal_txbx.Name = "displbal_txbx";
            displbal_txbx.ReadOnly = true;
            displbal_txbx.Size = new Size(168, 31);
            displbal_txbx.TabIndex = 1;
            displbal_txbx.TabStop = false;
            displbal_txbx.TextChanged += displbal_txbx_TextChanged;
            // 
            // deposit_btn
            // 
            deposit_btn.Location = new Point(81, 169);
            deposit_btn.Name = "deposit_btn";
            deposit_btn.Size = new Size(94, 65);
            deposit_btn.TabIndex = 2;
            deposit_btn.Text = "Deposit";
            deposit_btn.UseVisualStyleBackColor = true;
            deposit_btn.Click += deposit_btn_Click;
            // 
            // withdraw_btn
            // 
            withdraw_btn.Location = new Point(251, 169);
            withdraw_btn.Name = "withdraw_btn";
            withdraw_btn.Size = new Size(94, 65);
            withdraw_btn.TabIndex = 3;
            withdraw_btn.Text = "Withdraw";
            withdraw_btn.UseVisualStyleBackColor = true;
            withdraw_btn.Click += withdraw_btn_Click;
            // 
            // vwSavings_btn
            // 
            vwSavings_btn.Location = new Point(251, 333);
            vwSavings_btn.Name = "vwSavings_btn";
            vwSavings_btn.Size = new Size(94, 65);
            vwSavings_btn.TabIndex = 4;
            vwSavings_btn.Text = "View Savings";
            vwSavings_btn.UseVisualStyleBackColor = true;
            vwSavings_btn.Click += vwSavings_btn_Click;
            // 
            // crtsavings_btn
            // 
            crtsavings_btn.Location = new Point(81, 333);
            crtsavings_btn.Name = "crtsavings_btn";
            crtsavings_btn.Size = new Size(94, 65);
            crtsavings_btn.TabIndex = 5;
            crtsavings_btn.Text = "Savings";
            crtsavings_btn.UseVisualStyleBackColor = true;
            crtsavings_btn.Click += crtsavings_btn_Click;
            // 
            // expenses_btn
            // 
            expenses_btn.Location = new Point(409, 169);
            expenses_btn.Name = "expenses_btn";
            expenses_btn.Size = new Size(94, 65);
            expenses_btn.TabIndex = 6;
            expenses_btn.Text = "Expenses";
            expenses_btn.UseVisualStyleBackColor = true;
            expenses_btn.Click += expenses_btn_Click_1;
            // 
            // trnsctHist_btn
            // 
            trnsctHist_btn.Location = new Point(409, 333);
            trnsctHist_btn.Name = "trnsctHist_btn";
            trnsctHist_btn.Size = new Size(94, 65);
            trnsctHist_btn.TabIndex = 7;
            trnsctHist_btn.Text = "Transaction History";
            trnsctHist_btn.UseVisualStyleBackColor = true;
            trnsctHist_btn.Click += trnsctHist_btn_Click;
            // 
            // mainDashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(610, 586);
            Controls.Add(trnsctHist_btn);
            Controls.Add(expenses_btn);
            Controls.Add(crtsavings_btn);
            Controls.Add(vwSavings_btn);
            Controls.Add(withdraw_btn);
            Controls.Add(deposit_btn);
            Controls.Add(displbal_txbx);
            Controls.Add(balance_lbl);
            Name = "mainDashboard";
            Text = "mainDashboard";
            Load += mainDashboard_Load;
            ResumeLayout(false);
            PerformLayout();
        }




        #endregion

        private Label balance_lbl;
        private TextBox displbal_txbx;
        private Button deposit_btn;
        private Button withdraw_btn;
        private Button vwSavings_btn;
        private Button crtsavings_btn;
        private Button expenses_btn;
        private Button trnsctHist_btn;
    }
}