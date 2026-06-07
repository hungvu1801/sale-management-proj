using QuanLyBanHang.Models;
using QuanLyBanHang.Singletons;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBanHang.Forms
{
    public partial class frmHoaDonBanHang : Form
    {
        public NhanVien CurrentEmployee { get; set; }

        private KhangHang selectedKhachHang;

        private DBContextModel dbContext;

        private bool isCusFound = false;
        public frmHoaDonBanHang()
        {
            InitializeComponent();
        }
        private void frmHoaDonBanHang_Load(object sender, EventArgs e)
        {
            dbContext = new DBContextModel();
            BindingDataGioHang();
            updateSLGioHang();
            updateTongSoTien();
        }
        private void frmHoaDonBanHang_FormClosed(object sender, FormClosedEventArgs e)
        {
            dbContext?.Dispose();
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            if (!ValidateGioHangIsAvailable())
            {
                Utils.ShowMessage("Giỏ hàng trống!", txtTenKH);
                return; 
            } 

            if (!ValidateSoLuongSanPhamIsAvailable()) return;

            string maKH = CreateNewKhachHang();
            if (maKH == null) return;

            string maHD = CreateHoaDon(maKH);
            if (maHD == null) return;

            CreateChiTietHoaDon(maHD);

            Utils.ShowMessage("Thanh toán sản phẩm thành công.", txtTenKH);
            Utils.ClearGioHang();
            BindingDataGioHang();
            updateSLGioHang();
            updateTongSoTien();
            ClearForm();
        }
        private void btnHuy_Click(object sender, EventArgs e)
        {
            var mainForm = this.MdiParent as mainFrm;
            if (mainForm != null)
            {
                MethodInfo showMethod = mainForm.GetType()
                .GetMethod("ShowForm", BindingFlags.NonPublic | BindingFlags.Instance); // get ShowForm method from mainform

                if (showMethod != null)
                {
                    showMethod = showMethod.MakeGenericMethod(typeof(frmSanPham));
                    showMethod.Invoke(mainForm, null); // execute the show method
                }
            }
        }
        private void txtSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter) 
            {
                isCusFound = false; // reset
                selectedKhachHang = dbContext.KhangHangs.FirstOrDefault(kh => kh.SDT == txtSDT.Text.Trim());
                if (selectedKhachHang == null) return;
                txtTenKH.Text = selectedKhachHang.TenKH;
                txtDiaChi.Text = selectedKhachHang.DiaCHi;
                isCusFound = true;
            }
        }
   
        private void BindingDataGioHang()
        {
            dvgGioHang.Rows.Clear();

            foreach (var sp in LstGioHang.Instance.giohang)
            {
                int idx = dvgGioHang.Rows.Add();
                dvgGioHang.Rows[idx].Cells[0].Value = sp.MaSP;
                dvgGioHang.Rows[idx].Cells[1].Value = sp.TenSP;
                dvgGioHang.Rows[idx].Cells[2].Value = sp.SoLuong;
                dvgGioHang.Rows[idx].Cells[3].Value = sp.DonGia;
                dvgGioHang.Rows[idx].Cells[4].Value = sp.ThanhTien;
            }

        }


        private void updateSLGioHang()
        {
            int soLuongGioHang = LstGioHang.Instance.giohang.Count();
            txtSLGioHang.Text = soLuongGioHang.ToString();
        }
        private void updateTongSoTien()
        {
            int sum = Utils.CalcTongSoTienGioHang();
            txtTongSoTien.Text = sum.ToString();
        }
        private string CreateNewKhachHang()
        {
            try
            {
                if (isCusFound) return selectedKhachHang.MaKH;
                if (string.IsNullOrEmpty(txtTenKH.Text))
                {
                    Utils.ShowMessage("Vui lòng nhập tên khách hàng!", txtTenKH);
                    return null;
                }
                if (string.IsNullOrEmpty(txtSDT.Text))
                    // if the customer not say the phone no
                    return "KH00";

                string newMaKH = Utils.GenNewKHID(dbContext);
                string newSDT = txtSDT.Text.Trim();
                string newTenKH = txtTenKH.Text.Trim();
                string newDiaChi = txtDiaChi.Text.Trim();

                KhangHang newKhachHang = new KhangHang
                {
                    MaKH = newMaKH,
                    SDT = newSDT,
                    TenKH = newTenKH,
                    DiaCHi = newDiaChi
                };
                dbContext.KhangHangs.Add(newKhachHang);
                dbContext.SaveChanges();
                return newMaKH;
            }
            catch (Exception ex)
            {
                Utils.ShowMessage(ex.Message, txtTenKH);
                return null;
            }
        }

        private string CreateHoaDon(string maKH)
        {
            try
            {
                string maNV = CurrentUsr.Instance.NhanVien.MaNV;
                string newMaHD = Utils.GenNewHDID(dbContext);
                int newTongSoTien = Utils.CalcTongSoTienGioHang();

                var newHD = new HoaDonBanHang
                {
                    MaHD = newMaHD,
                    TongST = newTongSoTien,
                    MaNV = maNV,
                    MaKH = maKH,
                    NgayLap = DateTime.Now,
                };

                dbContext.HoaDonBanHangs.Add(newHD);
                dbContext.SaveChanges();
                return newMaHD;
            }
            catch (Exception ex)
            {
                Utils.ShowMessage(ex.Message, txtTenKH);
                return null;
            }
        }

        private void CreateChiTietHoaDon(string maHD)
        {
            try
            {
                var maSPLst = LstGioHang.Instance.giohang.Select(sp => sp.MaSP).ToList(); // query masp in giohang
                var sanPhamsLst = dbContext.SanPhams.Where(sp => maSPLst.Contains(sp.MaSP)).ToList();
                foreach (var item in LstGioHang.Instance.giohang)
                {
                    // Add New record in ChiTietHoaDon
                    ChiTietHoaDon newCTHD = new ChiTietHoaDon
                    {
                        MaHD = maHD,
                        MaSP = item.MaSP,
                        SoLuong = item.SoLuong,
                        GiaBan = item.DonGia
                    };
                    dbContext.ChiTietHoaDons.Add(newCTHD);

                    // Update SoLuong in SanPham table
                    var sanPham = sanPhamsLst.FirstOrDefault(sp => sp.MaSP == item.MaSP);
                    if (sanPham != null)
                        sanPham.SoLuongTon -= item.SoLuong;
                }
                dbContext.SaveChanges();
            }
            catch (Exception ex)
            {
                Utils.ShowMessage(ex.Message, txtTenKH);
            }

        }

        private bool ValidateSoLuongSanPhamIsAvailable()
        {
            foreach (var item in LstGioHang.Instance.giohang)
            {
                SanPham sanPham = dbContext.SanPhams.FirstOrDefault(sp => sp.MaSP == item.MaSP);
                if (sanPham.SoLuongTon - item.SoLuong < 0)
                {
                    Utils.ShowMessage("Số lượng hàng " + item.TenSP + " không đủ!! Vui lòng kiểm tra lại giỏ hàng!", txtTenKH);
                    return false;
                }
                    
            }

            return true;
        }

        private bool ValidateGioHangIsAvailable()
        {
            if (LstGioHang.Instance.giohang.Count > 0)
                return true;
            return false;
        }

       private void ClearForm()
        {
            txtDiaChi.Text = "";
            txtTenKH.Text = "";
            txtSDT.Text = "";
            
        }
    }
}
