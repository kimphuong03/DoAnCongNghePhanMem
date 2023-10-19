namespace DAL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PHIEUTRA")]
    public partial class PHIEUTRA
    {
        [Key]
        [StringLength(10)]
        public string MaPhieu { get; set; }

        [StringLength(10)]
        public string MaDocGia { get; set; }

        [StringLength(10)]
        public string MaSach { get; set; }

        public DateTime? NgayTra { get; set; }

        public virtual DOCGIA DOCGIA { get; set; }

        public virtual SACH SACH { get; set; }
    }
}
