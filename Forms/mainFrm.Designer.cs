namespace QuanLyBanHang.Forms
{
    partial class mainFrm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainFrm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmSystem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmDangXuat = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmChangePassword = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmQuit = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmFeature = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmSanPham = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmKhachHang = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmNhanVien = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmNPP = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmHoaDonBanHang = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmHangNhap = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmReport = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmSaleByDay = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmSaleByMonth = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmBestSeller = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmUsageIns = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbSanPham = new System.Windows.Forms.ToolStripButton();
            this.tsbHoaDonBanHang = new System.Windows.Forms.ToolStripButton();
            this.tsbKhachHang = new System.Windows.Forms.ToolStripButton();
            this.tsbNPP = new System.Windows.Forms.ToolStripButton();
            this.tsbHangNhap = new System.Windows.Forms.ToolStripButton();
            this.tsbNhanVien = new System.Windows.Forms.ToolStripButton();
            this.tsbDangXuat = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tsslTenNV = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmSystem,
            this.tsmFeature,
            this.tsmReport,
            this.tsmHelp});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1592, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsmSystem
            // 
            this.tsmSystem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmDangXuat,
            this.tsmChangePassword,
            this.toolStripSeparator1,
            this.tsmQuit});
            this.tsmSystem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsmSystem.Name = "tsmSystem";
            this.tsmSystem.Size = new System.Drawing.Size(69, 20);
            this.tsmSystem.Text = "&Hệ thống";
            this.tsmSystem.Click += new System.EventHandler(this.tsmSystem_Click);
            // 
            // tsmDangXuat
            // 
            this.tsmDangXuat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsmDangXuat.Name = "tsmDangXuat";
            this.tsmDangXuat.Size = new System.Drawing.Size(180, 22);
            this.tsmDangXuat.Text = "&Đăng xuất";
            this.tsmDangXuat.Click += new System.EventHandler(this.tsmDangXuat_Click);
            // 
            // tsmChangePassword
            // 
            this.tsmChangePassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsmChangePassword.Name = "tsmChangePassword";
            this.tsmChangePassword.Size = new System.Drawing.Size(180, 22);
            this.tsmChangePassword.Text = "&Thay đổi Mật khẩu";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // tsmQuit
            // 
            this.tsmQuit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsmQuit.Name = "tsmQuit";
            this.tsmQuit.Size = new System.Drawing.Size(180, 22);
            this.tsmQuit.Text = "&Thoát chương trình";
            // 
            // tsmFeature
            // 
            this.tsmFeature.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmSanPham,
            this.tsmKhachHang,
            this.tsmNhanVien,
            this.tsmNPP,
            this.tsmHoaDonBanHang,
            this.tsmHangNhap});
            this.tsmFeature.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsmFeature.Name = "tsmFeature";
            this.tsmFeature.Size = new System.Drawing.Size(78, 20);
            this.tsmFeature.Text = "&Chức năng";
            // 
            // tsmSanPham
            // 
            this.tsmSanPham.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsmSanPham.Name = "tsmSanPham";
            this.tsmSanPham.Size = new System.Drawing.Size(203, 22);
            this.tsmSanPham.Text = "&Quản Lý Sản phẩm";
            this.tsmSanPham.Click += new System.EventHandler(this.mainFrm_Click);
            // 
            // tsmKhachHang
            // 
            this.tsmKhachHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsmKhachHang.Name = "tsmKhachHang";
            this.tsmKhachHang.Size = new System.Drawing.Size(203, 22);
            this.tsmKhachHang.Text = "&Quản Lý Khách hàng";
            this.tsmKhachHang.Click += new System.EventHandler(this.mainFrm_Click);
            // 
            // tsmNhanVien
            // 
            this.tsmNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsmNhanVien.Name = "tsmNhanVien";
            this.tsmNhanVien.Size = new System.Drawing.Size(203, 22);
            this.tsmNhanVien.Text = "&Quản Lý Nhân Viên";
            this.tsmNhanVien.Click += new System.EventHandler(this.mainFrm_Click);
            // 
            // tsmNPP
            // 
            this.tsmNPP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsmNPP.Name = "tsmNPP";
            this.tsmNPP.Size = new System.Drawing.Size(203, 22);
            this.tsmNPP.Text = "&Quản Lý Nhà phân phối";
            this.tsmNPP.Click += new System.EventHandler(this.mainFrm_Click);
            // 
            // tsmHoaDonBanHang
            // 
            this.tsmHoaDonBanHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsmHoaDonBanHang.Name = "tsmHoaDonBanHang";
            this.tsmHoaDonBanHang.Size = new System.Drawing.Size(203, 22);
            this.tsmHoaDonBanHang.Text = "&Quản Lý Hóa đơn";
            this.tsmHoaDonBanHang.Click += new System.EventHandler(this.mainFrm_Click);
            // 
            // tsmHangNhap
            // 
            this.tsmHangNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsmHangNhap.Name = "tsmHangNhap";
            this.tsmHangNhap.Size = new System.Drawing.Size(203, 22);
            this.tsmHangNhap.Text = "&Quản Lý Hàng Nhập";
            this.tsmHangNhap.Click += new System.EventHandler(this.mainFrm_Click);
            // 
            // tsmReport
            // 
            this.tsmReport.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmSaleByDay,
            this.tsmSaleByMonth,
            this.tsmBestSeller});
            this.tsmReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsmReport.Name = "tsmReport";
            this.tsmReport.Size = new System.Drawing.Size(64, 20);
            this.tsmReport.Text = "&Báo cáo";
            // 
            // tsmSaleByDay
            // 
            this.tsmSaleByDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsmSaleByDay.Name = "tsmSaleByDay";
            this.tsmSaleByDay.Size = new System.Drawing.Size(163, 22);
            this.tsmSaleByDay.Text = "Sales by &Day";
            // 
            // tsmSaleByMonth
            // 
            this.tsmSaleByMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsmSaleByMonth.Name = "tsmSaleByMonth";
            this.tsmSaleByMonth.Size = new System.Drawing.Size(163, 22);
            this.tsmSaleByMonth.Text = "Salse by &Month";
            // 
            // tsmBestSeller
            // 
            this.tsmBestSeller.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsmBestSeller.Name = "tsmBestSeller";
            this.tsmBestSeller.Size = new System.Drawing.Size(163, 22);
            this.tsmBestSeller.Text = "Top &Best Sellers";
            // 
            // tsmHelp
            // 
            this.tsmHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmUsageIns,
            this.tsmAbout});
            this.tsmHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsmHelp.Name = "tsmHelp";
            this.tsmHelp.Size = new System.Drawing.Size(64, 20);
            this.tsmHelp.Text = "&Trợ giúp";
            // 
            // tsmUsageIns
            // 
            this.tsmUsageIns.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsmUsageIns.Name = "tsmUsageIns";
            this.tsmUsageIns.Size = new System.Drawing.Size(169, 22);
            this.tsmUsageIns.Text = "Usage Instruction";
            // 
            // tsmAbout
            // 
            this.tsmAbout.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsmAbout.Name = "tsmAbout";
            this.tsmAbout.Size = new System.Drawing.Size(169, 22);
            this.tsmAbout.Text = "About";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbSanPham,
            this.tsbHoaDonBanHang,
            this.tsbKhachHang,
            this.tsbNPP,
            this.tsbHangNhap,
            this.tsbNhanVien,
            this.tsbDangXuat});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1592, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbSanPham
            // 
            this.tsbSanPham.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsbSanPham.Image = ((System.Drawing.Image)(resources.GetObject("tsbSanPham.Image")));
            this.tsbSanPham.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSanPham.Name = "tsbSanPham";
            this.tsbSanPham.Size = new System.Drawing.Size(126, 22);
            this.tsbSanPham.Text = "Quản lý sản phẩm";
            this.tsbSanPham.Click += new System.EventHandler(this.mainFrm_Click);
            // 
            // tsbHoaDonBanHang
            // 
            this.tsbHoaDonBanHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsbHoaDonBanHang.Image = ((System.Drawing.Image)(resources.GetObject("tsbHoaDonBanHang.Image")));
            this.tsbHoaDonBanHang.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbHoaDonBanHang.Name = "tsbHoaDonBanHang";
            this.tsbHoaDonBanHang.Size = new System.Drawing.Size(118, 22);
            this.tsbHoaDonBanHang.Text = "Quản lý Hóa đơn";
            this.tsbHoaDonBanHang.Click += new System.EventHandler(this.mainFrm_Click);
            // 
            // tsbKhachHang
            // 
            this.tsbKhachHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsbKhachHang.Image = ((System.Drawing.Image)(resources.GetObject("tsbKhachHang.Image")));
            this.tsbKhachHang.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbKhachHang.Name = "tsbKhachHang";
            this.tsbKhachHang.Size = new System.Drawing.Size(137, 22);
            this.tsbKhachHang.Text = "Quản lý Khách hàng";
            this.tsbKhachHang.Click += new System.EventHandler(this.mainFrm_Click);
            // 
            // tsbNPP
            // 
            this.tsbNPP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsbNPP.Image = ((System.Drawing.Image)(resources.GetObject("tsbNPP.Image")));
            this.tsbNPP.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbNPP.Name = "tsbNPP";
            this.tsbNPP.Size = new System.Drawing.Size(152, 22);
            this.tsbNPP.Text = "Quản lý Nhà phân phối";
            this.tsbNPP.Click += new System.EventHandler(this.mainFrm_Click);
            // 
            // tsbHangNhap
            // 
            this.tsbHangNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsbHangNhap.Image = ((System.Drawing.Image)(resources.GetObject("tsbHangNhap.Image")));
            this.tsbHangNhap.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbHangNhap.Name = "tsbHangNhap";
            this.tsbHangNhap.Size = new System.Drawing.Size(132, 22);
            this.tsbHangNhap.Text = "Quản lý Hàng nhập";
            this.tsbHangNhap.Click += new System.EventHandler(this.mainFrm_Click);
            // 
            // tsbNhanVien
            // 
            this.tsbNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsbNhanVien.Image = ((System.Drawing.Image)(resources.GetObject("tsbNhanVien.Image")));
            this.tsbNhanVien.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbNhanVien.Name = "tsbNhanVien";
            this.tsbNhanVien.Size = new System.Drawing.Size(126, 22);
            this.tsbNhanVien.Text = "Quản lý Nhân viên";
            this.tsbNhanVien.Click += new System.EventHandler(this.mainFrm_Click);
            // 
            // tsbDangXuat
            // 
            this.tsbDangXuat.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsbDangXuat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsbDangXuat.Image = ((System.Drawing.Image)(resources.GetObject("tsbDangXuat.Image")));
            this.tsbDangXuat.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbDangXuat.Name = "tsbDangXuat";
            this.tsbDangXuat.Size = new System.Drawing.Size(83, 22);
            this.tsbDangXuat.Text = "Đăng xuất";
            this.tsbDangXuat.Click += new System.EventHandler(this.tsbDangXuat_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslTenNV});
            this.statusStrip1.Location = new System.Drawing.Point(0, 863);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 16, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1592, 22);
            this.statusStrip1.TabIndex = 5;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tsslTenNV
            // 
            this.tsslTenNV.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsslTenNV.Name = "tsslTenNV";
            this.tsslTenNV.Size = new System.Drawing.Size(118, 17);
            this.tsslTenNV.Text = "toolStripStatusLabel1";
            // 
            // mainFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1592, 885);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "mainFrm";
            this.Text = "Hệ Thống Quản Lý Bán Hang";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.mainFrm_FormClosed);
            this.Load += new System.EventHandler(this.mainFrm_Load);
            this.Click += new System.EventHandler(this.mainFrm_Click);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmSystem;
        private System.Windows.Forms.ToolStripMenuItem tsmFeature;
        private System.Windows.Forms.ToolStripMenuItem tsmHelp;
        private System.Windows.Forms.ToolStripMenuItem tsmSanPham;
        private System.Windows.Forms.ToolStripMenuItem tsmNhanVien;
        private System.Windows.Forms.ToolStripMenuItem tsmKhachHang;
        private System.Windows.Forms.ToolStripMenuItem tsmNPP;
        private System.Windows.Forms.ToolStripMenuItem tsmHangNhap;
        private System.Windows.Forms.ToolStripMenuItem tsmHoaDonBanHang;
        private System.Windows.Forms.ToolStripMenuItem tsmReport;
        private System.Windows.Forms.ToolStripMenuItem tsmDangXuat;
        private System.Windows.Forms.ToolStripMenuItem tsmChangePassword;
        private System.Windows.Forms.ToolStripMenuItem tsmQuit;
        private System.Windows.Forms.ToolStripMenuItem tsmSaleByDay;
        private System.Windows.Forms.ToolStripMenuItem tsmSaleByMonth;
        private System.Windows.Forms.ToolStripMenuItem tsmBestSeller;
        private System.Windows.Forms.ToolStripMenuItem tsmUsageIns;
        private System.Windows.Forms.ToolStripMenuItem tsmAbout;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbSanPham;
        private System.Windows.Forms.ToolStripButton tsbNhanVien;
        private System.Windows.Forms.ToolStripButton tsbKhachHang;
        private System.Windows.Forms.ToolStripButton tsbNPP;
        private System.Windows.Forms.ToolStripButton tsbHangNhap;
        private System.Windows.Forms.ToolStripButton tsbHoaDonBanHang;
        private System.Windows.Forms.ToolStripButton tsbDangXuat;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tsslTenNV;
    }
}

