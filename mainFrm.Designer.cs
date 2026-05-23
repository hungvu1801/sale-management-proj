namespace QuanLyBanHang
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
            this.tsmSignIn = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmSignOut = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmChangePassword = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmQuit = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmFeature = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmProduct = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmEmployee = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmCustomer = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmDistributor = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmPurchase = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmInvoice = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmReport = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmSaleByDay = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmSaleByMonth = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmBestSeller = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmExport = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmUsageIns = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbProduct = new System.Windows.Forms.ToolStripButton();
            this.tsbEmployee = new System.Windows.Forms.ToolStripButton();
            this.tsbCustomer = new System.Windows.Forms.ToolStripButton();
            this.tsbDistributor = new System.Windows.Forms.ToolStripButton();
            this.tsbPurchase = new System.Windows.Forms.ToolStripButton();
            this.tsbInvoice = new System.Windows.Forms.ToolStripButton();
            this.tsbDangXuat = new System.Windows.Forms.ToolStripButton();
            this.toolStrip3 = new System.Windows.Forms.ToolStrip();
            this.tsbSearch = new System.Windows.Forms.ToolStripButton();
            this.tsbPrint = new System.Windows.Forms.ToolStripButton();
            this.tsbExport = new System.Windows.Forms.ToolStripButton();
            this.tsbQuit = new System.Windows.Forms.ToolStripButton();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.toolStrip3.SuspendLayout();
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
            this.menuStrip1.Size = new System.Drawing.Size(1260, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsmSystem
            // 
            this.tsmSystem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmSignIn,
            this.tsmSignOut,
            this.tsmChangePassword,
            this.tsmQuit});
            this.tsmSystem.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsmSystem.Name = "tsmSystem";
            this.tsmSystem.Size = new System.Drawing.Size(69, 20);
            this.tsmSystem.Text = "&Hệ thống";
            this.tsmSystem.Click += new System.EventHandler(this.tsmSystem_Click);
            // 
            // tsmSignIn
            // 
            this.tsmSignIn.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsmSignIn.Name = "tsmSignIn";
            this.tsmSignIn.Size = new System.Drawing.Size(180, 22);
            this.tsmSignIn.Text = "&Đăng nhập";
            this.tsmSignIn.Click += new System.EventHandler(this.signInToolStripMenuItem_Click);
            // 
            // tsmSignOut
            // 
            this.tsmSignOut.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsmSignOut.Name = "tsmSignOut";
            this.tsmSignOut.Size = new System.Drawing.Size(180, 22);
            this.tsmSignOut.Text = "&Đăng xuất";
            // 
            // tsmChangePassword
            // 
            this.tsmChangePassword.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsmChangePassword.Name = "tsmChangePassword";
            this.tsmChangePassword.Size = new System.Drawing.Size(180, 22);
            this.tsmChangePassword.Text = "&Thay đổi Mật khẩu";
            // 
            // tsmQuit
            // 
            this.tsmQuit.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsmQuit.Name = "tsmQuit";
            this.tsmQuit.Size = new System.Drawing.Size(180, 22);
            this.tsmQuit.Text = "&Thoát chương trình";
            // 
            // tsmFeature
            // 
            this.tsmFeature.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmProduct,
            this.tsmCustomer,
            this.tsmEmployee,
            this.tsmDistributor,
            this.tsmPurchase,
            this.tsmInvoice});
            this.tsmFeature.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsmFeature.Name = "tsmFeature";
            this.tsmFeature.Size = new System.Drawing.Size(81, 20);
            this.tsmFeature.Text = "&Chức năng";
            // 
            // tsmProduct
            // 
            this.tsmProduct.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsmProduct.Name = "tsmProduct";
            this.tsmProduct.Size = new System.Drawing.Size(180, 22);
            this.tsmProduct.Text = "&Sản phẩm";
            this.tsmProduct.Click += new System.EventHandler(this.mainFrm_Click);
            // 
            // tsmEmployee
            // 
            this.tsmEmployee.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsmEmployee.Name = "tsmEmployee";
            this.tsmEmployee.Size = new System.Drawing.Size(180, 22);
            this.tsmEmployee.Text = "&Nhân Viên";
            this.tsmEmployee.Click += new System.EventHandler(this.mainFrm_Click);
            // 
            // tsmCustomer
            // 
            this.tsmCustomer.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsmCustomer.Name = "tsmCustomer";
            this.tsmCustomer.Size = new System.Drawing.Size(180, 22);
            this.tsmCustomer.Text = "&Khách hàng";
            this.tsmCustomer.Click += new System.EventHandler(this.mainFrm_Click);
            // 
            // tsmDistributor
            // 
            this.tsmDistributor.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsmDistributor.Name = "tsmDistributor";
            this.tsmDistributor.Size = new System.Drawing.Size(180, 22);
            this.tsmDistributor.Text = "&Nhà phân phối";
            this.tsmDistributor.Click += new System.EventHandler(this.mainFrm_Click);
            // 
            // tsmPurchase
            // 
            this.tsmPurchase.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsmPurchase.Name = "tsmPurchase";
            this.tsmPurchase.Size = new System.Drawing.Size(180, 22);
            this.tsmPurchase.Text = "&Hóa đơn nhập";
            this.tsmPurchase.Click += new System.EventHandler(this.mainFrm_Click);
            // 
            // tsmInvoice
            // 
            this.tsmInvoice.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsmInvoice.Name = "tsmInvoice";
            this.tsmInvoice.Size = new System.Drawing.Size(180, 22);
            this.tsmInvoice.Text = "&Hóa đơn xuất";
            this.tsmInvoice.Click += new System.EventHandler(this.mainFrm_Click);
            // 
            // tsmReport
            // 
            this.tsmReport.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmSaleByDay,
            this.tsmSaleByMonth,
            this.tsmBestSeller,
            this.tsmExport});
            this.tsmReport.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsmReport.Name = "tsmReport";
            this.tsmReport.Size = new System.Drawing.Size(65, 20);
            this.tsmReport.Text = "&Báo cáo";
            // 
            // tsmSaleByDay
            // 
            this.tsmSaleByDay.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsmSaleByDay.Name = "tsmSaleByDay";
            this.tsmSaleByDay.Size = new System.Drawing.Size(180, 22);
            this.tsmSaleByDay.Text = "Sales by &Day";
            // 
            // tsmSaleByMonth
            // 
            this.tsmSaleByMonth.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsmSaleByMonth.Name = "tsmSaleByMonth";
            this.tsmSaleByMonth.Size = new System.Drawing.Size(180, 22);
            this.tsmSaleByMonth.Text = "Salse by &Month";
            // 
            // tsmBestSeller
            // 
            this.tsmBestSeller.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsmBestSeller.Name = "tsmBestSeller";
            this.tsmBestSeller.Size = new System.Drawing.Size(180, 22);
            this.tsmBestSeller.Text = "Top &Best Sellers";
            // 
            // tsmExport
            // 
            this.tsmExport.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsmExport.Name = "tsmExport";
            this.tsmExport.Size = new System.Drawing.Size(180, 22);
            this.tsmExport.Text = "&Export to Excel";
            // 
            // tsmHelp
            // 
            this.tsmHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmUsageIns,
            this.tsmAbout});
            this.tsmHelp.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsmHelp.Name = "tsmHelp";
            this.tsmHelp.Size = new System.Drawing.Size(61, 20);
            this.tsmHelp.Text = "&Trợ giúp";
            // 
            // tsmUsageIns
            // 
            this.tsmUsageIns.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsmUsageIns.Name = "tsmUsageIns";
            this.tsmUsageIns.Size = new System.Drawing.Size(180, 22);
            this.tsmUsageIns.Text = "Usage Instruction";
            // 
            // tsmAbout
            // 
            this.tsmAbout.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsmAbout.Name = "tsmAbout";
            this.tsmAbout.Size = new System.Drawing.Size(180, 22);
            this.tsmAbout.Text = "About";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbProduct,
            this.tsbInvoice,
            this.tsbCustomer,
            this.tsbDistributor,
            this.tsbPurchase,
            this.tsbEmployee,
            this.tsbDangXuat});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1260, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbProduct
            // 
            this.tsbProduct.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsbProduct.Image = ((System.Drawing.Image)(resources.GetObject("tsbProduct.Image")));
            this.tsbProduct.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbProduct.Name = "tsbProduct";
            this.tsbProduct.Size = new System.Drawing.Size(125, 22);
            this.tsbProduct.Text = "Quản lý sản phẩm";
            this.tsbProduct.Click += new System.EventHandler(this.mainFrm_Click);
            // 
            // tsbEmployee
            // 
            this.tsbEmployee.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsbEmployee.Image = ((System.Drawing.Image)(resources.GetObject("tsbEmployee.Image")));
            this.tsbEmployee.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbEmployee.Name = "tsbEmployee";
            this.tsbEmployee.Size = new System.Drawing.Size(80, 22);
            this.tsbEmployee.Text = "Employee";
            this.tsbEmployee.Click += new System.EventHandler(this.mainFrm_Click);
            // 
            // tsbCustomer
            // 
            this.tsbCustomer.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsbCustomer.Image = ((System.Drawing.Image)(resources.GetObject("tsbCustomer.Image")));
            this.tsbCustomer.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbCustomer.Name = "tsbCustomer";
            this.tsbCustomer.Size = new System.Drawing.Size(140, 22);
            this.tsbCustomer.Text = "Quản lý Khách hàng";
            this.tsbCustomer.Click += new System.EventHandler(this.mainFrm_Click);
            // 
            // tsbDistributor
            // 
            this.tsbDistributor.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsbDistributor.Image = ((System.Drawing.Image)(resources.GetObject("tsbDistributor.Image")));
            this.tsbDistributor.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbDistributor.Name = "tsbDistributor";
            this.tsbDistributor.Size = new System.Drawing.Size(155, 22);
            this.tsbDistributor.Text = "Quản lý Nhà phân phối";
            this.tsbDistributor.Click += new System.EventHandler(this.mainFrm_Click);
            // 
            // tsbPurchase
            // 
            this.tsbPurchase.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsbPurchase.Image = ((System.Drawing.Image)(resources.GetObject("tsbPurchase.Image")));
            this.tsbPurchase.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbPurchase.Name = "tsbPurchase";
            this.tsbPurchase.Size = new System.Drawing.Size(77, 22);
            this.tsbPurchase.Text = "Purchase";
            this.tsbPurchase.Click += new System.EventHandler(this.mainFrm_Click);
            // 
            // tsbInvoice
            // 
            this.tsbInvoice.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsbInvoice.Image = ((System.Drawing.Image)(resources.GetObject("tsbInvoice.Image")));
            this.tsbInvoice.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbInvoice.Name = "tsbInvoice";
            this.tsbInvoice.Size = new System.Drawing.Size(120, 22);
            this.tsbInvoice.Text = "Quản lý Hóa đơn";
            this.tsbInvoice.Click += new System.EventHandler(this.mainFrm_Click);
            // 
            // tsbDangXuat
            // 
            this.tsbDangXuat.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsbDangXuat.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsbDangXuat.Image = ((System.Drawing.Image)(resources.GetObject("tsbDangXuat.Image")));
            this.tsbDangXuat.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbDangXuat.Name = "tsbDangXuat";
            this.tsbDangXuat.Size = new System.Drawing.Size(85, 22);
            this.tsbDangXuat.Text = "Đăng xuất";
            this.tsbDangXuat.Click += new System.EventHandler(this.tsbDangXuat_Click);
            // 
            // toolStrip3
            // 
            this.toolStrip3.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbSearch,
            this.tsbPrint,
            this.tsbExport,
            this.tsbQuit});
            this.toolStrip3.Location = new System.Drawing.Point(0, 49);
            this.toolStrip3.Name = "toolStrip3";
            this.toolStrip3.Size = new System.Drawing.Size(1260, 25);
            this.toolStrip3.TabIndex = 3;
            this.toolStrip3.Text = "toolStrip3";
            // 
            // tsbSearch
            // 
            this.tsbSearch.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsbSearch.Image = ((System.Drawing.Image)(resources.GetObject("tsbSearch.Image")));
            this.tsbSearch.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSearch.Name = "tsbSearch";
            this.tsbSearch.Size = new System.Drawing.Size(65, 22);
            this.tsbSearch.Text = "Search";
            this.tsbSearch.Click += new System.EventHandler(this.mainFrm_Click);
            // 
            // tsbPrint
            // 
            this.tsbPrint.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsbPrint.Image = ((System.Drawing.Image)(resources.GetObject("tsbPrint.Image")));
            this.tsbPrint.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbPrint.Name = "tsbPrint";
            this.tsbPrint.Size = new System.Drawing.Size(50, 22);
            this.tsbPrint.Text = "Print";
            this.tsbPrint.Click += new System.EventHandler(this.mainFrm_Click);
            // 
            // tsbExport
            // 
            this.tsbExport.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsbExport.Image = ((System.Drawing.Image)(resources.GetObject("tsbExport.Image")));
            this.tsbExport.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbExport.Name = "tsbExport";
            this.tsbExport.Size = new System.Drawing.Size(61, 22);
            this.tsbExport.Text = "Export";
            this.tsbExport.Click += new System.EventHandler(this.mainFrm_Click);
            // 
            // tsbQuit
            // 
            this.tsbQuit.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsbQuit.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsbQuit.Image = ((System.Drawing.Image)(resources.GetObject("tsbQuit.Image")));
            this.tsbQuit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbQuit.Name = "tsbQuit";
            this.tsbQuit.Size = new System.Drawing.Size(129, 22);
            this.tsbQuit.Text = "Thoát chương trình";
            this.tsbQuit.Click += new System.EventHandler(this.tsbQuit_Click);
            // 
            // mainFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1260, 750);
            this.Controls.Add(this.toolStrip3);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "mainFrm";
            this.Text = "Sales Management System";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.mainFrm_FormClosed);
            this.Load += new System.EventHandler(this.mainFrm_Load);
            this.Click += new System.EventHandler(this.mainFrm_Click);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.toolStrip3.ResumeLayout(false);
            this.toolStrip3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmSystem;
        private System.Windows.Forms.ToolStripMenuItem tsmFeature;
        private System.Windows.Forms.ToolStripMenuItem tsmHelp;
        private System.Windows.Forms.ToolStripMenuItem tsmProduct;
        private System.Windows.Forms.ToolStripMenuItem tsmEmployee;
        private System.Windows.Forms.ToolStripMenuItem tsmCustomer;
        private System.Windows.Forms.ToolStripMenuItem tsmDistributor;
        private System.Windows.Forms.ToolStripMenuItem tsmPurchase;
        private System.Windows.Forms.ToolStripMenuItem tsmInvoice;
        private System.Windows.Forms.ToolStripMenuItem tsmReport;
        private System.Windows.Forms.ToolStripMenuItem tsmSignIn;
        private System.Windows.Forms.ToolStripMenuItem tsmSignOut;
        private System.Windows.Forms.ToolStripMenuItem tsmChangePassword;
        private System.Windows.Forms.ToolStripMenuItem tsmQuit;
        private System.Windows.Forms.ToolStripMenuItem tsmSaleByDay;
        private System.Windows.Forms.ToolStripMenuItem tsmSaleByMonth;
        private System.Windows.Forms.ToolStripMenuItem tsmBestSeller;
        private System.Windows.Forms.ToolStripMenuItem tsmExport;
        private System.Windows.Forms.ToolStripMenuItem tsmUsageIns;
        private System.Windows.Forms.ToolStripMenuItem tsmAbout;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbProduct;
        private System.Windows.Forms.ToolStripButton tsbEmployee;
        private System.Windows.Forms.ToolStripButton tsbCustomer;
        private System.Windows.Forms.ToolStripButton tsbDistributor;
        private System.Windows.Forms.ToolStripButton tsbPurchase;
        private System.Windows.Forms.ToolStripButton tsbInvoice;
        private System.Windows.Forms.ToolStrip toolStrip3;
        private System.Windows.Forms.ToolStripButton tsbSearch;
        private System.Windows.Forms.ToolStripButton tsbPrint;
        private System.Windows.Forms.ToolStripButton tsbExport;
        private System.Windows.Forms.ToolStripButton tsbQuit;
        private System.Windows.Forms.ToolStripButton tsbDangXuat;
    }
}

