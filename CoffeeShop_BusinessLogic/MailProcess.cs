using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CoffeeShopCommon;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
namespace CoffeeShopSystem_BusinessLogic
{
    using MailKit.Net.Smtp;
    using MailKit.Security;
    using MimeKit;
    using System.Collections.Specialized;

    public class MailProcess
    {
        private readonly IConfiguration _configuration;
        public MailProcess(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public void SendEmail(MailRequest request)
        {
            try
            {
                using var email = new MimeMessage();
                email.From.Add(new MailboxAddress(_configuration["EmailSettings:FromName"], _configuration["EmailSettings:Fromemail"]));
                email.To.Add(new MailboxAddress("", request.email));
                var builder = new BodyBuilder();

                if (request.type == "account_creation")
                {
                    email.Subject = "Account Creation!";
                    builder.TextBody = """
                        Hi Ka-Coffee,

                        Your account with Coffee++ has been successfully created.  
                        You can now log in to start earning rewards and ordering your favorite brews.

                        See you at the counter,  
                        – Coffee++ 
                        """;
                }
                else if (request.type == "receipt")
                {
                    email.Subject = "Successful Purchase";
                    builder.TextBody = $"""
                        Hi Ka-Coffee,

                        Thanks for purchase! This is the receipt of your order:

                        {request.body}

                        Hope you enjoy,
                        - Coffee++
                        """;

                }
                else
                {
                    Console.WriteLine("INVALIDDDD");
                    return;
                }

                email.Body = builder.ToMessageBody();

                using var smtp = new SmtpClient();
                smtp.Connect(_configuration["EmailSettings:SmtpHost"], int.Parse(_configuration["EmailSettings:SmtpPort"]), SecureSocketOptions.StartTls);
                smtp.Authenticate("bfdc526e0f12fd", "7d4cb4fb61e390");
                smtp.Send(email);

                smtp.Disconnect(true);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }
}
