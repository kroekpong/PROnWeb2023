using PrOnWeb.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace PrOnWeb.EmailServices
{
    public class EmailService : IEmailService
    {
        private readonly EmailSettings _mailConfig;
        private static string _mailResponse;

        public EmailService(EmailSettings mailConfig)
        {
            _mailConfig = mailConfig;
        }

        public async Task<string> SendEmailAsync(string ToEmailName, string Subject, PrNoti Data)
        {
            return await SendEmailAsync(new List<string>() { ToEmailName }, Subject, Data);
        }

        public async Task<string> SendEmailAsync(List<string> ToEmailName, string Subject, PrNoti Data)
        {
            _mailResponse = string.Empty;

            using (SmtpClient smtpClient = new SmtpClient(_mailConfig.Host, _mailConfig.Port))
            {
                smtpClient.UseDefaultCredentials = true;
                smtpClient.Credentials = new NetworkCredential(_mailConfig.Username, _mailConfig.Password);
                smtpClient.EnableSsl = true;
                smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtpClient.SendCompleted += new SendCompletedEventHandler((object sender, AsyncCompletedEventArgs e) => {
                    _mailResponse = (e.Error != null || e.Cancelled != false) ? "failure" : "success";
                });

                MailMessage message = new MailMessage
                {
                    From = new MailAddress(_mailConfig.Username, _mailConfig.DisplayName),
                    Subject = Subject,
                    SubjectEncoding = Encoding.UTF8,
                    BodyEncoding = Encoding.UTF8,
                    HeadersEncoding = Encoding.UTF8,
                    IsBodyHtml = true,
                    Body = GetEmailContent(Subject, Data),
                    Priority = MailPriority.High
                };
                foreach (string EmailName in ToEmailName)
                {
                    message.To.Add(new MailAddress(EmailName));
                }

                // --------
                await smtpClient.SendMailAsync(message);
            }

            return _mailResponse;
        }

        public bool IsValidEmail(string EmailName)
        {
            return new EmailAddressAttribute().IsValid(EmailName);
        }

        private string GetEmailContent(string Title, PrNoti Data)
        {
            string HTMLBody = string.Empty;

            using (FileStream fs = File.Open(Directory.GetCurrentDirectory() + "/Email_Template.html", FileMode.Open, FileAccess.ReadWrite))
            {
                using (StreamReader sr = new StreamReader(fs))
                {
                    HTMLBody = sr.ReadToEnd();
                }
            }

            HTMLBody = HTMLBody.Replace("###EMAILTITLE###", Title);
            HTMLBody = HTMLBody.Replace("###PRNUM###", Data.PrSAPNo);
            HTMLBody = HTMLBody.Replace("###ID###", Data.PrId.ToString());
            HTMLBody = HTMLBody.Replace("###STATUS###", Data.PrStatus.ToString());
            HTMLBody = HTMLBody.Replace("###APPROVESTATUS###", Data.ApproveStatus.ToString());
            HTMLBody = HTMLBody.Replace("###ROLE###", Data.AsRole ?? "NA");

            return HTMLBody;
        }

        public async Task<string> SendPlainEmailAsync(string ToEmailName, string Subject, string MailBody)
        {
            _mailResponse = string.Empty;

            using (SmtpClient smtpClient = new SmtpClient(_mailConfig.Host, _mailConfig.Port))
            {
                smtpClient.UseDefaultCredentials = true;
                smtpClient.Credentials = new NetworkCredential(_mailConfig.Username, _mailConfig.Password);
                smtpClient.EnableSsl = true;
                smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtpClient.SendCompleted += new SendCompletedEventHandler((object sender, AsyncCompletedEventArgs e) => {
                    _mailResponse = (e.Error != null || e.Cancelled != false) ? "failure" : "success";
                });

                MailAddress from = new MailAddress(_mailConfig.Username, _mailConfig.DisplayName);
                MailAddress to = new MailAddress(ToEmailName);

                MailMessage message = new MailMessage(from, to)
                {
                    Subject = Subject,
                    SubjectEncoding = Encoding.UTF8,
                    BodyEncoding = Encoding.UTF8,
                    HeadersEncoding = Encoding.UTF8,
                    IsBodyHtml = true,
                    Body = MailBody,
                    Priority = MailPriority.High
                };

                // --------
                await smtpClient.SendMailAsync(message);
            }
            return _mailResponse;
        }
    }
}
