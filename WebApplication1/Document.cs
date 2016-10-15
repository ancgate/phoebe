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
    
    public partial class Document
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Document()
        {
            this.DocumentsTags = new HashSet<DocumentsTag>();
            this.People = new HashSet<Person>();
        }
    
        public int idDocuments { get; set; }
        public string documentsName { get; set; }
        public string documentsPath { get; set; }
        public Nullable<int> accessCount { get; set; }
        public string documentsDetails { get; set; }
        public Nullable<System.DateTime> dateUploaded { get; set; }
        public string uploadedBy { get; set; }
        public int idDocumentType { get; set; }
    
        public virtual DocumentType DocumentType { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DocumentsTag> DocumentsTags { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Person> People { get; set; }
    }
}