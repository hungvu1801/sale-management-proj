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
    public partial class frmQuanLyHangNhap : Form
    {
        private DBContextModel dbContext;

        private List<SanPham> lstSanPham;

        private SanPhamPhieuNhapHang selectedSanPhamPhieuNhapHang;
        
        public frmQuanLyHangNhap()
        {
            InitializeComponent();
        }
        private void frmQuanLyHangNhap_Load(object sender, EventArgs e)
        {
            dbContext = new DBContextModel();
            lstSanPham = dbContext.SanPhams.ToList(); // Save query times
            initTxt();
            LoadData();
        }
        private void cbSanPham_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbSanPham.SelectedValue == null) return;
            string maSP = cbSanPham.SelectedValue.ToString();
            SanPham sp = lstSanPham.FirstOrDefault(s => s.MaSP == maSP);

            if (sp != null) 
            {
                txtGiaNhap.Text = sp.GiaNhapHienTai.ToString();
            }
        }
        private void btnHuy_Click(object sender, EventArgs e)
        {
            DialogResult = MessageBox.Show("Bạn có chắc Xóa chi tiết phiếu nhập không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (DialogResult == DialogResult.Yes)
            {
                Utils.ClearPhieuNhapHang();
                BindingData();
            }
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            if(!LstCTPhieuNhap.Instance.CtPhieuNhap.Any())
            {
                Utils.ShowMessage("Phiếu nhập trống. Vui lòng thêm sản phẩm vào phiếu nhập!", txtGiaNhap);
                return;
            }    
            string maPN = CreatePhieuNhap();
            CreateCTPhieuNhap(maPN);
            dbContext.SaveChanges();
            Utils.ClearPhieuNhapHang();
            ClearForm();
            BindingData();
            Utils.ShowMessage("Nhập hàng thành công!", txtGiaNhap);
            initTxt();
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (!ValidateThemSanPhamIsAvailable()) return;
            Insert();
            txtTongTien.Text = Utils.CalcTongSoTienPhieuNhap().ToString();
            BindingData();
        }

        private void dvgPhieuNhapHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ClickHuyBtn(e);
        }
        private void frmQuanLyHangNhap_FormClosed(object sender, FormClosedEventArgs e)
        {
            dbContext?.Dispose();
        }

        private void ClearForm()
        {
            txtGiaNhap.Text = "";
            txtTongTien.Text = "";
            sbSoLuong.Value = 0;
            cbSanPham.SelectedIndex = -1;
            cbNhaCungCap.SelectedIndex = -1;

        }
        private void LoadData()
        {
            try
            {
                
                List<NhaCungCap> lstNCC = dbContext.NhaCungCaps.ToList();
                var lstSanPhamCB = lstSanPham
                    .Select(sp => new SanPhamPhieuNhapHangCB
                    {
                        MaSP = sp.MaSP,
                        TenSP = sp.TenSP
                    })
                    .ToList();
                initCBs(lstNCC, lstSanPhamCB);

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        private void initCBs(List<NhaCungCap> lstNCC, List<SanPhamPhieuNhapHangCB> lstSanPham)
        {
            this.cbNhaCungCap.DataSource = lstNCC;
            this.cbNhaCungCap.DisplayMember = "TenNCC";
            this.cbNhaCungCap.ValueMember = "MaNCC";
            this.cbNhaCungCap.SelectedIndex = -1;
            this.cbNhaCungCap.SelectedIndex = -1;

            this.cbSanPham.DataSource = lstSanPham;
            this.cbSanPham.DisplayMember = "TenSP";
            this.cbSanPham.ValueMember = "MaSP";
            this.cbSanPham.SelectedIndex = -1;
            this.cbSanPham.SelectedIndex = -1;
        }

        private void initTxt()
        {
            txtMaPhieuNhap.Text = Utils.GenNewPNID(dbContext);
            txtNhanVien.Text = CurrentUsr.Instance.NhanVien.MaNV;
        }
        
        private bool ValidateThemSanPhamIsAvailable()
        {
            if (cbNhaCungCap.SelectedValue == null)
            {
                Utils.ShowMessage("Vui lòng chọn Nhà Cung Cấp!", cbNhaCungCap);
                return false;
            }    

            if (string.IsNullOrWhiteSpace(txtGiaNhap.Text))
            {
                Utils.ShowMessage("Vui lòng nhập giá nhập!", txtGiaNhap);
                return false;
            }
            int soLuong = (int)sbSoLuong.Value;
            if (soLuong == 0)
            {
                Utils.ShowMessage("Vui lòng nhập số lượng!", sbSoLuong);
                return false;
            }
            return true;
        }
        private void BindingData()
        {
            dvgPhieuNhapHang.Rows.Clear();

            foreach (var sp in LstCTPhieuNhap.Instance.CtPhieuNhap)
            {
                int idx = dvgPhieuNhapHang.Rows.Add();
                dvgPhieuNhapHang.Rows[idx].Cells[0].Value = sp.MaSP;
                dvgPhieuNhapHang.Rows[idx].Cells[1].Value = sp.TenSP;
                dvgPhieuNhapHang.Rows[idx].Cells[2].Value = sp.SoLuong;
                dvgPhieuNhapHang.Rows[idx].Cells[3].Value = sp.GiaNhap;
                dvgPhieuNhapHang.Rows[idx].Cells[4].Value = sp.ThanhTien;
                dvgPhieuNhapHang.Rows[idx].Cells[5].Value = sp.TenNCC;
            }

        }
        private void Insert()
        {
            string maSP = cbSanPham.SelectedValue.ToString();
            string tenSP = cbSanPham.Text;
            string maNCC = cbNhaCungCap.SelectedValue.ToString();
            string tenNCC = cbNhaCungCap.Text;
            int giaNhap = Convert.ToInt32(txtGiaNhap.Text);
            int soLuong = (int)sbSoLuong.Value;

            if (!LstCTPhieuNhap.Instance.CtPhieuNhap.Any())
            {
                SanPhamPhieuNhapHang newSanPham = new SanPhamPhieuNhapHang
                {
                    MaSP = maSP,
                    TenSP = tenSP,
                    SoLuong = soLuong,
                    GiaNhap = giaNhap,
                    MaNCC = maNCC,
                    TenNCC = tenNCC,
                };
                LstCTPhieuNhap.Instance.CtPhieuNhap.Add(newSanPham);
                return;
            }    

            var item = LstCTPhieuNhap.Instance.CtPhieuNhap
            .FirstOrDefault(sp => sp.MaSP == maSP && sp.MaNCC == maNCC);
            if (item != null) 
            {
                item.SoLuong += soLuong;
                return;
            }
            item = LstCTPhieuNhap.Instance.CtPhieuNhap
            .FirstOrDefault(sp => sp.MaNCC == maNCC);
            if (item != null)
            {
                SanPhamPhieuNhapHang newSanPham = new SanPhamPhieuNhapHang
                {
                    MaSP = maSP,
                    TenSP = tenSP,
                    SoLuong = soLuong,
                    GiaNhap = giaNhap,
                    MaNCC = maNCC,
                    TenNCC = tenNCC,
                };
                LstCTPhieuNhap.Instance.CtPhieuNhap.Add(newSanPham);
                return;
            }
            Utils.ShowMessage("Chỉ được chọn MỘT Nhà cung cấp trong một Phiếu Nhập", txtGiaNhap);
        }

        private void ClickHuyBtn(DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dvgPhieuNhapHang.Columns["btnColHuy"].Index)
            {
                string maPN = dvgPhieuNhapHang.Rows[e.RowIndex].Cells[0].Value.ToString();
                selectedSanPhamPhieuNhapHang = LstCTPhieuNhap.Instance.CtPhieuNhap
                    .FirstOrDefault(sp => sp.MaSP == maPN);
                LstCTPhieuNhap.Instance.CtPhieuNhap.Remove(selectedSanPhamPhieuNhapHang);
                BindingData();
            }
            
        }
        private string CreatePhieuNhap()
        {
            string newMaPN = Utils.GenNewPNID(dbContext);
            string maNV = txtNhanVien.Text;
            int newTongST = Convert.ToInt32(txtTongTien.Text);
            string maNCC = cbNhaCungCap.SelectedValue.ToString();
            PhieuNhapHang newPhieuNhapHang = new PhieuNhapHang
            {
                MaPhieuNhap = newMaPN,
                MaNV = maNV,
                MaNCC = maNCC,
                TongST = newTongST
            };
            dbContext.PhieuNhapHangs.Add(newPhieuNhapHang);
            return newMaPN;
        }

        private void CreateCTPhieuNhap(string maPN)
        {
            foreach(SanPhamPhieuNhapHang sp in LstCTPhieuNhap.Instance.CtPhieuNhap)
            {
                ChiTietPhieuNhapHang ct = new ChiTietPhieuNhapHang
                {
                    MaPhieuNhap = maPN,
                    MaSP = sp.MaSP,
                    SoLuong = sp.SoLuong,
                    GiaNhap = sp.GiaNhap,
                };
                dbContext.ChiTietPhieuNhapHangs.Add(ct);
            }    
        }
        
    }
}
