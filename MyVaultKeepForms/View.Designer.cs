namespace MyVaultKeepForms
{
    partial class View
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
            view_lstbx = new ListBox();
            view_lbl = new Label();
            back_btn = new Button();
            SuspendLayout();
            // 
            // view_lstbx
            // 
            view_lstbx.Font = new Font("Microsoft YaHei", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            view_lstbx.FormattingEnabled = true;
            view_lstbx.ItemHeight = 19;
            view_lstbx.Location = new Point(43, 74);
            view_lstbx.Name = "view_lstbx";
            view_lstbx.Size = new Size(328, 289);
            view_lstbx.TabIndex = 0;
            // 
            // view_lbl
            // 
            view_lbl.AutoSize = true;
            view_lbl.Font = new Font("Microsoft YaHei", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            view_lbl.Location = new Point(28, 23);
            view_lbl.Name = "view_lbl";
            view_lbl.Size = new Size(61, 28);
            view_lbl.TabIndex = 1;
            view_lbl.Text = "View";
            // 
            // back_btn
            // 
            back_btn.Font = new Font("Microsoft YaHei", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            back_btn.Location = new Point(52, 405);
            back_btn.Name = "back_btn";
            back_btn.Size = new Size(75, 33);
            back_btn.TabIndex = 2;
            back_btn.Text = "Back";
            back_btn.UseVisualStyleBackColor = true;
            back_btn.Click += back_btn_Click;
            // 
            // View
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(413, 450);
            Controls.Add(back_btn);
            Controls.Add(view_lbl);
            Controls.Add(view_lstbx);
            Name = "View";
            Text = "View";
            Load += View_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox view_lstbx;
        private Label view_lbl;
        private Button back_btn;
    }
}