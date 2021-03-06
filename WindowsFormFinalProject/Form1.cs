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

namespace WindowsFormFinalProject
{
    public partial class Form1 : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader reader;

        public Form1()
        {
            InitializeComponent();
        }

        public string SetValueForText1 = "";

        private void Form1_Load(object sender, EventArgs e)
        {
            passwordInput.PasswordChar = '*';
        }



        private void iconMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void iconExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSubmit_Click_1(object sender, EventArgs e)
        {
            String result = "";
            SetValueForText1 = usernameInput.Text.ToString();
            try
            {
                con = new SqlConnection(@"Data Source=DESKTOP-5LGQ0A2\ANHDUC;Initial Catalog=eShopManagement;Integrated Security=True");
                cmd = new SqlCommand("select * from Employee where uname = @uname and pwd = @pwd", con);
                con.Open();
                cmd.Parameters.AddWithValue("@uname", usernameInput.Text.ToString());
                cmd.Parameters.AddWithValue("@pwd", passwordInput.Text.ToString());
                reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    if (reader["pwd"].ToString().Equals(passwordInput.Text.ToString(), StringComparison.InvariantCulture))
                    {
                        UserInfo.userID = reader["ID"].ToString();
                        UserInfo.userName = reader["uname"].ToString();
                        result = "1";
                    }
                    else
                    {
                        result = "Invalid Connection";
                    }
                }
                else
                {
                    result = "Connection Failed";
                }

                reader.Close();
                cmd.Dispose();
                con.Close();
            }
            catch (Exception ex)
            {
                result = ex.Message.ToString();
            }
            if (result == "1")
            {
                Program.openDashboard = true;
                this.Close();
            }
            else
            {
                MessageBox.Show(result);
            }
        }

        private void xuiSwitch1_Click(object sender, EventArgs e)
        {
            if (passwordInput.PasswordChar == '*')
            {
                passwordInput.PasswordChar = '\0';
            }
            else
            {
                passwordInput.PasswordChar = '*';
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
