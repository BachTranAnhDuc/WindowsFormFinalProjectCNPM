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
    public partial class CustomerBill : Form
    {
        public CustomerBill()
        {
            InitializeComponent();
        }

        SqlCommand cmd;
        SqlDataReader reader;
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-5LGQ0A2\ANHDUC;Initial Catalog=eShopManagement;Integrated Security=True");

        public CustomerBill(string msg)
        {
            InitializeComponent();
            label1.Text = msg;
        }

        private void CustomerBill_Load(object sender, EventArgs e)
        {

        }

        private void xuiButtonShow_Click(object sender, EventArgs e)
        {
            con.Open();
            string sql = "select Customer.cusID, Customer.nameCus, Bill.billID, Bill.empID, Bill.datePick from Customer inner join Bill on Customer.cusID = Bill.cusID where Customer.cusID like N'%" + label1.Text + "%'";
            cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            dataGridView1.DataSource = dt;
        }
    }
}
