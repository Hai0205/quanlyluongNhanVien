namespace QL_TienLuongNhanVien
{
    partial class frmQL_NhanVien
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.grpNhanVien = new System.Windows.Forms.GroupBox();
            this.txtThanhTien = new System.Windows.Forms.TextBox();
            this.txtSoNgayCong = new System.Windows.Forms.TextBox();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.lblThanhTien = new System.Windows.Forms.Label();
            this.lblSoNgayCong = new System.Windows.Forms.Label();
            this.lblHoTen = new System.Windows.Forms.Label();
            this.txtMaSo = new System.Windows.Forms.TextBox();
            this.rdoQuanLy = new System.Windows.Forms.RadioButton();
            this.rdoCongNhan = new System.Windows.Forms.RadioButton();
            this.lblChucVu = new System.Windows.Forms.Label();
            this.lblMaSo = new System.Windows.Forms.Label();
            this.lblTieuDe = new System.Windows.Forms.Label();
            this.dgvThongTinNV = new System.Windows.Forms.DataGridView();
            this.btnThemNhanVien = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnKetThuc = new System.Windows.Forms.Button();
            this.btnChinhSua = new System.Windows.Forms.Button();
            this.clMSNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clHoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clChucVu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clSoNgayCong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clThanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpNhanVien.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongTinNV)).BeginInit();
            this.SuspendLayout();
            // 
            // grpNhanVien
            // 
            this.grpNhanVien.Controls.Add(this.txtThanhTien);
            this.grpNhanVien.Controls.Add(this.txtSoNgayCong);
            this.grpNhanVien.Controls.Add(this.txtHoTen);
            this.grpNhanVien.Controls.Add(this.lblThanhTien);
            this.grpNhanVien.Controls.Add(this.lblSoNgayCong);
            this.grpNhanVien.Controls.Add(this.lblHoTen);
            this.grpNhanVien.Controls.Add(this.txtMaSo);
            this.grpNhanVien.Controls.Add(this.rdoQuanLy);
            this.grpNhanVien.Controls.Add(this.rdoCongNhan);
            this.grpNhanVien.Controls.Add(this.lblChucVu);
            this.grpNhanVien.Controls.Add(this.lblMaSo);
            this.grpNhanVien.Location = new System.Drawing.Point(56, 76);
            this.grpNhanVien.Margin = new System.Windows.Forms.Padding(4);
            this.grpNhanVien.Name = "grpNhanVien";
            this.grpNhanVien.Padding = new System.Windows.Forms.Padding(4);
            this.grpNhanVien.Size = new System.Drawing.Size(860, 200);
            this.grpNhanVien.TabIndex = 0;
            this.grpNhanVien.TabStop = false;
            this.grpNhanVien.Text = "Thông Tin Nhân Viên";
            // 
            // txtThanhTien
            // 
            this.txtThanhTien.Location = new System.Drawing.Point(592, 143);
            this.txtThanhTien.Name = "txtThanhTien";
            this.txtThanhTien.Size = new System.Drawing.Size(203, 33);
            this.txtThanhTien.TabIndex = 10;
            // 
            // txtSoNgayCong
            // 
            this.txtSoNgayCong.Location = new System.Drawing.Point(592, 88);
            this.txtSoNgayCong.Name = "txtSoNgayCong";
            this.txtSoNgayCong.Size = new System.Drawing.Size(203, 33);
            this.txtSoNgayCong.TabIndex = 9;
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(592, 33);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(203, 33);
            this.txtHoTen.TabIndex = 8;
            // 
            // lblThanhTien
            // 
            this.lblThanhTien.AutoSize = true;
            this.lblThanhTien.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThanhTien.Location = new System.Drawing.Point(390, 151);
            this.lblThanhTien.Name = "lblThanhTien";
            this.lblThanhTien.Size = new System.Drawing.Size(122, 25);
            this.lblThanhTien.TabIndex = 7;
            this.lblThanhTien.Text = "Thành tiền:";
            // 
            // lblSoNgayCong
            // 
            this.lblSoNgayCong.AutoSize = true;
            this.lblSoNgayCong.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoNgayCong.Location = new System.Drawing.Point(390, 96);
            this.lblSoNgayCong.Name = "lblSoNgayCong";
            this.lblSoNgayCong.Size = new System.Drawing.Size(142, 25);
            this.lblSoNgayCong.TabIndex = 6;
            this.lblSoNgayCong.Text = "Số ngày công:";
            // 
            // lblHoTen
            // 
            this.lblHoTen.AutoSize = true;
            this.lblHoTen.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoTen.Location = new System.Drawing.Point(390, 41);
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Size = new System.Drawing.Size(181, 25);
            this.lblHoTen.TabIndex = 5;
            this.lblHoTen.Text = "Họ tên nhân viên:";
            // 
            // txtMaSo
            // 
            this.txtMaSo.Location = new System.Drawing.Point(200, 33);
            this.txtMaSo.Name = "txtMaSo";
            this.txtMaSo.Size = new System.Drawing.Size(110, 33);
            this.txtMaSo.TabIndex = 4;
            // 
            // rdoQuanLy
            // 
            this.rdoQuanLy.AutoSize = true;
            this.rdoQuanLy.Location = new System.Drawing.Point(181, 138);
            this.rdoQuanLy.Name = "rdoQuanLy";
            this.rdoQuanLy.Size = new System.Drawing.Size(107, 29);
            this.rdoQuanLy.TabIndex = 3;
            this.rdoQuanLy.TabStop = true;
            this.rdoQuanLy.Text = "Quản lý";
            this.rdoQuanLy.UseVisualStyleBackColor = true;
            this.rdoQuanLy.CheckedChanged += new System.EventHandler(this.rdoQuanLy_CheckedChanged);
            // 
            // rdoCongNhan
            // 
            this.rdoCongNhan.AutoSize = true;
            this.rdoCongNhan.Location = new System.Drawing.Point(33, 138);
            this.rdoCongNhan.Name = "rdoCongNhan";
            this.rdoCongNhan.Size = new System.Drawing.Size(129, 29);
            this.rdoCongNhan.TabIndex = 2;
            this.rdoCongNhan.TabStop = true;
            this.rdoCongNhan.Text = "Công nhân";
            this.rdoCongNhan.UseVisualStyleBackColor = true;
            this.rdoCongNhan.CheckedChanged += new System.EventHandler(this.rdoCongNhan_CheckedChanged);
            // 
            // lblChucVu
            // 
            this.lblChucVu.AutoSize = true;
            this.lblChucVu.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChucVu.Location = new System.Drawing.Point(28, 96);
            this.lblChucVu.Name = "lblChucVu";
            this.lblChucVu.Size = new System.Drawing.Size(100, 25);
            this.lblChucVu.TabIndex = 1;
            this.lblChucVu.Text = "Chức vụ:";
            // 
            // lblMaSo
            // 
            this.lblMaSo.AutoSize = true;
            this.lblMaSo.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaSo.Location = new System.Drawing.Point(19, 41);
            this.lblMaSo.Name = "lblMaSo";
            this.lblMaSo.Size = new System.Drawing.Size(175, 25);
            this.lblMaSo.TabIndex = 0;
            this.lblMaSo.Text = "Mã số nhân viên:";
            // 
            // lblTieuDe
            // 
            this.lblTieuDe.AutoSize = true;
            this.lblTieuDe.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTieuDe.Location = new System.Drawing.Point(285, 23);
            this.lblTieuDe.Name = "lblTieuDe";
            this.lblTieuDe.Size = new System.Drawing.Size(379, 45);
            this.lblTieuDe.TabIndex = 1;
            this.lblTieuDe.Text = "Quản Lý Tiền Lương";
            // 
            // dgvThongTinNV
            // 
            this.dgvThongTinNV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThongTinNV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clMSNV,
            this.clHoTen,
            this.clChucVu,
            this.clSoNgayCong,
            this.clThanhTien});
            this.dgvThongTinNV.Location = new System.Drawing.Point(56, 296);
            this.dgvThongTinNV.Name = "dgvThongTinNV";
            this.dgvThongTinNV.RowTemplate.Height = 28;
            this.dgvThongTinNV.Size = new System.Drawing.Size(860, 177);
            this.dgvThongTinNV.TabIndex = 2;
            this.dgvThongTinNV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvThongTinNV_CellClick);
            // 
            // btnThemNhanVien
            // 
            this.btnThemNhanVien.BackColor = System.Drawing.Color.Lime;
            this.btnThemNhanVien.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemNhanVien.ForeColor = System.Drawing.Color.Red;
            this.btnThemNhanVien.Location = new System.Drawing.Point(105, 497);
            this.btnThemNhanVien.Name = "btnThemNhanVien";
            this.btnThemNhanVien.Size = new System.Drawing.Size(202, 49);
            this.btnThemNhanVien.TabIndex = 3;
            this.btnThemNhanVien.Text = "Thêm Nhân Viên";
            this.btnThemNhanVien.UseVisualStyleBackColor = false;
            this.btnThemNhanVien.Click += new System.EventHandler(this.btnThemNhanVien_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.Color.Lime;
            this.btnLuu.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.ForeColor = System.Drawing.Color.Red;
            this.btnLuu.Location = new System.Drawing.Point(313, 497);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(107, 49);
            this.btnLuu.TabIndex = 4;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.Lime;
            this.btnXoa.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.Color.Red;
            this.btnXoa.Location = new System.Drawing.Point(574, 497);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(108, 49);
            this.btnXoa.TabIndex = 5;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnKetThuc
            // 
            this.btnKetThuc.BackColor = System.Drawing.Color.Lime;
            this.btnKetThuc.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKetThuc.ForeColor = System.Drawing.Color.Red;
            this.btnKetThuc.Location = new System.Drawing.Point(688, 497);
            this.btnKetThuc.Name = "btnKetThuc";
            this.btnKetThuc.Size = new System.Drawing.Size(154, 49);
            this.btnKetThuc.TabIndex = 6;
            this.btnKetThuc.Text = "Kết Thúc";
            this.btnKetThuc.UseVisualStyleBackColor = false;
            this.btnKetThuc.Click += new System.EventHandler(this.btnKetThuc_Click);
            // 
            // btnChinhSua
            // 
            this.btnChinhSua.BackColor = System.Drawing.Color.Lime;
            this.btnChinhSua.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChinhSua.ForeColor = System.Drawing.Color.Red;
            this.btnChinhSua.Location = new System.Drawing.Point(427, 497);
            this.btnChinhSua.Name = "btnChinhSua";
            this.btnChinhSua.Size = new System.Drawing.Size(141, 49);
            this.btnChinhSua.TabIndex = 7;
            this.btnChinhSua.Text = "Chỉnh Sửa";
            this.btnChinhSua.UseVisualStyleBackColor = false;
            this.btnChinhSua.Click += new System.EventHandler(this.btnChinhSua_Click);
            // 
            // clMSNV
            // 
            this.clMSNV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clMSNV.HeaderText = "MSNV";
            this.clMSNV.Name = "clMSNV";
            // 
            // clHoTen
            // 
            this.clHoTen.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clHoTen.HeaderText = "Họ và tên";
            this.clHoTen.Name = "clHoTen";
            // 
            // clChucVu
            // 
            this.clChucVu.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clChucVu.HeaderText = "Chức vụ";
            this.clChucVu.Name = "clChucVu";
            // 
            // clSoNgayCong
            // 
            this.clSoNgayCong.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            this.clSoNgayCong.DefaultCellStyle = dataGridViewCellStyle1;
            this.clSoNgayCong.HeaderText = "Số ngày công";
            this.clSoNgayCong.Name = "clSoNgayCong";
            // 
            // clThanhTien
            // 
            this.clThanhTien.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            this.clThanhTien.DefaultCellStyle = dataGridViewCellStyle2;
            this.clThanhTien.HeaderText = "Thành tiền";
            this.clThanhTien.Name = "clThanhTien";
            // 
            // frmQL_NhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(972, 576);
            this.Controls.Add(this.btnChinhSua);
            this.Controls.Add(this.btnKetThuc);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnThemNhanVien);
            this.Controls.Add(this.dgvThongTinNV);
            this.Controls.Add(this.lblTieuDe);
            this.Controls.Add(this.grpNhanVien);
            this.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmQL_NhanVien";
            this.Text = "Quản Lý Tiền Lương Nhân Viên";
            this.Load += new System.EventHandler(this.QL_NhanVien_Load);
            this.grpNhanVien.ResumeLayout(false);
            this.grpNhanVien.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongTinNV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpNhanVien;
        private System.Windows.Forms.TextBox txtThanhTien;
        private System.Windows.Forms.TextBox txtSoNgayCong;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Label lblThanhTien;
        private System.Windows.Forms.Label lblSoNgayCong;
        private System.Windows.Forms.Label lblHoTen;
        private System.Windows.Forms.TextBox txtMaSo;
        private System.Windows.Forms.RadioButton rdoQuanLy;
        private System.Windows.Forms.RadioButton rdoCongNhan;
        private System.Windows.Forms.Label lblChucVu;
        private System.Windows.Forms.Label lblMaSo;
        private System.Windows.Forms.Label lblTieuDe;
        private System.Windows.Forms.DataGridView dgvThongTinNV;
        private System.Windows.Forms.Button btnThemNhanVien;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnKetThuc;
        private System.Windows.Forms.Button btnChinhSua;
        private System.Windows.Forms.DataGridViewTextBoxColumn clMSNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn clHoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn clChucVu;
        private System.Windows.Forms.DataGridViewTextBoxColumn clSoNgayCong;
        private System.Windows.Forms.DataGridViewTextBoxColumn clThanhTien;
    }
}

