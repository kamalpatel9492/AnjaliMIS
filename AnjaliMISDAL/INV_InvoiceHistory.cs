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
    
    public partial class INV_InvoiceHistory
    {
        public int InvoiceHistoryID { get; set; }
        public int CompanyID { get; set; }
        public Nullable<int> PartyID { get; set; }
        public Nullable<int> UserID { get; set; }
        public int Amount { get; set; }
        public int AmountReceived { get; set; }
        public int StatusID { get; set; }
        public System.DateTime Created { get; set; }
        public string Remarks { get; set; }
        public Nullable<System.DateTime> InvoiceDate { get; set; }
        public int InvoiceNo { get; set; }
        public int PONo { get; set; }
        public Nullable<int> AmountPending { get; set; }
        public int FinYearID { get; set; }
        public Nullable<int> CGST { get; set; }
        public Nullable<decimal> CGSTAmount { get; set; }
        public Nullable<int> SGST { get; set; }
        public Nullable<decimal> SGSTAmount { get; set; }
        public Nullable<int> IGST { get; set; }
        public Nullable<decimal> IGSTAmount { get; set; }
        public Nullable<bool> IsLocal { get; set; }
        public bool IsActive { get; set; }
        public Nullable<decimal> Casar { get; set; }
        public decimal TotalAmount { get; set; }
        public string Operation { get; set; }
        public int InvoiceID { get; set; }
    
        public virtual ACC_Tax ACC_Tax { get; set; }
        public virtual ACC_Tax ACC_Tax1 { get; set; }
        public virtual ACC_Tax ACC_Tax2 { get; set; }
        public virtual INV_Invoice INV_Invoice { get; set; }
        public virtual SYS_Company SYS_Company { get; set; }
        public virtual SYS_FinYear SYS_FinYear { get; set; }
        public virtual MST_Party MST_Party { get; set; }
        public virtual SYS_Status SYS_Status { get; set; }
        public virtual SEC_User SEC_User { get; set; }
    }
}
