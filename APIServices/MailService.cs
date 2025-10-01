using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace APIServices
{
    public class MailService
    {
        ServiceResponse response = new ServiceResponse();

        public async Task<ServiceResponse> SendMail(Mail mail)
        {
            SmtpClient smtpClient = new("mail.ourladyps.org")
            {
                Port = 587, // SMTP port (25 for non-SSL)
                Credentials = new NetworkCredential(mail.From, mail.FromPassword),
                EnableSsl = false, // Do not use SSL

            };

            MailMessage message = new MailMessage();
            message.From = new MailAddress(mail.From, mail.SenderName); // Sender's name
            message.To.Add(new MailAddress(mail.To, mail.RecipientName)); // Recipient's name
            message.Subject = mail.Subject;
            message.Body = mail.Message;
            message.IsBodyHtml = true;
            try
            {
                smtpClient.Send(message);
                response.Message = "Mail sent successfully";
            }
            catch (Exception ex)
            {
                response.IsSuccessful = false;
                response.Message = ex.Message + "  " + ex.InnerException;
            }
            return response;
        }
    }
}
