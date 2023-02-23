using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrOnWeb.Data
{
    public class MatGroupList
    {
        public string Item_Code { get; set; }
        public string Item_Description { get; set; }
        public string Material_Group { get; set; }
        public string Material_Group_Des { get; set; }
        //public int? Item_Id { get; set; } // this is Pr_item_id 
        //public string Item_No { get; set; }
        public string Account_Ass_Cat { get; set; }
        public string GL_Account { get; set; }
        public string Cost_Center { get; set; }
        public string WBS_Code { get; set; }

    }
}
