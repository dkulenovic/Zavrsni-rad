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
    
    public partial class Linija
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Linija()
        {
            this.Vozna_ruta = new HashSet<Vozna_ruta>();
            this.Vozni_red = new HashSet<Vozni_red>();
        }
    
        public int id_linija { get; set; }
        public string naziv { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Vozna_ruta> Vozna_ruta { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Vozni_red> Vozni_red { get; set; }
    }
}
