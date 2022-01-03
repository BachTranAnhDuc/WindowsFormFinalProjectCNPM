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

        private void btnWareAdd_Click(object sender, EventArgs e)
        {
            eShopManagementDataSet.wareHouseRow ware = this.eShopManagementDataSet.wareHouse.AddwareHouseRow(prdID.Text, prdName.Text, Int32.Parse(prdQuantity.Text), Int32.Parse(prdPriceIn.Text), Int32.Parse(prdPriceOut.Text), prdCateName.Text, prdEmID.Text);
            this.wareHouseTableAdapter.Update(ware);
            MessageBox.Show("Product add successfully!");
        }

        private void btnWareDelete_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show(
                "Are you sure", "Product Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question
            );

            if (dr == DialogResult.Yes)
            {
                int rowIndex = this.dataGridView1.CurrentCell.RowIndex;
                eShopManagementDataSet.wareHouseRow ware = (eShopManagementDataSet.wareHouseRow)this.eShopManagementDataSet.wareHouse.Rows[rowIndex];
                ware.Delete();

                this.wareHouseTableAdapter.Update(ware);

                MessageBox.Show("Product has been deleted!");
            }
        }

        private void btnWareUpdate_Click(object sender, EventArgs e)
        {
            int rowIndex = this.dataGridView1.CurrentCell.RowIndex;
            eShopManagementDataSet.wareHouseRow ware = (eShopManagementDataSet.wareHouseRow)this.eShopManagementDataSet.wareHouse.Rows[rowIndex];
            ware.productID = prdID.Text;
            ware.productName = prdName.Text;
            ware.quantity = Int32.Parse(prdQuantity.Text);
            ware.priceIn = Int32.Parse(prdPriceIn.Text);
            ware.priceOut = Int32.Parse(prdPriceOut.Text);
            ware.categoryName = prdCateName.Text;
            ware.employeeID = prdEmID.Text;


            this.wareHouseTableAdapter.Update(ware);

            MessageBox.Show("Product has been updated successfully!");
        }

        private void xuiButtonExecl_Click(object sender, EventArgs e)
        {
            // creating Excel Application  
            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
            // creating new WorkBook within Excel application  
            Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
            // creating new Excelsheet in workbook  
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
            // see the excel sheet behind the program  
            app.Visible = true;
            // get the reference of first sheet. By default its name is Sheet1.  
            // store its reference to worksheet  
            worksheet = workbook.Sheets["Sheet1"];
            worksheet = workbook.ActiveSheet;
            // changing the name of active sheet  
            worksheet.Name = "Exported from gridview";
            // storing header part in Excel  
            for (int i = 1; i < dataGridView1.Columns.Count + 1; i++)
            {
                worksheet.Cells[1, i] = dataGridView1.Columns[i - 1].HeaderText;
            }
            // storing Each row and column value to excel sheet  
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                for (int j = 0; j < dataGridView1.Columns.Count; j++)
                {
                    worksheet.Cells[i + 2, j + 1] = dataGridView1.Rows[i].Cells[j].Value.ToString();
                }
            }
            // save the application  
            workbook.SaveAs("D:\\Study\\Winform\\WindowsFormFinalProjectCNPM\\output.xls", Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
            // Exit from the application  
            app.Quit();
        }
    }
}
