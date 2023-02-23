using PrOnWeb.Validations;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime;
using System.Threading.Tasks;

namespace PrOnWeb.Data
{
    public class PRItem
    {
        public int Id { get; set; } // this is Pr_item_id 
        public int PrHeadersId { get; set; } // this is PrHeadersId 
        public PRHeader PrHeaders { get; set; }

        public string Item_No { get; set; }
        public string Delete_Status { get; set; }

        [Required]
        public string Item_Description { get; set; }

        public string Item_Code { get; set; }
        [Required]
        public string Material_Group { get; set; }
        [Required]
        public string Material_Group_Des { get; set; }

        [Required]
        [Range(float.Epsilon, float.MaxValue)]
        public float Quantity { get; set; }

        [Required]
        public string UOM { get; set; }
        public DateTime Requistion_date { get; set; }

        [Required]
        public DateTime Delivery_date { get; set; }

        [Required]
        [Range(float.Epsilon, float.MaxValue)]
        public float Price_PR { get; set; }

        public int Price_Unit { get; set; }
        public string Desired_Vendor { get; set; }
        public string Fixed_Vendor { get; set; }
        [Required]
        public string Currency { get; set; }
        public string Account_Ass_Cat { get; set; }
        public string GL_Account { get; set; }

        [CreatePRValidation(ParentFieldName: "Item_Code", FieldType: "Cost_Center", ValidationTypes: new[] { "required" })]
        public string Cost_Center { get; set; }

        //[CreatePRValidation(matCode:Item_Code)]
        [CreatePRValidation(ParentFieldName: "Item_Code", FieldType: "WBS_Code", ValidationTypes: new[] { "required" }) ]
        public string WBS_Code { get; set; }
        public string Purchasing_Staff { get; set; }
        public int Purchasing_Staff_Id { get; set; }
        public Boolean PR_Closed { get; set; }
        public Boolean PR_Fixed { get; set; }
        public DateTime Staff_assign_date { get; set; }
        public DateTime Item_close_date { get; set; }
        public string PO_No { get; set; }
        public string PO_ITEM_NO { get; set; }
        public DateTime? PO_DATE { get; set; }
        public DateTime? GRDate { get; set; }
        public DateTime? UpdateDate { get; set; }

        [Required]
        [Range(float.Epsilon, float.MaxValue)]
        public float ExRate { get; set; } 

        [NotMapped]
        [Required]
        [Range(float.Epsilon, float.MaxValue)]
        public float Amount { get; set; } 

        [NotMapped]
        [Required]
        [Range(float.Epsilon, float.MaxValue)]
        public float AmountTHB { get; set; }

    }
}
