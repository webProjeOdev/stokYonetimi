namespace stokYonetimi.Models {
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("urunler")]
    public partial class Urun {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage",
            "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Urun() {
            siparisler = new HashSet<Siparis>();
            stoklar = new HashSet<Stok>();
        }

        [Key]
        public int urunId { get; set; }

        [Required]
        public string isim { get; set; }

        [Required]
        public string tur { get; set; }

        public int adetFiyat { get; set; }

        public string aciklama { get; set; }

        public string resim { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage",
            "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Siparis> siparisler { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage",
            "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Stok> stoklar { get; set; }
    }
}