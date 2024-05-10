using System.Drawing;
using System.Windows.Forms;

namespace LaundroFill_5
{
    partial class uc_products
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_product4 = new System.Windows.Forms.Button();
            this.btn_product3 = new System.Windows.Forms.Button();
            this.btn_product2 = new System.Windows.Forms.Button();
            this.btn_product1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_back = new System.Windows.Forms.Button();
            this.uc_products_form1 = new LaundroFill_5.uc_products_form();
            this.SuspendLayout();
            // 
            // btn_product4
            // 
            this.btn_product4.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_product4.Location = new System.Drawing.Point(727, 252);
            this.btn_product4.Name = "btn_product4";
            this.btn_product4.Size = new System.Drawing.Size(185, 136);
            this.btn_product4.TabIndex = 12;
            this.btn_product4.Text = "Product 4";
            this.btn_product4.UseVisualStyleBackColor = true;
            this.btn_product4.Click += new System.EventHandler(this.btn_product4_Click);
            // 
            // btn_product3
            // 
            this.btn_product3.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_product3.Location = new System.Drawing.Point(517, 252);
            this.btn_product3.Name = "btn_product3";
            this.btn_product3.Size = new System.Drawing.Size(185, 136);
            this.btn_product3.TabIndex = 11;
            this.btn_product3.Text = "Product 3";
            this.btn_product3.UseVisualStyleBackColor = true;
            this.btn_product3.Click += new System.EventHandler(this.btn_product3_Click);
            // 
            // btn_product2
            // 
            this.btn_product2.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_product2.Location = new System.Drawing.Point(308, 252);
            this.btn_product2.Name = "btn_product2";
            this.btn_product2.Size = new System.Drawing.Size(185, 136);
            this.btn_product2.TabIndex = 10;
            this.btn_product2.Text = "Product 2";
            this.btn_product2.UseVisualStyleBackColor = true;
            this.btn_product2.Click += new System.EventHandler(this.btn_product2_Click);
            // 
            // btn_product1
            // 
            this.btn_product1.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_product1.Location = new System.Drawing.Point(98, 252);
            this.btn_product1.Name = "btn_product1";
            this.btn_product1.Size = new System.Drawing.Size(185, 136);
            this.btn_product1.TabIndex = 9;
            this.btn_product1.Text = "Product 1";
            this.btn_product1.UseVisualStyleBackColor = true;
            this.btn_product1.Click += new System.EventHandler(this.btn_product1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(382, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(229, 38);
            this.label5.TabIndex = 8;
            this.label5.Text = "Edit Products";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(247, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(514, 59);
            this.label4.TabIndex = 7;
            this.label4.Text = "L A U N D R O F I L L";
            // 
            // btn_back
            // 
            this.btn_back.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_back.Location = new System.Drawing.Point(98, 52);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(92, 33);
            this.btn_back.TabIndex = 13;
            this.btn_back.Text = "<";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // uc_products_form1
            // 
            this.uc_products_form1.Location = new System.Drawing.Point(0, 0);
            this.uc_products_form1.Name = "uc_products_form1";
            this.uc_products_form1.ProductIDText = "id";
            this.uc_products_form1.Size = new System.Drawing.Size(1003, 488);
            this.uc_products_form1.TabIndex = 14;
            this.uc_products_form1.Visible = false;
            // 
            // uc_products
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.uc_products_form1);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.btn_product4);
            this.Controls.Add(this.btn_product3);
            this.Controls.Add(this.btn_product2);
            this.Controls.Add(this.btn_product1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Name = "uc_products";
            this.Size = new System.Drawing.Size(1003, 488);
            this.Load += new System.EventHandler(this.uc_products_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btn_product4;
        private Button btn_product3;
        private Button btn_product2;
        private Button btn_product1;
        private Label label5;
        private Label label4;
        private Button btn_back;
        private uc_products_form uc_products_form1;
        //private uc_products_forms uc_products_forms1;
        //private uc_products_forms uc_products_forms2;
    }
}
