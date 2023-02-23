using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrOnWeb.Data
{
    public class WorkflowAutho
    {
        public int? Id { get; set; }
        public int User_Id { get; set; }
        public string Org { get; set; }
        public string Dep { get; set; }
        public string Sec { get; set; }
        public int Wf_Order { get; set; }
        public bool BudgetRange1 { get; set; }
        public bool BudgetRange2 { get; set; }
        public bool BudgetRange3 { get; set; }
        public bool BudgetRange4 { get; set; }
        public bool BudgetRange5 { get; set; }
        public bool IsSm { get; set; }
        public bool IsDm { get; set; }
        public bool IsAccount { get; set; }
        public bool IsCoSign { get; set; }
        public bool IsPsMember { get; set; }
        public bool IsPhMember { get; set; }
        public bool IsRequester{ get; set; }
        public bool IsPM { get; set; }
        public int Wf_Position { get; set; }

    }
    public class vWorkflowAuthoName
    {
        public int? Id { get; set; }
        public int User_Id { get; set; }
        public string Org { get; set; }
        public string Dep { get; set; }
        public string Sec { get; set; }
        public int Wf_Order { get; set; }
        public int Wf_Position { get; set; }
        public bool BudgetRange1 { get; set; }
        public bool BudgetRange2 { get; set; }
        public bool BudgetRange3 { get; set; }
        public bool BudgetRange4 { get; set; }
        public bool BudgetRange5 { get; set; }
        public bool IsSm { get; set; }
        public bool IsDm { get; set; }
        public bool IsAccount { get; set; }
        public bool IsCoSign { get; set; }
        public bool IsPsMember { get; set; }
        public bool IsPhMember { get; set; }
        public bool IsRequester { get; set; }
        public bool IsPM { get; set; }
        public string UserName { get; set; }

    }
}
