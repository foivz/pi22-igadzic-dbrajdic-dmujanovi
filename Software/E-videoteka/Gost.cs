//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace E_videoteka
{
    using System;
    using System.Collections.Generic;
    
    public partial class Gost
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Gost()
        {
            this.Filmovis = new HashSet<Filmovi>();
        }
    
        public int ID_Gosta { get; set; }
        public string Ime { get; set; }
        public string Adresa { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Filmovi> Filmovis { get; set; }
    }
}
