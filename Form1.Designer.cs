namespace WinForms_SimpleSendingEmail_V_1._0
{
    partial class Form1
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
            label = new Label();
            textBox_senderAddress = new TextBox();
            label2 = new Label();
            textBox_senderPassword = new TextBox();
            label3 = new Label();
            textBox_smtpServer = new TextBox();
            label4 = new Label();
            textBox_smtpPort = new TextBox();
            label5 = new Label();
            textBox_recerverEmail = new TextBox();
            button_sendEmail = new Button();
            label6 = new Label();
            textBox_emailSubject = new TextBox();
            label7 = new Label();
            textBox_emailContent = new TextBox();
            label8 = new Label();
            label9 = new Label();
            label1 = new Label();
            textBox_senderName = new TextBox();
            label10 = new Label();
            label_output = new Label();
            label11 = new Label();
            label_status = new Label();
            SuspendLayout();
            // 
            // label
            // 
            label.AutoSize = true;
            label.Location = new Point(30, 82);
            label.Name = "label";
            label.Size = new Size(134, 15);
            label.TabIndex = 0;
            label.Text = "Your  OUTLOOK address";
            // 
            // textBox_senderAddress
            // 
            textBox_senderAddress.Location = new Point(170, 79);
            textBox_senderAddress.Name = "textBox_senderAddress";
            textBox_senderAddress.PlaceholderText = "like xxxx@outlook.com";
            textBox_senderAddress.Size = new Size(149, 23);
            textBox_senderAddress.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(30, 116);
            label2.Name = "label2";
            label2.Size = new Size(116, 15);
            label2.TabIndex = 2;
            label2.Text = "Your email password";
            // 
            // textBox_senderPassword
            // 
            textBox_senderPassword.Location = new Point(170, 116);
            textBox_senderPassword.Name = "textBox_senderPassword";
            textBox_senderPassword.PasswordChar = '@';
            textBox_senderPassword.PlaceholderText = "Enter your email password";
            textBox_senderPassword.Size = new Size(149, 23);
            textBox_senderPassword.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(461, 49);
            label3.Name = "label3";
            label3.Size = new Size(71, 15);
            label3.TabIndex = 4;
            label3.Text = "SMTP server";
            // 
            // textBox_smtpServer
            // 
            textBox_smtpServer.Location = new Point(597, 46);
            textBox_smtpServer.Name = "textBox_smtpServer";
            textBox_smtpServer.Size = new Size(149, 23);
            textBox_smtpServer.TabIndex = 5;
            textBox_smtpServer.Text = "smpt-mail.outlook.com";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(462, 79);
            label4.Name = "label4";
            label4.Size = new Size(29, 15);
            label4.TabIndex = 6;
            label4.Text = "Port";
            // 
            // textBox_smtpPort
            // 
            textBox_smtpPort.Location = new Point(600, 79);
            textBox_smtpPort.Name = "textBox_smtpPort";
            textBox_smtpPort.Size = new Size(146, 23);
            textBox_smtpPort.TabIndex = 7;
            textBox_smtpPort.Text = "587";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(31, 163);
            label5.Name = "label5";
            label5.Size = new Size(134, 15);
            label5.TabIndex = 8;
            label5.Text = "Receiver's email address";
            // 
            // textBox_recerverEmail
            // 
            textBox_recerverEmail.Location = new Point(170, 158);
            textBox_recerverEmail.Name = "textBox_recerverEmail";
            textBox_recerverEmail.PlaceholderText = "Enter receiver's email";
            textBox_recerverEmail.Size = new Size(149, 23);
            textBox_recerverEmail.TabIndex = 9;
            // 
            // button_sendEmail
            // 
            button_sendEmail.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_sendEmail.Location = new Point(403, 400);
            button_sendEmail.Name = "button_sendEmail";
            button_sendEmail.Size = new Size(88, 35);
            button_sendEmail.TabIndex = 10;
            button_sendEmail.Text = "SEND Email";
            button_sendEmail.UseVisualStyleBackColor = true;
            button_sendEmail.Click += button_sendEmail_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(112, 238);
            label6.Name = "label6";
            label6.Size = new Size(46, 15);
            label6.TabIndex = 11;
            label6.Text = "Subject";
            // 
            // textBox_emailSubject
            // 
            textBox_emailSubject.Location = new Point(164, 235);
            textBox_emailSubject.Name = "textBox_emailSubject";
            textBox_emailSubject.Size = new Size(582, 23);
            textBox_emailSubject.TabIndex = 12;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(78, 276);
            label7.Name = "label7";
            label7.Size = new Size(80, 15);
            label7.TabIndex = 13;
            label7.Text = "Email content";
            // 
            // textBox_emailContent
            // 
            textBox_emailContent.Location = new Point(164, 276);
            textBox_emailContent.Multiline = true;
            textBox_emailContent.Name = "textBox_emailContent";
            textBox_emailContent.Size = new Size(582, 118);
            textBox_emailContent.TabIndex = 14;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = SystemColors.Highlight;
            label8.Location = new Point(548, 472);
            label8.Name = "label8";
            label8.Size = new Size(251, 15);
            label8.TabIndex = 15;
            label8.Text = "Copyringt by VAA-FIT  https://fitvaa.edu.vn/";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(13, 472);
            label9.Name = "label9";
            label9.Size = new Size(133, 15);
            label9.TabIndex = 16;
            label9.Text = "Author: Vũ Quốc Hưng";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 49);
            label1.Name = "label1";
            label1.Size = new Size(64, 15);
            label1.TabIndex = 17;
            label1.Text = "Your name";
            // 
            // textBox_senderName
            // 
            textBox_senderName.Location = new Point(172, 44);
            textBox_senderName.Name = "textBox_senderName";
            textBox_senderName.Size = new Size(147, 23);
            textBox_senderName.TabIndex = 18;
            textBox_senderName.Text = "Enter you name";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(163, 441);
            label10.Name = "label10";
            label10.Size = new Size(42, 15);
            label10.TabIndex = 19;
            label10.Text = "Status:";
            // 
            // label_output
            // 
            label_output.AutoSize = true;
            label_output.Location = new Point(224, 441);
            label_output.Name = "label_output";
            label_output.Size = new Size(0, 15);
            label_output.TabIndex = 20;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.ForeColor = Color.IndianRed;
            label11.Location = new Point(31, 9);
            label11.Name = "label11";
            label11.Size = new Size(533, 15);
            label11.TabIndex = 21;
            label11.Text = "Please register an email in OUTLOOK.COM and collect nessesary info as below before using this tool";
            // 
            // label_status
            // 
            label_status.AutoSize = true;
            label_status.Location = new Point(214, 438);
            label_status.Name = "label_status";
            label_status.Size = new Size(13, 15);
            label_status.TabIndex = 22;
            label_status.Text = "  ";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 500);
            Controls.Add(label_status);
            Controls.Add(label11);
            Controls.Add(label_output);
            Controls.Add(label10);
            Controls.Add(textBox_senderName);
            Controls.Add(label1);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(textBox_emailContent);
            Controls.Add(label7);
            Controls.Add(textBox_emailSubject);
            Controls.Add(label6);
            Controls.Add(button_sendEmail);
            Controls.Add(textBox_recerverEmail);
            Controls.Add(label5);
            Controls.Add(textBox_smtpPort);
            Controls.Add(label4);
            Controls.Add(textBox_smtpServer);
            Controls.Add(label3);
            Controls.Add(textBox_senderPassword);
            Controls.Add(label2);
            Controls.Add(textBox_senderAddress);
            Controls.Add(label);
            Name = "Form1";
            Text = "Simple Sending Email by C#";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label;
        private TextBox textBox_senderAddress;
        private Label label2;
        private TextBox textBox_senderPassword;
        private Label label3;
        private TextBox textBox_smtpServer;
        private Label label4;
        private TextBox textBox_smtpPort;
        private Label label5;
        private TextBox textBox_recerverEmail;
        private Button button_sendEmail;
        private Label label6;
        private TextBox textBox_emailSubject;
        private Label label7;
        private TextBox textBox_emailContent;
        private Label label8;
        private Label label9;
        private Label label1;
        private TextBox textBox_senderName;
        private Label label10;
        private Label label_output;
        private Label label11;
        private Label label_status;
    }
}
