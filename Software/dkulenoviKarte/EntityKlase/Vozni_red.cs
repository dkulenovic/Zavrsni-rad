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
    
    public partial class Vozni_red
    {
        public int id_vozni_red { get; set; }
        public Nullable<System.TimeSpan> vrijeme_pocetka { get; set; }
        public Nullable<System.TimeSpan> vrijeme_zavrsetka { get; set; }
        public Nullable<int> status { get; set; }
        public int id_tramvaj { get; set; }
        public int id_linija { get; set; }
    
        public virtual Linija Linija { get; set; }
        public virtual Tramvaj Tramvaj { get; set; }
    }
}
