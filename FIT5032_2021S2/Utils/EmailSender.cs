using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;
using System.Web;

namespace FIT5032_2021S2.Utils
{
    public class EmailSender
    {
        private readonly SmtpClient client = new SmtpClient("in-v3.mailjet.com", 587)
        {
            Credentials = new NetworkCredential("64a551e4965ca86d6574301475b6b9bf", "81e21ca5ac16e9c0f218ca54ae25d68e"),
            EnableSsl = true
        };

        public async Task Send(string toEmail, string subject, string contents)
        {
            var mailMessage = new MailMessage("keyucui621@gmail.com", toEmail,subject,contents);
            await client.SendMailAsync(mailMessage);
        }

        // Please use your API KEY here.
        //private const String API_KEY = "YOUR API KEY HERE";

        //public void Send(String toEmail, String subject, String contents)
        //{
        //    var client = new SendGridClient(API_KEY);
        //    var from = new EmailAddress("noreply@localhost.com", "FIT5032 Example Email User");
        //    var to = new EmailAddress(toEmail, "");
        //    var plainTextContent = contents;
        //    var htmlContent = "<p>" + contents + "</p>";
        //    var msg = MailHelper.CreateSingleEmail(from, to, subject, plainTextContent, htmlContent);
        //    var response = client.SendEmailAsync(msg);
        //}
    }
}