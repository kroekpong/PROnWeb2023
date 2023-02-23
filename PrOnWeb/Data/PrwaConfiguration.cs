using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrOnWeb.Data
{
    public class PrwaConfiguration
    {
        public string CSVImportPath { get; set; }
        public string CSVArchivePath { get; set; }
        //public List<string> PDRY { get; set; }
        //public List<string> PDHO { get; set; }

        public event Action OnChange;

        public void SetConfiguration(string PathIn, string PathSave)
        {
            CSVImportPath = PathIn;
            CSVArchivePath = PathSave;
            NotifyStateChanged();
        }

        private void NotifyStateChanged()
        {
            OnChange?.Invoke();
        }
    }
}
