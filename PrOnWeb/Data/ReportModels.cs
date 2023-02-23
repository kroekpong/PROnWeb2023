using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrOnWeb.Data
{
    public class ReportModels
    { }

    public class VPrList
    {
        public int Id { get; set; }
        public string Company { get; set; }
        public string Purchasing_Group { get; set; }
        public DateTime? Pr_Date { get; set; }
        public string Requester { get; set; }
        public string Plant { get; set; }
        public string Tracking_No { get; set; }
        public string Material_Group { get; set; }
        public string Material_Group_Des { get; set; }

        public string Department { get; set; }
        public string Pr_No { get; set; }
        public string Status { get; set; }
        public DateTime? PO_DATE { get; set; }
        public string PO_ITEM_NO { get; set; }
        public string PO_No { get; set; }
        public string Section { get; set; }
        public string Objective { get; set; }
        public int Item_Id { get; set; } // this is Pr_item_id 
        public string Item_No { get; set; }
        public string Item_Description { get; set; }
        public string Item_Code { get; set; }
        public float Quantity { get; set; }
        public DateTime Requistion_date { get; set; }
        public float Price_PR { get; set; }
        public int Price_Unit { get; set; }
        public string Desired_Vendor { get; set; }
        public string Fixed_Vendor { get; set; }
        public string GL_Account { get; set; }
        public string Cost_Center { get; set; }
        public string WBS_Code { get; set; }
        public string Delete_Status { get; set; }
        public DateTime Delivery_date { get; set; }
        public string UOM { get; set; }
        public string Purchasing_Staff { get; set; }
        public int Purchasing_Staff_Id { get; set; }
        public Boolean PR_Closed { get; set; }
        public Boolean PR_Fixed { get; set; }
    }
}
