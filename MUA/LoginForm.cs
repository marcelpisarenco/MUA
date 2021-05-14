using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MUA
{
    public partial class LoginForm : Form
    {
        public static string UserNameValue = "";
        public static string LoginValue = "";
        public static string PasswordValue = "";

        public LoginForm()
        {
            InitializeComponent();
        }


        private void UserNameLabel_Click(object sender, EventArgs e)
        {

        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            UserNameValue = UserNameTextBox.Text;
            LoginValue = LoginTextBox.Text;
            PasswordValue = PasswordTextBox.Text;

            this.Hide();
            new MenuFormWindow().Show();
            
        }
    }
}
