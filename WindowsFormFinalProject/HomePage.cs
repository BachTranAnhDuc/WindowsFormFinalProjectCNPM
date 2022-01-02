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
            activeForm.Close();
            Reset();

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
        }

        private void btnBill_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Bill());
            textHead.Text = "Bill Detail";
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Products());
            textHead.Text = "Product";
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Customer());
            textHead.Text = "Manage Customer";
        }
    }
}
