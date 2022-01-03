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
    public partial class Customer : Form
    {
        public Customer()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-5LGQ0A2\ANHDUC;Initial Catalog=eShopManagement;Integrated Security=True");
        SqlCommand cmd;

        private void Customer_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'eShopManagementDataSet5.Customer' table. You can move, or remove it, as needed.
            this.customerTableAdapter.Fill(this.eShopManagementDataSet5.Customer);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnFindCusDetail_Click(object sender, EventArgs e)
        {
            CustomerBill ctmb = new CustomerBill(textBoxFindCus.Text);
            ctmb.ShowDialog();
        }
    }
}
