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
    
    public partial class EMP_Punch
    {
        public int PunchID { get; set; }
        public int EmployeeID { get; set; }
        public System.DateTime PunchDateTime { get; set; }
        public string Remarks { get; set; }
        public System.DateTime Created { get; set; }
    
        public virtual EMP_Employee EMP_Employee { get; set; }
    }
}
