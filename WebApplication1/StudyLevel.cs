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
    
    public partial class StudyLevel
    {
        public int idstudyLevel { get; set; }
        public int idStudyLevelType { get; set; }
        public Nullable<System.DateTime> fromDate { get; set; }
        public Nullable<System.DateTime> toDate { get; set; }
        public string nameSchoolOrUniversity { get; set; }
        public int idPerson { get; set; }
    
        public virtual Person Person { get; set; }
        public virtual StudyLevelType StudyLevelType { get; set; }
    }
}