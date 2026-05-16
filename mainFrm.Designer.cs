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
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.tsbAdd = new System.Windows.Forms.ToolStripButton();
            this.tsbFix = new System.Windows.Forms.ToolStripButton();
            this.tsbDelete = new System.Windows.Forms.ToolStripButton();
            this.tsbSave = new System.Windows.Forms.ToolStripButton();
            this.tsbRefresh = new System.Windows.Forms.ToolStripButton();
            this.toolStrip3 = new System.Windows.Forms.ToolStrip();
            this.tsbSearch = new System.Windows.Forms.ToolStripButton();
            this.tsbPrint = new System.Windows.Forms.ToolStripButton();
            this.tsbExport = new System.Windows.Forms.ToolStripButton();
            this.tsbQuit = new System.Windows.Forms.ToolStripButton();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.toolStrip3.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmSystem,
            this.tsmFeature,
            this.tsmReport,
            this.tsmHelp});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(808, 38);
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
            this.tsmSystem.Name = "tsmSystem";
            this.tsmSystem.Size = new System.Drawing.Size(94, 34);
            this.tsmSystem.Text = "&System";
            this.tsmSystem.Click += new System.EventHandler(this.hệThốngToolStripMenuItem_Click);
            // 
            // tsmSignIn
            // 
            this.tsmSignIn.Name = "tsmSignIn";
            this.tsmSignIn.Size = new System.Drawing.Size(256, 34);
            this.tsmSignIn.Text = "&Sign In";
            this.tsmSignIn.Click += new System.EventHandler(this.signInToolStripMenuItem_Click);
            // 
            // tsmSignOut
            // 
            this.tsmSignOut.Name = "tsmSignOut";
            this.tsmSignOut.Size = new System.Drawing.Size(256, 34);
            this.tsmSignOut.Text = "&Sign Out";
            // 
            // tsmChangePassword
            // 
            this.tsmChangePassword.Name = "tsmChangePassword";
            this.tsmChangePassword.Size = new System.Drawing.Size(256, 34);
            this.tsmChangePassword.Text = "&Change Password";
            // 
            // tsmQuit
            // 
            this.tsmQuit.Name = "tsmQuit";
            this.tsmQuit.Size = new System.Drawing.Size(256, 34);
            this.tsmQuit.Text = "&Quit";
            // 
            // tsmFeature
            // 
            this.tsmFeature.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmProduct,
            this.tsmEmployee,
            this.tsmCustomer,
            this.tsmDistributor,
            this.tsmPurchase,
            this.tsmInvoice});
            this.tsmFeature.Name = "tsmFeature";
            this.tsmFeature.Size = new System.Drawing.Size(98, 34);
            this.tsmFeature.Text = "&Feature";
            // 
            // tsmProduct
            // 
            this.tsmProduct.Name = "tsmProduct";
            this.tsmProduct.Size = new System.Drawing.Size(236, 34);
            this.tsmProduct.Text = "&Product";
            this.tsmProduct.Click += new System.EventHandler(this.mainFrm_Click);
            // 
            // tsmEmployee
            // 
            this.tsmEmployee.Name = "tsmEmployee";
            this.tsmEmployee.Size = new System.Drawing.Size(236, 34);
            this.tsmEmployee.Text = "&Employee";
            this.tsmEmployee.Click += new System.EventHandler(this.mainFrm_Click);
            // 
            // tsmCustomer
            // 
            this.tsmCustomer.Name = "tsmCustomer";
            this.tsmCustomer.Size = new System.Drawing.Size(236, 34);
            this.tsmCustomer.Text = "&Customers";
            this.tsmCustomer.Click += new System.EventHandler(this.mainFrm_Click);
            // 
            // tsmDistributor
            // 
            this.tsmDistributor.Name = "tsmDistributor";
            this.tsmDistributor.Size = new System.Drawing.Size(236, 34);
            this.tsmDistributor.Text = "&Distributor";
            this.tsmDistributor.Click += new System.EventHandler(this.mainFrm_Click);
            // 
            // tsmPurchase
            // 
            this.tsmPurchase.Name = "tsmPurchase";
            this.tsmPurchase.Size = new System.Drawing.Size(236, 34);
            this.tsmPurchase.Text = "&Purchase Order";
            this.tsmPurchase.Click += new System.EventHandler(this.mainFrm_Click);
            // 
            // tsmInvoice
            // 
            this.tsmInvoice.Name = "tsmInvoice";
            this.tsmInvoice.Size = new System.Drawing.Size(236, 34);
            this.tsmInvoice.Text = "&Invoice";
            this.tsmInvoice.Click += new System.EventHandler(this.mainFrm_Click);
            // 
            // tsmReport
            // 
            this.tsmReport.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmSaleByDay,
            this.tsmSaleByMonth,
            this.tsmBestSeller,
            this.tsmExport});
            this.tsmReport.Name = "tsmReport";
            this.tsmReport.Size = new System.Drawing.Size(90, 34);
            this.tsmReport.Text = "&Report";
            // 
            // tsmSaleByDay
            // 
            this.tsmSaleByDay.Name = "tsmSaleByDay";
            this.tsmSaleByDay.Size = new System.Drawing.Size(238, 34);
            this.tsmSaleByDay.Text = "Sales by &Day";
            // 
            // tsmSaleByMonth
            // 
            this.tsmSaleByMonth.Name = "tsmSaleByMonth";
            this.tsmSaleByMonth.Size = new System.Drawing.Size(238, 34);
            this.tsmSaleByMonth.Text = "Salse by &Month";
            // 
            // tsmBestSeller
            // 
            this.tsmBestSeller.Name = "tsmBestSeller";
            this.tsmBestSeller.Size = new System.Drawing.Size(238, 34);
            this.tsmBestSeller.Text = "Top &Best Sellers";
            // 
            // tsmExport
            // 
            this.tsmExport.Name = "tsmExport";
            this.tsmExport.Size = new System.Drawing.Size(238, 34);
            this.tsmExport.Text = "&Export to Excel";
            // 
            // tsmHelp
            // 
            this.tsmHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmUsageIns,
            this.tsmAbout});
            this.tsmHelp.Name = "tsmHelp";
            this.tsmHelp.Size = new System.Drawing.Size(71, 34);
            this.tsmHelp.Text = "&Help";
            // 
            // tsmUsageIns
            // 
            this.tsmUsageIns.Name = "tsmUsageIns";
            this.tsmUsageIns.Size = new System.Drawing.Size(253, 34);
            this.tsmUsageIns.Text = "Usage Instruction";
            // 
            // tsmAbout
            // 
            this.tsmAbout.Name = "tsmAbout";
            this.tsmAbout.Size = new System.Drawing.Size(253, 34);
            this.tsmAbout.Text = "About";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbProduct,
            this.tsbEmployee,
            this.tsbCustomer,
            this.tsbDistributor,
            this.tsbPurchase,
            this.tsbInvoice,
            this.tsbDangXuat});
            this.toolStrip1.Location = new System.Drawing.Point(0, 38);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(808, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbProduct
            // 
            this.tsbProduct.Image = ((System.Drawing.Image)(resources.GetObject("tsbProduct.Image")));
            this.tsbProduct.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbProduct.Name = "tsbProduct";
            this.tsbProduct.Size = new System.Drawing.Size(69, 22);
            this.tsbProduct.Text = "Product";
            this.tsbProduct.Click += new System.EventHandler(this.mainFrm_Click);
            // 
            // tsbEmployee
            // 
            this.tsbEmployee.Image = ((System.Drawing.Image)(resources.GetObject("tsbEmployee.Image")));
            this.tsbEmployee.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbEmployee.Name = "tsbEmployee";
            this.tsbEmployee.Size = new System.Drawing.Size(79, 22);
            this.tsbEmployee.Text = "Employee";
            this.tsbEmployee.Click += new System.EventHandler(this.mainFrm_Click);
            // 
            // tsbCustomer
            // 
            this.tsbCustomer.Image = ((System.Drawing.Image)(resources.GetObject("tsbCustomer.Image")));
            this.tsbCustomer.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbCustomer.Name = "tsbCustomer";
            this.tsbCustomer.Size = new System.Drawing.Size(84, 22);
            this.tsbCustomer.Text = "Customers";
            this.tsbCustomer.Click += new System.EventHandler(this.mainFrm_Click);
            // 
            // tsbDistributor
            // 
            this.tsbDistributor.Image = ((System.Drawing.Image)(resources.GetObject("tsbDistributor.Image")));
            this.tsbDistributor.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbDistributor.Name = "tsbDistributor";
            this.tsbDistributor.Size = new System.Drawing.Size(83, 22);
            this.tsbDistributor.Text = "Distributor";
            this.tsbDistributor.Click += new System.EventHandler(this.mainFrm_Click);
            // 
            // tsbPurchase
            // 
            this.tsbPurchase.Image = ((System.Drawing.Image)(resources.GetObject("tsbPurchase.Image")));
            this.tsbPurchase.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbPurchase.Name = "tsbPurchase";
            this.tsbPurchase.Size = new System.Drawing.Size(75, 22);
            this.tsbPurchase.Text = "Purchase";
            this.tsbPurchase.Click += new System.EventHandler(this.mainFrm_Click);
            // 
            // tsbInvoice
            // 
            this.tsbInvoice.Image = ((System.Drawing.Image)(resources.GetObject("tsbInvoice.Image")));
            this.tsbInvoice.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbInvoice.Name = "tsbInvoice";
            this.tsbInvoice.Size = new System.Drawing.Size(65, 22);
            this.tsbInvoice.Text = "Invoice";
            this.tsbInvoice.Click += new System.EventHandler(this.mainFrm_Click);
            // 
            // tsbDangXuat
            // 
            this.tsbDangXuat.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsbDangXuat.Image = ((System.Drawing.Image)(resources.GetObject("tsbDangXuat.Image")));
            this.tsbDangXuat.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbDangXuat.Name = "tsbDangXuat";
            this.tsbDangXuat.Size = new System.Drawing.Size(80, 22);
            this.tsbDangXuat.Text = "Đăng xuất";
            this.tsbDangXuat.Click += new System.EventHandler(this.tsbDangXuat_Click);
            // 
            // toolStrip2
            // 
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbAdd,
            this.tsbFix,
            this.tsbDelete,
            this.tsbSave,
            this.tsbRefresh});
            this.toolStrip2.Location = new System.Drawing.Point(0, 63);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(808, 25);
            this.toolStrip2.TabIndex = 2;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // tsbAdd
            // 
            this.tsbAdd.Image = ((System.Drawing.Image)(resources.GetObject("tsbAdd.Image")));
            this.tsbAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAdd.Name = "tsbAdd";
            this.tsbAdd.Size = new System.Drawing.Size(49, 22);
            this.tsbAdd.Text = "Add";
            this.tsbAdd.Click += new System.EventHandler(this.mainFrm_Click);
            // 
            // tsbFix
            // 
            this.tsbFix.Image = ((System.Drawing.Image)(resources.GetObject("tsbFix.Image")));
            this.tsbFix.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbFix.Name = "tsbFix";
            this.tsbFix.Size = new System.Drawing.Size(41, 22);
            this.tsbFix.Text = "Fix";
            this.tsbFix.Click += new System.EventHandler(this.mainFrm_Click);
            // 
            // tsbDelete
            // 
            this.tsbDelete.Image = ((System.Drawing.Image)(resources.GetObject("tsbDelete.Image")));
            this.tsbDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbDelete.Name = "tsbDelete";
            this.tsbDelete.Size = new System.Drawing.Size(60, 22);
            this.tsbDelete.Text = "Delete";
            this.tsbDelete.Click += new System.EventHandler(this.mainFrm_Click);
            // 
            // tsbSave
            // 
            this.tsbSave.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsbSave.Image = ((System.Drawing.Image)(resources.GetObject("tsbSave.Image")));
            this.tsbSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSave.Name = "tsbSave";
            this.tsbSave.Size = new System.Drawing.Size(51, 22);
            this.tsbSave.Text = "Save";
            // 
            // tsbRefresh
            // 
            this.tsbRefresh.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsbRefresh.Image = ((System.Drawing.Image)(resources.GetObject("tsbRefresh.Image")));
            this.tsbRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbRefresh.Name = "tsbRefresh";
            this.tsbRefresh.Size = new System.Drawing.Size(66, 22);
            this.tsbRefresh.Text = "Refresh";
            this.tsbRefresh.Click += new System.EventHandler(this.tsbRefresh_Click);
            // 
            // toolStrip3
            // 
            this.toolStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbSearch,
            this.tsbPrint,
            this.tsbExport,
            this.tsbQuit});
            this.toolStrip3.Location = new System.Drawing.Point(0, 88);
            this.toolStrip3.Name = "toolStrip3";
            this.toolStrip3.Size = new System.Drawing.Size(808, 25);
            this.toolStrip3.TabIndex = 3;
            this.toolStrip3.Text = "toolStrip3";
            // 
            // tsbSearch
            // 
            this.tsbSearch.Image = ((System.Drawing.Image)(resources.GetObject("tsbSearch.Image")));
            this.tsbSearch.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSearch.Name = "tsbSearch";
            this.tsbSearch.Size = new System.Drawing.Size(62, 22);
            this.tsbSearch.Text = "Search";
            this.tsbSearch.Click += new System.EventHandler(this.mainFrm_Click);
            // 
            // tsbPrint
            // 
            this.tsbPrint.Image = ((System.Drawing.Image)(resources.GetObject("tsbPrint.Image")));
            this.tsbPrint.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbPrint.Name = "tsbPrint";
            this.tsbPrint.Size = new System.Drawing.Size(52, 22);
            this.tsbPrint.Text = "Print";
            this.tsbPrint.Click += new System.EventHandler(this.mainFrm_Click);
            // 
            // tsbExport
            // 
            this.tsbExport.Image = ((System.Drawing.Image)(resources.GetObject("tsbExport.Image")));
            this.tsbExport.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbExport.Name = "tsbExport";
            this.tsbExport.Size = new System.Drawing.Size(60, 22);
            this.tsbExport.Text = "Export";
            this.tsbExport.Click += new System.EventHandler(this.mainFrm_Click);
            // 
            // tsbQuit
            // 
            this.tsbQuit.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsbQuit.Image = ((System.Drawing.Image)(resources.GetObject("tsbQuit.Image")));
            this.tsbQuit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbQuit.Name = "tsbQuit";
            this.tsbQuit.Size = new System.Drawing.Size(50, 22);
            this.tsbQuit.Text = "Quit";
            this.tsbQuit.Click += new System.EventHandler(this.tsbQuit_Click);
            // 
            // mainFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 750);
            this.Controls.Add(this.toolStrip3);
            this.Controls.Add(this.toolStrip2);
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
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
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
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton tsbAdd;
        private System.Windows.Forms.ToolStripButton tsbFix;
        private System.Windows.Forms.ToolStripButton tsbDelete;
        private System.Windows.Forms.ToolStripButton tsbSave;
        private System.Windows.Forms.ToolStripButton tsbRefresh;
        private System.Windows.Forms.ToolStrip toolStrip3;
        private System.Windows.Forms.ToolStripButton tsbSearch;
        private System.Windows.Forms.ToolStripButton tsbPrint;
        private System.Windows.Forms.ToolStripButton tsbExport;
        private System.Windows.Forms.ToolStripButton tsbQuit;
        private System.Windows.Forms.ToolStripButton tsbDangXuat;
    }
}

