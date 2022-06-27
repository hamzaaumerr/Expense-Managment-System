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
    public partial class Report : Form
    {
        public Report()
        {
            InitializeComponent();
            CountExp();
            GetMaxExp();
            GetMinExp();
            GetTotExp();
            GetAvgExp();
            GetHiExp();
            GetLoExp();
        }
        SqlConnection sqlConn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\AIPS\OneDrive\Documents\ExpensesDb.mdf;Integrated Security=True;Connect Timeout=30");
        
        private void CountExp()
        {
            sqlConn.Open();
            SqlDataAdapter sqlda = new SqlDataAdapter("select Count(*) from ExpensesTbl where ExpUser = '" + Login.User + "'", sqlConn);
            DataTable dt = new DataTable();
            sqlda.Fill(dt);
            countLbl.Text = dt.Rows[0][0].ToString() + " Expenses";
            sqlConn.Close();
        }
        private void GetMaxExp()
        {
            sqlConn.Open();
            SqlDataAdapter sqlda = new SqlDataAdapter("select Max(ExpAmt) from ExpensesTbl where ExpUser = '"+ Login.User +"'", sqlConn);
            DataTable dt = new DataTable(); 
            sqlda.Fill(dt);
            maxLbl.Text = "Rs " + dt.Rows[0][0].ToString();
            sqlConn.Close();
        }
        private void GetMinExp()
        {
            sqlConn.Open();
            SqlDataAdapter sqlda = new SqlDataAdapter("select Min(ExpAmt) from ExpensesTbl where ExpUser = '" + Login.User + "'", sqlConn);
            DataTable dt = new DataTable();
            sqlda.Fill(dt);
            minLbl.Text = "Rs " + dt.Rows[0][0].ToString();
            sqlConn.Close();
        }
        private void GetAvgExp()
        {
            sqlConn.Open();
            SqlDataAdapter sqlda = new SqlDataAdapter("select Sum(ExpAmt) from ExpensesTbl where ExpUser = '" + Login.User + "'", sqlConn);
            SqlDataAdapter sqlda1 = new SqlDataAdapter("select Count(*) from ExpensesTbl where ExpUser = '" + Login.User + "'", sqlConn);

            DataTable dt = new DataTable();
            DataTable dt1 = new DataTable();

            sqlda.Fill(dt);
            sqlda1.Fill(dt1);

            Double avg = Convert.ToDouble(dt.Rows[0][0].ToString()) / Convert.ToDouble(dt1.Rows[0][0].ToString());
            avgLbl.Text = "Rs " + avg;
            sqlConn.Close();
        }
        private void GetTotExp()
        {
            sqlConn.Open();
            SqlDataAdapter sqlda = new SqlDataAdapter("select Sum(ExpAmt) from ExpensesTbl where ExpUser = '" + Login.User + "'", sqlConn);
            DataTable dt = new DataTable();
            sqlda.Fill(dt);
            totLbl.Text = "Rs " + dt.Rows[0][0].ToString();
            sqlConn.Close();
        }
        private void GetTotExpByCat()
        {
            sqlConn.Open();
            SqlDataAdapter sqlda = new SqlDataAdapter("select Sum(ExpAmt) from ExpensesTbl where ExpUser = '" + Login.User + "' and ExpCat = '"+ exCatCb.SelectedItem.ToString() +"'", sqlConn);
            DataTable dt = new DataTable();
            sqlda.Fill(dt);
            amountLbl.Text = "Rs " + dt.Rows[0][0].ToString();
            sqlConn.Close();
        }
        private void GetHiExp()
        {
            sqlConn.Open();
            SqlDataAdapter sqlda = new SqlDataAdapter("select Max(ExpAmt) from ExpensesTbl", sqlConn);
            DataTable dt = new DataTable();
            sqlda.Fill(dt);

            SqlDataAdapter sqlda1 = new SqlDataAdapter("select ExpCat from ExpensesTbl where ExpAmt = '"+ dt.Rows[0][0].ToString() +"'", sqlConn);
            DataTable dt1 = new DataTable();
            sqlda1.Fill(dt1);


            hiExLbl.Text = dt1.Rows[0][0].ToString();
            sqlConn.Close();
        }
        private void GetLoExp()
        {
            sqlConn.Open();
            SqlDataAdapter sqlda = new SqlDataAdapter("select Min(ExpAmt) from ExpensesTbl", sqlConn);
            DataTable dt = new DataTable();
            sqlda.Fill(dt);

            SqlDataAdapter sqlda1 = new SqlDataAdapter("select ExpCat from ExpensesTbl where ExpAmt = '" + dt.Rows[0][0].ToString() + "'", sqlConn);
            DataTable dt1 = new DataTable();
            sqlda1.Fill(dt1);


            loExLbl.Text = dt1.Rows[0][0].ToString();
            sqlConn.Close();
        }


        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void exCatCb_SelectionChangeCommitted(object sender, EventArgs e)
        {
            GetTotExpByCat();
        }

        private void countLbl_Click(object sender, EventArgs e)
        {

        }
    }
}
