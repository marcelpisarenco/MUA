
namespace MUA
{
    partial class ReadMessages
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.UserEmailLabel = new System.Windows.Forms.Label();
            this.MailListBox = new System.Windows.Forms.ListBox();
            this.CloseBtn = new System.Windows.Forms.Button();
            this.SendEmailBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // UserEmailLabel
            // 
            this.UserEmailLabel.AutoSize = true;
            this.UserEmailLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.UserEmailLabel.Location = new System.Drawing.Point(12, 9);
            this.UserEmailLabel.Name = "UserEmailLabel";
            this.UserEmailLabel.Size = new System.Drawing.Size(75, 20);
            this.UserEmailLabel.TabIndex = 0;
            this.UserEmailLabel.Text = "UserEmail";
            // 
            // MailListBox
            // 
            this.MailListBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.MailListBox.FormattingEnabled = true;
            this.MailListBox.ItemHeight = 20;
            this.MailListBox.Location = new System.Drawing.Point(12, 46);
            this.MailListBox.Margin = new System.Windows.Forms.Padding(10);
            this.MailListBox.Name = "MailListBox";
            this.MailListBox.Size = new System.Drawing.Size(613, 324);
            this.MailListBox.TabIndex = 1;
            // 
            // CloseBtn
            // 
            this.CloseBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CloseBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.CloseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CloseBtn.ForeColor = System.Drawing.Color.White;
            this.CloseBtn.Location = new System.Drawing.Point(12, 380);
            this.CloseBtn.Margin = new System.Windows.Forms.Padding(0);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(108, 38);
            this.CloseBtn.TabIndex = 10;
            this.CloseBtn.Text = "Close";
            this.CloseBtn.UseVisualStyleBackColor = false;
            this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // SendEmailBtn
            // 
            this.SendEmailBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SendEmailBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.SendEmailBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SendEmailBtn.ForeColor = System.Drawing.Color.White;
            this.SendEmailBtn.Location = new System.Drawing.Point(158, 380);
            this.SendEmailBtn.Margin = new System.Windows.Forms.Padding(0);
            this.SendEmailBtn.Name = "SendEmailBtn";
            this.SendEmailBtn.Size = new System.Drawing.Size(108, 38);
            this.SendEmailBtn.TabIndex = 13;
            this.SendEmailBtn.Text = "Send Email";
            this.SendEmailBtn.UseVisualStyleBackColor = false;
            this.SendEmailBtn.Click += new System.EventHandler(this.SendEmailBtn_Click);
            // 
            // ReadMessages
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 427);
            this.Controls.Add(this.SendEmailBtn);
            this.Controls.Add(this.CloseBtn);
            this.Controls.Add(this.MailListBox);
            this.Controls.Add(this.UserEmailLabel);
            this.Name = "ReadMessages";
            this.Text = "ReadMessages";
            this.Load += new System.EventHandler(this.ReadMessages_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label UserEmailLabel;
        private System.Windows.Forms.ListBox MailListBox;
        private System.Windows.Forms.Button CloseBtn;
        private System.Windows.Forms.Button SendEmailBtn;
    }
}