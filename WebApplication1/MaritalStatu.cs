//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplication1
{
    using System;
    using System.Collections.Generic;
    
    public partial class MaritalStatu
    {
        public int idMaritalStatus { get; set; }
        public int idMaritalStatusType { get; set; }
        public Nullable<System.DateTime> startDate { get; set; }
        public Nullable<System.DateTime> endDate { get; set; }
        public int idPerson { get; set; }
    
        public virtual MaritalStatusType MaritalStatusType { get; set; }
        public virtual Person Person { get; set; }
    }
}
