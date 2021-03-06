//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BPeState
{
    using System;
    using System.Collections.Generic;
    
    public partial class Investment
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Investment()
        {
            this.ICs = new HashSet<IC>();
            this.ISs = new HashSet<IS>();
            this.IT = new HashSet<IT>();
        }
    
        public int Investments_SK { get; set; }
        public string Name { get; set; }
        public decimal Price_min { get; set; }
        public decimal Price_max { get; set; }
        public int Area_min { get; set; }
        public int Area_max { get; set; }
        public byte Rooms_min { get; set; }
        public byte Rooms_max { get; set; }
        public Nullable<System.DateTime> Date_of_finish { get; set; }
        public int No_of_homes { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IC> ICs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IS> ISs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IT> IT { get; set; }
    }
}
