using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrOnWeb.Data
{
    public class Approval_flow
    {
        public int Id { get; set; }
        public int Pr_id { get; set; }
        public int Pr_item_id { get; set; }
        public string Approver_role { get; set; }
        public int Approver_id { get; set; }
        public int Approver_group_id { get; set; }
        public string Status { get; set; }
        public DateTime When_init { get; set; }
        public DateTime When_end { get; set; }
        public Boolean Is_disabled { get; set; }
        public int Wf_order { get; set; }
        // 0 = active
        public int? Af_Version { get; set; }
    }

    public class vApproval_flow
    {
        public int Id { get; set; }
        public int Pr_id { get; set; }
        public int Pr_item_id { get; set; }
        public string Approver_role { get; set; }
        public int Approver_id { get; set; }
        public int Approver_group_id { get; set; }
        public string Status { get; set; }
        public DateTime When_init { get; set; }
        public DateTime When_end { get; set; }
        public Boolean Is_disabled { get; set; }
        public int Wf_order { get; set; }
        public string Approver_Name { get; set; }
        public int? Af_Version { get; set; }

    }
}
