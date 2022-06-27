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
    public partial class Admin_Expenses : Form
    {
        public Admin_Expenses()
        {
            InitializeComponent();
            ShowAdminEx();
        }
        SqlConnection sqlConn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\AIPS\OneDrive\Documents\ExpensesDb.mdf;Integrated Security=True;Connect Timeout=30");
        private void ShowAdminEx()
        {
            sqlConn.Open();
            SqlDataAdapter sqlDA = new SqlDataAdapter("select * from ExpensesTbl", sqlConn);
            SqlCommandBuilder sqlBld = new SqlCommandBuilder(sqlDA);
            var ds = new DataSet();
            sqlDA.Fill(ds);
            adminExDgv.DataSource = ds.Tables[0];
            sqlConn.Close();
        }
        private void ShowAllExByCat()
        {
            sqlConn.Open();
            SqlDataAdapter sqlDA = new SqlDataAdapter("select * from ExpensesTbl where ExpCat = '"+ exCategoryCb.SelectedItem.ToString() +"'", sqlConn);
            SqlCommandBuilder sqlBld = new SqlCommandBuilder(sqlDA);
            var ds = new DataSet();
            sqlDA.Fill(ds);
            adminExDgv.DataSource = ds.Tables[0];
            sqlConn.Close();
        }


        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void logoutLbl_Click(object sender, EventArgs e)
        {
            
        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            exCategoryCb.SelectedIndex = -1;
            ShowAdminEx();
        }

        private void exCategoryCb_SelectionChangeCommitted(object sender, EventArgs e)
        {
            ShowAllExByCat();
        }
    }
}
