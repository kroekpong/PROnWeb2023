using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrOnWeb.EmailServices
{
    public class MailKitSettings
    {
        public string MailFrom { get; set; }
        public string SmtpServer { get; set; }
        public int SmtpPort { get; set; }
        public string SmtpUsername { get; set; }
        public string SmtpPassword { get; set; }
        public string HostUrl { get; set; }
        public bool isTestEnv { get; set; }
    }
}
