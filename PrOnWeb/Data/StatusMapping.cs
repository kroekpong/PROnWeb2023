using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrOnWeb.Data
{
    public class StatusMapping
    {
        public int Id { get; set; }
        public string Status { get; set; }
        public string Pr_status { get; set; }
        public Boolean Is_disabled { get; set; }

    }
}
