using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Limilabs.Client.POP3;
using Limilabs.Mail;

namespace MUA
{
    public partial class ReadMessages : Form
    {
        public ReadMessages()
        {
            InitializeComponent();
        }

        private void ReadMessages_Load(object sender, EventArgs e)
        {
            UserEmailLabel.Text = LoginForm.UserNameValue + " Mail List:";
            using (Pop3 pop3 = new Pop3())
            {
                pop3.Connect("pop.gmail.com", 995, true); 
                pop3.UseBestLogin("recent:"+LoginForm.LoginValue, LoginForm.PasswordValue);
                List<string> UidList = pop3.GetAll();

                foreach (string uid in UidList)
                {
                    IMail email = new MailBuilder().CreateFromEml(pop3.GetMessageByUID(uid));
                    MailListBox.Items.Add(email.From);
                    MailListBox.Items.Add(email.GetBodyAsText());
                    MailListBox.Items.Add(" ");
                }
                pop3.Close();
            }
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void SendEmailBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            new SendForm().Show();
        }
    }

}
