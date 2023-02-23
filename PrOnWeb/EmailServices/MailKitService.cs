using PrOnWeb.Data;
using MailKit.Net.Smtp;
using MailKit.Security;
using Microsoft.Extensions.Options;
using MimeKit;
using MimeKit.Text;
using System.IO;
using System.Text;
using Microsoft.AspNetCore.Hosting;
using System;

namespace PrOnWeb.EmailServices
{
    public interface IMailKitEmailService
    {
        void Send(string from, string to, string subject, string html);
        void SendNoti(string from, string to, string subject, EmailMessage data, string type);
        void SendNotiMail( string to, string subject, EmailMessage data, string type);
        void SendEmail( string to, string subject, string data);
        void SendNotiTest(string from, string to, string subject, EmailMessage data, string type);
    }

    public class MailKitService : IMailKitEmailService
    {
        private readonly MailKitSettings _appSettings;
        private readonly IWebHostEnvironment _env;

        public MailKitService(MailKitSettings appSettings, IWebHostEnvironment env)
        {
            _appSettings = appSettings;
            _env = env;
        }
        public void Send(string from, string to, string subject, string html)
        {
            // create message
            var email = new MimeMessage();
            email.From.Add(MailboxAddress.Parse(from));
            email.To.Add(MailboxAddress.Parse(to));
            email.Subject = subject;
            email.Body = new TextPart(TextFormat.Html) { Text = html };

            // send email
            using var smtp = new SmtpClient();
            //smtp.Connect(_appSettings.SmtpServer, _appSettings.SmtpPort, SecureSocketOptions.StartTls);
            //smtp.Authenticate(_appSettings.SmtpUsername, _appSettings.SmtpPassword);
            smtp.Connect("RSIMGS.RSI.CO.JP", _appSettings.SmtpPort, SecureSocketOptions.None);
            smtp.Send(email);
            smtp.Disconnect(true);
        }

        private string GetEmailContent(string Title, EmailMessage Data, string type)
        {
            string HTMLBody = string.Empty;
            var x = _env.WebRootPath;
            var ftype = null== type? "Approver": type;
            using (FileStream fs = File.Open(_env.WebRootPath + $"/Resources/{ftype}_Email_Template.html", FileMode.Open, FileAccess.Read))
            {
                using (StreamReader sr = new StreamReader(fs))
                {
                    HTMLBody = sr.ReadToEnd();
                }
            }
            
            HTMLBody = HTMLBody.Replace("###PRID###", Data.PrId);
            HTMLBody = HTMLBody.Replace("###PRNO###", Data.PrNo);
            HTMLBody = HTMLBody.Replace("###REQUESTER###", Data.RequesterInfo);
            HTMLBody = HTMLBody.Replace("###PRAMT###", Data.TotalCost);
            HTMLBody = HTMLBody.Replace("###PRSTATUS###", Data.StatusName);
            HTMLBody = HTMLBody.Replace("###REQDATE###", Data.RequirementDate);
            HTMLBody = HTMLBody.Replace("###OBJECTIVE###", Data.Objective);
            HTMLBody = HTMLBody.Replace("###COMPANY###", Data.Company);
            HTMLBody = HTMLBody.Replace("###DEPARTMENT###", Data.Department);
            HTMLBody = HTMLBody.Replace("###SECTION###", Data.Section);
            HTMLBody = HTMLBody.Replace("###MEMO###", Data.Memo);
            HTMLBody = HTMLBody.Replace("###COMMENT###", Data.Comment);

            if (ftype == "Returning" && Data.ReturningNote != null) { 
                HTMLBody = HTMLBody.Replace("###RN_DATE###", Data.ReturningNote.Rn_When.ToString());
                HTMLBody = HTMLBody.Replace("###RN_TYPE###", Data.RN_TYPE);
                HTMLBody = HTMLBody.Replace("###RN_MEMO###", Data.ReturningNote.Rn_Memo1);
                HTMLBody = HTMLBody.Replace("###RQ_MEMO###", Data.ReturningNote.Rn_Memo2);
            }

            HTMLBody = HTMLBody.Replace("###HOST###", _appSettings.HostUrl);

            return HTMLBody;
        }

        public void SendNotiMail(string toEmail, string subj, EmailMessage emailMessage, string type)
        {
            var fromEmail = _appSettings.MailFrom;
            if (_appSettings.isTestEnv)
            {
                fromEmail = "no-reply@beko.com";
                subj += $"({toEmail})";
                toEmail = "kroekpong@gmail.com";
                SendNotiTest(fromEmail, toEmail, subj, emailMessage, type);
            }
            else
            {
                SendNoti(fromEmail, toEmail, subj, emailMessage, type);
            }
        }
          
        public void SendNoti(string from, string to, string subject, EmailMessage data, string type)
        {
            // create message
            var email = new MimeMessage();
            email.From.Add(MailboxAddress.Parse(from));
            email.To.Add(MailboxAddress.Parse(to));
            email.Subject = subject;
            email.Body = new TextPart(TextFormat.Html) { Text = GetEmailContent(subject, data,type) };

            // send email
            using var smtp = new SmtpClient();
            //smtp.Connect(_appSettings.SmtpServer, _appSettings.SmtpPort, SecureSocketOptions.StartTls);
            //smtp.Authenticate(_appSettings.SmtpUsername, _appSettings.SmtpPassword);
            smtp.Connect("RSIMGS.RSI.CO.JP", _appSettings.SmtpPort, SecureSocketOptions.None);
            smtp.Send(email);
            smtp.Disconnect(true);
        }


        public void SendEmail(string to, string subject, string html)
        {
            // create message
            var email = new MimeMessage();
            email.From.Add(MailboxAddress.Parse("TPP-PrOnWeb@th.tpcc-tpac.com"));
            email.To.Add(MailboxAddress.Parse(to));
            email.Subject = subject;
            email.Body = new TextPart(TextFormat.Html) { Text = html };

            // send email
            using var smtp = new SmtpClient();
            //smtp.Connect(_appSettings.SmtpServer, _appSettings.SmtpPort, SecureSocketOptions.StartTls);
            //smtp.Authenticate(_appSettings.SmtpUsername, _appSettings.SmtpPassword);
            smtp.Connect("RSIMGS.RSI.CO.JP", _appSettings.SmtpPort, SecureSocketOptions.None);
            smtp.Send(email);
            smtp.Disconnect(true);
        }

        public void SendNotiTest(string from, string to, string subject, EmailMessage data,string type)
        {
            var email = new MimeMessage();
            email.From.Add(MailboxAddress.Parse(from));
            email.To.Add(MailboxAddress.Parse(to));
            email.Subject = subject;
            email.Body = new TextPart(TextFormat.Html) { Text = GetEmailContent(subject, data, type) };

            // send email
            using var smtp = new SmtpClient();
            smtp.Connect("apl-smtp.arcelik.com", 587);
            smtp.Authenticate("mars.sender", "nxj2m5bPwnGq");
             

            smtp.Send(email);
            smtp.Disconnect(true);
        }
    }
}
