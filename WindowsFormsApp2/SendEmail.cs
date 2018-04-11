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

        public SendEmail(string mail)
        {
            Email = mail;
        }

        public MailMessage Message { get => message; set => message = value; }
        public string Email { get => email; set => email = value; }


        public override string ToString()
        {
            return string.Format("{0}",
                this.Email);
        }

        public override void Do()
        {
            Mail(Email);            
            using(StreamReader sr = new StreamReader("./atturl.txt"))
            {
                Send(sr.ReadLine(), sr.ReadLine());
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
            Log.log("mailbox_setup: krzysztof.kowlaczek1@gmail.com", "HH:mm:ss");
        }
    
        public void Send(string attachmentURL, string msg)
        {
            message.Body = msg;
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
