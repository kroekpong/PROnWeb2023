using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrOnWeb.Data
{
    public class BudgetRange
    {
        public int Id { get; set; }
        public int Range_No { get; set; }
        public string Range_Oper { get; set; }
        public float Range_Amount { get; set; }
        public string Range_Name { get; set; }

    }
}
