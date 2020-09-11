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

namespace Login_Form
{
    public partial class form_login : Form
    {
        SqlConnection con;
        SqlDataAdapter adp;
        DataTable dt;
        public form_login()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            con = new SqlConnection("data source=KRIPARAJ\\SQLEXPRESS; database=SuperMarket; user ID=sa; password=Sukritha7###");
            con.Open();
        }
        
        private void btn_Login_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM USER_TABLE WHERE USER_NAME= '" + txt_username.Text.Trim() + "' and PASSWORD='" + txt_password.Text.Trim() + "' ";
            adp = new SqlDataAdapter(query, con);
            dt = new DataTable();
            adp.Fill(dt);
            if (dt.Rows.Count == 1)
            {
                AdminLanding objadminlanding = new AdminLanding();
                this.Hide();
                objadminlanding.Show();
                MessageBox.Show("Done");
            }
            else
            {
                MessageBox.Show("Username or password is incorrect");
            }
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
