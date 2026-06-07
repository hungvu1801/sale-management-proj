using QuanLyBanHang.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanHang.Singletons
{
    public class LstCTPhieuNhap
    {
        private static LstCTPhieuNhap instance;

        public static LstCTPhieuNhap Instance
        {
            get
            {
                if (instance == null) instance = new LstCTPhieuNhap();
                return instance;
            }

            set => instance = value;
        }

        List<SanPhamPhieuNhapHang> _ctphieunhap;

        public List<SanPhamPhieuNhapHang> CtPhieuNhap { get => _ctphieunhap; set => _ctphieunhap = value; }

        private LstCTPhieuNhap()
        {
            _ctphieunhap = new List<SanPhamPhieuNhapHang>();
        }

    }
}
