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
    public partial class Add_Expenses : Form
    {
        public Add_Expenses()
        {
            InitializeComponent();
        }
        SqlConnection sqlConn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\AIPS\OneDrive\Documents\ExpensesDb.mdf;Integrated Security=True;Connect Timeout=30");
        private void Clear()
        {
            exNameTb.Text = "";
            exAmountTb.Text = "";
            exCategoryCb.SelectedIndex = -1;
            exDescriptionTb.Text = "";
        }
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addExBtn_Click(object sender, EventArgs e)
        {
            if (exNameTb.Text == "" || exAmountTb.Text == "" || exCategoryCb.SelectedIndex == -1 || exDateDtp.Text == "")
            {
                MessageBox.Show("Fill all required information.");
            }
            else
            {
                sqlConn.Open();
                SqlCommand sqlCmd = new SqlCommand("Insert into ExpensesTbl (ExpName, ExpAmt, ExpCat, ExpDate, ExpDes, ExpUser) values (@ExN, @ExA, @ExC, @ExD, @ExDes, @ExU)", sqlConn);
                sqlCmd.Parameters.AddWithValue("@ExN", exNameTb.Text);
                sqlCmd.Parameters.AddWithValue("@ExA", exAmountTb.Text);
                sqlCmd.Parameters.AddWithValue("@ExC", exCategoryCb.SelectedItem.ToString());
                sqlCmd.Parameters.AddWithValue("@ExD", exDateDtp.Value.Date);
                sqlCmd.Parameters.AddWithValue("@ExDes", exDescriptionTb.Text);
                sqlCmd.Parameters.AddWithValue("@ExU", Login.User);
                sqlCmd.ExecuteNonQuery();
                MessageBox.Show("Expense Added.");
                sqlConn.Close();
                Clear();
            }
        }
    }
}