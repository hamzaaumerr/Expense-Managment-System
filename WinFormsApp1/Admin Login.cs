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
    public partial class Admin_Login : Form
    {
        public Admin_Login()
        {
            InitializeComponent();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            if (passwordTb.Text == "")
            {
                MessageBox.Show("Enter Password.");
            }
            else if (passwordTb.Text == "Hamza")
            {
                Users user = new Users();
                user.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Wrong Password.");
            }
        }
    }
}
