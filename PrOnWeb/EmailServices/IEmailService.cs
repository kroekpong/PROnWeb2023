using PrOnWeb.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrOnWeb.EmailServices
{
    interface IEmailService
    {
        Task<string> SendEmailAsync(string ToEmailName, string Subject, PrNoti Data);
        Task<string> SendEmailAsync(List<string> ToEmailNames, string Subject, PrNoti Data);
        bool IsValidEmail(string EmailName);
        Task<string> SendPlainEmailAsync(string ToEmailName, string Subject, string Body);
    }
}
