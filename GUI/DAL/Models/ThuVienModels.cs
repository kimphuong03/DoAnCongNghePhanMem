using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace DAL.Models
{
    public partial class ThuVienModels : DbContext
    {
        public ThuVienModels()
            : base("name=ThuVienModels")
        {
        }

        public virtual DbSet<ACCOUNT> ACCOUNTs { get; set; }
        public virtual DbSet<DOCGIA> DOCGIAs { get; set; }
        public virtual DbSet<PHIEUMUON> PHIEUMUONs { get; set; }
        public virtual DbSet<PHIEUTRA> PHIEUTRAs { get; set; }
        public virtual DbSet<SACH> SACHes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ACCOUNT>()
                .Property(e => e.MaDocGia)
                .IsFixedLength();

            modelBuilder.Entity<ACCOUNT>()
                .Property(e => e.TenDangNhap)
                .IsFixedLength();

            modelBuilder.Entity<ACCOUNT>()
                .Property(e => e.MatKhau)
                .IsFixedLength();

            modelBuilder.Entity<ACCOUNT>()
                .HasOptional(e => e.DOCGIA)
                .WithRequired(e => e.ACCOUNT);

            modelBuilder.Entity<DOCGIA>()
                .Property(e => e.MaDocGia)
                .IsFixedLength();

            modelBuilder.Entity<DOCGIA>()
                .Property(e => e.TenDangNhap)
                .IsFixedLength();

            modelBuilder.Entity<DOCGIA>()
                .Property(e => e.HoTen)
                .IsFixedLength();

            modelBuilder.Entity<DOCGIA>()
                .Property(e => e.GioiTinh)
                .IsFixedLength();

            modelBuilder.Entity<DOCGIA>()
                .Property(e => e.DiaChi)
                .IsFixedLength();

            modelBuilder.Entity<PHIEUMUON>()
                .Property(e => e.MaPhieu)
                .IsFixedLength();

            modelBuilder.Entity<PHIEUMUON>()
                .Property(e => e.MaDocGia)
                .IsFixedLength();

            modelBuilder.Entity<PHIEUMUON>()
                .Property(e => e.MaSach)
                .IsFixedLength();

            modelBuilder.Entity<PHIEUTRA>()
                .Property(e => e.MaPhieu)
                .IsFixedLength();

            modelBuilder.Entity<PHIEUTRA>()
                .Property(e => e.MaDocGia)
                .IsFixedLength();

            modelBuilder.Entity<PHIEUTRA>()
                .Property(e => e.MaSach)
                .IsFixedLength();

            modelBuilder.Entity<SACH>()
                .Property(e => e.MaSach)
                .IsFixedLength();

            modelBuilder.Entity<SACH>()
                .Property(e => e.TenSach)
                .IsFixedLength();

            modelBuilder.Entity<SACH>()
                .Property(e => e.TacGia)
                .IsFixedLength();

            modelBuilder.Entity<SACH>()
                .Property(e => e.TheLoai)
                .IsFixedLength();

            modelBuilder.Entity<SACH>()
                .Property(e => e.NhaXuatBan)
                .IsFixedLength();

            modelBuilder.Entity<SACH>()
                .Property(e => e.TinhTrang)
                .IsFixedLength();
        }
    }
}
