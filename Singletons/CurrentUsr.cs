using QuanLyBanHang.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanHang.Singletons
{
    public class CurrentUsr
    {
        private static CurrentUsr instance;

        public static CurrentUsr Instance
        {
            get
            {
                if (instance == null) instance = new CurrentUsr();
                return instance;
            }

            set => instance = value;
        }

        NhanVien _nhanvien;
        public NhanVien NhanVien { get => _nhanvien; set => _nhanvien = value; }

        private CurrentUsr() 
        {
            _nhanvien = new NhanVien();
        }

    }
}
