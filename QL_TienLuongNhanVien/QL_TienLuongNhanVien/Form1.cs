using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_TienLuongNhanVien
{
    public partial class frmQL_NhanVien : Form
    {
        public frmQL_NhanVien()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void QL_NhanVien_Load(object sender, EventArgs e)
        {
            dgvThongTinNV.Rows.Add("Nv1", "Nguyễn Văn A", "Công nhân", 33, "5,000,000");
            grpNhanVien.Enabled = false;
            btnLuu.Enabled = false;
            btnChinhSua.Enabled = false;
            btnXoa.Enabled = false;
            txtThanhTien.ReadOnly = true;
            dgvThongTinNV.ReadOnly = true;
        }

        private void btnThemNhanVien_Click(object sender, EventArgs e)
        {
            txtMaSo.Clear();
            txtHoTen.Clear();
            txtSoNgayCong.Clear();
            txtThanhTien.Clear();
            rdoCongNhan.Checked = false;
            rdoQuanLy.Checked = false;
            grpNhanVien.Enabled = true;
            btnLuu.Enabled = true;
            btnThemNhanVien.Enabled = false;
            txtMaSo.Focus();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            int SoNgayCong = 0;
            if (txtMaSo.Text.Length == 0)
            {
                MessageBox.Show("Chưa nhập mã số nhân viên!", "Lỗi dữ liệu!");
                txtMaSo.Focus();
            }
            else
            {
                if (rdoCongNhan.Checked == false && rdoQuanLy.Checked == false)
                    MessageBox.Show("Chưa chọn chức vụ!", "Lỗi dữ liệu!");
                else
                {
                    if (txtHoTen.Text.Length == 0)
                    {
                        MessageBox.Show("Chưa nhập họ tên nhân viên!", "Lỗi dữ liệu!");
                        txtHoTen.Focus();
                    }
                    else
                    {
                        if (txtSoNgayCong.Text.Length == 0 || !int.TryParse(txtSoNgayCong.Text, out SoNgayCong))
                        {
                            MessageBox.Show("Nhập lại số ngày công!", "Lỗi dữ liệu!");
                            txtSoNgayCong.Clear();
                            txtSoNgayCong.Focus();
                        }
                        else
                        {
                            if (rdoCongNhan.Checked == true)
                            {
                                CongNhan CN = new CongNhan(txtMaSo.Text, txtHoTen.Text, SoNgayCong);
                                txtThanhTien.Text = CN.TienLuong().ToString("#,##");
                                dgvThongTinNV.Rows.Add(CN.layMSNV(), CN.layHoTen(), "Công nhân", CN.layNgayCong(), CN.TienLuong().ToString("#,##"));
                            }
                            if (rdoQuanLy.Checked == true)
                            {
                                QuanLy QL = new QuanLy(txtMaSo.Text, txtHoTen.Text, SoNgayCong);
                                txtThanhTien.Text = QL.TienLuong().ToString("#,##");
                                dgvThongTinNV.Rows.Add(QL.layMSNV(), QL.layHoTen(), "Quản lý", QL.layNgayCong(), QL.TienLuong().ToString("#,##"));
                            }
                            btnThemNhanVien.Enabled = true;
                            btnLuu.Enabled = false;
                            grpNhanVien.Enabled = false;
                        }
                    }
                }
            }
        }

        private void btnKetThuc_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rdoCongNhan_CheckedChanged(object sender, EventArgs e)
        {
            btnLuu.Enabled = true;
        }

        private void rdoQuanLy_CheckedChanged(object sender, EventArgs e)
        {
            btnLuu.Enabled = true;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if ((dgvThongTinNV.CurrentRow.Index != -1) && (dgvThongTinNV.CurrentRow.Index < (dgvThongTinNV.RowCount - 1)))
            {
                dgvThongTinNV.Rows.RemoveAt(dgvThongTinNV.CurrentRow.Index);
                btnXoa.Enabled = false;
                btnChinhSua.Enabled = false;
            }
        }

        private void dgvThongTinNV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if ((dgvThongTinNV.CurrentRow.Index != -1) && (dgvThongTinNV.CurrentRow.Index < (dgvThongTinNV.RowCount - 1)))
            {
                DataGridViewRow row = this.dgvThongTinNV.Rows[e.RowIndex];
                txtMaSo.Text = row.Cells[0].Value.ToString();
                txtHoTen.Text = row.Cells[1].Value.ToString();
                if (row.Cells[2].Value.ToString() == "Công nhân")
                    rdoCongNhan.Checked = true;
                else
                    rdoQuanLy.Checked = true;
                txtSoNgayCong.Text = row.Cells[3].Value.ToString();
                txtThanhTien.Text = row.Cells[4].Value.ToString();
            }
            btnChinhSua.Enabled = true;
            btnXoa.Enabled = true;
            grpNhanVien.Enabled = true;
        }

        private void btnChinhSua_Click(object sender, EventArgs e)
        {
            int SoNgayCong = 0;
            if (txtMaSo.Text.Length == 0)
            {
                MessageBox.Show("Chưa nhập mã số nhân viên!", "Lỗi dữ liệu!");
                txtMaSo.Focus();
            }
            else
            {
                if (rdoCongNhan.Checked == false && rdoQuanLy.Checked == false)
                    MessageBox.Show("Chưa chọn chức vụ!", "Lỗi dữ liệu!");
                else
                {
                    if (txtHoTen.Text.Length == 0)
                    {
                        MessageBox.Show("Chưa nhập họ tên nhân viên!", "Lỗi dữ liệu!");
                        txtHoTen.Focus();
                    }
                    else
                    {
                        if (txtSoNgayCong.Text.Length == 0 || !int.TryParse(txtSoNgayCong.Text, out SoNgayCong))
                        {
                            MessageBox.Show("Nhập lại số ngày công!", "Lỗi dữ liệu!");
                            txtSoNgayCong.Clear();
                            txtSoNgayCong.Focus();
                        }
                        else
                        {
                            if ((dgvThongTinNV.CurrentRow.Index != -1) && (dgvThongTinNV.CurrentRow.Index < (dgvThongTinNV.RowCount - 1)))
                            {
                                dgvThongTinNV.Rows.RemoveAt(dgvThongTinNV.CurrentRow.Index);
                                if (rdoCongNhan.Checked == true)
                                {
                                    CongNhan CN = new CongNhan(txtMaSo.Text, txtHoTen.Text, SoNgayCong);
                                    txtThanhTien.Text = CN.TienLuong().ToString("#,##");
                                    dgvThongTinNV.Rows.Insert(dgvThongTinNV.CurrentRow.Index, CN.layMSNV(), CN.layHoTen(), "Công nhân", CN.layNgayCong(), CN.TienLuong().ToString("#,##"));
                                }
                                if (rdoQuanLy.Checked == true)
                                {
                                    QuanLy QL = new QuanLy(txtMaSo.Text, txtHoTen.Text, SoNgayCong);
                                    txtThanhTien.Text = QL.TienLuong().ToString("#,##");
                                    dgvThongTinNV.Rows.Insert(dgvThongTinNV.CurrentRow.Index, QL.layMSNV(), QL.layHoTen(), "Quản lý", QL.layNgayCong(), QL.TienLuong().ToString("#,##"));
                                }
                                btnChinhSua.Enabled = false;
                                btnXoa.Enabled = false;
                            }
                        }
                    }
                }
            }
        }
    }
}
