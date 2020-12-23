using System;
using System.IO;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using sunrisehospital.Models;

namespace sunrisehospital.Helper

{
    public class MailHelper 

    {


        public static  bool Create(string fromaddress, string toAddress, string subject, string content)
        {
            try
            {

                var builder = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json");
                var configuration = builder.Build();
                var host = configuration["Gmail:Host"];
                var port = int.Parse(configuration["Gmail:Port"]);
                var username = configuration["Gmail: Username"];
                var Passsword = configuration["Gmail:Password"];
                var enable = bool.Parse(configuration["Gmail:SMTP:starttls:enable"]);
                var smtpClient = new SmtpClient()
                {
                    Host = host,
                    Port = port,
                    EnableSsl = enable,
                    Credentials = new NetworkCredential(username,Passsword)


                };
                var message = new MailMessage(fromaddress, toAddress);

                message.Subject = subject;
                message.Body = content;
                message.IsBodyHtml = true;

              
                return true;
               
               


            }
            catch
            {

                return false;
            }



        }



    }
}