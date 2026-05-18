namespace QuanLyBanHang.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SanPham")]
    public partial class SanPham
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SanPham()
        {
            ChiTietHoaDons = new HashSet<ChiTietHoaDon>();
            ChiTietPhieuNhapHangs = new HashSet<ChiTietPhieuNhapHang>();
        }

        [Key]
        [StringLength(10)]
        public string MaSP { get; set; }

        [Required]
        [StringLength(10)]
        public string MaPL { get; set; }

        [Required]
        [StringLength(100)]
        public string TenSP { get; set; }

        public int SoLuongTon { get; set; }

        public int GiaNhapHienTai { get; set; }

        public int GiaBanHienTai { get; set; }

        [Required]
        [StringLength(10)]
        public string MaHangSX { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChiTietHoaDon> ChiTietHoaDons { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChiTietPhieuNhapHang> ChiTietPhieuNhapHangs { get; set; }

        public virtual HangSX HangSX { get; set; }

        public virtual PhanLoaiSP PhanLoaiSP { get; set; }
    }
}
