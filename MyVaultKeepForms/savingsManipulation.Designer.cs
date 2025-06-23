namespace MyVaultKeepForms
{
    partial class savingsManipulation
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
            manipulate_lbl = new Label();
            Amount_lbl = new Label();
            Name_lbl = new Label();
            amount_txbx = new TextBox();
            name_txbx = new TextBox();
            back_btn = new Button();
            delete_btn = new Button();
            update_btn = new Button();
            add_btn = new Button();
            SuspendLayout();
            // 
            // manipulate_lbl
            // 
            manipulate_lbl.AutoSize = true;
            manipulate_lbl.Font = new Font("Microsoft YaHei", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            manipulate_lbl.Location = new Point(43, 77);
            manipulate_lbl.Name = "manipulate_lbl";
            manipulate_lbl.Size = new Size(116, 36);
            manipulate_lbl.TabIndex = 0;
            manipulate_lbl.Text = "Savings";
            // 
            // Amount_lbl
            // 
            Amount_lbl.AutoSize = true;
            Amount_lbl.Font = new Font("Microsoft YaHei", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Amount_lbl.Location = new Point(126, 230);
            Amount_lbl.Name = "Amount_lbl";
            Amount_lbl.Size = new Size(94, 27);
            Amount_lbl.TabIndex = 1;
            Amount_lbl.Text = "Amount:";
            // 
            // Name_lbl
            // 
            Name_lbl.AutoSize = true;
            Name_lbl.Font = new Font("Microsoft YaHei", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name_lbl.Location = new Point(126, 163);
            Name_lbl.Name = "Name_lbl";
            Name_lbl.Size = new Size(74, 27);
            Name_lbl.TabIndex = 2;
            Name_lbl.Text = "Name:";
            // 
            // amount_txbx
            // 
            amount_txbx.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            amount_txbx.Location = new Point(226, 232);
            amount_txbx.Name = "amount_txbx";
            amount_txbx.Size = new Size(148, 31);
            amount_txbx.TabIndex = 3;
            // 
            // name_txbx
            // 
            name_txbx.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            name_txbx.Location = new Point(206, 161);
            name_txbx.Name = "name_txbx";
            name_txbx.Size = new Size(168, 31);
            name_txbx.TabIndex = 4;
            // 
            // back_btn
            // 
            back_btn.Font = new Font("Microsoft YaHei", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            back_btn.Location = new Point(403, 396);
            back_btn.Name = "back_btn";
            back_btn.Size = new Size(94, 42);
            back_btn.TabIndex = 5;
            back_btn.Text = "Back";
            back_btn.UseVisualStyleBackColor = true;
            back_btn.Click += back_btn_Click;
            // 
            // delete_btn
            // 
            delete_btn.Font = new Font("Microsoft YaHei", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            delete_btn.Location = new Point(374, 304);
            delete_btn.Name = "delete_btn";
            delete_btn.Size = new Size(94, 45);
            delete_btn.TabIndex = 6;
            delete_btn.Text = "Delete";
            delete_btn.UseVisualStyleBackColor = true;
            delete_btn.Click += delete_btn_Click;
            // 
            // update_btn
            // 
            update_btn.Font = new Font("Microsoft YaHei", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            update_btn.Location = new Point(206, 304);
            update_btn.Name = "update_btn";
            update_btn.Size = new Size(94, 45);
            update_btn.TabIndex = 7;
            update_btn.Text = "Update";
            update_btn.UseVisualStyleBackColor = true;
            update_btn.Click += update_btn_Click;
            // 
            // add_btn
            // 
            add_btn.Font = new Font("Microsoft YaHei", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            add_btn.Location = new Point(43, 304);
            add_btn.Name = "add_btn";
            add_btn.Size = new Size(94, 45);
            add_btn.TabIndex = 8;
            add_btn.Text = "Add";
            add_btn.UseVisualStyleBackColor = true;
            add_btn.Click += add_btn_Click;
            // 
            // savingsManipulation
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(509, 450);
            Controls.Add(add_btn);
            Controls.Add(update_btn);
            Controls.Add(delete_btn);
            Controls.Add(back_btn);
            Controls.Add(name_txbx);
            Controls.Add(amount_txbx);
            Controls.Add(Name_lbl);
            Controls.Add(Amount_lbl);
            Controls.Add(manipulate_lbl);
            Name = "savingsManipulation";
            Text = "Savings";
            Load += savingsManipulation_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label manipulate_lbl;
        private Label Amount_lbl;
        private Label Name_lbl;
        private TextBox amount_txbx;
        private TextBox name_txbx;
        private Button back_btn;
        private Button delete_btn;
        private Button update_btn;
        private Button add_btn;
    }
}