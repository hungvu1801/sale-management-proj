using QuanLyBanHang.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBanHang.Forms
{
    public partial class frmHangNhap : Form
    {
        public frmHangNhap()
        {
            InitializeComponent();
        }

        private bool ValidateInsert()
        {

            //if (string.IsNullOrEmpty(this.txtMaSP.Text))
            //{
            //    Utils.ShowMessage("Vui lòng nhập mã sản phẩm.", this.txtMaSP);
            //    return false;
            //}
            //if (string.IsNullOrEmpty(txtTenSP.Text))
            //{
            //    Utils.ShowMessage("Vui lòng nhập tên sản phẩm!", this.txtTenSP);
            //    return false;
            //}
            return true;
        }

        private void Insert()
        {

            //SanPham newSanPham = new SanPham
            //{
            //    MaSP = GenNewMaSP(),
            //    MaHangSX = cbHangSX.SelectedValue.ToString(),
            //    TenSP = txtTenSP.Text,
            //    SoLuongTon = 0,
            //    GiaNhapHienTai = 0,
            //    GiaBanHienTai = 0
            //};

        }

        private string GenNewID()
        {
            // Return increment MaSP
            return "";
            
            //string lastMaSP = dbContext.SanPhams
            //    .OrderByDescending(sp => sp.MaSP)
            //    .Select(sp => sp.MaSP)
            //    .FirstOrDefault();
            //if (lastMaSP == null)
            //    return "SP001";
            //int number = int.Parse(lastMaSP.Substring(2));
            //number++;
            //return "SP" + number.ToString();
        }
    }
}
