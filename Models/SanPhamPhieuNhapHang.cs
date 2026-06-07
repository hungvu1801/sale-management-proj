using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanHang.Models
{
    public class SanPhamPhieuNhapHangCB
    {
        public string MaSP { get; set; }
        public string TenSP { get; set; }
    }

    public class SanPhamPhieuNhapHang
    {
        public string MaSP { get; set; }
        public string TenSP { get; set; }

        public int SoLuong { get; set; }

        public int GiaNhap { get; set; }

        public string MaNCC { get; set; }

        public string TenNCC { get; set; }

        public int ThanhTien => SoLuong * GiaNhap;
    }
}
