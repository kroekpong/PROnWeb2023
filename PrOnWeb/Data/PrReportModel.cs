using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrOnWeb.Data
{
    public class PrReportModel
    {
        public int Id { get; set; } // this is Pr_id --> PrHeadersID in PrItems(FK)
        public string Pr_No { get; set; }
        public string Tracking_No { get; set; }
        public string Item_No { get; set; }
        public string Item_Description { get; set; }
        public float? Quantity { get; set; }
        public string UOM { get; set; }
        public string Item_Code { get; set; }
        public float? Budget { get; set; }
        public DateTime? Date_Need { get; set; }
        public string Company { get; set; }
        public string Plant { get; set; }
        public string Purchasing_Group { get; set; }
        public string Department { get; set; }
        public DateTime Staff_assign_date { get; set; }
        public string Purchasing_Staff { get; set; }
        public string Requester { get; set; }
        public string Status { get; set; }
        public string PrStatus { get; set; }
        public string PO_No { get; set; }
        public DateTime? PO_DATE { get; set; }
        public string UserName { get; set; }
        public int? PendingDay { get; set; }
        public bool Pr_Closed { get; set; }
        public string Comment { get; set; }
        public DateTime? GRDate { get; set; }
        public string Location { get; set; }  // New Requirement
    }
}
