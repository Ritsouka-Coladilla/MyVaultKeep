namespace MyVaultKeepForms
{
    partial class enterAmount
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
            enteredAmount_txbx = new TextBox();
            amount_lbl = new Label();
            enterAmount_btn = new Button();
            SuspendLayout();
            // 
            // enteredAmount_txbx
            // 
            enteredAmount_txbx.Font = new Font("Microsoft YaHei", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            enteredAmount_txbx.Location = new Point(276, 137);
            enteredAmount_txbx.Margin = new Padding(3, 2, 3, 2);
            enteredAmount_txbx.Name = "enteredAmount_txbx";
            enteredAmount_txbx.Size = new Size(176, 29);
            enteredAmount_txbx.TabIndex = 1;
            // 
            // amount_lbl
            // 
            amount_lbl.AutoSize = true;
            amount_lbl.Font = new Font("Microsoft YaHei", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            amount_lbl.Location = new Point(111, 109);
            amount_lbl.Name = "amount_lbl";
            amount_lbl.Size = new Size(150, 26);
            amount_lbl.TabIndex = 2;
            amount_lbl.Text = "Enter Amount:";
            // 
            // enterAmount_btn
            // 
            enterAmount_btn.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            enterAmount_btn.Location = new Point(481, 273);
            enterAmount_btn.Margin = new Padding(3, 2, 3, 2);
            enterAmount_btn.Name = "enterAmount_btn";
            enterAmount_btn.Size = new Size(82, 38);
            enterAmount_btn.TabIndex = 3;
            enterAmount_btn.Text = "Confirm";
            enterAmount_btn.UseVisualStyleBackColor = true;
            enterAmount_btn.Click += enterAmount_btn_Click;
            // 
            // enterAmount
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(591, 338);
            Controls.Add(enterAmount_btn);
            Controls.Add(amount_lbl);
            Controls.Add(enteredAmount_txbx);
            Margin = new Padding(3, 2, 3, 2);
            Name = "enterAmount";
            Text = "Enter Amount";
            Load += enterAmount_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox enteredAmount_txbx;
        private Label amount_lbl;
        private Button enterAmount_btn;
    }
}