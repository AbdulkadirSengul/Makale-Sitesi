//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Abdülkadir_Şengül.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class MakaleYazar
    {
        public int No { get; set; }
        public Nullable<int> KullaniciNo { get; set; }
        public Nullable<int> MakaleNo { get; set; }
    
        public virtual Kullanici Kullanici { get; set; }
        public virtual Makale Makale { get; set; }
    }
}
