namespace DAL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PHIEUMUON")]
    public partial class PHIEUMUON
    {
        [Key]
        [StringLength(10)]
        public string MaPhieu { get; set; }

        [StringLength(10)]
        public string MaDocGia { get; set; }

        [StringLength(10)]
        public string MaSach { get; set; }

        public DateTime? NgayMuon { get; set; }

        public DateTime? NgayPhaiTra { get; set; }

        public virtual DOCGIA DOCGIA { get; set; }

        public virtual SACH SACH { get; set; }
    }
}
