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
    
    public partial class Tithe
    {
        public int idTithes { get; set; }
        public Nullable<System.DateTime> titheDate { get; set; }
        public Nullable<decimal> titheAmount { get; set; }
        public string titheComment { get; set; }
        public int idService { get; set; }
        public int idPerson { get; set; }
    
        public virtual Person Person { get; set; }
    }
}
