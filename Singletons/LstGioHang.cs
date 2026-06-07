using QuanLyBanHang.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanHang.Singletons
{
    public class LstGioHang
    {
        private static LstGioHang instance;

        public static LstGioHang Instance
        {
            get
            {
                if (instance == null) instance = new LstGioHang();
                return instance;
            }

            set => instance = value;
        }

        List<SanPhamGioHang> _giohang;
        public List<SanPhamGioHang> giohang { get => _giohang; set => _giohang = value; }

        private LstGioHang()
        {
            _giohang = new List<SanPhamGioHang>();
        }
    }
}
