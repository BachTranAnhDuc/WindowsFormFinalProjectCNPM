using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormFinalProject.Menu;

namespace WindowsFormFinalProject
{
    public partial class HomePage : Form
    {
        private Form activeForm;

        public HomePage()
        {
            InitializeComponent();
        }

        private void HomePage_Load(object sender, EventArgs e)
        {

        }

        private void OpenChildForm(Form childForm)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }

            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelMain.Controls.Add(childForm);
            panelMain.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnWareHouse_Click(object sender, EventArgs e)
        {
            OpenChildForm(new WareHouses());

            Color myRgbColor = new Color();
            myRgbColor = Color.FromArgb(19, 15, 64);

            Color myRgbColor2 = new Color();
            myRgbColor2 = Color.FromArgb(48, 51, 107);

            textHead.Text = "Ware House";

            navBar.BackColor = myRgbColor;
            sideBar.BackColor = myRgbColor;
            logo.BackColor = myRgbColor2;

            btnHome.BackgroundColor = myRgbColor;
            btnWareHouse.BackgroundColor = myRgbColor;
            btnBill.BackgroundColor = myRgbColor;
            btnCustomer.BackgroundColor = myRgbColor;
            btnProduct.BackgroundColor = myRgbColor;
            btnStatistic.BackgroundColor = myRgbColor;
            btnLogOut.BackgroundColor = myRgbColor;
        }

        private void panelMain_Paint(object sender, PaintEventArgs e)
        {

        }

        private void iconMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void iconExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Reset()
        {
            textHead.Text = "Home Page";
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            Color myRgbColor = new Color();
            myRgbColor = Color.FromArgb(46, 157, 93);

            Color myRgbColor2 = new Color();
            myRgbColor2 = Color.FromArgb(151, 186, 161);

            textHead.Text = "Ware House";

            navBar.BackColor = myRgbColor;
            sideBar.BackColor = myRgbColor;
            logo.BackColor = myRgbColor2;

            btnHome.BackgroundColor = myRgbColor;
            btnWareHouse.BackgroundColor = myRgbColor;
            btnBill.BackgroundColor = myRgbColor;
            btnCustomer.BackgroundColor = myRgbColor;
            btnProduct.BackgroundColor = myRgbColor;
            btnStatistic.BackgroundColor = myRgbColor;
            btnLogOut.BackgroundColor = myRgbColor;
            activeForm.Close();
            Reset();

            
        }

        private void btnBill_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Bill());
            textHead.Text = "Bill Detail";

            Color myRgbColor = new Color();
            myRgbColor = Color.FromArgb(25, 42, 86);

            Color myRgbColor2 = new Color();
            myRgbColor2 = Color.FromArgb(39, 60, 117);

            navBar.BackColor = myRgbColor;
            sideBar.BackColor = myRgbColor;
            logo.BackColor = myRgbColor2;

            btnHome.BackgroundColor = myRgbColor;
            btnWareHouse.BackgroundColor = myRgbColor;
            btnBill.BackgroundColor = myRgbColor;
            btnCustomer.BackgroundColor = myRgbColor;
            btnProduct.BackgroundColor = myRgbColor;
            btnStatistic.BackgroundColor = myRgbColor;
            btnLogOut.BackgroundColor = myRgbColor;
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Products());
            textHead.Text = "Product";

            Color myRgbColor = new Color();
            myRgbColor = Color.FromArgb(34, 47, 62);

            Color myRgbColor2 = new Color();
            myRgbColor2 = Color.FromArgb(87, 101, 116);

            navBar.BackColor = myRgbColor;
            sideBar.BackColor = myRgbColor;
            logo.BackColor = myRgbColor2;

            btnHome.BackgroundColor = myRgbColor;
            btnWareHouse.BackgroundColor = myRgbColor;
            btnBill.BackgroundColor = myRgbColor;
            btnCustomer.BackgroundColor = myRgbColor;
            btnProduct.BackgroundColor = myRgbColor;
            btnStatistic.BackgroundColor = myRgbColor;
            btnLogOut.BackgroundColor = myRgbColor;
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Customer());
            textHead.Text = "Manage Customer";

            Color myRgbColor = new Color();
            myRgbColor = Color.FromArgb(10, 61, 98);

            Color myRgbColor2 = new Color();
            myRgbColor2 = Color.FromArgb(60, 99, 130);

            navBar.BackColor = myRgbColor;
            sideBar.BackColor = myRgbColor;
            logo.BackColor = myRgbColor2;

            btnHome.BackgroundColor = myRgbColor;
            btnWareHouse.BackgroundColor = myRgbColor;
            btnBill.BackgroundColor = myRgbColor;
            btnCustomer.BackgroundColor = myRgbColor;
            btnProduct.BackgroundColor = myRgbColor;
            btnStatistic.BackgroundColor = myRgbColor;
            btnLogOut.BackgroundColor = myRgbColor;
        }

        private void btnStatistic_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Statistic());
            textHead.Text = "Statistic";

            Color myRgbColor = new Color();
            myRgbColor = Color.FromArgb(109, 33, 79);

            Color myRgbColor2 = new Color();
            myRgbColor2 = Color.FromArgb(179, 55, 113);

            navBar.BackColor = myRgbColor;
            sideBar.BackColor = myRgbColor;
            logo.BackColor = myRgbColor2;

            btnHome.BackgroundColor = myRgbColor;
            btnWareHouse.BackgroundColor = myRgbColor;
            btnBill.BackgroundColor = myRgbColor;
            btnCustomer.BackgroundColor = myRgbColor;
            btnProduct.BackgroundColor = myRgbColor;
            btnStatistic.BackgroundColor = myRgbColor;
            btnLogOut.BackgroundColor = myRgbColor;
        }
    }
}
