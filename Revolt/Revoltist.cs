//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Revolt
{
    using System;
    using System.Collections.Generic;
    
    public partial class Revoltist
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Revoltist()
        {
            this.RevoltistGameScores = new HashSet<RevoltistGameScore>();
        }
    
        public int id { get; set; }
        public string username { get; set; }
        public string password { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RevoltistGameScore> RevoltistGameScores { get; set; }
        public virtual RevoltistTitle RevoltistTitle { get; set; }
    }
}
