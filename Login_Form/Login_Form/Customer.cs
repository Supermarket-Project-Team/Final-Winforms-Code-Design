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
    public partial class form_Customer : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter adp;
        DataSet ds;
        public form_Customer()
        {
            InitializeComponent();
        }

        private void btn_cust_back_Click(object sender, EventArgs e)
        {
            AdminLanding objadminlanding = new AdminLanding();
            this.Hide();
            objadminlanding.Show();
        }

        private void form_Customer_Load(object sender, EventArgs e)
        {
            con = new SqlConnection("data source=KRIPARAJ\\SQLEXPRESS; database=SuperMarket; user ID=sa; Password=Sukritha7###");
            con.Open();
            adp = new SqlDataAdapter("SELECT * FROM CUSTOMER", con);
            ds = new DataSet();
            adp.Fill(ds, "CUSTOMER");

            dgv_customers.DataSource = ds;
            dgv_customers.DataMember = "CUSTOMER";
        }
    }
}
