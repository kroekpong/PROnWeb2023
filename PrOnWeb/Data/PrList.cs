using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrOnWeb.Data
{
    public class PrListModel
    {
        public int Id { get; set; } // this is Pr_id --> PrHeadersID in PrItems(FK)
        public string Company { get; set; }
        public string Pr_No { get; set; }
        public string Purchasing_Group { get; set; }
        public DateTime? Pr_Date { get; set; }
        public string Requester { get; set; }
        public string Plant { get; set; }
        public string Tracking_No { get; set; }
        public string Purchasing_Org { get; set; }
        public string Department { get; set; }
        public string Status { get; set; }
        public string Print_Status { get; set; }
        public DateTime? Create_Date { get; set; }
        public DateTime? Release_Date { get; set; }
        public string PO_No { get; set; }
        public string PO_ITEM_NO { get; set; }
        public DateTime? PO_DATE { get; set; }
        public string PrStatus { get; set; }
        public int NumberOfItem { get; set; }
        public double PrAmt { get; set; }
        public string sPrAmt { get; set; }
        public string Section { get; set; }
        public string Objective { get; set; }
        public Boolean Need_CG_Concerning { get; set; }
        public Boolean Need_SCA_Concerning { get; set; }
        public Boolean Need_ISO { get; set; }
        public string Approver_role { get; set; }
        public int Approver_id { get; set; }
        public string Appr_Status { get; set; }
        public bool Is_Disabled { get; set; }
        public int Af_Version { get; set; }
        public int List_Level { get; set; }
    }
}
