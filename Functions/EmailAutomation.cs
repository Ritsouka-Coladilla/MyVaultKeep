using MailKit.Net.Smtp;
using MailKit.Security;
using Microsoft.Extensions.Configuration;
using MimeKit;
using MyVaultCommon;
using MyVaultCommon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Functions_BusinessLogic
{
    public class EmailAutomation
    {
        private readonly SmtpSettings _smtpSettings;
        public EmailAutomation(SmtpSettings smtpSettings)
        {
            _smtpSettings = smtpSettings;
        }
        public void SendEmail()
        {
            var message = new MimeMessage();


            message.From.Add(new MailboxAddress(
                _smtpSettings.FromName,
                _smtpSettings.FromAddress
                ));
            message.To.Add(new MailboxAddress(
                _smtpSettings.ToName,
                _smtpSettings.ToAddress
                ));
            message.Subject = "MyVault Transactions";

            string emailMessage = $"A transaction was made into your Vault!";

            message.Body = new TextPart("plain")
            {
                Text = emailMessage
            };

            using (var client = new SmtpClient())
            {
                var smtpHost = _smtpSettings.SmtpHost;
                var smtpPort = _smtpSettings.SmtpPort;
                var tsl = _smtpSettings.SecureSocketOption;

                client.Connect(smtpHost, smtpPort, tsl);

                var username = _smtpSettings.SmtpUsername;
                var password = _smtpSettings.SmtpPassword;

                client.Authenticate(username, password);

                client.Send(message);
                client.Disconnect(true);
            }
        }
    }
}
