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
    
    public partial class Kullanici
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Kullanici()
        {
            this.MakaleYazar = new HashSet<MakaleYazar>();
        }
    
        public int No { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string DogumTarihi { get; set; }
        public string Cinsiyet { get; set; }
        public string Eposta { get; set; }
        public string TcKimlikNo { get; set; }
        public string KullaniciAdi { get; set; }
        public string Parola { get; set; }
        public Nullable<int> UnvanNo { get; set; }
        public Nullable<int> BolumNo { get; set; }
    
        public virtual Bolum Bolum { get; set; }
        public virtual Unvan Unvan { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MakaleYazar> MakaleYazar { get; set; }
    }
}
