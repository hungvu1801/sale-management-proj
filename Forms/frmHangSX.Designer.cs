namespace QuanLyBanHang.Forms
{
    partial class frmHangSX
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.txtTenHangSX = new System.Windows.Forms.TextBox();
            this.txtMaHangSX = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvHangSX = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHangSX)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnXoa);
            this.groupBox1.Controls.Add(this.btnSua);
            this.groupBox1.Controls.Add(this.btnThem);
            this.groupBox1.Controls.Add(this.txtTenHangSX);
            this.groupBox1.Controls.Add(this.txtMaHangSX);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(23, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(431, 162);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Hãng Sản Xuất";
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.Red;
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.Location = new System.Drawing.Point(303, 104);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(100, 35);
            this.btnXoa.TabIndex = 16;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.Orange;
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.ForeColor = System.Drawing.Color.White;
            this.btnSua.Location = new System.Drawing.Point(166, 104);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(100, 35);
            this.btnSua.TabIndex = 13;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.LimeGreen;
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.Location = new System.Drawing.Point(28, 104);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(100, 35);
            this.btnThem.TabIndex = 15;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            // 
            // txtTenHangSX
            // 
            this.txtTenHangSX.Location = new System.Drawing.Point(130, 63);
            this.txtTenHangSX.Name = "txtTenHangSX";
            this.txtTenHangSX.Size = new System.Drawing.Size(295, 20);
            this.txtTenHangSX.TabIndex = 1;
            // 
            // txtMaHangSX
            // 
            this.txtMaHangSX.Location = new System.Drawing.Point(130, 26);
            this.txtMaHangSX.Name = "txtMaHangSX";
            this.txtMaHangSX.Size = new System.Drawing.Size(295, 20);
            this.txtMaHangSX.TabIndex = 0;
            this.txtMaHangSX.TextChanged += new System.EventHandler(this.txtMaHangSX_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Mã Hãng Sản Xuất";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên Hãng Sản Xuất";
            // 
            // dgvHangSX
            // 
            this.dgvHangSX.AllowUserToAddRows = false;
            this.dgvHangSX.AllowUserToDeleteRows = false;
            this.dgvHangSX.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHangSX.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dgvHangSX.Location = new System.Drawing.Point(23, 201);
            this.dgvHangSX.Name = "dgvHangSX";
            this.dgvHangSX.ReadOnly = true;
            this.dgvHangSX.Size = new System.Drawing.Size(431, 242);
            this.dgvHangSX.TabIndex = 3;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Mã Hãng Sản Xuất";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 150;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Tên Hãng Sản Xuất";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 200;
            // 
            // frmHangSX
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 464);
            this.Controls.Add(this.dgvHangSX);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmHangSX";
            this.Text = "Quản Lý Thông Tin Hãng Sản Xuất";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHangSX)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.TextBox txtTenHangSX;
        private System.Windows.Forms.TextBox txtMaHangSX;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvHangSX;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}