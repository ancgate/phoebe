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
    
    public partial class MedicalInfo
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MedicalInfo()
        {
            this.People = new HashSet<Person>();
        }
    
        public int idMedicalInfo { get; set; }
        public string doctorName { get; set; }
        public string doctorPhone { get; set; }
        public string doctorEmail { get; set; }
        public int idbloodType { get; set; }
        public string height { get; set; }
        public string allergies { get; set; }
        public string pathologies { get; set; }
        public string medicines { get; set; }
        public string vaccines { get; set; }
        public string comments { get; set; }
    
        public virtual BloodType BloodType { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Person> People { get; set; }
    }
}
