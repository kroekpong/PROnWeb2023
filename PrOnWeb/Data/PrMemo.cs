using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrOnWeb.Data
{
    public class PrMemo
    {
        public string Id { get; set; }
        public int PrID { get; set; }
        public int MemoWhoID { get; set; }
        public string MemoMsg { get; set; }
        public DateTime MemoWhen { get; set; }
    }

    public class vPrMemo
    {
        public string Id { get; set; }
        public int PrID { get; set; }
        public int MemoWhoID { get; set; }
        public string MemoMsg { get; set; }
        public DateTime MemoWhen { get; set; }
        public string MemoWho { get; set; }
    }
}
