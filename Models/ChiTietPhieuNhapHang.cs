namespace QuanLyBanHang.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ChiTietPhieuNhapHang")]
    public partial class ChiTietPhieuNhapHang
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(10)]
        public string MaPhieuNhap { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(10)]
        public string MaSP { get; set; }

        public int SoLuong { get; set; }

        public int GiaNhap { get; set; }

        public virtual PhieuNhapHang PhieuNhapHang { get; set; }

        public virtual SanPham SanPham { get; set; }
    }
}
