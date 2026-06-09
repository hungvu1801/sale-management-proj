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
    public partial class frmHangSX : Form
    {
        public frmHangSX()
        {
            InitializeComponent();
        }

        private void txtMaHangSX_TextChanged(object sender, EventArgs e)
        {

        }

        private void PhanQuyen()
        {
            bool isAdmin = CurrentUsr.Instance.NhanVien.Role;
            //btnXoaNPP.Enabled = isAdmin;
        }
    }
}
