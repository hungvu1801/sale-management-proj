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
    public partial class frmKhachHang : Form
    {
        private DBContextModel dbContext;
        //private bool isAddingNew = false;

        public frmKhachHang()
        {
            InitializeComponent();
            
        }

        private void frmKhachHang_Load(object sender, EventArgs e)
        {
            dbContext = new DBContextModel();
            LoadCustomers();
        }

        private void frmKhachHang_FormClosed(object sender, FormClosedEventArgs e)
        {
            dbContext?.Dispose();
        }

        private void LoadCustomers()
        {
            try
            {
                var lstKhachHang = dbContext.KhangHangs.ToList();
                BindingDataKhachHang(lstKhachHang);
            }
            catch (Exception ex)
            {
                Utils.ShowMessage("Lỗi khi tải dữ liệu khách hàng: " + ex.Message, txtTenKH);
            }
        }
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            SearchKhachHang();
        }

        private void btnXoaTimKiem_Click(object sender, EventArgs e)
        {
            txtTimSDT.Text = "";            
            LoadCustomers();
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtMaKH.Text) || string.IsNullOrWhiteSpace(txtTenKH.Text) ||
                    string.IsNullOrWhiteSpace(txtSDT.Text) || string.IsNullOrWhiteSpace(txtDiaChi.Text))
                {
                    Utils.ShowMessage("Vui lòng điền đầy đủ thông tin!", txtTenKH);
                    return;
                }

                var existingCustomer = dbContext.KhangHangs.FirstOrDefault(k => k.MaKH == txtMaKH.Text);
                if (existingCustomer != null)
                {
                    Utils.ShowMessage("Mã khách hàng đã tồn tại!", txtTenKH);
                    return;
                }

                var newCustomer = new KhangHang
                {
                    MaKH = txtMaKH.Text,
                    TenKH = txtTenKH.Text,
                    SDT = txtSDT.Text,
                    DiaCHi = txtDiaChi.Text
                };

                dbContext.KhangHangs.Add(newCustomer);
                dbContext.SaveChanges();

                Utils.ShowMessage("Thêm khách hàng thành công!", txtTenKH);
                ClearForm();
                LoadCustomers();
            }
            catch (Exception ex)
            {
                Utils.ShowMessage("Lỗi khi thêm khách hàng: " + ex.Message, txtTenKH);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtMaKH.Text))
                {
                    Utils.ShowMessage("Vui lòng chọn khách hàng để sửa!", txtTenKH);
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtTenKH.Text) || string.IsNullOrWhiteSpace(txtSDT.Text) ||
                    string.IsNullOrWhiteSpace(txtDiaChi.Text))
                {
                    Utils.ShowMessage("Vui lòng điền đầy đủ thông tin!", txtTenKH);
                    return;
                }

                var customer = dbContext.KhangHangs.FirstOrDefault(k => k.MaKH == txtMaKH.Text);
                if (customer == null)
                {
                    Utils.ShowMessage("Khách hàng không tồn tại!", txtTenKH);
                    return;
                }

                customer.TenKH = txtTenKH.Text;
                customer.SDT = txtSDT.Text;
                customer.DiaCHi = txtDiaChi.Text;

                dbContext.SaveChanges();
                Utils.ShowMessage("Cập nhật khách hàng thành công!", txtTenKH);
                ClearForm();
                LoadCustomers();
            }
            catch (Exception ex)
            {
                Utils.ShowMessage("Lỗi khi sửa khách hàng: " + ex.Message, txtTenKH);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtMaKH.Text))
                {
                    Utils.ShowMessage("Vui lòng chọn khách hàng để xóa!", txtTenKH);
                    return;
                }

                var result = MessageBox.Show("Bạn có chắc chắn muốn xóa khách hàng này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result != DialogResult.Yes)
                    return;

                var customer = dbContext.KhangHangs.FirstOrDefault(k => k.MaKH == txtMaKH.Text);
                if (customer == null)
                {
                    Utils.ShowMessage("Khách hàng không tồn tại!", txtTenKH);
                    return;
                }

                dbContext.KhangHangs.Remove(customer);
                dbContext.SaveChanges();

                Utils.ShowMessage("Xóa khách hàng thành công!", txtTenKH);

                ClearForm();
                LoadCustomers();
            }
            catch (Exception ex)
            {
                Utils.ShowMessage("Lỗi khi xóa khách hàng: " + ex.Message, txtTenKH);
            }
        }

        private void dgvCustomers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvCustomers.Rows[e.RowIndex];
                txtMaKH.Text = row.Cells[0].Value?.ToString();
                txtTenKH.Text = row.Cells[1].Value?.ToString();
                txtSDT.Text = row.Cells[2].Value?.ToString();
                txtDiaChi.Text = row.Cells[3].Value?.ToString();
            }
        }

        private void ClearForm()
        {
            txtMaKH.Clear();
            txtTenKH.Clear();
            txtSDT.Clear();
            txtDiaChi.Clear();
            txtMaKH.Focus();
        }


        private void BindingDataKhachHang(List<KhangHang> lstKhachHang)
        {
            dgvCustomers.Rows.Clear();

            foreach (var c in lstKhachHang)
            {
                int idx = dgvCustomers.Rows.Add();
                dgvCustomers.Rows[idx].Cells[0].Value = c.MaKH;
                dgvCustomers.Rows[idx].Cells[1].Value = c.TenKH;
                dgvCustomers.Rows[idx].Cells[2].Value = c.SDT;
                dgvCustomers.Rows[idx].Cells[3].Value = c.DiaCHi;
            }

        }

        private void SearchKhachHang()
        {
            var searchLst = dbContext.KhangHangs.Where(sp => sp.SDT == txtTimSDT.Text).ToList();
            BindingDataKhachHang(searchLst);
        }

        
    }
}
