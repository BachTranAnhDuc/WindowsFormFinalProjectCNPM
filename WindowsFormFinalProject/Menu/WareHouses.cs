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
    public partial class WareHouses : Form
    {
        public WareHouses()
        {
            InitializeComponent();
        }

        private void WareHouses_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'eShopManagementDataSet.wareHouse' table. You can move, or remove it, as needed.
            this.wareHouseTableAdapter.Fill(this.eShopManagementDataSet.wareHouse);

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];

            prdID.Text = row.Cells[0].Value.ToString();
            prdName.Text = row.Cells[1].Value.ToString();
            prdQuantity.Text = row.Cells[2].Value.ToString();
            prdPriceIn.Text = row.Cells[3].Value.ToString();
            prdPriceOut.Text = row.Cells[4].Value.ToString();
            prdCateName.Text = row.Cells[5].Value.ToString();
            prdEmID.Text = row.Cells[6].Value.ToString();
        }
    }
}
