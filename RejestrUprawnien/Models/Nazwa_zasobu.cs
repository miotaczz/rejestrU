//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RejestrUprawnien.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Nazwa_zasobu
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Nazwa_zasobu()
        {
            this.Uprawnienies = new HashSet<Uprawnienie>();
        }
    
        public int id { get; set; }
        public string nazwa { get; set; }
        public int id_zasob { get; set; }
    
        public virtual Zasob Zasob { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Uprawnienie> Uprawnienies { get; set; }
    }
}
