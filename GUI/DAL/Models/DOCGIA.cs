namespace DAL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DOCGIA")]
    public partial class DOCGIA
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DOCGIA()
        {
            PHIEUMUONs = new HashSet<PHIEUMUON>();
            PHIEUTRAs = new HashSet<PHIEUTRA>();
        }

        [Key]
        [StringLength(10)]
        public string MaDocGia { get; set; }

        [StringLength(30)]
        public string TenDangNhap { get; set; }

        [StringLength(30)]
        public string HoTen { get; set; }

        [StringLength(5)]
        public string GioiTinh { get; set; }

        public DateTime? NamSinh { get; set; }

        [StringLength(100)]
        public string DiaChi { get; set; }

        public virtual ACCOUNT ACCOUNT { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PHIEUMUON> PHIEUMUONs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PHIEUTRA> PHIEUTRAs { get; set; }
    }
}
