using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CoffeeShopCommon;
using System.Threading.Tasks;

namespace CoffeeShopSystem_BusinessLogic
{
    using MailKit.Net.Smtp;
    using MimeKit;
    using System.Collections.Specialized;

    public class MailProcess
    {
        public MailProcess()
        {
     
        }

        public void SendEmail(MailRequest request)
        {
            try
            {
                using var email = new MimeMessage();
                email.From.Add(new MailboxAddress("Coffee++", "no-reply@demomailtrap.co"));
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
                smtp.Connect("sandbox.smtp.mailtrap.io", 2525, false);
                smtp.Authenticate("bfdc526e0f12fd", "7d4cb4fb61e390");
                smtp.Send(email);

                smtp.Disconnect(true);
                Console.WriteLine("ORDER SUCCESS");


            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }
}
