//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Apartman.Models.veritabanı
{
    using System;
    using System.Collections.Generic;
    
    public partial class kisi_bilgileri
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public kisi_bilgileri()
        {
            this.arac_bilgileri = new HashSet<arac_bilgileri>();
        }
    
        public int kisi_id { get; set; }
        public string tc_kimlik { get; set; }
        public string ad { get; set; }
        public string soyad { get; set; }
        public string cep_telefonu { get; set; }
        public string Adres { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<arac_bilgileri> arac_bilgileri { get; set; }
    }
}
