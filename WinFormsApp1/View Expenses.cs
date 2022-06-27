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
    public partial class View_Expenses : Form
    {
        public View_Expenses()
        {
            InitializeComponent();
            ShowExpense();
        }
        SqlConnection sqlConn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\AIPS\OneDrive\Documents\ExpensesDb.mdf;Integrated Security=True;Connect Timeout=30");
        private void ShowExpense()
        {
            sqlConn.Open();
            SqlDataAdapter sqlDA = new SqlDataAdapter("select * from ExpensesTbl where ExpUser = '"+Login.User+"'", sqlConn);
            SqlCommandBuilder sqlBld = new SqlCommandBuilder(sqlDA);
            var ds = new DataSet();
            sqlDA.Fill(ds);
            expensesDgv.DataSource = ds.Tables[0];
            sqlConn.Close();
        }
        private void ShowExByCat()
        {
            sqlConn.Open();
            SqlDataAdapter sqlDA = new SqlDataAdapter("select * from ExpensesTbl where ExpUser = '" + Login.User + "' and ExpCat = '"+ exCategoryCb.SelectedItem.ToString() +"'", sqlConn);
            SqlCommandBuilder sqlBld = new SqlCommandBuilder(sqlDA);
            var ds = new DataSet();
            sqlDA.Fill(ds);
            expensesDgv.DataSource = ds.Tables[0];
            sqlConn.Close();
        }


        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void exCategoryCb_SelectionChangeCommitted(object sender, EventArgs e)
        {
            ShowExByCat();
        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            exCategoryCb.SelectedIndex = -1;
            ShowExpense();
        }
    }
}
