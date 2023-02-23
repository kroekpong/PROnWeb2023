using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrOnWeb.Data
{
    public class ReturningNote
    {
        public int Id { get; set; }
        public string Rn_Id { get; set; }
        public int Pr_Id { get; set; }
        public int Pr_Item_No { get; set; }
        public int Rn_Type { get; set; }
        public int Rn_Reason { get; set; }
        public string Rn_Memo1 { get; set; }
        public string Rn_Memo2 { get; set; }
        public string Rn_Memo3 { get; set; }
        public string Rn_By { get; set; }
        public int Rn_By_Id { get; set; }
        public  string Rn_Status { get; set; }
        public DateTime? Rn_When { get; set; }
        public DateTime? Rn_LastStatus_Date { get; set; }
    }
    public class VReturningNote
    {
        public int Id { get; set; }
        public string Rn_Id { get; set; }
        public int Pr_Id { get; set; }
        public int Pr_Item_No { get; set; }
        public int Rn_Type { get; set; }
        public int Rn_Reason { get; set; }
        public string Rn_Memo1 { get; set; }
        public string Rn_Memo2 { get; set; }
        public string Rn_Memo3 { get; set; }
        public string Rn_By { get; set; }
        public int Rn_By_Id { get; set; }
        public string Rn_Status { get; set; }
        public DateTime? Rn_When { get; set; }
        public string Rn_Status_Name { get; set; }
        public DateTime? Rn_LastStatus_Date { get; set; }
    }
}
