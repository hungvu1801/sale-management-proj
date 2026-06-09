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
    public partial class frmTroGiup : Form
    {
        public frmTroGiup()
        {
            InitializeComponent();
            
        }

        private void frmTroGiup_Load(object sender, EventArgs e)
        {
            richTextBox1.Text =
            "HƯỚNG DẪN SỬ DỤNG\n\n" +

            "1. ĐĂNG NHẬP\n" +
            "   - Nhập tên đăng nhập và mật khẩu\n" +
            "   - Nhấn Đăng Nhập để vào hệ thống\n\n" +

            "2. QUẢN LÝ SẢN PHẨM\n" +
            "   - Thêm/Sửa/Xóa sản phẩm\n" +
            "   - Tìm kiếm theo tên, hãng, phân loại\n\n" +

            "3. BÁN HÀNG\n" +
            "   - Chọn sản phẩm → Thêm vào giỏ\n" +
            "   - Nhập SDT khách hàng → Enter để tìm\n" +
            "   - Nhấn Thanh Toán để hoàn tất\n\n" +

            "4. NHẬP HÀNG\n" +
            "   - Chọn Nhà Cung Cấp và Sản Phẩm\n" +
            "   - Nhập số lượng và giá nhập\n" +
            "   - Nhấn Thêm rồi Nhập Hàng\n\n" +

            "5. QUẢN LÝ KHÁCH HÀNG\n" +
            "   - Thêm/Sửa/Xóa khách hàng\n" +
            "   - Tìm kiếm theo tên, số điện thoại\n\n" +

            "6. PHÂN QUYỀN\n" +
            "   - Admin: toàn quyền\n" +
            "   - User: không thể xóa dữ liệu";
        }
    }
}
