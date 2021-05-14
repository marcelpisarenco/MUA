using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MUA
{
    public partial class MenuFormWindow : Form
    {
        public MenuFormWindow()
        {
            InitializeComponent();
        }

        private void SendEmailBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            new SendForm().Show();
        }

        private void ViewEmailsBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            new ReadMessages().Show();
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MenuForm_Load(object sender, EventArgs e)
        {
            WelcomeLabel.Text = "Welcome " + LoginForm.UserNameValue;
        }
    }
}
