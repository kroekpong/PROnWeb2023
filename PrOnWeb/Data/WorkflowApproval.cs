using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrOnWeb.Data
{
    public class WorkflowApproval
    {
        public int Id { get; set; }
        public int Wf_Order { get; set; }
        public int Wf_Approver { get; set; }
        public string Status { get; set; }
        public DateTime Approve_When { get; set; }
    }

    public class Wf_Pr_Assignment
    {
        public int Id { get; set; }
        public int Pr_Id { get; set; }
        public int Wf_Order { get; set; }
        public int Approver_Id { get; set; }
        public string Status { get; set; }
        public DateTime Approve_When { get; set; }

    }
    public class Wf_Item_Assignment
    {
        public int Id { get; set; }
        public int Pr_Item_Id { get; set; }
        public string Approver_Role { get; set; }
        public int Approver_Id { get; set; }
        public string Status { get; set; }
        public DateTime Approve_When { get; set; }

    }

}
