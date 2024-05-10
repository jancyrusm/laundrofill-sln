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

namespace LaundroFill_5
{
    public partial class uc_products : UserControl
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter da;
        SqlDataReader dr;

        public string connection_string = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Shainna\\source\\repos\\LaundroFill_5\\LaundroFill_5\\Database.mdf;Integrated Security=True";

        public event EventHandler BackButtonClicked;

        public string productID1 = null;
        public string productID2 = null;
        public string productID3 = null;
        public string productID4 = null;

        public string productName1 = "product 1";
        public string productName2 = "product 2";
        public string productName3 = "product 3";
        public string productName4 = "product 4";


        public uc_products()
        {
            InitializeComponent();

            uc_products_form1.BackButtonClicked += Uc_product_form2_BackButtonClicked;
            //uc_products_form1.FunctionLoadData += Uc_product_form2_FunctionLoadData;
        }

        private void loadData()
        {
            con = new SqlConnection(connection_string);
            cmd = new SqlCommand("SP_products", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@tagged", "loadProductNames");
            da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Open();
            con.Close();

            if (dt.Rows.Count > 0)
            {
                if (dt.Rows.Count >= 1)
                {
                    productID1 = dt.Rows[0]["ProductID"] != DBNull.Value ? dt.Rows[0]["ProductID"].ToString() : null;
                    productName1 = dt.Rows[0]["ProductName"] != DBNull.Value ? dt.Rows[0]["ProductName"].ToString() : null;
                }
                if (dt.Rows.Count >= 2)
                {
                    productID2 = dt.Rows[1]["ProductID"] != DBNull.Value ? dt.Rows[1]["ProductID"].ToString() : null;
                    productName2 = dt.Rows[1]["ProductName"] != DBNull.Value ? dt.Rows[1]["ProductName"].ToString() : null;
                }
                if (dt.Rows.Count >= 3)
                {
                    productID3 = dt.Rows[2]["ProductID"] != DBNull.Value ? dt.Rows[2]["ProductID"].ToString() : null;
                    productName3 = dt.Rows[2]["ProductName"] != DBNull.Value ? dt.Rows[2]["ProductName"].ToString() : null;
                }
                if (dt.Rows.Count >= 3)
                {
                    productID4 = dt.Rows[3]["ProductID"] != DBNull.Value ? dt.Rows[3]["ProductID"].ToString() : null;
                    productName4 = dt.Rows[3]["ProductName"] != DBNull.Value ? dt.Rows[3]["ProductName"].ToString() : null;
                }
            }
        }
        private void uc_products_Load(object sender, EventArgs e)
        {

            loadData();

            btn_product1.Text = productName1;
            btn_product2.Text = productName2;
            btn_product3.Text = productName3;
            btn_product4.Text = productName4;

        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            BackButtonClicked?.Invoke(this, EventArgs.Empty);
        }

        private void btn_product1_Click(object sender, EventArgs e)
        {
            uc_products_form1.ProductIDText = productID1.ToString();
            uc_products_form1.Show();
        }

        private void btn_product2_Click(object sender, EventArgs e)
        {
            uc_products_form1.ProductIDText = productID2.ToString();
            uc_products_form1.Show();
        }

        private void btn_product3_Click(object sender, EventArgs e)
        {
            uc_products_form1.ProductIDText = productID3.ToString();
            uc_products_form1.Show();
        }

        private void btn_product4_Click(object sender, EventArgs e)
        {
            uc_products_form1.ProductIDText = productID4.ToString();
            uc_products_form1.Show();
        }

        private void Uc_product_form2_BackButtonClicked(object sender, EventArgs e)
        {
            loadData();
            btn_product1.Text = productName1;
            btn_product2.Text = productName2;
            btn_product3.Text = productName3;
            btn_product4.Text = productName4;

            uc_products_form1.Hide();
        }


    }
}
