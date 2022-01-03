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
            for (int i = 1; i < dataGridDetailBill.Columns.Count + 1; i++)
            {
                worksheet.Cells[1, i] = dataGridDetailBill.Columns[i - 1].HeaderText;
            }
            // storing Each row and column value to excel sheet  
            for (int i = 0; i < dataGridDetailBill.Rows.Count - 1; i++)
            {
                for (int j = 0; j < dataGridDetailBill.Columns.Count; j++)
                {
                    worksheet.Cells[i + 2, j + 1] = dataGridDetailBill.Rows[i].Cells[j].Value.ToString();
                }
            }
            // save the application  
            workbook.SaveAs("D:\\Study\\Winform\\WindowsFormFinalProjectCNPM\\outputBillDetail.xls", Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
            // Exit from the application  
            app.Quit();
        }
    }
}
