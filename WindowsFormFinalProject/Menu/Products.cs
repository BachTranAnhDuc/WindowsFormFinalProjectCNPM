using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormFinalProject.Menu
{
    public partial class Products : Form
    {
        public Products()
        {
            InitializeComponent();
        }

        private void Products_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'eShopManagementDataSet4.Category' table. You can move, or remove it, as needed.
            this.categoryTableAdapter.Fill(this.eShopManagementDataSet4.Category);
            // TODO: This line of code loads data into the 'eShopManagementDataSet3.Product' table. You can move, or remove it, as needed.
            this.productTableAdapter.Fill(this.eShopManagementDataSet3.Product);

        }
    }
}
