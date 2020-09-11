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
    public partial class form_Staff : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter adp;
        DataSet ds;
        public form_Staff()
        {
            InitializeComponent();
        }

        private void Staff_Load(object sender, EventArgs e)
        {
            con = new SqlConnection("data source=KRIPARAJ\\SQLEXPRESS; database=SuperMarket; user ID=sa; Password=Sukritha7###");
            con.Open();
            adp = new SqlDataAdapter("SELECT * FROM STAFF", con);
            ds = new DataSet();
            adp.Fill(ds, "STAFF");

            dgv_staff.DataSource = ds;
            dgv_staff.DataMember = "STAFF";
        }

        private void btn_staff_back_Click(object sender, EventArgs e)
        {
            AdminLanding objadminlanding = new AdminLanding();
            this.Hide();
            objadminlanding.Show();
        }

        private void dgv_staff_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
