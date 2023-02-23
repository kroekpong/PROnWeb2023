using Microsoft.AspNetCore.Identity;
using System;

namespace PrOnWeb.Data
{
    public class ApplicationUser : IdentityUser
    {
        public string PrUserId { get; set; }
        public string FullName { get; set; }
        public DateTime LastPasswordChangedDate { get; set; }
        public string Position { get; set; }
        public string Backup { get; set; }

    }
}
