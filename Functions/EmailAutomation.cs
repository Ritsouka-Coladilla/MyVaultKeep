using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MailKit.Net.Smtp;
using MimeKit;

namespace Functions_BusinessLogic
{
    class EmailAutomation
    {
        public void SendEmail()
        {
            var message = new MimeMessage();


            message.From.Add(new MailboxAddress("MyVault", "do-not-reply@myvault.com"));
            message.To.Add(new MailboxAddress("User", "user@rules.com"));
            message.Subject = "MyVault Transactions";

            string emailMessage = $"A transaction was made into your Vault!";

            message.Body = new TextPart("plain")
            {
                Text = emailMessage
            };

            using (var client = new SmtpClient())
            {
                var smtpHost = "sandbox.smtp.mailtrap.io";
                var smtpPort = 2525;
                var tsl = MailKit.Security.SecureSocketOptions.StartTls;

                client.Connect(smtpHost, smtpPort, tsl);

                var username = "a7f374eb1c2906";
                var password = "a38b501a90dbb7";

                client.Authenticate(username, password);

                client.Send(message);
                client.Disconnect(true);
            }
        }
    }
}
