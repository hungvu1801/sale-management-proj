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
    public partial class frmNhanVien : Form
    {
        private DBContextModel dbContext;

        private List<NhanVien> lstNV;

        private NhanVien selectedNV = null;

        public frmNhanVien()
        {
            InitializeComponent();
        }
        private void PhanQuyen()
        {
            bool isAdmin = CurrentUsr.Instance.NhanVien.Role;
            btnXoa.Visible = isAdmin;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (!ValidateData()) return;
            if (ValidateIsExist())
            {
                Utils.ShowMessage("Nhân Viên đã tồn tại", txtTenNV);
                return;
            }

            Insert();
            ClearForm();
            BindingData();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (!ValidateData()) return;
            if (!ValidateIsExist())
            {
                Utils.ShowMessage("Nhân Viên chưa tồn tại", txtTenNV);
                return;
            }
            Edit();
            ClearForm();
            BindingData();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            Delete();
            selectedNV = null;
            ClearForm();
            BindingData();
        }
        private void dgvHangSX_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = dgvNV.Rows[e.RowIndex];
                string maNV = row.Cells[0].Value.ToString();

                selectedNV = lstNV.FirstOrDefault(s => s.MaNV == maNV); // not query directly to db
                PopulateTxtBox();
            }
        }
        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            dbContext = new DBContextModel();
            BindingData();
            PhanQuyen();
        }

        private void frmNhanVien_FormClosed(object sender, FormClosedEventArgs e)
        {
            dbContext?.Dispose();
        }

        private void BindingData()
        {
            dgvNV.Rows.Clear();
            lstNV = dbContext.NhanViens.ToList();
            foreach (var sp in lstNV)
            {
                int idx = dgvNV.Rows.Add();
                dgvNV.Rows[idx].Cells[0].Value = sp.MaNV;
                dgvNV.Rows[idx].Cells[1].Value = sp.TenNV;
                dgvNV.Rows[idx].Cells[2].Value = sp.Role? "Admin" : "User" ;
            }

        }

        private void Insert()
        {
            string newMaNCC = Utils.GenNewNVID(dbContext);
            string tenNCC = txtTenNV.Text;
            string defaulPassword = "123";
            NhanVien newNCC = new NhanVien
            {
                MaNV = newMaNCC,
                TenNV = tenNCC,
                Role = true,
                Password = defaulPassword,
            };
            dbContext.NhanViens.Add(newNCC);
            dbContext.SaveChanges();
            Utils.ShowMessage("Thêm Nhân Viên Thành Công.", txtMaNV);
        }

        private void Delete()
        {
            try
            {
                if (selectedNV == null)
                {
                    Utils.ShowMessage("Vui lòng chọn dữ liệu để xóa!", txtMaNV);
                    return;
                }

                var result = MessageBox.Show("Bạn có chắc chắn muốn xóa Nhân Viên này? Các Thông tin về Phiếu Nhập Có thể sẽ bị xóa theo", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result != DialogResult.Yes)
                    return;
                
                dbContext.NhanViens.Remove(selectedNV);
                dbContext.SaveChanges();
                Utils.ShowMessage("Xóa Nhân Viên Thành Công.", txtMaNV);
            }
            catch (Exception ex)
            {

                Utils.ShowMessage("Lỗi xóa dữ liệu: " + ex.Message, txtMaNV);
            }
        }

        private void Edit()
        {
            selectedNV.TenNV = txtTenNV.Text;
            dbContext.SaveChanges();
            Utils.ShowMessage("Chỉnh sửa thông tin Nhân Viên Thành Công.", txtTenNV);
        }

        private bool ValidateData()
        {
            if (string.IsNullOrWhiteSpace(txtMaNV.Text))
            {
                Utils.ShowMessage("Vui lòng điền tên Nhân Viên!", txtMaNV);
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtTenNV.Text))
            {
                Utils.ShowMessage("Vui lòng điền Số Điện Thoại Nhân Viên!", txtTenNV);
                return false;
            }
           
            return true;
        }

        private bool ValidateIsExist()
        {
            return selectedNV != null;
        }
        private void ClearForm()
        {
            txtMaNV.Text = "";
            txtTenNV.Text = "";
        }

        private void PopulateTxtBox()
        {
            if (selectedNV == null) return;
            txtMaNV.Text = selectedNV.MaNV.ToString();
            txtTenNV.Text = selectedNV.TenNV.ToString();
            rbAdmin.Checked = selectedNV.Role;
            rbUser.Checked = !selectedNV.Role;
        }
    }
}

