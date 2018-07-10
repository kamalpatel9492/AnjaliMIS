using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnjaliMISViewModal
{
    public class LocationViewModal
    {
        public int CountryID { get; set; }
        public string CountryName { get; set; }
        public string Remarks { get; set; }
        public System.DateTime Created { get; set; }
        public Nullable<System.DateTime> Modified { get; set; }
        public Nullable<int> UserID { get; set; }
        public string UserName { get; set; }

    }
}
