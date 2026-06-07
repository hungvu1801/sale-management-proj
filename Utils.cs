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

        public static string GenNewKHID(DBContextModel dbContext)
        {
            // Return increment MaSP
            string lastMaSP = dbContext.KhangHangs
                .OrderByDescending(c => c.MaKH)
                .Select(c => c.MaKH)
                .FirstOrDefault();
            if (lastMaSP == null)
                return "KH001";
            int number = int.Parse(lastMaSP.Substring(2));
            number++;
            return "KH" + number.ToString();
        }

        public static string GenNewHDID(DBContextModel dbContext)
        {

            string lastMaSP = dbContext.HoaDonBanHangs
                .OrderByDescending(sp => sp.MaHD)
                .Select(sp => sp.MaHD)
                .FirstOrDefault();
            if (lastMaSP == null)
                return "HD001";
            int number = int.Parse(lastMaSP.Substring(2));
            number++;
            return "HD" + number.ToString();
        }

        public static string GenNewCTHDID(DBContextModel dbContext)
        {

            string lastMaSP = dbContext.HoaDonBanHangs
                .OrderByDescending(sp => sp.MaHD)
                .Select(sp => sp.MaHD)
                .FirstOrDefault();
            if (lastMaSP == null)
                return "HD001";
            int number = int.Parse(lastMaSP.Substring(2));
            number++;
            return "HD" + number.ToString();
        }

        public static int CalcTongSoTien()
        {
            int Sum = LstGioHang.Instance.giohang.Sum(sp => sp.ThanhTien);
            return Sum;
        }
    }
}
