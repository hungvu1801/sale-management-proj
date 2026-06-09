using QuanLyBanHang.Models;
using QuanLyBanHang.Singletons;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBanHang.Forms
{
    public partial class frmSanPham : Form
    {
        private DBContextModel dbContext;

        private SanPham selectedSanPham;

        private SanPhamGioHang selectedSanPhamGioHang;



        public frmSanPham()
        {
            InitializeComponent();
            
        }

        private void frmSanPham_Load(object sender, EventArgs e)
        {
            // Init the resources in the load form event
            dbContext = new DBContextModel();
            LoadDataSP();
            updateSLGioHang();
        }

        private void frmSanPham_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Clean up the connections
            dbContext?.Dispose();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            ClearFrm();
        }
        private void btnTim_Click(object sender, EventArgs e)
        {
            Search();
        }

        private void btnThemGioHang_Click(object sender, EventArgs e)
        {
            string maSP = selectedSanPham.MaSP;
            if (maSP != null)
            {
                var item = LstGioHang.Instance.giohang.FirstOrDefault(sp => sp.MaSP == maSP);
                if (item != null)
                {
                    item.SoLuong++;
                }
                else
                {
                    LstGioHang.Instance.giohang.Add(new SanPhamGioHang
                    {
                        MaSP = selectedSanPham.MaSP,
                        TenSP = selectedSanPham.TenSP,
                        DonGia = selectedSanPham.GiaBanHienTai,
                        SoLuong = 1
                    });
                }
            }
            BindingDataGioHang();
            updateSLGioHang();
        }

        private void btnXoaMotSP_Click(object sender, EventArgs e)
        {
            LstGioHang.Instance.giohang.Remove(selectedSanPhamGioHang);
            BindingDataGioHang();
            updateSLGioHang();
        }

        private void btnXoaGioHang_Click(object sender, EventArgs e)
        {
            DialogResult = MessageBox.Show("Bạn có chắc Xóa giỏ hàng không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DialogResult == DialogResult.Yes)
            {
                Utils.ClearGioHang();
                BindingDataGioHang();
            }
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            var mainForm = this.MdiParent as mainFrm;
            if (mainForm != null)
            {
                MethodInfo showMethod = mainForm.GetType()
                .GetMethod("ShowForm", BindingFlags.NonPublic | BindingFlags.Instance);

                if (showMethod != null)
                {
                    showMethod = showMethod.MakeGenericMethod(typeof(frmHoaDonBanHang));
                    showMethod.Invoke(mainForm, null); // mainForm, không phải this
                }
            }
        }

        private void dgvSanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex != -1)
            {
                DataGridViewRow row = dgvSanPham.Rows[e.RowIndex];
                string maSP = row.Cells[0].Value.ToString();

                selectedSanPham = dbContext.SanPhams.FirstOrDefault(s => s.MaSP == maSP);

            }
        }

        private void dvgGioHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                string selectedmaSP = dvgGioHang.Rows[e.RowIndex].Cells[0].Value.ToString();
                selectedSanPhamGioHang = LstGioHang.Instance.giohang
                    .FirstOrDefault(sp => sp.MaSP == selectedmaSP);

                if (selectedSanPhamGioHang == null) return;
                ChangeQuantityBtn(e);

            }

        }

        private void ChangeQuantityBtn(DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dvgGioHang.Columns["btnTang"].Index)
            {
                int soLuongHienTai = selectedSanPhamGioHang.SoLuong;
                soLuongHienTai++;
                selectedSanPhamGioHang.SoLuong = soLuongHienTai;
                BindingDataGioHang();
            }
            if (e.ColumnIndex == dvgGioHang.Columns["btnGiam"].Index)
            {
                int soLuongHienTai = selectedSanPhamGioHang.SoLuong;

                if (soLuongHienTai > 1)
                {
                    soLuongHienTai--;
                }

                selectedSanPhamGioHang.SoLuong = soLuongHienTai;
                BindingDataGioHang();
            }
        }

        private void updateSLGioHang()
        {
            int soLuongGioHang = LstGioHang.Instance.giohang.Count();
            txtSLGioHang.Text = soLuongGioHang.ToString();
        }
        

        private void LoadDataSP()
        {
            try
            {
                List<SanPhamPublic> lstSanPham = dbContext.SanPhams
                    .Include("HangSX")
                    .Include("PhanLoaiSP")
                    .Select(sp => new SanPhamPublic
                    {
                        MaSP = sp.MaSP,
                        TenSP = sp.TenSP,
                        TenPL = sp.PhanLoaiSP.TenPL,
                        TenHangSX = sp.HangSX.TenHangSX,
                        SoLuongTon = sp.SoLuongTon,
                        GiaBanHienTai = sp.GiaBanHienTai
                    })
                    .ToList();


                List<HangSX> lstHangSX = dbContext.HangSXes.ToList();
                List<PhanLoaiSP> lstPhanLoai = dbContext.PhanLoaiSPs.ToList();
                BindingDataSP(lstSanPham);
                initCB(lstHangSX, lstPhanLoai);
                BindingDataGioHang();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }


        private void initCB(List<HangSX> lstHangSX, List<PhanLoaiSP> lstPhanLoai)
        {
            this.cbHangSX.DataSource = lstHangSX;
            this.cbHangSX.DisplayMember = "TenHangSX";
            this.cbHangSX.ValueMember = "MaHangSX";
            this.cbHangSX.SelectedIndex = -1;
            this.cbHangSX.SelectedIndex = -1;

            this.cbPhanLoai.DataSource = lstPhanLoai;
            this.cbPhanLoai.DisplayMember = "TenPL";
            this.cbPhanLoai.ValueMember = "MaPL";
            this.cbPhanLoai.SelectedIndex = -1;
            this.cbPhanLoai.SelectedIndex = -1;
        }
        private void ClearFrm()
        {
            this.txtMaSP.Text = "";
            this.txtTenSP.Text = "";
            this.txtGiaSP.Text = "";
            this.cbHangSX.SelectedIndex = -1;
            this.cbPhanLoai.SelectedIndex = -1;
        }

        private void BindingDataSP(List<SanPhamPublic> lstSanPham)
        {
            dgvSanPham.Rows.Clear();

            foreach (var sp in lstSanPham)
            {
                int idx = dgvSanPham.Rows.Add();
                dgvSanPham.Rows[idx].Cells[0].Value = sp.MaSP;
                dgvSanPham.Rows[idx].Cells[1].Value = sp.TenSP;
                dgvSanPham.Rows[idx].Cells[2].Value = sp.TenPL;
                dgvSanPham.Rows[idx].Cells[3].Value = sp.TenHangSX;
                dgvSanPham.Rows[idx].Cells[4].Value = sp.SoLuongTon;
                dgvSanPham.Rows[idx].Cells[5].Value = sp.GiaBanHienTai;
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
        private void Search()
        {
            try
            {
                string tenSP = txtTenSP.Text.Trim();
                string maHangSX = cbHangSX.SelectedValue?.ToString();
                string maPL = cbPhanLoai.SelectedValue?.ToString();

                // start querying

                var query = dbContext.SanPhams
                    .Include("HangSX")
                    .Include("PhanLoaiSP")
                    .AsQueryable();

                if (!string.IsNullOrEmpty(tenSP))
                    query = query.Where(sp => sp.TenSP.Contains(tenSP));

                if (!string.IsNullOrEmpty(maHangSX))
                    query = query.Where(sp => sp.MaHangSX == maHangSX);

                if (maPL != null)
                    query = query.Where(sp => sp.MaPL == maPL);

                List<SanPhamPublic> result = query.Select(sp => new SanPhamPublic
                {
                    MaSP = sp.MaSP,
                    TenSP = sp.TenSP,
                    TenPL = sp.PhanLoaiSP.TenPL,
                    TenHangSX = sp.HangSX.TenHangSX,
                    SoLuongTon = sp.SoLuongTon,
                    GiaBanHienTai = sp.GiaBanHienTai
                }).ToList();

                BindingDataSP(result);
            }
            catch (Exception ex)
            {
                Utils.ShowMessage("Lỗi tìm kiếm thông tin: " + ex.Message, txtMaSP);
            }

        }


    }
}
