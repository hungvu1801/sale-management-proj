using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyBanHang.Models;

namespace QuanLyBanHang
{
    public partial class frmCustomer : Form
    {
        private DBContextModel dbContext;
        //private bool isAddingNew = false;

        public frmCustomer()
        {
            InitializeComponent();
            dbContext = new DBContextModel();
        }

        private void frmCustomer_Load(object sender, EventArgs e)
        {
            LoadCustomers();
        }

        private void LoadCustomers()
        {
            try
            {
                var customers = dbContext.KhangHangs.ToList();
                dgvCustomers.DataSource = customers;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu khách hàng: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtMaKH.Text) || string.IsNullOrWhiteSpace(txtTenKH.Text) ||
                    string.IsNullOrWhiteSpace(txtSDT.Text) || string.IsNullOrWhiteSpace(txtDiaChi.Text))
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var existingCustomer = dbContext.KhangHangs.FirstOrDefault(k => k.MaKH == txtMaKH.Text);
                if (existingCustomer != null)
                {
                    MessageBox.Show("Mã khách hàng đã tồn tại!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

                MessageBox.Show("Thêm khách hàng thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearForm();
                LoadCustomers();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm khách hàng: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtMaKH.Text))
                {
                    MessageBox.Show("Vui lòng chọn khách hàng để sửa!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtTenKH.Text) || string.IsNullOrWhiteSpace(txtSDT.Text) ||
                    string.IsNullOrWhiteSpace(txtDiaChi.Text))
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var customer = dbContext.KhangHangs.FirstOrDefault(k => k.MaKH == txtMaKH.Text);
                if (customer == null)
                {
                    MessageBox.Show("Khách hàng không tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                customer.TenKH = txtTenKH.Text;
                customer.SDT = txtSDT.Text;
                customer.DiaCHi = txtDiaChi.Text;

                dbContext.SaveChanges();

                MessageBox.Show("Cập nhật khách hàng thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearForm();
                LoadCustomers();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi sửa khách hàng: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtMaKH.Text))
                {
                    MessageBox.Show("Vui lòng chọn khách hàng để xóa!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var result = MessageBox.Show("Bạn có chắc chắn muốn xóa khách hàng này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result != DialogResult.Yes)
                    return;

                var customer = dbContext.KhangHangs.FirstOrDefault(k => k.MaKH == txtMaKH.Text);
                if (customer == null)
                {
                    MessageBox.Show("Khách hàng không tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                dbContext.KhangHangs.Remove(customer);
                dbContext.SaveChanges();

                MessageBox.Show("Xóa khách hàng thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearForm();
                LoadCustomers();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xóa khách hàng: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvCustomers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvCustomers.Rows[e.RowIndex];
                txtMaKH.Text = row.Cells["MaKH"].Value?.ToString() ?? "";
                txtTenKH.Text = row.Cells["TenKH"].Value?.ToString() ?? "";
                txtSDT.Text = row.Cells["SDT"].Value?.ToString() ?? "";
                txtDiaChi.Text = row.Cells["DiaCHi"].Value?.ToString() ?? "";
            }
        }
    }
}
