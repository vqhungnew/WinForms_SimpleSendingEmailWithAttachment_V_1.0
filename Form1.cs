//REF:  https://www.tutorialsteacher.com/articles/send-emails-in-csharp
//REF:  https://learn.microsoft.com/en-us/dotnet/api/system.net.mail.mailmessage?view=net-8.0

using System;
using System.Net;
using System.Net.Mail;


namespace WinForms_SimpleSendingEmail_V_1._0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_sendEmail_Click(object sender, EventArgs e)
        {
            //1. Get all nessesary info to send an email

                //1.1 get SMTP server infor
                string smtpServer=textBox_smtpServer.Text;
                int smtpPort= Int16.Parse(textBox_smtpPort.Text);

                //1.2 get SENDER info including Email and Password
                string senderEmail=textBox_senderAddress.Text;
                string senderPassword=textBox_senderPassword.Text;
                string senderName=textBox_senderName.Text;

                //1.3 get RECEIVER info
                string receiverEmail=textBox_recerverEmail.Text;

                //1.4 get email Subject & Content
                string emailSubject=textBox_emailSubject.Text;
                string emailContent=textBox_emailContent.Text;

            //2. Send all info to sendMail method with all collected info
            sendEmail(senderName, senderEmail, senderPassword, smtpServer, smtpPort, receiverEmail, emailSubject, emailContent);
        }

        //Build a SENDING Method

        public static void sendEmail(string yourName, string senderEmail, string yourPassword, string smptServer, int smptPort, string receiverEmail, string emailSubject, string emailContent)
        {
            MailMessage mailMessage = new MailMessage();
            
            mailMessage.From = new MailAddress(senderEmail, yourName);
            mailMessage.To.Add(receiverEmail);
            mailMessage.Subject = emailSubject;
            mailMessage.Body = emailContent;

            SmtpClient smtpClient = new SmtpClient();
            smtpClient.Host = smptServer;
            smtpClient.Port = smptPort;
            smtpClient.UseDefaultCredentials = false;


            
            smtpClient.Credentials = new NetworkCredential(senderEmail, yourPassword);
            smtpClient.EnableSsl = true;

            MessageBox.Show(mailMessage.ToString());
            try
            {
                smtpClient.Send(mailMessage);
                MessageBox.Show("Email Sent Successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
