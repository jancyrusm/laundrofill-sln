using System.Drawing;
using System.Windows.Forms;

namespace LaundroFill_5
{
    partial class uc_products_form
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
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_productID = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_product_desc = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_product_name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmb_product_type = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.volume1 = new System.Windows.Forms.Label();
            this.volume2 = new System.Windows.Forms.Label();
            this.volume3 = new System.Windows.Forms.Label();
            this.ndd_unitprice_1 = new System.Windows.Forms.NumericUpDown();
            this.ndd_unitprice_2 = new System.Windows.Forms.NumericUpDown();
            this.ndd_unitprice_3 = new System.Windows.Forms.NumericUpDown();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ndd_unitprice_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ndd_unitprice_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ndd_unitprice_3)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_back
            // 
            this.btn_back.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_back.Location = new System.Drawing.Point(89, 52);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(92, 33);
            this.btn_back.TabIndex = 20;
            this.btn_back.Text = "<";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(330, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(323, 59);
            this.label4.TabIndex = 14;
            this.label4.Text = "Edit Product";
            // 
            // lbl_productID
            // 
            this.lbl_productID.AutoSize = true;
            this.lbl_productID.Font = new System.Drawing.Font("Arial", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_productID.Location = new System.Drawing.Point(657, 52);
            this.lbl_productID.Name = "lbl_productID";
            this.lbl_productID.Size = new System.Drawing.Size(53, 59);
            this.lbl_productID.TabIndex = 21;
            this.lbl_productID.Text = "1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_product_desc);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_product_name);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cmb_product_type);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(89, 149);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(427, 191);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Product Info";
            // 
            // txt_product_desc
            // 
            this.txt_product_desc.Font = new System.Drawing.Font("Arial", 14F);
            this.txt_product_desc.Location = new System.Drawing.Point(170, 120);
            this.txt_product_desc.Name = "txt_product_desc";
            this.txt_product_desc.Size = new System.Drawing.Size(243, 34);
            this.txt_product_desc.TabIndex = 33;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 27);
            this.label3.TabIndex = 32;
            this.label3.Text = "Description: ";
            // 
            // txt_product_name
            // 
            this.txt_product_name.Font = new System.Drawing.Font("Arial", 14F);
            this.txt_product_name.Location = new System.Drawing.Point(170, 81);
            this.txt_product_name.Name = "txt_product_name";
            this.txt_product_name.Size = new System.Drawing.Size(243, 34);
            this.txt_product_name.TabIndex = 31;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 27);
            this.label2.TabIndex = 30;
            this.label2.Text = "Name: ";
            // 
            // cmb_product_type
            // 
            this.cmb_product_type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_product_type.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_product_type.FormattingEnabled = true;
            this.cmb_product_type.Items.AddRange(new object[] {
            "Liquid Detergent",
            "Fabric Conditioner"});
            this.cmb_product_type.Location = new System.Drawing.Point(170, 42);
            this.cmb_product_type.Name = "cmb_product_type";
            this.cmb_product_type.Size = new System.Drawing.Size(243, 35);
            this.cmb_product_type.TabIndex = 29;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 27);
            this.label1.TabIndex = 28;
            this.label1.Text = "Type: ";
            // 
            // btn_save
            // 
            this.btn_save.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.Location = new System.Drawing.Point(782, 392);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(124, 49);
            this.btn_save.TabIndex = 35;
            this.btn_save.Text = "SAVE";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_edit
            // 
            this.btn_edit.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_edit.Location = new System.Drawing.Point(652, 392);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(124, 49);
            this.btn_edit.TabIndex = 36;
            this.btn_edit.Text = "EDIT";
            this.btn_edit.UseVisualStyleBackColor = true;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancel.Location = new System.Drawing.Point(522, 392);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(124, 49);
            this.btn_cancel.TabIndex = 37;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // volume1
            // 
            this.volume1.AutoSize = true;
            this.volume1.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.volume1.Location = new System.Drawing.Point(24, 42);
            this.volume1.Name = "volume1";
            this.volume1.Size = new System.Drawing.Size(125, 27);
            this.volume1.TabIndex = 28;
            this.volume1.Text = "Volume 1: ";
            // 
            // volume2
            // 
            this.volume2.AutoSize = true;
            this.volume2.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.volume2.Location = new System.Drawing.Point(24, 81);
            this.volume2.Name = "volume2";
            this.volume2.Size = new System.Drawing.Size(125, 27);
            this.volume2.TabIndex = 30;
            this.volume2.Text = "Volume 2: ";
            // 
            // volume3
            // 
            this.volume3.AutoSize = true;
            this.volume3.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.volume3.Location = new System.Drawing.Point(24, 120);
            this.volume3.Name = "volume3";
            this.volume3.Size = new System.Drawing.Size(125, 27);
            this.volume3.TabIndex = 32;
            this.volume3.Text = "Volume 3: ";
            // 
            // ndd_unitprice_1
            // 
            this.ndd_unitprice_1.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ndd_unitprice_1.Location = new System.Drawing.Point(164, 42);
            this.ndd_unitprice_1.Name = "ndd_unitprice_1";
            this.ndd_unitprice_1.Size = new System.Drawing.Size(98, 34);
            this.ndd_unitprice_1.TabIndex = 38;
            this.ndd_unitprice_1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ndd_unitprice_2
            // 
            this.ndd_unitprice_2.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ndd_unitprice_2.Location = new System.Drawing.Point(164, 79);
            this.ndd_unitprice_2.Name = "ndd_unitprice_2";
            this.ndd_unitprice_2.Size = new System.Drawing.Size(98, 34);
            this.ndd_unitprice_2.TabIndex = 39;
            this.ndd_unitprice_2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ndd_unitprice_3
            // 
            this.ndd_unitprice_3.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ndd_unitprice_3.Location = new System.Drawing.Point(164, 117);
            this.ndd_unitprice_3.Name = "ndd_unitprice_3";
            this.ndd_unitprice_3.Size = new System.Drawing.Size(98, 34);
            this.ndd_unitprice_3.TabIndex = 40;
            this.ndd_unitprice_3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ndd_unitprice_3);
            this.groupBox2.Controls.Add(this.ndd_unitprice_2);
            this.groupBox2.Controls.Add(this.ndd_unitprice_1);
            this.groupBox2.Controls.Add(this.volume3);
            this.groupBox2.Controls.Add(this.volume2);
            this.groupBox2.Controls.Add(this.volume1);
            this.groupBox2.Location = new System.Drawing.Point(522, 149);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(384, 191);
            this.groupBox2.TabIndex = 34;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Product Volume and Unit Price";
            // 
            // uc_products_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbl_productID);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.label4);
            this.Name = "uc_products_form";
            this.Size = new System.Drawing.Size(1003, 488);
            this.Load += new System.EventHandler(this.uc_products_form_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ndd_unitprice_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ndd_unitprice_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ndd_unitprice_3)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btn_back;
        private Label label4;
        private Label lbl_productID;
        private GroupBox groupBox1;
        private TextBox txt_product_desc;
        private Label label3;
        private TextBox txt_product_name;
        private Label label2;
        private ComboBox cmb_product_type;
        private Label label1;
        private Button btn_save;
        private Button btn_edit;
        private Button btn_cancel;
        private Label volume1;
        private Label volume2;
        private Label volume3;
        private NumericUpDown ndd_unitprice_1;
        private NumericUpDown ndd_unitprice_2;
        private NumericUpDown ndd_unitprice_3;
        private GroupBox groupBox2;
    }
}
