using MailKit.Net.Smtp;
using MailKit.Security;
using Microsoft.Extensions.Configuration;
using MimeKit;
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
        private readonly IConfiguration _configuration;
        public EmailAutomation(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public void SendEmail()
        {
            var message = new MimeMessage();
            message.From.Add(new MailboxAddress(
                _configuration["SmtpSettings:FromName"],
                _configuration["SmtpSettings:FromAddress"]
            ));
            message.To.Add(new MailboxAddress(
                _configuration["SmtpSettings:ToName"],
                _configuration["SmtpSettings:ToAddress"]
                ));
            message.Subject = "MyVault Transactions";

            string emailMessage = $"A transaction was made into your Vault!";

            message.Body = new TextPart("plain")
            {
                Text = emailMessage
            };

            using (var client = new SmtpClient())
            {
                client.Connect(
                   _configuration["SmtpSettings:SmtpHost"],
                   int.Parse(_configuration["SmtpSettings:SmtpPort"]),
                   SecureSocketOptions.StartTls
               );

                client.Authenticate(
                    _configuration["SmtpSettings:Username"],
                    _configuration["SmtpSettings:Password"]
                );

                client.Send(message);
                client.Disconnect(true);
            }
        }
    }
}
