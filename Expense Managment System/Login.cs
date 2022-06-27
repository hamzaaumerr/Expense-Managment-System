using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WinFormsApp1
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        SqlConnection sqlConn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\AIPS\OneDrive\Documents\ExpensesDb.mdf;Integrated Security=True;Connect Timeout=30");
        public static string User;
        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            sqlConn.Open();
            SqlDataAdapter sqlDa = new SqlDataAdapter("select * from UsersTbl where UName = '"+usernameTb.Text+"' and UPass = '"+passwordTb.Text+"'", sqlConn);
            DataTable dt = new DataTable();
            sqlDa.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                User = usernameTb.Text;
                Menu menu = new Menu();
                menu.Show();
                this.Hide();
                sqlConn.Close();

            }
            else
            {
                MessageBox.Show("Wrong Username or Password.");
            }
            sqlConn.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Admin_Login adLogin = new Admin_Login();
            adLogin.Show();
            this.Hide();
        }
    }
}
