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
    public partial class StatisticBill : Form
    {
        public StatisticBill()
        {
            InitializeComponent();
        }

        SqlCommand cmd;
        SqlDataReader reader;
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-5LGQ0A2\ANHDUC;Initial Catalog=eShopManagement;Integrated Security=True");

        private void xuiButton2_Click(object sender, EventArgs e)
        {
            con.Open();
            string sql = "select prdID, price from BillDetail";

            cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            da.Fill(dt);

            con.Close();

            Chart1.DataSource = dt;

            Chart1.Series["priceIn"].XValueMember = "prdID";
            Chart1.Series["priceIn"].YValueMembers = "price";

            Chart1.Titles.Add("Price Chart");
        }

        private void xuiButton1_Click(object sender, EventArgs e)
        {
            con.Open();
            string sql = "select prdID, price from BillDetail";

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
