
namespace MUA
{
    partial class SendForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.EmailTextBox = new System.Windows.Forms.TextBox();
            this.EmaiLabel = new System.Windows.Forms.Label();
            this.SubjectLabel = new System.Windows.Forms.Label();
            this.SubjectTextBox = new System.Windows.Forms.TextBox();
            this.MessageLabel = new System.Windows.Forms.Label();
            this.MessageTextBox = new System.Windows.Forms.TextBox();
            this.SendBtn = new System.Windows.Forms.Button();
            this.CloseBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // EmailTextBox
            // 
            this.EmailTextBox.BackColor = System.Drawing.Color.White;
            this.EmailTextBox.Location = new System.Drawing.Point(117, 68);
            this.EmailTextBox.Name = "EmailTextBox";
            this.EmailTextBox.Size = new System.Drawing.Size(309, 27);
            this.EmailTextBox.TabIndex = 1;
            // 
            // EmaiLabel
            // 
            this.EmaiLabel.AutoSize = true;
            this.EmaiLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.EmaiLabel.Location = new System.Drawing.Point(42, 71);
            this.EmaiLabel.Name = "EmaiLabel";
            this.EmaiLabel.Size = new System.Drawing.Size(46, 20);
            this.EmaiLabel.TabIndex = 2;
            this.EmaiLabel.Text = "Email";
            this.EmaiLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SubjectLabel
            // 
            this.SubjectLabel.AutoSize = true;
            this.SubjectLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.SubjectLabel.Location = new System.Drawing.Point(42, 123);
            this.SubjectLabel.Name = "SubjectLabel";
            this.SubjectLabel.Size = new System.Drawing.Size(58, 20);
            this.SubjectLabel.TabIndex = 4;
            this.SubjectLabel.Text = "Subject";
            this.SubjectLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SubjectTextBox
            // 
            this.SubjectTextBox.BackColor = System.Drawing.Color.White;
            this.SubjectTextBox.Location = new System.Drawing.Point(117, 120);
            this.SubjectTextBox.Name = "SubjectTextBox";
            this.SubjectTextBox.Size = new System.Drawing.Size(309, 27);
            this.SubjectTextBox.TabIndex = 3;
            // 
            // MessageLabel
            // 
            this.MessageLabel.AutoSize = true;
            this.MessageLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.MessageLabel.Location = new System.Drawing.Point(42, 181);
            this.MessageLabel.Name = "MessageLabel";
            this.MessageLabel.Size = new System.Drawing.Size(67, 20);
            this.MessageLabel.TabIndex = 6;
            this.MessageLabel.Text = "Message";
            this.MessageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MessageTextBox
            // 
            this.MessageTextBox.BackColor = System.Drawing.Color.White;
            this.MessageTextBox.Location = new System.Drawing.Point(117, 178);
            this.MessageTextBox.Multiline = true;
            this.MessageTextBox.Name = "MessageTextBox";
            this.MessageTextBox.Size = new System.Drawing.Size(309, 162);
            this.MessageTextBox.TabIndex = 5;
            // 
            // SendBtn
            // 
            this.SendBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SendBtn.BackColor = System.Drawing.SystemColors.Highlight;
            this.SendBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SendBtn.ForeColor = System.Drawing.Color.White;
            this.SendBtn.Location = new System.Drawing.Point(117, 361);
            this.SendBtn.Margin = new System.Windows.Forms.Padding(0);
            this.SendBtn.Name = "SendBtn";
            this.SendBtn.Size = new System.Drawing.Size(81, 48);
            this.SendBtn.TabIndex = 7;
            this.SendBtn.Text = "Send";
            this.SendBtn.UseVisualStyleBackColor = false;
            this.SendBtn.Click += new System.EventHandler(this.SendBtn_Click);
            // 
            // CloseBtn
            // 
            this.CloseBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CloseBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.CloseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CloseBtn.ForeColor = System.Drawing.Color.White;
            this.CloseBtn.Location = new System.Drawing.Point(345, 361);
            this.CloseBtn.Margin = new System.Windows.Forms.Padding(0);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(81, 48);
            this.CloseBtn.TabIndex = 8;
            this.CloseBtn.Text = "Close";
            this.CloseBtn.UseVisualStyleBackColor = false;
            this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // SendForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 479);
            this.Controls.Add(this.CloseBtn);
            this.Controls.Add(this.SendBtn);
            this.Controls.Add(this.MessageLabel);
            this.Controls.Add(this.MessageTextBox);
            this.Controls.Add(this.SubjectLabel);
            this.Controls.Add(this.SubjectTextBox);
            this.Controls.Add(this.EmaiLabel);
            this.Controls.Add(this.EmailTextBox);
            this.Name = "SendForm";
            this.Text = "Send Email";
            this.Load += new System.EventHandler(this.SendForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox EmailTextBox;
        private System.Windows.Forms.Label EmaiLabel;
        private System.Windows.Forms.Label SubjectLabel;
        private System.Windows.Forms.TextBox SubjectTextBox;
        private System.Windows.Forms.Label MessageLabel;
        private System.Windows.Forms.TextBox MessageTextBox;
        private System.Windows.Forms.Button SendBtn;
        private System.Windows.Forms.Button CloseBtn;
    }
}

