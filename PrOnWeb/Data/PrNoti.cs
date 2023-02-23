using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrOnWeb.Data
{
    public class PrNoti
    {
        public string PrSAPNo { get; set; }
        public int Priority { get; set; }
        public int PrId { get; set; }
        public string PrStatus { get; set; }
        public string ApproveStatus { get; set; }
        public string AsRole { get; set; }
        public bool Active { get; set; }
    }
}
