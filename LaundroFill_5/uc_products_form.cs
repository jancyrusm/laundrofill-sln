using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Data.SqlClient;
using System.Data.Sql;

namespace LaundroFill_5
{
    public partial class uc_products_form : UserControl
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter da;
        SqlDataReader dr;

        public string connection_string = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Shainna\\source\\repos\\LaundroFill_5\\LaundroFill_5\\Database.mdf;Integrated Security=True";


        public event EventHandler BackButtonClicked;
        public event EventHandler FunctionLoadData;
        public uc_products_form()
        {
            InitializeComponent();
        }

        public string ProductIDText
        {
            get 
            { 
                return lbl_productID.Text; 
            }
            set 
            {   
                lbl_productID.Text = value;
                loadData();
            }

        }
        private void btn_back_Click(object sender, EventArgs e)
        {
            BackButtonClicked?.Invoke(this, EventArgs.Empty);
            btn_save.Enabled = false;
            disableInputs();
        }

        private void loadData()
        {

            con = new SqlConnection(connection_string);
            cmd = new SqlCommand("SP_products", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@tagged", "loadProductsData");
            cmd.Parameters.AddWithValue("@ProductID", ProductIDText);
            da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Open();


            if (dt.Rows.Count > 0)
            {
                var row = dt.Rows[0];

                cmb_product_type.SelectedItem = row["ProductType"].ToString();
                txt_product_name.Text = row["ProductName"].ToString();
                txt_product_desc.Text = row["ProductDesc"].ToString();
                volume1.Text = row["Volume1"].ToString();
                volume2.Text = row["Volume2"].ToString();
                volume3.Text = row["Volume3"].ToString();
                ndd_unitprice_1.Value = Convert.ToDecimal(row["UnitPrice1"]);
                ndd_unitprice_2.Value = Convert.ToDecimal(row["UnitPrice2"]);
                ndd_unitprice_3.Value = Convert.ToDecimal(row["UnitPrice3"]);
            }
            else
            {
                MessageBox.Show("No product data found for the given Product ID.");
            }

            con.Close();
        }

        private void uc_products_form_Load(object sender, EventArgs e)
        {
             btn_save.Enabled = false;
            disableInputs();
           
        }

        private void disableInputs()
        {
            
            if(btn_save.Enabled == false)
            {
                cmb_product_type.Enabled = false;
                txt_product_name.Enabled = false;
                txt_product_desc.Enabled = false;
                ndd_unitprice_1.Enabled = false;
                ndd_unitprice_2.Enabled = false;
                ndd_unitprice_3.Enabled = false;
            }
            else
            {
                cmb_product_type.Enabled    = true;
                txt_product_name.Enabled    = true;
                txt_product_desc.Enabled    = true;
                ndd_unitprice_1.Enabled     = true;
                ndd_unitprice_2.Enabled     = true;
                ndd_unitprice_3.Enabled     = true;
            }
            
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            BackButtonClicked?.Invoke(this, EventArgs.Empty);
            btn_save.Enabled = false;
            disableInputs();
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            btn_save.Enabled = true;
            disableInputs();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            con = new SqlConnection(connection_string);
            cmd = new SqlCommand("SP_products", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@tagged", "UpdateProduct");
            cmd.Parameters.AddWithValue("@ProductID", ProductIDText);
            cmd.Parameters.AddWithValue("@ProductType", cmb_product_type.Text);
            cmd.Parameters.AddWithValue("@ProductName", txt_product_name.Text);
            cmd.Parameters.AddWithValue("@ProductDesc", txt_product_desc.Text);
            cmd.Parameters.AddWithValue("@UnitPrice1", ndd_unitprice_1.Text);
            cmd.Parameters.AddWithValue("@UnitPrice2", ndd_unitprice_2.Text);
            cmd.Parameters.AddWithValue("@UnitPrice3", ndd_unitprice_3.Text);
           
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

            btn_save.Enabled = false;
            disableInputs();
            loadData();

        }
    }
}
