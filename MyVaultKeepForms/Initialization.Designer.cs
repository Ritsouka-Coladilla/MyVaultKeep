namespace MyVaultKeepForms
{
    partial class Initialization
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
            welcome_lbl = new Label();
            initialDeposit_lbl = new Label();
            confirm_btn = new Button();
            deposit_txtbx = new TextBox();
            SuspendLayout();
            // 
            // welcome_lbl
            // 
            welcome_lbl.AutoSize = true;
            welcome_lbl.Font = new Font("Microsoft YaHei", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            welcome_lbl.Location = new Point(12, 9);
            welcome_lbl.Name = "welcome_lbl";
            welcome_lbl.Size = new Size(372, 36);
            welcome_lbl.TabIndex = 0;
            welcome_lbl.Text = "Welcome to MyVaultKeep!";
            welcome_lbl.TextAlign = ContentAlignment.TopCenter;
            // 
            // initialDeposit_lbl
            // 
            initialDeposit_lbl.AutoSize = true;
            initialDeposit_lbl.Font = new Font("Microsoft YaHei", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            initialDeposit_lbl.Location = new Point(246, 157);
            initialDeposit_lbl.Name = "initialDeposit_lbl";
            initialDeposit_lbl.Size = new Size(175, 27);
            initialDeposit_lbl.TabIndex = 1;
            initialDeposit_lbl.Text = "Set initial deposit";
            initialDeposit_lbl.TextAlign = ContentAlignment.TopCenter;
            // 
            // confirm_btn
            // 
            confirm_btn.Font = new Font("Microsoft YaHei", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            confirm_btn.Location = new Point(556, 360);
            confirm_btn.Name = "confirm_btn";
            confirm_btn.Size = new Size(94, 51);
            confirm_btn.TabIndex = 2;
            confirm_btn.Text = "Confirm";
            confirm_btn.UseVisualStyleBackColor = true;
            confirm_btn.Click += confirm_btn_Click;
            // 
            // deposit_txtbx
            // 
            deposit_txtbx.Font = new Font("Microsoft YaHei", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            deposit_txtbx.Location = new Point(196, 210);
            deposit_txtbx.Name = "deposit_txtbx";
            deposit_txtbx.Size = new Size(272, 34);
            deposit_txtbx.TabIndex = 3;
            // 
            // Initialization
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(673, 450);
            Controls.Add(deposit_txtbx);
            Controls.Add(confirm_btn);
            Controls.Add(initialDeposit_lbl);
            Controls.Add(welcome_lbl);
            Name = "Initialization";
            Text = "Initialization";
            Load += Initialization_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label welcome_lbl;
        private Label initialDeposit_lbl;
        private Button confirm_btn;
        private TextBox deposit_txtbx;
    }
}