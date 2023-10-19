namespace DAL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SACH")]
    public partial class SACH
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SACH()
        {
            PHIEUMUONs = new HashSet<PHIEUMUON>();
            PHIEUTRAs = new HashSet<PHIEUTRA>();
        }

        [Key]
        [StringLength(10)]
        public string MaSach { get; set; }

        [StringLength(50)]
        public string TenSach { get; set; }

        [StringLength(30)]
        public string TacGia { get; set; }

        [StringLength(30)]
        public string TheLoai { get; set; }

        [StringLength(50)]
        public string NhaXuatBan { get; set; }

        public int? GiaSach { get; set; }

        public int? SoLuong { get; set; }

        [StringLength(10)]
        public string TinhTrang { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PHIEUMUON> PHIEUMUONs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PHIEUTRA> PHIEUTRAs { get; set; }
    }
}
