using System.Drawing;
using System.Windows.Forms;

namespace LaundroFill_5
{
    partial class uc_settings
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
            this.btn_back = new System.Windows.Forms.Button();
            this.btn_inventory = new System.Windows.Forms.Button();
            this.btn_sales = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_back
            // 
            this.btn_back.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_back.Location = new System.Drawing.Point(117, 38);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(92, 33);
            this.btn_back.TabIndex = 25;
            this.btn_back.Text = "<";
            this.btn_back.UseVisualStyleBackColor = true;
            // 
            // btn_inventory
            // 
            this.btn_inventory.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_inventory.Location = new System.Drawing.Point(560, 244);
            this.btn_inventory.Name = "btn_inventory";
            this.btn_inventory.Size = new System.Drawing.Size(185, 136);
            this.btn_inventory.TabIndex = 24;
            this.btn_inventory.Text = "Logout";
            this.btn_inventory.UseVisualStyleBackColor = true;
            // 
            // btn_sales
            // 
            this.btn_sales.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sales.Location = new System.Drawing.Point(275, 244);
            this.btn_sales.Name = "btn_sales";
            this.btn_sales.Size = new System.Drawing.Size(185, 136);
            this.btn_sales.TabIndex = 23;
            this.btn_sales.Text = "Account";
            this.btn_sales.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(448, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(150, 40);
            this.label5.TabIndex = 22;
            this.label5.Text = "Settings";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(266, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(514, 59);
            this.label4.TabIndex = 21;
            this.label4.Text = "L A U N D R O F I L L";
            // 
            // uc_settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.btn_inventory);
            this.Controls.Add(this.btn_sales);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Name = "uc_settings";
            this.Size = new System.Drawing.Size(1003, 518);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btn_back;
        private Button btn_inventory;
        private Button btn_sales;
        private Label label5;
        private Label label4;
    }

}
