using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace QuanLyBanHang.Models
{
    public partial class DBContextModel : DbContext
    {
        public DBContextModel()
            : base("name=DBContextModel")
        {
        }

        public virtual DbSet<ChiTietHoaDon> ChiTietHoaDons { get; set; }
        public virtual DbSet<ChiTietPhieuNhapHang> ChiTietPhieuNhapHangs { get; set; }
        public virtual DbSet<HangSX> HangSXes { get; set; }
        public virtual DbSet<HoaDonBanHang> HoaDonBanHangs { get; set; }
        public virtual DbSet<KhangHang> KhangHangs { get; set; }
        public virtual DbSet<NhaCungCap> NhaCungCaps { get; set; }
        public virtual DbSet<NhanVien> NhanViens { get; set; }
        public virtual DbSet<PhanLoaiSP> PhanLoaiSPs { get; set; }
        public virtual DbSet<PhieuNhapHang> PhieuNhapHangs { get; set; }
        public virtual DbSet<SanPham> SanPhams { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ChiTietHoaDon>()
                .Property(e => e.MaHD)
                .IsUnicode(false);

            modelBuilder.Entity<ChiTietHoaDon>()
                .Property(e => e.MaSP)
                .IsUnicode(false);

            modelBuilder.Entity<ChiTietPhieuNhapHang>()
                .Property(e => e.MaPhieuNhap)
                .IsUnicode(false);

            modelBuilder.Entity<ChiTietPhieuNhapHang>()
                .Property(e => e.MaSP)
                .IsUnicode(false);

            modelBuilder.Entity<HangSX>()
                .Property(e => e.MaHangSX)
                .IsUnicode(false);

            modelBuilder.Entity<HangSX>()
                .HasMany(e => e.SanPhams)
                .WithRequired(e => e.HangSX)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<HangSX>()
                .HasMany(e => e.NhaCungCaps)
                .WithMany(e => e.HangSXes)
                .Map(m => m.ToTable("NhaCungCap_Hang").MapLeftKey("MaHangSX").MapRightKey("MaNCC"));

            modelBuilder.Entity<HoaDonBanHang>()
                .Property(e => e.MaHD)
                .IsUnicode(false);

            modelBuilder.Entity<HoaDonBanHang>()
                .Property(e => e.MaNV)
                .IsUnicode(false);

            modelBuilder.Entity<HoaDonBanHang>()
                .Property(e => e.MaKH)
                .IsUnicode(false);

            modelBuilder.Entity<HoaDonBanHang>()
                .HasMany(e => e.ChiTietHoaDons)
                .WithRequired(e => e.HoaDonBanHang)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<KhangHang>()
                .Property(e => e.MaKH)
                .IsUnicode(false);

            modelBuilder.Entity<KhangHang>()
                .Property(e => e.SDT)
                .IsUnicode(false);

            modelBuilder.Entity<KhangHang>()
                .HasMany(e => e.HoaDonBanHangs)
                .WithRequired(e => e.KhangHang)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NhaCungCap>()
                .Property(e => e.MaNCC)
                .IsUnicode(false);

            modelBuilder.Entity<NhaCungCap>()
                .HasMany(e => e.PhieuNhapHangs)
                .WithRequired(e => e.NhaCungCap)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NhanVien>()
                .Property(e => e.MaNV)
                .IsUnicode(false);

            modelBuilder.Entity<NhanVien>()
                .Property(e => e.Username)
                .IsUnicode(false);

            modelBuilder.Entity<NhanVien>()
                .Property(e => e.Password)
                .IsUnicode(false);

            modelBuilder.Entity<NhanVien>()
                .HasMany(e => e.HoaDonBanHangs)
                .WithRequired(e => e.NhanVien)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NhanVien>()
                .HasMany(e => e.PhieuNhapHangs)
                .WithRequired(e => e.NhanVien)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PhanLoaiSP>()
                .Property(e => e.MaPL)
                .IsUnicode(false);

            modelBuilder.Entity<PhanLoaiSP>()
                .HasMany(e => e.SanPhams)
                .WithRequired(e => e.PhanLoaiSP)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PhieuNhapHang>()
                .Property(e => e.MaPhieuNhap)
                .IsUnicode(false);

            modelBuilder.Entity<PhieuNhapHang>()
                .Property(e => e.MaNV)
                .IsUnicode(false);

            modelBuilder.Entity<PhieuNhapHang>()
                .Property(e => e.MaNCC)
                .IsUnicode(false);

            modelBuilder.Entity<PhieuNhapHang>()
                .HasMany(e => e.ChiTietPhieuNhapHangs)
                .WithRequired(e => e.PhieuNhapHang)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SanPham>()
                .Property(e => e.MaSP)
                .IsUnicode(false);

            modelBuilder.Entity<SanPham>()
                .Property(e => e.MaPL)
                .IsUnicode(false);

            modelBuilder.Entity<SanPham>()
                .Property(e => e.MaHangSX)
                .IsUnicode(false);

            modelBuilder.Entity<SanPham>()
                .HasMany(e => e.ChiTietHoaDons)
                .WithRequired(e => e.SanPham)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SanPham>()
                .HasMany(e => e.ChiTietPhieuNhapHangs)
                .WithRequired(e => e.SanPham)
                .WillCascadeOnDelete(false);
        }
    }
}
