using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnjaliMISViewModal
{
    public class ACC_BankVM
    {
        public int BankID { get; set; }
        public string BankName { get; set; }
        public string BankShortName { get; set; }
        public string Remarks { get; set; }
        public System.DateTime Created { get; set; }
        public Nullable<System.DateTime> Modified { get; set; }
        public int UserID { get; set; }

        //Custom property
        //public CountryNameWithState 
    }
}
