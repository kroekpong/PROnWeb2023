using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrOnWeb.Data
{
    public class UploadFile
    {
        public int Id { get; set; }
        public int Upload_Type { get; set; }
        public int Document_id { get; set; }
        public string Filename { get; set; }
        public string Description { get; set; }
        public int Who { get; set; }
        public DateTime When { get; set; }
        public string Status { get; set; }
    }
}
