using QuanLyBanHang.Models;
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
    public partial class frmBaoCao : Form
    {
        private DBContextModel dbContext;
        public frmBaoCao()
        {
            InitializeComponent();
        }

        private void frmBaoCao_Load(object sender, EventArgs e)
        {
            dbContext = new DBContextModel();
            rbNgay.Checked = true;
            dtpTu.Value = DateTime.Now.AddMonths(-1);
            dtpDen.Value = DateTime.Now;
        }

        private void frmBaoCao_FormClosed(object sender, FormClosedEventArgs e)
        {
            dbContext?.Dispose();
        }

        private void btnXemBaoCao_Click(object sender, EventArgs e)
        {
            DateTime tuNgay = dtpTu.Value.Date;
            DateTime denNgay = dtpDen.Value.Date.AddDays(1);
            var query = dbContext.HoaDonBanHangs
            .Where(hd => hd.NgayLap >= tuNgay && hd.NgayLap < denNgay);

            if (rbNgay.Checked)
                BaoCaoTheoNgay(query);
            else if (rbThang.Checked)
                BaoCaoTheoThang(query);
            else
                BaoCaoTheoNam(query);
        }

        private void BaoCaoTheoNgay(IQueryable<HoaDonBanHang> query)
        {
            var result = query
                .GroupBy(hd => System.Data.Entity.DbFunctions.TruncateTime(hd.NgayLap))
                .Select(g => new
                {
                    ThoiGian = g.Key,
                    SoHD = g.Count(),
                    DoanhThu = g.Sum(hd => hd.TongST)
                })
                .OrderBy(x => x.ThoiGian)
                .ToList();

            dgvBaoCao.Rows.Clear();
            foreach (var item in result)
            {
                int idx = dgvBaoCao.Rows.Add();
                dgvBaoCao.Rows[idx].Cells[0].Value = item.ThoiGian?.ToString("dd/MM/yyyy");
                dgvBaoCao.Rows[idx].Cells[1].Value = item.SoHD;
                dgvBaoCao.Rows[idx].Cells[2].Value = item.DoanhThu.ToString("N0") + " VNĐ";
            }

            txtTongDT.Text =  result.Sum(x => x.DoanhThu).ToString("N0") ;
        }

        private void BaoCaoTheoThang(IQueryable<HoaDonBanHang> query)
        {
            var result = query
                .GroupBy(hd => new { hd.NgayLap.Month, hd.NgayLap.Year })
                .Select(g => new
                {
                    Thang = g.Key.Month,
                    Nam = g.Key.Year,
                    SoHD = g.Count(),
                    DoanhThu = g.Sum(hd => hd.TongST)
                })
                .OrderBy(x => x.Nam).ThenBy(x => x.Thang)
                .ToList();

            dgvBaoCao.Rows.Clear();
            foreach (var item in result)
            {
                int idx = dgvBaoCao.Rows.Add();
                dgvBaoCao.Rows[idx].Cells[0].Value = $"Tháng {item.Thang}/{item.Nam}";
                dgvBaoCao.Rows[idx].Cells[1].Value = item.SoHD;
                dgvBaoCao.Rows[idx].Cells[2].Value = item.DoanhThu.ToString("N0") + " VNĐ";
            }

            txtTongDT.Text = result.Sum(x => x.DoanhThu).ToString("N0") ;
        }

        private void BaoCaoTheoNam(IQueryable<HoaDonBanHang> query)
        {
            var result = query
                .GroupBy(hd => hd.NgayLap.Year)
                .Select(g => new
                {
                    Nam = g.Key,
                    SoHD = g.Count(),
                    DoanhThu = g.Sum(hd => hd.TongST)
                })
                .OrderBy(x => x.Nam)
                .ToList();

            dgvBaoCao.Rows.Clear();
            foreach (var item in result)
            {
                int idx = dgvBaoCao.Rows.Add();
                dgvBaoCao.Rows[idx].Cells[0].Value = $"Năm {item.Nam}";
                dgvBaoCao.Rows[idx].Cells[1].Value = item.SoHD;
                dgvBaoCao.Rows[idx].Cells[2].Value = item.DoanhThu.ToString("N0") + " VNĐ";
            }

            txtTongDT.Text = result.Sum(x => x.DoanhThu).ToString("N0");
        }
    }
}
