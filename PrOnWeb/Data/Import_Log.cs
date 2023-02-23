using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrOnWeb.Data
{
    public class Import_Log
    {
        public int Id { get; set; }
        public DateTime Import_DateTime { get; set; }
        public int Raw_Record_Count { get; set; }
        public string Import_File_Name { get; set; }
        public int Good_Record_Count { get; set; }
        public int Bad_Record_Count { get; set; }
        public int Pr_Header_Id_Start { get; set; }
        public int Pr_Header_Count { get; set; }
        public int Pr_Item_Id_Start { get; set; }
        public int Pr_Item_Count { get; set; }

    }
}
