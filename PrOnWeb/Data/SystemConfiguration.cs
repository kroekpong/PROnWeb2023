using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PrOnWeb.Data
{
    public class SystemConfiguration
    {
        [Key]
        public int Id { get; set; }
        public string ConfigName { get; set; }
        public string ConfigValue { get; set; }
    }
}
