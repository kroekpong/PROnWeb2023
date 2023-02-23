using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PrOnWeb.Data
{
    public class UserTable
    {
        [Key]
        public int Id { get; set; }
        public int Pr_User_Id { get; set; }
        public string UserName { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
    }

    public class PrUserId
    {
        public int UserId { get; set; }
    }
}
