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
    
    public partial class Tramvaj
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Tramvaj()
        {
            this.Vozni_red = new HashSet<Vozni_red>();
        }
    
        public int id_tramvaj { get; set; }
        public string broj_vagona { get; set; }
        public string broj_sjedala { get; set; }
        public string kapacitet_ljudi { get; set; }
        public string godina_proizvodnje { get; set; }
        public Nullable<int> id_vozac { get; set; }
    
        public virtual Vozac Vozac { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Vozni_red> Vozni_red { get; set; }
    }
}
