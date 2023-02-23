using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrOnWeb.Data
{
    public class EmailMessage
    {
        public string PrId { get; set; }
        public string PrNo { get; set; }
        public string RequesterInfo { get; set; }
        public string WBS { get; set; }
        public string TotalCost { get; set; }
        public string StatusName { get; set; }
        public string RequirementDate { get; set; }
        public string Objective { get; set; }
        public string Company { get; set; }
        public string Department { get; set; }
        public string Section { get; set; }
        public string Memo { get; set; }
        public string Comment { get; set; }
        public string RN_TYPE { get; set; }
        public ReturningNote ReturningNote { get; set; }
    }
}
