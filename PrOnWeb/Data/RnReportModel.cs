using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrOnWeb.Data
{
    public class RnReportModel
    {
        public string Rn_Id { get; set; } // this is Pr_id --> PrHeadersID in PrItems(FK)
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
        public string Department { get; set; }
        public DateTime Staff_assign_date { get; set; }
        public string Purchasing_Staff { get; set; }
        public int Rn_Type  { get; set; }
        public string Rn_Type_Name  { get; set; }
        public string Rn_Status_Name { get; set; }
        public DateTime? RN_When { get; set; }
        public string Rn_Status { get; set; }
        public int? Id { get; set; }
        public int? Pr_Id { get; set; }
        public DateTime? rn_LastStatus_Date { get; set; }
        public int? PendingDay { get; set; }
    }
}
