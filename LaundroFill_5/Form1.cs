using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Sql;

namespace LaundroFill_5
{
    public partial class admin_form : Form  
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter da;
        SqlDataReader dr;

        public string connection_string = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Shainna\\source\\repos\\LaundroFill_5\\LaundroFill_5\\Database.mdf;Integrated Security=True";

        public admin_form()
        {
            InitializeComponent();
            load_panels("login");

            uc_products1.BackButtonClicked += Uc_products1_BackButtonClicked;
            //uc_transactions2.BackButtonClicked += Uc_transactions1_BackButtonClicked;
            //uc_reports2.BackButtonClicked += Uc_reports1_BackButtonClicked;
            uc_settings1.BackButtonClicked += Uc_settings1_BackButtonClicked;

        }

        private void admin_form_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(connection_string);
            //con.Open();
        }

        private void load_panels(string nextPanel)
        {
            panel_login.Hide();
            panel_usercontrols.Hide();

            if (nextPanel == "login")
            {
                panel_login.Show();
            }
            else if (nextPanel == "usercontrols")
            {
                panel_usercontrols.Show();
            }
            else if (nextPanel == "main")
            {
                panel_login.Hide();
                panel_usercontrols.Hide();
            }
        }

        private void load_usercontrols(string nextUC)
        {
            uc_products1.Hide();
            //uc_transactions2.Hide();
            //uc_reports2.Hide();
            uc_settings1.Hide();

            if (nextUC == "products")
            {
                uc_products1.Show();
            }
            //else if (nextUC == "transactions")
            //{
            //    uc_transactions2.Show();
            //}
            //else if (nextUC == "reports")
            //{
            //    uc_reports2.Show();
            //}
            else if (nextUC == "settings")
            {
                uc_settings1.Show();
            }
            //else if (nextUC == "main")
            //{
            //    panel_login.Hide();
            //    panel_usercontrols.Hide();
            //}
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            string username = txt_username.Text;
            string password = txt_password.Text;

            con.Open();
            cmd = new SqlCommand("SP_account", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@tagged", "user_login");
            cmd.Parameters.AddWithValue("@UserID", "1");
            cmd.Parameters.AddWithValue("@Username", username);
            cmd.Parameters.AddWithValue("@Password", password);
            da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            if(dt.Rows.Count > 0)
            {
                MessageBox.Show("Login successful!");
                panel_login.Hide();
            }
            else
            {
                MessageBox.Show("Invalid username or password.");
            }

            con.Close();
        }

        private void btn_products_Click(object sender, EventArgs e)
        {
            load_panels("usercontrols");
            load_usercontrols("products");
        }

        private void Uc_products1_BackButtonClicked(object sender, EventArgs e)
        {
            load_panels("main");
            load_usercontrols("transactions");
        }


        private void btn_transactions_Click(object sender, EventArgs e)
        {
            load_panels("usercontrols");
        }

        private void Uc_transactions1_BackButtonClicked(object sender, EventArgs e)
        {
            load_panels("main");
            load_usercontrols("transactions");
        }

        private void btn_reports_Click(object sender, EventArgs e)
        {
            load_panels("usercontrols");
            load_usercontrols("reports");
        }

        private void Uc_reports1_BackButtonClicked(object sender, EventArgs e)
        {
            load_panels("main");

        }

        private void btn_settings_Click(object sender, EventArgs e)
        {
            load_panels("usercontrols");
            load_usercontrols("settings");
        }

        private void Uc_settings1_BackButtonClicked(object sender, EventArgs e)
        {
            load_panels("main");

        }

        
    }
}
