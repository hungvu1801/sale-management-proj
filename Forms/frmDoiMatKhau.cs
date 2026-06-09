using QuanLyBanHang.Models;
using QuanLyBanHang.Singletons;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBanHang.Forms
{
    public partial class frmDoiMatKhau : Form
    {
        public frmDoiMatKhau()
        {
            InitializeComponent();
        }
        private void ClearForm()
        {
            txtMKC.Text = string.Empty;
            txtMKM.Text = string.Empty;
        }
        private void btnDoiMK_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMKC.Text))
            {
                Utils.ShowMessage("Vui lòng nhập Mật Khẩu Cũ!", txtMKC);
                return;
            }
            if (string.IsNullOrEmpty(txtMKM.Text)) 
            {
                Utils.ShowMessage("Vui lòng nhập Mật Khẩu Mới!", txtMKM);
                return;
            }
            if (CurrentUsr.Instance.NhanVien.Password == txtMKC.Text.Trim()) 
            {
                CurrentUsr.Instance.NhanVien.Password = txtMKC.Text.Trim();
                using (DBContextModel dbContext = new DBContextModel())
                {
                    NhanVien nv = dbContext.NhanViens
                        .FirstOrDefault(n => n.MaNV == CurrentUsr.Instance.NhanVien.MaNV);

                    if (nv == null) return;

                    nv.Password = txtMKM.Text.Trim();
                    dbContext.SaveChanges();

                    // Update cho singleton
                    CurrentUsr.Instance.NhanVien.Password = txtMKM.Text.Trim();

                    Utils.ShowMessage("Đổi mật khẩu thành công!", txtMKM);
                    ClearForm();
                }
                    
            }
            else Utils.ShowMessage("Mật khẩu cũ không đúng!", txtMKC);
        }
    }
}
