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
    public partial class ProductDetail : Form
    {
        public ProductDetail()
        {
            InitializeComponent();
        }

        public ProductDetail(string msg)
        {
            InitializeComponent();
            label1.Text = msg;
        }

        SqlCommand cmd;
        SqlDataReader reader;
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-5LGQ0A2\ANHDUC;Initial Catalog=eShopManagement;Integrated Security=True");


        private void ProductDetail_Load(object sender, EventArgs e)
        {

        }

        private void dataGridProductDetail_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            con.Open();
            string sql = "select sum(quantity) as 'Quantity' from wareHouse inner join Product on wareHouse.productID = Product.productID where Product.nameCate like N'%" + label1.Text + "%'";

            SqlCommand com = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            dataGridProductDetail.DataSource = dt;
        }
    }
}
