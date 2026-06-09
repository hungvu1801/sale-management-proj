namespace QuanLyBanHang.Forms
{
    partial class frmNhaCungCap
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
            this.btnSuaNPP = new System.Windows.Forms.Button();
            this.btnThemNPP = new System.Windows.Forms.Button();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtTenNPP = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvNPP = new System.Windows.Forms.DataGridView();
            this.btnXoaNPP = new System.Windows.Forms.Button();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNPP)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnXoaNPP);
            this.groupBox1.Controls.Add(this.btnSuaNPP);
            this.groupBox1.Controls.Add(this.btnThemNPP);
            this.groupBox1.Controls.Add(this.txtSDT);
            this.groupBox1.Controls.Add(this.txtDiaChi);
            this.groupBox1.Controls.Add(this.txtTenNPP);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 47);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(576, 168);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Nhà Cung Cấp";
            // 
            // btnSuaNPP
            // 
            this.btnSuaNPP.BackColor = System.Drawing.Color.Orange;
            this.btnSuaNPP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuaNPP.ForeColor = System.Drawing.Color.White;
            this.btnSuaNPP.Location = new System.Drawing.Point(457, 71);
            this.btnSuaNPP.Name = "btnSuaNPP";
            this.btnSuaNPP.Size = new System.Drawing.Size(100, 35);
            this.btnSuaNPP.TabIndex = 13;
            this.btnSuaNPP.Text = "Sửa";
            this.btnSuaNPP.UseVisualStyleBackColor = false;
            this.btnSuaNPP.Click += new System.EventHandler(this.btnSuaNPP_Click);
            // 
            // btnThemNPP
            // 
            this.btnThemNPP.BackColor = System.Drawing.Color.LimeGreen;
            this.btnThemNPP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemNPP.ForeColor = System.Drawing.Color.White;
            this.btnThemNPP.Location = new System.Drawing.Point(457, 26);
            this.btnThemNPP.Name = "btnThemNPP";
            this.btnThemNPP.Size = new System.Drawing.Size(100, 35);
            this.btnThemNPP.TabIndex = 15;
            this.btnThemNPP.Text = "Thêm";
            this.btnThemNPP.UseVisualStyleBackColor = false;
            this.btnThemNPP.Click += new System.EventHandler(this.btnThemNPP_Click);
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(108, 122);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(295, 20);
            this.txtSDT.TabIndex = 3;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(108, 80);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(295, 20);
            this.txtDiaChi.TabIndex = 2;
            // 
            // txtTenNPP
            // 
            this.txtTenNPP.Location = new System.Drawing.Point(108, 35);
            this.txtTenNPP.Name = "txtTenNPP";
            this.txtTenNPP.Size = new System.Drawing.Size(295, 20);
            this.txtTenNPP.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Số Điện Thoại";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Địa Chỉ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên NCC";
            // 
            // dgvNPP
            // 
            this.dgvNPP.AllowUserToAddRows = false;
            this.dgvNPP.AllowUserToDeleteRows = false;
            this.dgvNPP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNPP.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dgvNPP.Location = new System.Drawing.Point(12, 232);
            this.dgvNPP.Name = "dgvNPP";
            this.dgvNPP.ReadOnly = true;
            this.dgvNPP.Size = new System.Drawing.Size(641, 242);
            this.dgvNPP.TabIndex = 2;
            this.dgvNPP.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNPP_CellClick);
            // 
            // btnXoaNPP
            // 
            this.btnXoaNPP.BackColor = System.Drawing.Color.Red;
            this.btnXoaNPP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaNPP.ForeColor = System.Drawing.Color.White;
            this.btnXoaNPP.Location = new System.Drawing.Point(457, 122);
            this.btnXoaNPP.Name = "btnXoaNPP";
            this.btnXoaNPP.Size = new System.Drawing.Size(100, 35);
            this.btnXoaNPP.TabIndex = 16;
            this.btnXoaNPP.Text = "Xóa";
            this.btnXoaNPP.UseVisualStyleBackColor = false;
            this.btnXoaNPP.Click += new System.EventHandler(this.btnXoaNPP_Click);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Mã NCC";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Tên NCC";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 200;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Số Điện Thoại";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Địa Chỉ";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 200;
            // 
            // frmNhaCungCap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 522);
            this.Controls.Add(this.dgvNPP);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmNhaCungCap";
            this.Text = "Quản Lý Thông Tin Nhà Cung Cấp";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmNPP_FormClosed);
            this.Load += new System.EventHandler(this.frmNPP_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNPP)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvNPP;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtTenNPP;
        private System.Windows.Forms.Button btnSuaNPP;
        private System.Windows.Forms.Button btnThemNPP;
        private System.Windows.Forms.Button btnXoaNPP;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}