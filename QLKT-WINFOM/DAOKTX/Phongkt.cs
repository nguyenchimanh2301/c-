//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAOKTX
{
    using System;
    using System.Collections.Generic;
    
    public partial class Phongkt
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Phongkt()
        {
            this.Hoadonphongs = new HashSet<Hoadonphong>();
            this.SINHVIENVAOs = new HashSet<SINHVIENVAO>();
        }
    
        public string maphong { get; set; }
        public string tenday { get; set; }
        public string vitri { get; set; }
        public string loaiphong { get; set; }
        public string tinhtrang { get; set; }
    
        public virtual chitietphongkt chitietphongkt { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Hoadonphong> Hoadonphongs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SINHVIENVAO> SINHVIENVAOs { get; set; }
    }
}
