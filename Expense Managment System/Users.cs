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
    public partial class Users : Form
    {
        public Users()
        {
            InitializeComponent();
            ShowUser();
        }
        SqlConnection sqlConn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\AIPS\OneDrive\Documents\ExpensesDb.mdf;Integrated Security=True;Connect Timeout=30");
        private void ShowUser()
        {
            sqlConn.Open();
            SqlDataAdapter sqlDA = new SqlDataAdapter("select * from UsersTbl" , sqlConn);
            SqlCommandBuilder sqlBld = new SqlCommandBuilder(sqlDA);
            var ds = new DataSet();
            sqlDA.Fill(ds);
            usersDgv.DataSource = ds.Tables[0];
            sqlConn.Close();
        }
        private void Clear()
        {
            nameTb.Text = "";
            phoneTb.Text = "";
            dobDtp.Text = "";
            passTb.Text = "";
            addressTb.Text = "";
        }
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            if (nameTb.Text == "" || phoneTb.Text == "" || dobDtp.Text == "" || passTb.Text == "")
            {
                MessageBox.Show("Fill all required information.");
            }
            else
            {
                sqlConn.Open();
                SqlCommand sqlCmd = new SqlCommand("Insert into UsersTbl (UName, UDOB, UPhone, UPass, UAddress) values (@UNAME, @UDOB, @UPHONE, @UPASSWORD, @UADDRESS)", sqlConn);
                sqlCmd.Parameters.AddWithValue("@UNAME", nameTb.Text);
                sqlCmd.Parameters.AddWithValue("@UDOB", dobDtp.Value.Date);
                sqlCmd.Parameters.AddWithValue("@UPHONE", phoneTb.Text);
                sqlCmd.Parameters.AddWithValue("@UPASSWORD", passTb.Text);
                sqlCmd.Parameters.AddWithValue("@UADDRESS", addressTb.Text);
                sqlCmd.ExecuteNonQuery();
                MessageBox.Show("User Added.");
                sqlConn.Close();
                ShowUser();
                Clear();
            }
        }

        private void Users_Load(object sender, EventArgs e)
        {

        }

        private void usersDgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            Admin_Expenses adEx = new Admin_Expenses();
            adEx.Show();
        }

        private void logoutLbl_Click(object sender, EventArgs e)
        {
            Admin_Login login = new Admin_Login();
            login.Show();
            this.Close();
        }
    }
}
