namespace QLXetNghiem.GUI
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.danhSachDuongTinhToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.congTyDaTestDuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xuatBaoCaoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCCCD = new System.Windows.Forms.TextBox();
            this.btnTim = new System.Windows.Forms.Button();
            this.grpThongTinXetNghiem = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.cboCongTy = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSoLanXN = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.dgvNhanVien = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.menuStrip1.SuspendLayout();
            this.grpThongTinXetNghiem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.danhSachDuongTinhToolStripMenuItem,
            this.congTyDaTestDuToolStripMenuItem,
            this.xuatBaoCaoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1215, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // danhSachDuongTinhToolStripMenuItem
            // 
            this.danhSachDuongTinhToolStripMenuItem.Name = "danhSachDuongTinhToolStripMenuItem";
            this.danhSachDuongTinhToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F1)));
            this.danhSachDuongTinhToolStripMenuItem.Size = new System.Drawing.Size(168, 24);
            this.danhSachDuongTinhToolStripMenuItem.Text = "Danh sách dương tính";
            this.danhSachDuongTinhToolStripMenuItem.Click += new System.EventHandler(this.danhSachDuongTinhToolStripMenuItem_Click);
            // 
            // congTyDaTestDuToolStripMenuItem
            // 
            this.congTyDaTestDuToolStripMenuItem.Name = "congTyDaTestDuToolStripMenuItem";
            this.congTyDaTestDuToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F2;
            this.congTyDaTestDuToolStripMenuItem.Size = new System.Drawing.Size(198, 24);
            this.congTyDaTestDuToolStripMenuItem.Text = "Công ty đã test đủ yêu cầu";
            this.congTyDaTestDuToolStripMenuItem.Click += new System.EventHandler(this.congTyDaTestDuToolStripMenuItem_Click);
            // 
            // xuatBaoCaoToolStripMenuItem
            // 
            this.xuatBaoCaoToolStripMenuItem.Name = "xuatBaoCaoToolStripMenuItem";
            this.xuatBaoCaoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.xuatBaoCaoToolStripMenuItem.Size = new System.Drawing.Size(111, 24);
            this.xuatBaoCaoToolStripMenuItem.Text = "Xuất báo cáo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 48);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "CCCD/CMND:";
            // 
            // txtCCCD
            // 
            this.txtCCCD.Location = new System.Drawing.Point(103, 45);
            this.txtCCCD.Margin = new System.Windows.Forms.Padding(4);
            this.txtCCCD.Name = "txtCCCD";
            this.txtCCCD.Size = new System.Drawing.Size(199, 22);
            this.txtCCCD.TabIndex = 2;
            // 
            // btnTim
            // 
            this.btnTim.Location = new System.Drawing.Point(330, 42);
            this.btnTim.Margin = new System.Windows.Forms.Padding(4);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(100, 28);
            this.btnTim.TabIndex = 3;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // grpThongTinXetNghiem
            // 
            this.grpThongTinXetNghiem.Controls.Add(this.radioButton2);
            this.grpThongTinXetNghiem.Controls.Add(this.radioButton1);
            this.grpThongTinXetNghiem.Controls.Add(this.cboCongTy);
            this.grpThongTinXetNghiem.Controls.Add(this.label5);
            this.grpThongTinXetNghiem.Controls.Add(this.txtSoLanXN);
            this.grpThongTinXetNghiem.Controls.Add(this.label4);
            this.grpThongTinXetNghiem.Controls.Add(this.txtHoTen);
            this.grpThongTinXetNghiem.Controls.Add(this.label3);
            this.grpThongTinXetNghiem.Controls.Add(this.label2);
            this.grpThongTinXetNghiem.Controls.Add(this.btnCapNhat);
            this.grpThongTinXetNghiem.Enabled = false;
            this.grpThongTinXetNghiem.Location = new System.Drawing.Point(29, 238);
            this.grpThongTinXetNghiem.Margin = new System.Windows.Forms.Padding(4);
            this.grpThongTinXetNghiem.Name = "grpThongTinXetNghiem";
            this.grpThongTinXetNghiem.Padding = new System.Windows.Forms.Padding(4);
            this.grpThongTinXetNghiem.Size = new System.Drawing.Size(410, 222);
            this.grpThongTinXetNghiem.TabIndex = 4;
            this.grpThongTinXetNghiem.TabStop = false;
            this.grpThongTinXetNghiem.Text = "Thông tin xét nghiệm";
            this.grpThongTinXetNghiem.Enter += new System.EventHandler(this.grpThongTinXetNghiem_Enter);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(216, 90);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(97, 20);
            this.radioButton2.TabIndex = 11;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Dương Tính";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(120, 92);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(77, 20);
            this.radioButton1.TabIndex = 10;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Âm Tính";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // cboCongTy
            // 
            this.cboCongTy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCongTy.FormattingEnabled = true;
            this.cboCongTy.Location = new System.Drawing.Point(120, 135);
            this.cboCongTy.Margin = new System.Windows.Forms.Padding(4);
            this.cboCongTy.Name = "cboCongTy";
            this.cboCongTy.Size = new System.Drawing.Size(212, 24);
            this.cboCongTy.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 135);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Công ty:";
            // 
            // txtSoLanXN
            // 
            this.txtSoLanXN.Location = new System.Drawing.Point(120, 55);
            this.txtSoLanXN.Margin = new System.Windows.Forms.Padding(4);
            this.txtSoLanXN.Name = "txtSoLanXN";
            this.txtSoLanXN.ReadOnly = true;
            this.txtSoLanXN.Size = new System.Drawing.Size(199, 22);
            this.txtSoLanXN.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 92);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Kết quả:";
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(120, 22);
            this.txtHoTen.Margin = new System.Windows.Forms.Padding(4);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(240, 22);
            this.txtHoTen.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 59);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Số lần xét nghiệm:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 26);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Họ và tên:";
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Location = new System.Drawing.Point(120, 186);
            this.btnCapNhat.Margin = new System.Windows.Forms.Padding(4);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(100, 28);
            this.btnCapNhat.TabIndex = 1;
            this.btnCapNhat.Text = "Cập nhật";
            this.btnCapNhat.UseVisualStyleBackColor = true;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // dgvNhanVien
            // 
            this.dgvNhanVien.AllowUserToAddRows = false;
            this.dgvNhanVien.AllowUserToDeleteRows = false;
            this.dgvNhanVien.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNhanVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dgvNhanVien.Location = new System.Drawing.Point(501, 165);
            this.dgvNhanVien.Margin = new System.Windows.Forms.Padding(4);
            this.dgvNhanVien.Name = "dgvNhanVien";
            this.dgvNhanVien.ReadOnly = true;
            this.dgvNhanVien.RowHeadersWidth = 51;
            this.dgvNhanVien.Size = new System.Drawing.Size(701, 295);
            this.dgvNhanVien.TabIndex = 5;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "CMND/CCCD";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Họ và Tên";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Số lần XN";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Kết Quả";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 125;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtCCCD);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnTim);
            this.groupBox1.Location = new System.Drawing.Point(29, 118);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(437, 100);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin nhân viên";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(294, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(438, 46);
            this.label6.TabIndex = 7;
            this.label6.Text = "Thông Tin Xét Nghiệm";
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1215, 554);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvNhanVien);
            this.Controls.Add(this.grpThongTinXetNghiem);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Quản lý xét nghiệm SAR-CoV2";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.grpThongTinXetNghiem.ResumeLayout(false);
            this.grpThongTinXetNghiem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem danhSachDuongTinhToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem congTyDaTestDuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xuatBaoCaoToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCCCD;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.GroupBox grpThongTinXetNghiem;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSoLanXN;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboCongTy;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvNhanVien;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
    }
}

