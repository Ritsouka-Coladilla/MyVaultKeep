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
            view_lstbx.ItemHeight = 21;
            view_lstbx.Location = new Point(49, 99);
            view_lstbx.Margin = new Padding(3, 4, 3, 4);
            view_lstbx.Name = "view_lstbx";
            view_lstbx.Size = new Size(374, 382);
            view_lstbx.TabIndex = 0;
            view_lstbx.SelectedIndexChanged += view_lstbx_SelectedIndexChanged;
            // 
            // view_lbl
            // 
            view_lbl.AutoSize = true;
            view_lbl.Font = new Font("Microsoft YaHei", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            view_lbl.Location = new Point(32, 31);
            view_lbl.Name = "view_lbl";
            view_lbl.Size = new Size(76, 35);
            view_lbl.TabIndex = 1;
            view_lbl.Text = "View";
            // 
            // back_btn
            // 
            back_btn.Font = new Font("Microsoft YaHei", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            back_btn.Location = new Point(59, 540);
            back_btn.Margin = new Padding(3, 4, 3, 4);
            back_btn.Name = "back_btn";
            back_btn.Size = new Size(86, 44);
            back_btn.TabIndex = 2;
            back_btn.Text = "Back";
            back_btn.UseVisualStyleBackColor = true;
            back_btn.Click += back_btn_Click;
            // 
            // View
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(472, 600);
            Controls.Add(back_btn);
            Controls.Add(view_lbl);
            Controls.Add(view_lstbx);
            Margin = new Padding(3, 4, 3, 4);
            Name = "View";
            Text = "View";
            Activated += View_Actived;
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