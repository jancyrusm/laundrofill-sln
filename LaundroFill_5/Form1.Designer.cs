using System.Drawing;
using System.Runtime;
using System.Windows.Forms;

namespace LaundroFill_5
{
    partial class admin_form
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel_login = new System.Windows.Forms.Panel();
            this.btn_login = new System.Windows.Forms.Button();
            this.btn_login_cancel = new System.Windows.Forms.Button();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_username = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel_main = new System.Windows.Forms.Panel();
            this.panel_usercontrols = new System.Windows.Forms.Panel();
            this.uc_products1 = new LaundroFill_5.uc_products();
            this.btn_settings = new System.Windows.Forms.Button();
            this.btn_reports = new System.Windows.Forms.Button();
            this.btn_transactions = new System.Windows.Forms.Button();
            this.btn_products = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.uc_settings1 = new LaundroFill_5.uc_settings();
            this.panel_login.SuspendLayout();
            this.panel_main.SuspendLayout();
            this.panel_usercontrols.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_login
            // 
            this.panel_login.Controls.Add(this.btn_login);
            this.panel_login.Controls.Add(this.btn_login_cancel);
            this.panel_login.Controls.Add(this.txt_password);
            this.panel_login.Controls.Add(this.label3);
            this.panel_login.Controls.Add(this.txt_username);
            this.panel_login.Controls.Add(this.label2);
            this.panel_login.Controls.Add(this.label1);
            this.panel_login.Location = new System.Drawing.Point(76, 92);
            this.panel_login.Name = "panel_login";
            this.panel_login.Size = new System.Drawing.Size(913, 392);
            this.panel_login.TabIndex = 0;
            // 
            // btn_login
            // 
            this.btn_login.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_login.Location = new System.Drawing.Point(515, 285);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(135, 49);
            this.btn_login.TabIndex = 6;
            this.btn_login.Text = "LOGIN";
            this.btn_login.UseVisualStyleBackColor = true;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // btn_login_cancel
            // 
            this.btn_login_cancel.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_login_cancel.Location = new System.Drawing.Point(374, 285);
            this.btn_login_cancel.Name = "btn_login_cancel";
            this.btn_login_cancel.Size = new System.Drawing.Size(135, 49);
            this.btn_login_cancel.TabIndex = 5;
            this.btn_login_cancel.Text = "Cancel";
            this.btn_login_cancel.UseVisualStyleBackColor = true;
            // 
            // txt_password
            // 
            this.txt_password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_password.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_password.Location = new System.Drawing.Point(393, 211);
            this.txt_password.Name = "txt_password";
            this.txt_password.PasswordChar = '*';
            this.txt_password.Size = new System.Drawing.Size(257, 27);
            this.txt_password.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(250, 211);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 27);
            this.label3.TabIndex = 3;
            this.label3.Text = "Password: ";
            // 
            // txt_username
            // 
            this.txt_username.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_username.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_username.Location = new System.Drawing.Point(393, 168);
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(257, 27);
            this.txt_username.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(250, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 27);
            this.label2.TabIndex = 1;
            this.label2.Text = "Username: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(240, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(410, 59);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome Admin";
            // 
            // panel_main
            // 
            this.panel_main.Controls.Add(this.panel_usercontrols);
            this.panel_main.Controls.Add(this.panel_login);
            this.panel_main.Controls.Add(this.btn_settings);
            this.panel_main.Controls.Add(this.btn_reports);
            this.panel_main.Controls.Add(this.btn_transactions);
            this.panel_main.Controls.Add(this.btn_products);
            this.panel_main.Controls.Add(this.label5);
            this.panel_main.Controls.Add(this.label4);
            this.panel_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_main.Location = new System.Drawing.Point(0, 0);
            this.panel_main.Name = "panel_main";
            this.panel_main.Size = new System.Drawing.Size(1080, 600);
            this.panel_main.TabIndex = 8;
            // 
            // panel_usercontrols
            // 
            this.panel_usercontrols.Controls.Add(this.uc_settings1);
            this.panel_usercontrols.Controls.Add(this.uc_products1);
            this.panel_usercontrols.Location = new System.Drawing.Point(40, 25);
            this.panel_usercontrols.Name = "panel_usercontrols";
            this.panel_usercontrols.Size = new System.Drawing.Size(1003, 518);
            this.panel_usercontrols.TabIndex = 7;
            this.panel_usercontrols.Visible = false;
            // 
            // uc_products1
            // 
            this.uc_products1.Location = new System.Drawing.Point(0, 0);
            this.uc_products1.Name = "uc_products1";
            this.uc_products1.Size = new System.Drawing.Size(1003, 518);
            this.uc_products1.TabIndex = 0;
            // 
            // btn_settings
            // 
            this.btn_settings.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_settings.Location = new System.Drawing.Point(746, 281);
            this.btn_settings.Name = "btn_settings";
            this.btn_settings.Size = new System.Drawing.Size(185, 128);
            this.btn_settings.TabIndex = 6;
            this.btn_settings.Text = "Settings";
            this.btn_settings.UseVisualStyleBackColor = true;
            // 
            // btn_reports
            // 
            this.btn_reports.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_reports.Location = new System.Drawing.Point(536, 281);
            this.btn_reports.Name = "btn_reports";
            this.btn_reports.Size = new System.Drawing.Size(185, 128);
            this.btn_reports.TabIndex = 5;
            this.btn_reports.Text = "Reports";
            this.btn_reports.UseVisualStyleBackColor = true;
            // 
            // btn_transactions
            // 
            this.btn_transactions.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_transactions.Location = new System.Drawing.Point(308, 281);
            this.btn_transactions.Name = "btn_transactions";
            this.btn_transactions.Size = new System.Drawing.Size(204, 128);
            this.btn_transactions.TabIndex = 4;
            this.btn_transactions.Text = "Transactions";
            this.btn_transactions.UseVisualStyleBackColor = true;
            // 
            // btn_products
            // 
            this.btn_products.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_products.Location = new System.Drawing.Point(100, 281);
            this.btn_products.Name = "btn_products";
            this.btn_products.Size = new System.Drawing.Size(185, 128);
            this.btn_products.TabIndex = 3;
            this.btn_products.Text = "Products";
            this.btn_products.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(301, 158);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(423, 38);
            this.label5.TabIndex = 2;
            this.label5.Text = "Management and Settings";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(266, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(514, 59);
            this.label4.TabIndex = 1;
            this.label4.Text = "L A U N D R O F I L L";
            // 
            // uc_settings1
            // 
            this.uc_settings1.Location = new System.Drawing.Point(-3, 3);
            this.uc_settings1.Name = "uc_settings1";
            this.uc_settings1.Size = new System.Drawing.Size(1003, 518);
            this.uc_settings1.TabIndex = 1;
            // 
            // admin_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1080, 600);
            this.Controls.Add(this.panel_main);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "admin_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin";
            this.Load += new System.EventHandler(this.admin_form_Load);
            this.panel_login.ResumeLayout(false);
            this.panel_login.PerformLayout();
            this.panel_main.ResumeLayout(false);
            this.panel_main.PerformLayout();
            this.panel_usercontrols.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel_login;
        private Button btn_login;
        private Button btn_login_cancel;
        private TextBox txt_password;
        private Label label3;
        private TextBox txt_username;
        private Label label2;
        private Label label1;
        private Panel panel_main;
        private Button btn_settings;
        private Button btn_reports;
        private Button btn_transactions;
        private Button btn_products;
        private Label label5;
        private Label label4;
        private Panel panel_usercontrols;
        private uc_products uc_products1;
        private uc_settings uc_settings1;
        //private uc_transactions uc_transactions1;
        //private uc_reports uc_reports1;
        //private uc_settings uc_settings1;
        //private uc_products uc_products1;
        //private uc_transactions uc_transactions2;
        //private uc_reports uc_reports2;
    }
}

