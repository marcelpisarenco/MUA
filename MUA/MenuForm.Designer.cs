
namespace MUA
{
    partial class MenuFormWindow
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
            this.CloseBtn = new System.Windows.Forms.Button();
            this.WelcomeLabel = new System.Windows.Forms.Label();
            this.ViewEmailsBtn = new System.Windows.Forms.Button();
            this.SendEmailBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CloseBtn
            // 
            this.CloseBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CloseBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.CloseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CloseBtn.ForeColor = System.Drawing.Color.White;
            this.CloseBtn.Location = new System.Drawing.Point(141, 230);
            this.CloseBtn.Margin = new System.Windows.Forms.Padding(0);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(108, 48);
            this.CloseBtn.TabIndex = 9;
            this.CloseBtn.Text = "Close";
            this.CloseBtn.UseVisualStyleBackColor = false;
            this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // WelcomeLabel
            // 
            this.WelcomeLabel.AutoSize = true;
            this.WelcomeLabel.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.WelcomeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.WelcomeLabel.Location = new System.Drawing.Point(108, 9);
            this.WelcomeLabel.Name = "WelcomeLabel";
            this.WelcomeLabel.Size = new System.Drawing.Size(180, 30);
            this.WelcomeLabel.TabIndex = 10;
            this.WelcomeLabel.Text = "Welcome Marcus";
            // 
            // ViewEmailsBtn
            // 
            this.ViewEmailsBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ViewEmailsBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.ViewEmailsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ViewEmailsBtn.ForeColor = System.Drawing.Color.White;
            this.ViewEmailsBtn.Location = new System.Drawing.Point(141, 144);
            this.ViewEmailsBtn.Margin = new System.Windows.Forms.Padding(0);
            this.ViewEmailsBtn.Name = "ViewEmailsBtn";
            this.ViewEmailsBtn.Size = new System.Drawing.Size(108, 48);
            this.ViewEmailsBtn.TabIndex = 11;
            this.ViewEmailsBtn.Text = "View Emails";
            this.ViewEmailsBtn.UseVisualStyleBackColor = false;
            this.ViewEmailsBtn.Click += new System.EventHandler(this.ViewEmailsBtn_Click);
            // 
            // SendEmailBtn
            // 
            this.SendEmailBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SendEmailBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.SendEmailBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SendEmailBtn.ForeColor = System.Drawing.Color.White;
            this.SendEmailBtn.Location = new System.Drawing.Point(141, 66);
            this.SendEmailBtn.Margin = new System.Windows.Forms.Padding(0);
            this.SendEmailBtn.Name = "SendEmailBtn";
            this.SendEmailBtn.Size = new System.Drawing.Size(108, 48);
            this.SendEmailBtn.TabIndex = 12;
            this.SendEmailBtn.Text = "Send Email";
            this.SendEmailBtn.UseVisualStyleBackColor = false;
            this.SendEmailBtn.Click += new System.EventHandler(this.SendEmailBtn_Click);
            // 
            // MenuFormWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 330);
            this.Controls.Add(this.SendEmailBtn);
            this.Controls.Add(this.ViewEmailsBtn);
            this.Controls.Add(this.WelcomeLabel);
            this.Controls.Add(this.CloseBtn);
            this.Name = "MenuFormWindow";
            this.Text = "MenuForm";
            this.Load += new System.EventHandler(this.MenuForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CloseBtn;
        private System.Windows.Forms.Label WelcomeLabel;
        private System.Windows.Forms.Button ViewEmailsBtn;
        private System.Windows.Forms.Button SendEmailBtn;
    }
}