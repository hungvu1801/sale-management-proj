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
        string connectionString = ConfigurationManager.ConnectionStrings["MyDB"].ConnectionString;
        string userName = "admin";
        string password = "admin";
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

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

            Employee emp = GetEmployeeFromDB(txtUsername.Text, txtPassword.Text);

            if (emp != null)
            {
                mainFrm f = new mainFrm();
                f.CurrentEmployee = emp;
                f.Show();
                this.Hide();
                f.DangXuat += F_DangXuat;
                txtPassword.Text = "";
                txtUsername.Text = "";
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
        bool checkLogin(string userName, string password)
        {
            if (userName == this.userName && password == this.password) { return true; }
            return false;
        }

        private Employee GetEmployeeFromDB(string username, string password)
        {
            Employee employee = null;

            string query = @"select MaNV, TenNV, QuanLy, Username, Role 
                             from NhanVien 
                             where Username = @Username AND Password = @Password";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Username", username);
                        cmd.Parameters.AddWithValue("@Password", password);

                        using (SqlDataReader reader = cmd.ExecuteReader()) 
                        {
                            if (reader.Read()) 
                            { 
                                employee = new Employee
                                {
                                    MaNV = reader["MaNV"].ToString(),
                                    TenNV = reader["TenNV"].ToString(),
                                    QuanLy = reader["QuanLy"].ToString(),
                                    Username = reader["Username"].ToString(),
                                    Role = Convert.ToInt32(reader["Role"]) == 1
                                };
                            }
                        }
                    }
                }
            }

            catch (Exception e) { 
                MessageBox.Show("Error " + e.Message);
            }
            return employee;
            
        }
    }
}
