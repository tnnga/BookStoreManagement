namespace kthp
{
    partial class frmHoaDonThemMoi
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
            this.components = new System.ComponentModel.Container();
            this.lblDienThongTin = new System.Windows.Forms.Label();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.lblDonGia = new System.Windows.Forms.Label();
            this.btnThemHoaDon = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnHoanTatThemHoaDon = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtGioLapHoaDon = new System.Windows.Forms.TextBox();
            this.lblGioHoaDon = new System.Windows.Forms.Label();
            this.txtNgayHoaDon = new System.Windows.Forms.TextBox();
            this.lblNgayHoaDon = new System.Windows.Forms.Label();
            this.txtMaKhachHang = new System.Windows.Forms.TextBox();
            this.lblMaKhachHang = new System.Windows.Forms.Label();
            this.txtMaHoaDon = new System.Windows.Forms.TextBox();
            this.lblMaHoaDon = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblChiTietHoaDon = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnHoanTat = new System.Windows.Forms.Button();
            this.btnThemChiTiet = new System.Windows.Forms.Button();
            this.dgwHoaDonThemChiTiet = new System.Windows.Forms.DataGridView();
            this.dgwThanhTien = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwHoaDonThemChiTiet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwThanhTien)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDienThongTin
            // 
            this.lblDienThongTin.BackColor = System.Drawing.Color.LightSeaGreen;
            this.lblDienThongTin.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblDienThongTin.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDienThongTin.ForeColor = System.Drawing.Color.White;
            this.lblDienThongTin.Location = new System.Drawing.Point(0, 0);
            this.lblDienThongTin.Name = "lblDienThongTin";
            this.lblDienThongTin.Size = new System.Drawing.Size(1366, 126);
            this.lblDienThongTin.TabIndex = 0;
            this.lblDienThongTin.Text = "VUI LÒNG ĐIỀN THÔNG TIN";
            this.lblDienThongTin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblDienThongTin.Click += new System.EventHandler(this.lblDienThongTin_Click);
            // 
            // txtDonGia
            // 
            this.txtDonGia.BackColor = System.Drawing.Color.White;
            this.txtDonGia.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDonGia.ForeColor = System.Drawing.Color.Black;
            this.txtDonGia.Location = new System.Drawing.Point(205, 67);
            this.txtDonGia.Multiline = true;
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(395, 44);
            this.txtDonGia.TabIndex = 1;
            // 
            // lblDonGia
            // 
            this.lblDonGia.AutoSize = true;
            this.lblDonGia.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDonGia.ForeColor = System.Drawing.Color.White;
            this.lblDonGia.Location = new System.Drawing.Point(41, 70);
            this.lblDonGia.Name = "lblDonGia";
            this.lblDonGia.Size = new System.Drawing.Size(119, 23);
            this.lblDonGia.TabIndex = 0;
            this.lblDonGia.Text = "Thành tiền:";
            // 
            // btnThemHoaDon
            // 
            this.btnThemHoaDon.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnThemHoaDon.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemHoaDon.ForeColor = System.Drawing.Color.White;
            this.btnThemHoaDon.Location = new System.Drawing.Point(380, 345);
            this.btnThemHoaDon.Name = "btnThemHoaDon";
            this.btnThemHoaDon.Size = new System.Drawing.Size(220, 57);
            this.btnThemHoaDon.TabIndex = 8;
            this.btnThemHoaDon.Text = "THÊM CHI TIẾT";
            this.btnThemHoaDon.UseVisualStyleBackColor = false;
            this.btnThemHoaDon.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgwThanhTien);
            this.panel1.Controls.Add(this.txtDonGia);
            this.panel1.Controls.Add(this.lblDonGia);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 543);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1366, 160);
            this.panel1.TabIndex = 4;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btnHoanTatThemHoaDon);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel5.Location = new System.Drawing.Point(872, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(494, 160);
            this.panel5.TabIndex = 2;
            // 
            // btnHoanTatThemHoaDon
            // 
            this.btnHoanTatThemHoaDon.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnHoanTatThemHoaDon.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHoanTatThemHoaDon.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnHoanTatThemHoaDon.Location = new System.Drawing.Point(73, 47);
            this.btnHoanTatThemHoaDon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnHoanTatThemHoaDon.Name = "btnHoanTatThemHoaDon";
            this.btnHoanTatThemHoaDon.Size = new System.Drawing.Size(399, 85);
            this.btnHoanTatThemHoaDon.TabIndex = 1;
            this.btnHoanTatThemHoaDon.Text = "HOÀN TẤT THÊM HOÁ ĐƠN";
            this.btnHoanTatThemHoaDon.UseVisualStyleBackColor = false;
            this.btnHoanTatThemHoaDon.Click += new System.EventHandler(this.btnHoanTatThemHoaDon_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtGioLapHoaDon);
            this.panel2.Controls.Add(this.lblGioHoaDon);
            this.panel2.Controls.Add(this.btnThemHoaDon);
            this.panel2.Controls.Add(this.txtNgayHoaDon);
            this.panel2.Controls.Add(this.lblNgayHoaDon);
            this.panel2.Controls.Add(this.txtMaKhachHang);
            this.panel2.Controls.Add(this.lblMaKhachHang);
            this.panel2.Controls.Add(this.txtMaHoaDon);
            this.panel2.Controls.Add(this.lblMaHoaDon);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 126);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(644, 417);
            this.panel2.TabIndex = 1;
            // 
            // txtGioLapHoaDon
            // 
            this.txtGioLapHoaDon.BackColor = System.Drawing.Color.White;
            this.txtGioLapHoaDon.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGioLapHoaDon.ForeColor = System.Drawing.Color.Black;
            this.txtGioLapHoaDon.Location = new System.Drawing.Point(214, 277);
            this.txtGioLapHoaDon.Multiline = true;
            this.txtGioLapHoaDon.Name = "txtGioLapHoaDon";
            this.txtGioLapHoaDon.Size = new System.Drawing.Size(395, 41);
            this.txtGioLapHoaDon.TabIndex = 7;
            // 
            // lblGioHoaDon
            // 
            this.lblGioHoaDon.AutoSize = true;
            this.lblGioHoaDon.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGioHoaDon.ForeColor = System.Drawing.Color.White;
            this.lblGioHoaDon.Location = new System.Drawing.Point(12, 280);
            this.lblGioHoaDon.Name = "lblGioHoaDon";
            this.lblGioHoaDon.Size = new System.Drawing.Size(167, 23);
            this.lblGioHoaDon.TabIndex = 6;
            this.lblGioHoaDon.Text = "Giờ lập hoá đơn:";
            // 
            // txtNgayHoaDon
            // 
            this.txtNgayHoaDon.BackColor = System.Drawing.Color.White;
            this.txtNgayHoaDon.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNgayHoaDon.ForeColor = System.Drawing.Color.Black;
            this.txtNgayHoaDon.Location = new System.Drawing.Point(214, 195);
            this.txtNgayHoaDon.Multiline = true;
            this.txtNgayHoaDon.Name = "txtNgayHoaDon";
            this.txtNgayHoaDon.Size = new System.Drawing.Size(395, 41);
            this.txtNgayHoaDon.TabIndex = 5;
            // 
            // lblNgayHoaDon
            // 
            this.lblNgayHoaDon.AutoSize = true;
            this.lblNgayHoaDon.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgayHoaDon.ForeColor = System.Drawing.Color.White;
            this.lblNgayHoaDon.Location = new System.Drawing.Point(12, 198);
            this.lblNgayHoaDon.Name = "lblNgayHoaDon";
            this.lblNgayHoaDon.Size = new System.Drawing.Size(184, 23);
            this.lblNgayHoaDon.TabIndex = 4;
            this.lblNgayHoaDon.Text = "Ngày lập hoá đơn:";
            // 
            // txtMaKhachHang
            // 
            this.txtMaKhachHang.BackColor = System.Drawing.Color.White;
            this.txtMaKhachHang.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaKhachHang.ForeColor = System.Drawing.Color.Black;
            this.txtMaKhachHang.Location = new System.Drawing.Point(214, 113);
            this.txtMaKhachHang.Multiline = true;
            this.txtMaKhachHang.Name = "txtMaKhachHang";
            this.txtMaKhachHang.Size = new System.Drawing.Size(395, 41);
            this.txtMaKhachHang.TabIndex = 3;
            // 
            // lblMaKhachHang
            // 
            this.lblMaKhachHang.AutoSize = true;
            this.lblMaKhachHang.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaKhachHang.ForeColor = System.Drawing.Color.White;
            this.lblMaKhachHang.Location = new System.Drawing.Point(12, 113);
            this.lblMaKhachHang.Name = "lblMaKhachHang";
            this.lblMaKhachHang.Size = new System.Drawing.Size(160, 23);
            this.lblMaKhachHang.TabIndex = 2;
            this.lblMaKhachHang.Text = "Mã khách hàng:";
            // 
            // txtMaHoaDon
            // 
            this.txtMaHoaDon.BackColor = System.Drawing.Color.White;
            this.txtMaHoaDon.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaHoaDon.ForeColor = System.Drawing.Color.Black;
            this.txtMaHoaDon.Location = new System.Drawing.Point(214, 32);
            this.txtMaHoaDon.Multiline = true;
            this.txtMaHoaDon.Name = "txtMaHoaDon";
            this.txtMaHoaDon.Size = new System.Drawing.Size(395, 41);
            this.txtMaHoaDon.TabIndex = 1;
            // 
            // lblMaHoaDon
            // 
            this.lblMaHoaDon.AutoSize = true;
            this.lblMaHoaDon.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaHoaDon.ForeColor = System.Drawing.Color.White;
            this.lblMaHoaDon.Location = new System.Drawing.Point(16, 35);
            this.lblMaHoaDon.Name = "lblMaHoaDon";
            this.lblMaHoaDon.Size = new System.Drawing.Size(128, 23);
            this.lblMaHoaDon.TabIndex = 0;
            this.lblMaHoaDon.Text = "Mã hoá đơn:";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.lblChiTietHoaDon);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(644, 126);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(722, 73);
            this.panel4.TabIndex = 45;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Tahoma", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(391, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(331, 73);
            this.label1.TabIndex = 1;
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblChiTietHoaDon
            // 
            this.lblChiTietHoaDon.BackColor = System.Drawing.Color.LightSeaGreen;
            this.lblChiTietHoaDon.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblChiTietHoaDon.Font = new System.Drawing.Font("Tahoma", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChiTietHoaDon.ForeColor = System.Drawing.Color.White;
            this.lblChiTietHoaDon.Location = new System.Drawing.Point(0, 0);
            this.lblChiTietHoaDon.Name = "lblChiTietHoaDon";
            this.lblChiTietHoaDon.Size = new System.Drawing.Size(391, 73);
            this.lblChiTietHoaDon.TabIndex = 0;
            this.lblChiTietHoaDon.Text = "CHI TIẾT HÓA ĐƠN";
            this.lblChiTietHoaDon.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnHoanTat);
            this.panel3.Controls.Add(this.btnThemChiTiet);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(644, 453);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(722, 90);
            this.panel3.TabIndex = 46;
            // 
            // btnHoanTat
            // 
            this.btnHoanTat.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnHoanTat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnHoanTat.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHoanTat.ForeColor = System.Drawing.Color.White;
            this.btnHoanTat.Location = new System.Drawing.Point(228, 0);
            this.btnHoanTat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnHoanTat.Name = "btnHoanTat";
            this.btnHoanTat.Size = new System.Drawing.Size(494, 90);
            this.btnHoanTat.TabIndex = 1;
            this.btnHoanTat.Text = "HOÀN THÀNH THÊM CHI TIẾT";
            this.btnHoanTat.UseVisualStyleBackColor = false;
            this.btnHoanTat.Click += new System.EventHandler(this.btnHoanTat_Click);
            // 
            // btnThemChiTiet
            // 
            this.btnThemChiTiet.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnThemChiTiet.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnThemChiTiet.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemChiTiet.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnThemChiTiet.Location = new System.Drawing.Point(0, 0);
            this.btnThemChiTiet.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThemChiTiet.Name = "btnThemChiTiet";
            this.btnThemChiTiet.Size = new System.Drawing.Size(228, 90);
            this.btnThemChiTiet.TabIndex = 0;
            this.btnThemChiTiet.Text = "THÊM";
            this.btnThemChiTiet.UseVisualStyleBackColor = false;
            this.btnThemChiTiet.Click += new System.EventHandler(this.btnThemChiTiet_Click);
            // 
            // dgwHoaDonThemChiTiet
            // 
            this.dgwHoaDonThemChiTiet.BackgroundColor = System.Drawing.Color.LightSeaGreen;
            this.dgwHoaDonThemChiTiet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwHoaDonThemChiTiet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgwHoaDonThemChiTiet.Location = new System.Drawing.Point(644, 199);
            this.dgwHoaDonThemChiTiet.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgwHoaDonThemChiTiet.Name = "dgwHoaDonThemChiTiet";
            this.dgwHoaDonThemChiTiet.RowHeadersWidth = 62;
            this.dgwHoaDonThemChiTiet.RowTemplate.Height = 28;
            this.dgwHoaDonThemChiTiet.Size = new System.Drawing.Size(722, 254);
            this.dgwHoaDonThemChiTiet.TabIndex = 2;
            this.dgwHoaDonThemChiTiet.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwHoaDonThemChiTiet_CellContentClick);
            // 
            // dgwThanhTien
            // 
            this.dgwThanhTien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwThanhTien.Location = new System.Drawing.Point(644, 83);
            this.dgwThanhTien.Name = "dgwThanhTien";
            this.dgwThanhTien.RowHeadersWidth = 51;
            this.dgwThanhTien.RowTemplate.Height = 24;
            this.dgwThanhTien.Size = new System.Drawing.Size(10, 10);
            this.dgwThanhTien.TabIndex = 47;
            this.dgwThanhTien.Visible = false;
            // 
            // frmHoaDonThemMoi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(1366, 703);
            this.Controls.Add(this.dgwHoaDonThemChiTiet);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblDienThongTin);
            this.Name = "frmHoaDonThemMoi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HoaDonThemMoi";
            this.Load += new System.EventHandler(this.frmHoaDonThemMoi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgwHoaDonThemChiTiet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwThanhTien)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblDienThongTin;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.Label lblDonGia;
        private System.Windows.Forms.Button btnThemHoaDon;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txtGioLapHoaDon;
        private System.Windows.Forms.Label lblGioHoaDon;
        private System.Windows.Forms.TextBox txtNgayHoaDon;
        private System.Windows.Forms.Label lblNgayHoaDon;
        private System.Windows.Forms.TextBox txtMaKhachHang;
        private System.Windows.Forms.Label lblMaKhachHang;
        private System.Windows.Forms.TextBox txtMaHoaDon;
        private System.Windows.Forms.Label lblMaHoaDon;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblChiTietHoaDon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgwHoaDonThemChiTiet;
        private System.Windows.Forms.Button btnHoanTat;
        private System.Windows.Forms.Button btnThemChiTiet;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnHoanTatThemHoaDon;
        private System.Windows.Forms.DataGridView dgwThanhTien;
    }
}