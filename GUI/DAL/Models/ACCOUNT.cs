namespace DAL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ACCOUNT")]
    public partial class ACCOUNT
    {
        [Key]
        [StringLength(10)]
        public string MaDocGia { get; set; }

        [StringLength(30)]
        public string TenDangNhap { get; set; }

        [StringLength(30)]
        public string MatKhau { get; set; }

        public int? Quyen { get; set; }

        public virtual DOCGIA DOCGIA { get; set; }
    }
}
