//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SvaSuceljaAplikacije.EntityKlase
{
    using System;
    using System.Collections.Generic;
    
    public partial class Vozac
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Vozac()
        {
            this.Tramvaj = new HashSet<Tramvaj>();
        }
    
        public int id_vozac { get; set; }
        public string ime { get; set; }
        public string prezime { get; set; }
        public string placa { get; set; }
        public string datum_rodenja { get; set; }
        public string telefon { get; set; }
        public string email { get; set; }
        public string adresa { get; set; }
        public int id_korisnik { get; set; }
    
        public virtual Korisnik Korisnik { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tramvaj> Tramvaj { get; set; }
    }
}
