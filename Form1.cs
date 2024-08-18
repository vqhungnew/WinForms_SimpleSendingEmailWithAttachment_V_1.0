//REF:  https://www.tutorialsteacher.com/articles/send-emails-in-csharp
//REF:  https://learn.microsoft.com/en-us/dotnet/api/system.net.mail.mailmessage?view=net-8.0

using System;
using System.Net;
using System.Net.Mail;
using System.Net.Mime;


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
            string smtpServer = textBox_smtpServer.Text;
            int smtpPort = Int16.Parse(textBox_smtpPort.Text);

            //1.2 get SENDER info including Email and Password
            string senderEmail = textBox_senderAddress.Text;
            string senderPassword = textBox_senderPassword.Text;
            string senderName = textBox_senderName.Text;

            //1.3 get RECEIVER info
            string receiverEmail = textBox_recerverEmail.Text;

            //1.4 get email Subject & Content
            string emailSubject = textBox_emailSubject.Text;
            string emailContent = textBox_emailContent.Text;

            //1.5 get Attachment
            // Prepare Attachement
            //REF: https://learn.microsoft.com/en-us/dotnet/api/system.net.mail.mailmessage.attachments?view=net-8.0#system-net-mail-mailmessage-attachments

            // Create  the file attachment for this email message.
            string file = textBox_attachFilePath.Text;
            Attachment data = new Attachment(file, MediaTypeNames.Application.Octet);
            // Add time stamp information for the file.
            ContentDisposition disposition = data.ContentDisposition;
            disposition.CreationDate = System.IO.File.GetCreationTime(file);
            disposition.ModificationDate = System.IO.File.GetLastWriteTime(file);
            disposition.ReadDate = System.IO.File.GetLastAccessTime(file);
            // Add the file attachment to this email message.

            //2. Send all info to sendMail method with all collected info
            sendEmail(senderName, senderEmail, senderPassword, smtpServer, smtpPort, receiverEmail, emailSubject, emailContent, data);
        }

        //Build a SENDING Method

        public static void sendEmail(string yourName, string senderEmail, string yourPassword, string smptServer, int smptPort, string receiverEmail, string emailSubject, string emailContent, Attachment attachFile)
        {
            MailMessage mailMessage = new MailMessage();

            mailMessage.From = new MailAddress(senderEmail, yourName);
            mailMessage.To.Add(receiverEmail);
            mailMessage.Subject = emailSubject;
            mailMessage.Body = emailContent;

            //Attach file to message
            mailMessage.Attachments.Add(attachFile);

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

        //REF: https://stackoverflow.com/questions/4999734/how-to-add-browse-file-button-to-windows-form-using-c-sharp
        private void button1_Click(object sender, EventArgs e)
        {

            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            DialogResult result = openFileDialog1.ShowDialog(); // Show the dialog.
            string file = null;
            file = openFileDialog1.FileName;
            textBox_attachFilePath.Text = file;
        }
    }
}
