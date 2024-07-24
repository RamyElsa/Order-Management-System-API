using Microsoft.Extensions.Configuration;
using OrderSystem.Core.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using OrderSystem.Core.Models.Emailllll;

namespace OrderSystem.Service
{

    /// <summary>
    /// Sends an email using the configured SMTP server.
    /// </summary>
    /// <param name="EM">The email message to send.</param>
    public class EmailSender : IEmailSender
    {

        public void SendEmail(EmailMessage EM)
        {
            // Email Server Gmail
            var client = new SmtpClient("smtp.gmail.com", 587)
            {
                EnableSsl = true,
                Credentials = new NetworkCredential("ramye301@gmail.com", "qjmcrmudhoaxmjos")
            };
            client.SendMailAsync("ramye301@gmail.com", EM.To, EM.Subject, EM.Body);
        }
    }
}
