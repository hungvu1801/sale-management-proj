using QuanLyBanHang.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;


namespace QuanLyBanHang
{
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            InitializeComponent();
            //TODO: Remove this code after testing
            txtUsername.Text = "nv001";
            txtPassword.Text = "Admin@123";
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtPassword.Text) || string.IsNullOrEmpty(txtUsername.Text))
            {
                MessageBox.Show("Not input username or password.", "Notification");
                txtUsername.Focus();
                return;
            }

            NhanVien emp = GetEmployeeFromDB(txtUsername.Text, txtPassword.Text);

            if (emp != null)
            {
                mainFrm f = new mainFrm();
                f.CurrentEmployee = emp;
                f.Show();
                this.Hide();
                f.DangXuat += F_DangXuat;
                //TODO: Remove this code after testing
                txtUsername.Text = "nv001";
                txtPassword.Text = "Admin@123";
                
                //txtPassword.Text = "";
                //txtUsername.Text = "";
            }
            else
            {
                MessageBox.Show("Wrong username or Password", "Error");
                txtUsername.Focus();
            }
            
        }

        private void F_DangXuat(object sender, EventArgs e)
        {
            (sender as mainFrm).isThoat = false;
            (sender as mainFrm).Close();
            this.Show();
        }

        private NhanVien GetEmployeeFromDB(string username, string password)
        {

            using (var context = new DBContextModel())
            {
                return context.NhanViens.FirstOrDefault(nv => nv.Username == username && nv.Password == password);
            }            
        }
    }
}
