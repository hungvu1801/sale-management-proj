using QuanLyBanHang.Models;
using QuanLyBanHang.Forms;
using QuanLyBanHang.Singletons;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBanHang.Forms
{
    public partial class mainFrm : Form
    {
        public NhanVien CurrentEmployee { get; set; }
        public bool isThoat = true;
        public event EventHandler DangXuat;
        public mainFrm()
        {
            InitializeComponent();
        }

        private void mainFrm_Load(object sender, EventArgs e)
        {
            string role = "Admin";
            if (!CurrentUsr.Instance.NhanVien.Role)
                role = "User";
            tsslTenNV.Text = "Nhân viên: " + CurrentUsr.Instance.NhanVien.TenNV + " - " + role;
            PhanQuyen();
        }

        private void tsmDangXuat_Click(object sender, EventArgs e)
        {
            DangXuat(this, new EventArgs());
            this.Close();
        }

        private void mainFrm_Click(object sender, EventArgs e)
        {
            string controlName = string.Empty;
            // if user clicks toolStripItem
            if (sender is ToolStripMenuItem toolStripMenuItem) {
                controlName = toolStripMenuItem.Name;
            }
            
            // if user clicks MenuItem
            if (sender is ToolStripButton toolStripButton)
            {
                controlName = toolStripButton.Name;
            }

            if (formTypes.ContainsKey(controlName))
            {
                Type formType = formTypes[controlName];
                MethodInfo showMethod = this.GetType().GetMethod("ShowForm", BindingFlags.NonPublic | BindingFlags.Instance);

                if (showMethod != null) 
                {
                    showMethod = showMethod.MakeGenericMethod(formType);
                    showMethod.Invoke(this, null);
                }
                else
                {
                    MessageBox.Show("No Form Found", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void tsbRefresh_Click(object sender, EventArgs e)
        {

        }
        private void Exit()
        {
            DialogResult result = MessageBox.Show("Bạn muốn thoát?", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (result == DialogResult.OK)
            {
                this.Close();
            }
        }
        private void tsbQuit_Click(object sender, EventArgs e)
        {
            Exit();
        }
        private void tsmQuit_Click(object sender, EventArgs e)
        {
            Exit();
        }
        private void tsbDangXuat_Click(object sender, EventArgs e)
        {
            DangXuat(this, new EventArgs());
            this.Close();
        }

        private void mainFrm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (isThoat)
                Application.Exit();
        }

        private void tsmUsageIns_Click(object sender, EventArgs e)
        {
            frmTroGiup frm = new frmTroGiup();
            frm.ShowDialog();
        }

        

        private void ShowForm<T>() where T : Form, new()
        {
            closeForm();
            foreach (Form f in this.MdiChildren)
            {
                f.Activate();
                f.BringToFront();
                f.WindowState = FormWindowState.Maximized;
                f.Show();
                return;
            }
            T form = new T();
            form.MdiParent = this;
            form.BringToFront();
            form.WindowState = FormWindowState.Maximized;
            form.Show();
        }


        // function close form
        private void closeForm()
        {
            foreach (Form f in this.MdiChildren) { f.Close(); }
        }

        private Dictionary<string, Type> formTypes = new Dictionary<string, Type>()
        {
            {"tsbNhanVien", typeof(frmNhanVien)},
            {"tsbKhachHang", typeof(frmKhachHang)},
            {"tsbSanPham", typeof(frmSanPham)},
            {"tsbNPP", typeof(frmNhaCungCap)},
            {"tsbHangNhap", typeof(frmQuanLyHangNhap)},
            {"tsbHoaDonBanHang", typeof(frmHoaDonBanHang)},
            {"tsmNhanVien", typeof(frmNhanVien)},
            {"tsmKhachHang", typeof(frmKhachHang)},
            {"tsmSanPham", typeof(frmSanPham)},
            {"tsmNPP", typeof(frmNhaCungCap)},
            {"tsmHangNhap", typeof(frmQuanLyHangNhap)},
            {"tsmDoiMatKhau", typeof(frmDoiMatKhau)},
            {"tsmHoaDonBanHang", typeof(frmHoaDonBanHang)},
            {"tsmDoanhSo", typeof(frmBaoCao)},
        };


        private void PhanQuyen() 
        {
            if (!CurrentUsr.Instance.NhanVien.Role)
            {
                tsbNhanVien.Visible = false;
                tsmNhanVien.Visible = false;
            }
        }

        private void tsmAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
    "THÔNG TIN NHÓM THỰC HIỆN\n\n" +
    string.Format("{0,-30} {1,-12} {2}\n", "Sinh viên thực hiện", "Lớp", "MSSV") +
    "─────────────────────────────────────────────\n" +
    string.Format("{0,-30} {1,-12} {2}\n", "1. Ngô Quốc Đạt", "24TXTHE1", "2410060195") +
    string.Format("{0,-30} {1,-12} {2}\n", "2. Vũ Tiến Hùng", "24TXTHG1", "2410060289") +
    string.Format("{0,-30} {1,-12} {2}\n", "3. Trần Trí Nam", "24TXTHG1", "2410060292") +
    string.Format("{0,-30} {1,-12} {2}\n", "4. Nguyễn Huỳnh Xuân Phong", "24TXTHG1", "2410060262"),
    "Về Chúng Tôi",
    MessageBoxButtons.OK,
    MessageBoxIcon.Information
        );
        }

        
    }
}
