using QuanLyBanHang.Models;
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

namespace QuanLyBanHang
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

        private void tsmSystem_Click(object sender, EventArgs e)
        {

        }

        private void signInToolStripMenuItem_Click(object sender, EventArgs e)
        {

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

        private void ShowForm<T>()where T : Form, new()
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
            {"tsbEmployee", typeof(frmNhanVien)},
            {"tsbCustomer", typeof(frmKhachHang)},
            {"tsbProduct", typeof(frmSanPham)},
            {"tsbDistributor", typeof(frmDistributor)},
            {"tsbPurchase", typeof(frmPurchaseOrderDetail)},
            {"tsbInvoice", typeof(frmInvoiceDetail)},
            {"tsmEmployee", typeof(frmNhanVien)},
            {"tsmCustomer", typeof(frmKhachHang)},
            {"tsmProduct", typeof(frmSanPham)},
            {"tsmDistributor", typeof(frmDistributor)},
            {"tsmPurchase", typeof(frmPurchaseOrderDetail)},
            {"tsmInvoice", typeof(frmInvoiceDetail)},

        };

        private void tsbRefresh_Click(object sender, EventArgs e)
        {

        }

        private void tsbQuit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn muốn thoát?", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (result == DialogResult.OK)    
            {
                this.Close();
            }
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

        void PhanQuyen() 
        {
            if (CurrentEmployee == null) return;
            if (!CurrentEmployee.Role) { }
        }

        private void mainFrm_Load(object sender, EventArgs e)
        {
            PhanQuyen();
            //lblWelcome.Text = "Xin chào, " + CurrentEmployee.TenNV;
            if (CurrentEmployee.Role) { }
        }
    }
}
