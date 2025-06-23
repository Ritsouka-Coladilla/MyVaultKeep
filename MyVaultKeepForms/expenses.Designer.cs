namespace MyVaultKeepForms
{
    partial class expenses
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
            label1 = new Label();
            expenses_cmbx = new ComboBox();
            back_btn = new Button();
            confirm_btn = new Button();
            amount_lbl = new Label();
            amount_txbx = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft YaHei", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(40, 52);
            label1.Name = "label1";
            label1.Size = new Size(187, 36);
            label1.TabIndex = 0;
            label1.Text = "Set Expenses";
            // 
            // expenses_cmbx
            // 
            expenses_cmbx.Font = new Font("Microsoft YaHei", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            expenses_cmbx.FormattingEnabled = true;
            expenses_cmbx.Location = new Point(293, 113);
            expenses_cmbx.Name = "expenses_cmbx";
            expenses_cmbx.Size = new Size(216, 31);
            expenses_cmbx.TabIndex = 1;
            expenses_cmbx.Text = "-";
            expenses_cmbx.SelectedIndexChanged += expenses_cmbx_SelectedIndexChanged;
            // 
            // back_btn
            // 
            back_btn.Font = new Font("Microsoft YaHei", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            back_btn.Location = new Point(22, 357);
            back_btn.Name = "back_btn";
            back_btn.Size = new Size(94, 43);
            back_btn.TabIndex = 2;
            back_btn.Text = "Back";
            back_btn.UseVisualStyleBackColor = true;
            back_btn.Click += back_btn_Click;
            // 
            // confirm_btn
            // 
            confirm_btn.Font = new Font("Microsoft YaHei", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            confirm_btn.Location = new Point(401, 357);
            confirm_btn.Name = "confirm_btn";
            confirm_btn.Size = new Size(94, 43);
            confirm_btn.TabIndex = 3;
            confirm_btn.Text = "Confirm";
            confirm_btn.UseVisualStyleBackColor = true;
            confirm_btn.Click += confirm_btn_Click;
            // 
            // amount_lbl
            // 
            amount_lbl.AutoSize = true;
            amount_lbl.Font = new Font("Microsoft YaHei", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            amount_lbl.Location = new Point(22, 113);
            amount_lbl.Name = "amount_lbl";
            amount_lbl.Size = new Size(94, 27);
            amount_lbl.TabIndex = 4;
            amount_lbl.Text = "Amount:";
            // 
            // amount_txbx
            // 
            amount_txbx.Font = new Font("Microsoft YaHei", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            amount_txbx.Location = new Point(40, 157);
            amount_txbx.Name = "amount_txbx";
            amount_txbx.Size = new Size(187, 31);
            amount_txbx.TabIndex = 5;
            // 
            // expenses
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(521, 421);
            Controls.Add(amount_txbx);
            Controls.Add(amount_lbl);
            Controls.Add(confirm_btn);
            Controls.Add(back_btn);
            Controls.Add(expenses_cmbx);
            Controls.Add(label1);
            Name = "expenses";
            Text = "Expenses";
            Load += expenses_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox expenses_cmbx;
        private Button back_btn;
        private Button confirm_btn;
        private Label amount_lbl;
        private TextBox amount_txbx;
    }
}