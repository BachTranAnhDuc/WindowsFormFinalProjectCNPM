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
using System.Windows.Forms.DataVisualization.Charting;

namespace WindowsFormFinalProject.Menu
{
    public partial class Statistic : Form
    {
        public Statistic()
        {
            InitializeComponent();
        }
        private Form activeForm;
        SqlCommand cmd;
        SqlDataReader reader;
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-5LGQ0A2\ANHDUC;Initial Catalog=eShopManagement;Integrated Security=True");


        private void Statistic_Load(object sender, EventArgs e)
        {

        }

        private void Chart1_Click(object sender, EventArgs e)
        {

        }


        private void xuiButton1_Click(object sender, EventArgs e)
        {
            con.Open();
            string sql = "select productID, priceIn from wareHouse";

            cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            dataGridView1.DataSource = dt;
        }

        private void xuiButton2_Click(object sender, EventArgs e)
        {
            con.Open();
            string sql = "select productID, priceIn from wareHouse";

            cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            da.Fill(dt);

            con.Close();

            Chart1.DataSource = dt;

            Chart1.Series["priceIn"].XValueMember = "productID";
            Chart1.Series["priceIn"].YValueMembers = "priceIn";

            Chart1.Titles.Add("Price Chart");
        }

        private void xuiButton3_Click(object sender, EventArgs e)
        {
            StatisticBill stb = new StatisticBill();
            stb.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void xuiButton4_Click(object sender, EventArgs e)
        {
            StatisticCateWare stc = new StatisticCateWare();
            stc.ShowDialog();
        }

        private void xuiButton5_Click(object sender, EventArgs e)
        {
            StatisticOut stt = new StatisticOut();
            stt.ShowDialog();
        }
    }
}
