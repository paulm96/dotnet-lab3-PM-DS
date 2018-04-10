using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using System.Net;
using System.IO;
namespace WindowsFormsApp2
{
    public class SendEmail : IAction
    {
        string email;
        private SmtpClient smtp;
        private MailMessage message;

        public override string ToString()
        {
            return string.Format("{0}",
                this.Email);
        }

        public SendEmail(string mail)
        {
            Email = mail;
        }

        public override void Do()
        {
            Mail(Email);            
            using(StreamReader sr = new StreamReader("./atturl.txt"))
            {
                Send(sr.ReadToEnd());
            }
        }

        public void Mail(string email)
        {
            var fromAddress = new MailAddress("krzysztof.kowlaczek1@gmail.com");
            var fromPassword = "masakra7";
            var toAddress = new MailAddress(email);

            smtp = new System.Net.Mail.SmtpClient
            {
                Host = "smtp.gmail.com",
                Port = 587,
                EnableSsl = true,
                DeliveryMethod = System.Net.Mail.SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential(fromAddress.Address, fromPassword)
            };

            message = new MailMessage();
            message.From = new MailAddress(fromAddress.ToString());
            message.To.Add(toAddress);
            message.Subject = "JTTT app";
            message.Body = "Znaleziono szukany obrazek. Dodano go w załączniku";

            Log.log("mailbox_setup: krzysztof.kowlaczek1@gmail.com", "HH:mm:ss");
        }

        public MailMessage Message { get => message; set => message = value; }
        public string Email { get => email; set => email = value; }

        public void Send(string attachmentURL)
        {
            var stream = new WebClient().OpenRead(attachmentURL);
            Log.log("atachment_loaded: " + attachmentURL, "HH:mm:ss");
            Attachment attachment = new Attachment(stream, "att.jpg");
            message.Attachments.Add(attachment);
            Log.log("attachment_added", "HH:mm:ss");
            smtp.Send(message);
            Log.log("email_sent", "HH:mm:ss");
        }
    }
}
