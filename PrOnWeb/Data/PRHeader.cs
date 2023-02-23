using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PrOnWeb.Data
{
    public class PRHeader
    {
        public int Id { get; set; } // this is Pr_id --> PrHeadersID in PrItems(FK)

        [Required]
        public string? Company { get; set; }
        public string Pr_No { get; set; }

        [Required(ErrorMessage = "The Purchasing Group field is required.")]
        public string? Purchasing_Group { get; set; }

        [Required(ErrorMessage = "The PR Date field is required.")]
        public DateTime? Pr_Date { get; set; }
        [Required]
        public string? Requester { get; set; }
        [Required]
        public string? Plant { get; set; }
        [Required(ErrorMessage = "The Tracking No. field is required.")]
        [MinLength(9, ErrorMessage = "Please input Tracking No. for 9 digits !")]
        public string? Tracking_No { get; set; }
        public string? Purchasing_Org { get; set; }
        [Required]
        public string? Department { get; set; }
        public string Status { get; set; }
        public string Print_Status { get; set; }
        public DateTime? Create_Date { get; set; }
        public DateTime? Release_Date { get; set; }
        public string? PO_No { get; set; }
        public string? PO_ITEM_NO { get; set; }
        public DateTime? PO_DATE { get; set; }

        [Required]
        public string? Section { get; set; }
        public string Objective { get; set; }
        public Boolean Need_CG_Concerning { get; set; }
        public Boolean Need_SCA_Concerning { get; set; }
        public Boolean Need_ISO { get; set; }
        public string Comment { get; set; }
        public string? Location { get; set; }
        public string? Extension { get; set; }
        public string? Pr_Urgent { get; set; }
        public string? CoSign_Group { get; set; }
        public DateTime? Update_Date { get; set; }
        //public ICollection<PRItems> PRItems { get; set; }
    }
    public class vPRHeader
    {
        public int Id { get; set; }
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
        public string Comment { get; set; }

        [NotMapped]
        public string? Location { get; set; }

        [NotMapped]
        public string? Extension { get; set; }

        public string? Pr_Urgent { get; set; }
        public string? CoSign_Group { get; set; }

    }
}
