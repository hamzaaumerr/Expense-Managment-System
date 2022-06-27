using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
            dayLbl.Text = DateTime.Today.Day.ToString();
            monthLbl.Text = DateTime.Today.Month.ToString();
            usernameTb.Text = Login.User;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Add_Expenses aExpences = new Add_Expenses();
            aExpences.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void logoutLbl_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            View_Expenses vExpenses = new View_Expenses();
            vExpenses.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Report nReport = new Report();
            nReport.Show();
        }

        private void usernameTb_Click(object sender, EventArgs e)
        {

        }
    }
}
