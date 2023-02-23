using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrOnWeb.Data
{
    public class vWorkflowAutho
    {
        public int Id { get; set; }
        public int User_Id { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Position { get; set; }
        public string Org { get; set; }
        public string Dep { get; set; }
        public string Sec { get; set; }
        public int Wf_Order { get; set; }
    }

    public class vWorkflowAuthoOrder
    {
        public int Id { get; set; }
        public int User_Id { get; set; }
        public string UserName { get; set; }
        public int WF_order { get; set; }
        public string Position { get; set; }
        public string BR1 { get; set; }
        public string BR2 { get; set; }
        public string BR3 { get; set; }
        public string BR4 { get; set; }
        public string BR5 { get; set; }

    }
}
