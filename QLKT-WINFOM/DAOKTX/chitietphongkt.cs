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
    
    public partial class chitietphongkt
    {
        public string maphong { get; set; }
        public Nullable<int> solsv { get; set; }
        public Nullable<int> controng { get; set; }
        public string vitri { get; set; }
    
        public virtual Phongkt Phongkt { get; set; }
    }
}
