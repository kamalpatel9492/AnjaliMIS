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
    
    public partial class DIA_AssignCassettToMachine
    {
        public int AssignCassettToMachineID { get; set; }
        public int MachineID { get; set; }
        public int CassettID { get; set; }
        public int UserID { get; set; }
        public int StatusID { get; set; }
        public System.DateTime Created { get; set; }
        public Nullable<System.DateTime> Modified { get; set; }
        public string Remrks { get; set; }
    
        public virtual DIA_Cassett DIA_Cassett { get; set; }
        public virtual DIA_Machine DIA_Machine { get; set; }
        public virtual SYS_Status SYS_Status { get; set; }
        public virtual SEC_User SEC_User { get; set; }
    }
}
