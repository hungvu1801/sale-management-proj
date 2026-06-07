using QuanLyBanHang.Models;
using QuanLyBanHang.Singletons;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBanHang
{
    public class Utils
    {
        public static void ShowMessage(string message, Control control)
        {
            MessageBox.Show(message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            control.Focus();
        }

        public static void ClearGioHang()
        {
            LstGioHang.Instance.giohang.Clear();
        }
        public static void ClearPhieuNhapHang()
        {
            LstCTPhieuNhap.Instance.CtPhieuNhap.Clear();
        }

        public static string GenNewKHID(DBContextModel dbContext)
        {
            // Return increment MaSP
            string lastMaKH = dbContext.KhangHangs
                .OrderByDescending(c => c.MaKH)
                .Select(c => c.MaKH)
                .FirstOrDefault();
            if (lastMaKH == null)
                return "KH001";
            int number = int.Parse(lastMaKH.Substring(2));
            number++;
            return "KH" + number.ToString();
        }

        public static string GenNewHDID(DBContextModel dbContext)
        {

            string lastMaHD = dbContext.HoaDonBanHangs
                .OrderByDescending(sp => sp.MaHD)
                .Select(sp => sp.MaHD)
                .FirstOrDefault();
            if (lastMaHD == null)
                return "HD001";
            int number = int.Parse(lastMaHD.Substring(2));
            number++;
            return "HD" + number.ToString();
        }

       
        public static string GenNewNCCID(DBContextModel dbContext)
        {

            string lastMaNCC = dbContext.NhaCungCaps
                .OrderByDescending(sp => sp.MaNCC)
                .Select(sp => sp.MaNCC)
                .FirstOrDefault();
            if (lastMaNCC == null)
                return "NCC001";
            int number = int.Parse(lastMaNCC.Substring(3));
            number++;
            return "NCC" + number.ToString();
        }

        public static string GenNewPNID(DBContextModel dbContext)
        {

            string lastMaPH = dbContext.PhieuNhapHangs
                .OrderByDescending(sp => sp.MaPhieuNhap)
                .Select(sp => sp.MaPhieuNhap)
                .FirstOrDefault();
            if (lastMaPH == null)
                return "PN001";
            int number = int.Parse(lastMaPH.Substring(2));
            number++;
            return "PN" + number.ToString();
        }

        public static string GenNewNVID(DBContextModel dbContext)
        {
            // Tinh gia tri ID tiep theo
            string lastMaNV = dbContext.NhanViens
                .OrderByDescending(sp => sp.MaNV)
                .Select(sp => sp.MaNV)
                .FirstOrDefault();
            if (lastMaNV == null)
                return "NV001";
            int number = int.Parse(lastMaNV.Substring(2));
            number++;
            return "NV" + number.ToString();
        }

        public static int CalcTongSoTienGioHang()
        {
            // Tinh tong so tien gio hang
            int Sum = LstGioHang.Instance.giohang.Sum(sp => sp.ThanhTien);
            return Sum;
        }

        public static int CalcTongSoTienPhieuNhap()
        {
            // Tinh tong so tien chi tiết phiếu nhập
            int Sum = LstCTPhieuNhap.Instance.CtPhieuNhap.Sum(sp => sp.ThanhTien);
            return Sum;
        }
    }
}
