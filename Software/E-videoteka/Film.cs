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
    
    public partial class Film
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Film()
        {
            this.AktivnostKorisnikas = new HashSet<AktivnostKorisnika>();
        }
    
        public int ID_Film { get; set; }
        public string Naziv { get; set; }
        public string GodinaIzdanja { get; set; }
        public string Kategorija { get; set; }
        public string Trajanje { get; set; }
        public string LokacijaFilma { get; set; }
        public string Odobren { get; set; }
        public int ID_Korsinik { get; set; }
        public Nullable<int> Gledan { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AktivnostKorisnika> AktivnostKorisnikas { get; set; }
        public virtual Korisnik Korisnik { get; set; }
    }
}
