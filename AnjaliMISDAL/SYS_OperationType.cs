//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AnjaliMISDAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class SYS_OperationType
    {
        public SYS_OperationType()
        {
            this.INV_StockHistory = new HashSet<INV_StockHistory>();
        }
    
        public int OperationTypeID { get; set; }
        public string OperationType { get; set; }
        public string Remarks { get; set; }
        public System.DateTime Created { get; set; }
        public Nullable<System.DateTime> Modified { get; set; }
        public int UserID { get; set; }
    
        public virtual ICollection<INV_StockHistory> INV_StockHistory { get; set; }
    }
}
