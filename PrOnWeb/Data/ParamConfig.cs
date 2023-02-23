using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PrOnWeb.Data
{
    //[Table("ParamConfig")]
    public class ParamConfig
    {
         
        public string code { get; set; }
        public string type { get; set; }
        public string name { get; set; }
        public string value { get; set; }
        public string text { get; set; }
        public DateTime? createDate { get; set; }
        public string createBy { get; set; }
        public DateTime? updateDate { get; set; }
        public string updateBy { get; set; }

        public ParamConfig(string _code, string _name)
        {
            code = _code;
            name = _name;
        }

        public ParamConfig(string _code, string _name, string _type)
        {
            code = _code;
            name = _name;
            type = _type;
        }
    }
}
