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

namespace WindowsFormFinalProject.Menu
{
    public partial class Bill : Form
    {
/*        SqlConnection con;*/

        public Bill()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-5LGQ0A2\ANHDUC;Initial Catalog=eShopManagement;Integrated Security=True");
        SqlCommand cmd;



        private void Bill_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'eShopManagementDataSet2.BillDetail' table. You can move, or remove it, as needed.
            this.billDetailTableAdapter.Fill(this.eShopManagementDataSet2.BillDetail);
            // TODO: This line of code loads data into the 'eShopManagementDataSet1.Bill' table. You can move, or remove it, as needed.
            this.billTableAdapter.Fill(this.eShopManagementDataSet1.Bill);

        }

        public void ConnectionSQL()
        {
            con.Open();
            string sql = "select * from BillDetail";

            cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            dataGridDetailBill.DataSource = dt;
        }

        private void btnFindBillDetail_Click(object sender, EventArgs e)
        {
            con.Open();
            string sql = "select * from BillDetail where billID like N'%" + this.textBoxFindBill.Text + "%'";
            cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            dataGridDetailBill.DataSource = dt;
        }

        private void textBoxFindBill_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
