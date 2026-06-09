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
    public partial class frmNhaCungCap : Form
    {

        private DBContextModel dbContext;

        private List<NhaCungCap> lstNCC;

        private NhaCungCap selectedNCC = null;

        public frmNhaCungCap()
        {
            InitializeComponent();
        }
        private void PhanQuyen()
        {
            bool isAdmin = CurrentUsr.Instance.NhanVien.Role;
            btnXoaNPP.Visible = isAdmin;
        }
        private void btnThemNPP_Click(object sender, EventArgs e)
        {
            if (!ValidateData()) return;
            if (ValidateIsExist())
            {
                Utils.ShowMessage("Nhà Cung Cấp đã tồn tại", txtTenNPP);
                return;
            }    
                
            Insert();
            ClearForm();
            BindingDataNPP();
        }

        private void btnSuaNPP_Click(object sender, EventArgs e)
        {
            if (!ValidateData()) return;
            if (!ValidateIsExist())
            {
                Utils.ShowMessage("Nhà Cung Cấp chưa tồn tại", txtTenNPP);
                return;
            }
            Edit();
            ClearForm();
            BindingDataNPP();
        }

        private void btnXoaNPP_Click(object sender, EventArgs e)
        {
            Delete();
            selectedNCC = null;
            ClearForm();
            BindingDataNPP();
        }
        private void dgvNPP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = dgvNPP.Rows[e.RowIndex];
                string maNCC = row.Cells[0].Value.ToString();

                selectedNCC = lstNCC.FirstOrDefault(s => s.MaNCC == maNCC); // not query directly to db
                PopulateTxtBox();
            }
        }
        private void frmNPP_Load(object sender, EventArgs e)
        {
            dbContext = new DBContextModel();
            BindingDataNPP();
            PhanQuyen();
        }

        private void PopulateTxtBox()
        {
            if (selectedNCC == null) return;
            txtTenNPP.Text = selectedNCC.TenNCC.ToString();
            txtSDT.Text = selectedNCC.SDT.ToString();
            txtDiaChi.Text = selectedNCC.DiaChi.ToString();
        }

        private void frmNPP_FormClosed(object sender, FormClosedEventArgs e)
        {
            dbContext?.Dispose();
        }
        
        
        private void BindingDataNPP()
        {
            dgvNPP.Rows.Clear();
            lstNCC = dbContext.NhaCungCaps.ToList();
            foreach (var sp in lstNCC)
            {
                int idx = dgvNPP.Rows.Add();
                dgvNPP.Rows[idx].Cells[0].Value = sp.MaNCC;
                dgvNPP.Rows[idx].Cells[1].Value = sp.TenNCC;
                dgvNPP.Rows[idx].Cells[2].Value = sp.SDT;
                dgvNPP.Rows[idx].Cells[3].Value = sp.DiaChi;
            }

        }

        private void Insert()
        {
            string newMaNCC = Utils.GenNewNCCID(dbContext);
            string tenNCC = txtTenNPP.Text;
            string SDT = txtSDT.Text;
            string DiaChi = txtDiaChi.Text;
            NhaCungCap newNCC = new NhaCungCap
            {
                MaNCC = newMaNCC,
                TenNCC = tenNCC,
                SDT = SDT,
                DiaChi = DiaChi,
                NgayTao = DateTime.Now
            };
            dbContext.NhaCungCaps.Add(newNCC);
            dbContext.SaveChanges();
            Utils.ShowMessage("Thêm Nhà Cung Cấp Thành Công.", txtTenNPP);
        }

        private void Delete()
        {
            try
            {
                if (selectedNCC == null)
                {
                    Utils.ShowMessage("Vui lòng chọn dữ liệu để xóa!", txtTenNPP);
                    return;
                }

                var result = MessageBox.Show("Bạn có chắc chắn muốn xóa Nhà Cung Cấp này? Các Thông tin về Phiếu Nhập Có thể sẽ bị xóa theo", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result != DialogResult.Yes)
                    return;
                if (selectedNCC == null)
                {
                    Utils.ShowMessage("Nhà Cung Cấp không tồn tại.", txtTenNPP);
                    return;
                }
                dbContext.NhaCungCaps.Remove(selectedNCC);
                dbContext.SaveChanges();
                Utils.ShowMessage("Xóa Nhà Cung Cấp Thành Công.", txtTenNPP);
            }
            catch (Exception ex)
            {
                
                Utils.ShowMessage("Lỗi xóa dữ liệu: " + ex.Message, txtTenNPP);
            }
        }

        private void Edit()
        {
            selectedNCC.SDT = txtSDT.Text;
            selectedNCC.DiaChi = txtDiaChi.Text;
            selectedNCC.TenNCC = txtTenNPP.Text;
            dbContext.SaveChanges();
            Utils.ShowMessage("Chỉnh sửa thông tin Nhà Cung Cấp Thành Công.", txtTenNPP);
        }

        private bool ValidateData()
        {
            if (string.IsNullOrWhiteSpace(txtTenNPP.Text))
            {
                Utils.ShowMessage("Vui lòng điền tên Nhà Cung Cấp!", txtTenNPP);
                return false;
            }
            if ( string.IsNullOrWhiteSpace(txtSDT.Text))
            {
                Utils.ShowMessage("Vui lòng điền Số Điện Thoại Nhà Cung Cấp!", txtSDT);
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtDiaChi.Text))
            {
                Utils.ShowMessage("Vui lòng điền Địa Chỉ!", txtDiaChi);
                return false;
            }
            return true;
        }

        private bool ValidateIsExist()
        {
            return selectedNCC != null;
        }
        private void ClearForm()
        {
            txtDiaChi.Text = "";
            txtSDT.Text = "";
            txtTenNPP.Text = "";
        }
    }
}
