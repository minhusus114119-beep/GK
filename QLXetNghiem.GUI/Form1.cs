using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using QLXetNghiem.BUS;      // ← Đảm bảo có 2 BUS
using QLXetNghiem.DAL.Model;

namespace QLXetNghiem.GUI
{
    public partial class Form1 : Form
    {
        private readonly NHANVIENBUS _nhanVienBus = new NHANVIENBUS();
        private readonly CONGTY _congTyBus = new CONGTY();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            // ✅ DÙNG ĐÚNG SERVICE
            var list = _nhanVienBus.GetAllNhanVien();
            // ✅ SỬA BindGrid ĐỂ NHẬN dynamic
            dgvNhanVien.DataSource = list;

            // ✅ DÙNG CongTyBUS CHO CÔNG TY
            cboCongTy.DataSource = _congTyBus.GetAllCongTy();
            cboCongTy.DisplayMember = "TenCty";
            cboCongTy.ValueMember = "MaCty";

            ResetForm();
        }


        private void btnTim_Click(object sender, EventArgs e)
        {
            string id = txtCCCD.Text.Trim();

            if (id.Length != 9 && id.Length != 12)
            {
                MessageBox.Show("Vui lòng nhập CCCD hoặc CMND (9 hoặc 12 ký tự số).", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!id.All(char.IsDigit))
            {
                MessageBox.Show("ID chỉ là các ký tự số.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // ✅ GỌI ĐÚNG PHƯƠNG THỨC
            var nhanVien = _nhanVienBus.FindById(id);
            grpThongTinXetNghiem.Enabled = false;

            if (nhanVien == null)
            {
                txtHoTen.Clear();
                txtSoLanXN.Text = "1";
                radioButton1.Checked = true;
                if (cboCongTy.Items.Count > 0)
                    cboCongTy.SelectedIndex = 0;
            }
            else
            {
                txtHoTen.Text = nhanVien.HoTen;
                txtSoLanXN.Text = (nhanVien.SoLanXN + 1).ToString();
                radioButton1.Checked = nhanVien.AmTinh;
                radioButton2.Checked = !nhanVien.AmTinh;
                cboCongTy.SelectedValue = nhanVien.MaCty;
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            string id = txtCCCD.Text.Trim();
            string hoTen = txtHoTen.Text.Trim();
            if (string.IsNullOrWhiteSpace(hoTen))
            {
                MessageBox.Show("Vui lòng nhập họ tên.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int soLanXN;
            if (!int.TryParse(txtSoLanXN.Text, out soLanXN) || soLanXN < 1)
            {
                MessageBox.Show("Số lần xét nghiệm không hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            bool amTinh = radioButton1.Checked;
            string maCty = cboCongTy.SelectedValue?.ToString();

            if (string.IsNullOrEmpty(maCty))
            {
                MessageBox.Show("Vui lòng chọn công ty.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var nhanVien = new NHANVIEN
            {
                ID = id,
                HoTen = hoTen,
                SoLanXN = soLanXN,
                AmTinh = amTinh,
                MaCty = maCty
            };

            // ✅ GỌI ĐÚNG PHƯƠNG THỨC
            var existing = _nhanVienBus.FindById(id);
            _nhanVienBus.InsertOrUpdate(nhanVien);

            MessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadData();
        }

        private void ResetForm()
        {
            grpThongTinXetNghiem.Enabled = false;
            txtCCCD.Clear();
            txtHoTen.Clear();
            txtSoLanXN.Clear();
            radioButton1.Checked = true;
            if (cboCongTy.Items.Count > 0)
                cboCongTy.SelectedIndex = 0;
        }

        private void danhSachDuongTinhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var list = _nhanVienBus.GetListDuongTinh();
            dgvNhanVien.DataSource = list;
        }

        private void congTyDaTestDuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var list = _congTyBus.GetCongTyDaTestDu(); 
            if (list.Count == 0)
            {
                MessageBox.Show("Không có công ty nào đã test đủ yêu cầu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string msg = "Danh sách công ty đã tham gia test đủ theo yêu cầu:\n\n";
            for (int i = 0; i < list.Count; i++)
            {
                msg += $"{i + 1}. {list[i].TenCty}\n";
            }
            MessageBox.Show(msg, "Công ty đủ điều kiện", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void grpThongTinXetNghiem_Enter(object sender, EventArgs e)
        {

        }
    }
}