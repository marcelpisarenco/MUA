using System;
using System.Net;
using System.Net.Mail;
using System.Windows.Forms;

namespace MUA
{
    public partial class SendForm : Form
    {
        public SendForm()
        {
            InitializeComponent();
        }

        public SendForm(LoginForm loginForm)
        {
            InitializeComponent();
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void SendBtn_Click(object sender, EventArgs exception)
        {
            SmtpClient Client = new SmtpClient()
            {
                Host = "smtp.gmail.com",
                Port = 587,
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential()
                {
                    UserName = LoginForm.LoginValue,
                    Password = LoginForm.PasswordValue
                }
            };

            MailAddress From = new MailAddress(LoginForm.LoginValue, LoginForm.UserNameValue);
            MailAddress To = new MailAddress(EmailTextBox.Text);
            MailMessage Message = new MailMessage()
            {
                From = From,
                Subject = SubjectTextBox.Text,
                Body = MessageTextBox.Text,
            };

            Message.To.Add(To);
            try
            {
                Client.Send(Message);
                this.Hide();
                new MenuFormWindow().Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:\n" + ex.InnerException.Message);
            }
        }
        private void SendForm_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void LoginTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
