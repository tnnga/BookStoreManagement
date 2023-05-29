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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHoaDonThemMoi));
            this.lblDienThongTin = new System.Windows.Forms.Label();
            this.btnThemHoaDon = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.dgwThanhTien = new System.Windows.Forms.DataGridView();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.lblDonGia = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnHuyThemHoaDon = new System.Windows.Forms.Button();
            this.btnHoanTat = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnThemKhachHang = new System.Windows.Forms.Button();
            this.txtGioLapHoaDon = new System.Windows.Forms.MaskedTextBox();
            this.txtNgayHoaDon = new System.Windows.Forms.MaskedTextBox();
            this.btnThemChiTiet = new System.Windows.Forms.Button();
            this.lblGioHoaDon = new System.Windows.Forms.Label();
            this.lblNgayHoaDon = new System.Windows.Forms.Label();
            this.txtMaKhachHang = new System.Windows.Forms.TextBox();
            this.lblMaKhachHang = new System.Windows.Forms.Label();
            this.txtMaHoaDon = new System.Windows.Forms.TextBox();
            this.lblMaHoaDon = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblMaHoaDonChiTiet = new System.Windows.Forms.Label();
            this.lblChiTietHoaDon = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgwHoaDonThemChiTiet = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwThanhTien)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwHoaDonThemChiTiet)).BeginInit();
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
            this.lblDienThongTin.Size = new System.Drawing.Size(1538, 112);
            this.lblDienThongTin.TabIndex = 0;
            this.lblDienThongTin.Text = "VUI LÒNG ĐIỀN THÔNG TIN HOÁ ĐƠN";
            this.lblDienThongTin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnThemHoaDon
            // 
            this.btnThemHoaDon.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnThemHoaDon.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemHoaDon.ForeColor = System.Drawing.Color.White;
            this.btnThemHoaDon.Location = new System.Drawing.Point(25, 429);
            this.btnThemHoaDon.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnThemHoaDon.Name = "btnThemHoaDon";
            this.btnThemHoaDon.Size = new System.Drawing.Size(248, 71);
            this.btnThemHoaDon.TabIndex = 9;
            this.btnThemHoaDon.Text = "THÊM HOÁ ĐƠN";
            this.btnThemHoaDon.UseVisualStyleBackColor = false;
            this.btnThemHoaDon.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 630);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1538, 122);
            this.panel1.TabIndex = 4;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.dgwThanhTien);
            this.panel6.Controls.Add(this.txtDonGia);
            this.panel6.Controls.Add(this.lblDonGia);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(728, 122);
            this.panel6.TabIndex = 0;
            // 
            // dgwThanhTien
            // 
            this.dgwThanhTien.BackgroundColor = System.Drawing.Color.LightSeaGreen;
            this.dgwThanhTien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwThanhTien.GridColor = System.Drawing.Color.LightSeaGreen;
            this.dgwThanhTien.Location = new System.Drawing.Point(681, 54);
            this.dgwThanhTien.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgwThanhTien.Name = "dgwThanhTien";
            this.dgwThanhTien.RowHeadersWidth = 51;
            this.dgwThanhTien.RowTemplate.Height = 24;
            this.dgwThanhTien.Size = new System.Drawing.Size(1, 1);
            this.dgwThanhTien.TabIndex = 2;
            this.dgwThanhTien.Visible = false;
            // 
            // txtDonGia
            // 
            this.txtDonGia.BackColor = System.Drawing.Color.White;
            this.txtDonGia.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDonGia.ForeColor = System.Drawing.Color.Black;
            this.txtDonGia.Location = new System.Drawing.Point(194, 34);
            this.txtDonGia.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDonGia.Multiline = true;
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(444, 54);
            this.txtDonGia.TabIndex = 1;
            // 
            // lblDonGia
            // 
            this.lblDonGia.AutoSize = true;
            this.lblDonGia.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDonGia.ForeColor = System.Drawing.Color.White;
            this.lblDonGia.Location = new System.Drawing.Point(37, 38);
            this.lblDonGia.Name = "lblDonGia";
            this.lblDonGia.Size = new System.Drawing.Size(137, 27);
            this.lblDonGia.TabIndex = 0;
            this.lblDonGia.Text = "Thành tiền:";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btnHuyThemHoaDon);
            this.panel5.Controls.Add(this.btnHoanTat);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel5.Location = new System.Drawing.Point(728, 0);
            this.panel5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(810, 122);
            this.panel5.TabIndex = 2;
            // 
            // btnHuyThemHoaDon
            // 
            this.btnHuyThemHoaDon.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnHuyThemHoaDon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnHuyThemHoaDon.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuyThemHoaDon.ForeColor = System.Drawing.Color.White;
            this.btnHuyThemHoaDon.Location = new System.Drawing.Point(0, 0);
            this.btnHuyThemHoaDon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnHuyThemHoaDon.Name = "btnHuyThemHoaDon";
            this.btnHuyThemHoaDon.Size = new System.Drawing.Size(418, 122);
            this.btnHuyThemHoaDon.TabIndex = 0;
            this.btnHuyThemHoaDon.Text = "HUỶ THÊM HOÁ ĐƠN";
            this.btnHuyThemHoaDon.UseVisualStyleBackColor = false;
            this.btnHuyThemHoaDon.Click += new System.EventHandler(this.btnHuyThemHoaDon_Click);
            // 
            // btnHoanTat
            // 
            this.btnHoanTat.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnHoanTat.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnHoanTat.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHoanTat.ForeColor = System.Drawing.Color.White;
            this.btnHoanTat.Location = new System.Drawing.Point(418, 0);
            this.btnHoanTat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnHoanTat.Name = "btnHoanTat";
            this.btnHoanTat.Size = new System.Drawing.Size(392, 122);
            this.btnHoanTat.TabIndex = 1;
            this.btnHoanTat.Text = "HOÀN THÀNH THÊM HOÁ ĐƠN";
            this.btnHoanTat.UseVisualStyleBackColor = false;
            this.btnHoanTat.Click += new System.EventHandler(this.btnHoanTat_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnThemKhachHang);
            this.panel2.Controls.Add(this.txtGioLapHoaDon);
            this.panel2.Controls.Add(this.txtNgayHoaDon);
            this.panel2.Controls.Add(this.btnThemChiTiet);
            this.panel2.Controls.Add(this.lblGioHoaDon);
            this.panel2.Controls.Add(this.btnThemHoaDon);
            this.panel2.Controls.Add(this.lblNgayHoaDon);
            this.panel2.Controls.Add(this.txtMaKhachHang);
            this.panel2.Controls.Add(this.lblMaKhachHang);
            this.panel2.Controls.Add(this.txtMaHoaDon);
            this.panel2.Controls.Add(this.lblMaHoaDon);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 112);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(724, 518);
            this.panel2.TabIndex = 1;
            // 
            // btnThemKhachHang
            // 
            this.btnThemKhachHang.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnThemKhachHang.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemKhachHang.ForeColor = System.Drawing.Color.White;
            this.btnThemKhachHang.Location = new System.Drawing.Point(467, 120);
            this.btnThemKhachHang.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnThemKhachHang.Name = "btnThemKhachHang";
            this.btnThemKhachHang.Size = new System.Drawing.Size(218, 72);
            this.btnThemKhachHang.TabIndex = 4;
            this.btnThemKhachHang.Text = "THÊM KHÁCH HÀNG";
            this.btnThemKhachHang.UseVisualStyleBackColor = false;
            this.btnThemKhachHang.Click += new System.EventHandler(this.btnThemKhachHang_Click);
            // 
            // txtGioLapHoaDon
            // 
            this.txtGioLapHoaDon.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGioLapHoaDon.Location = new System.Drawing.Point(241, 345);
            this.txtGioLapHoaDon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtGioLapHoaDon.Mask = "00:00";
            this.txtGioLapHoaDon.Name = "txtGioLapHoaDon";
            this.txtGioLapHoaDon.Size = new System.Drawing.Size(444, 34);
            this.txtGioLapHoaDon.TabIndex = 8;
            this.txtGioLapHoaDon.ValidatingType = typeof(System.DateTime);
            this.txtGioLapHoaDon.Leave += new System.EventHandler(this.txtGioLapHoaDon_Leave);
            // 
            // txtNgayHoaDon
            // 
            this.txtNgayHoaDon.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNgayHoaDon.Location = new System.Drawing.Point(241, 239);
            this.txtNgayHoaDon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNgayHoaDon.Mask = "00-00-9999";
            this.txtNgayHoaDon.Name = "txtNgayHoaDon";
            this.txtNgayHoaDon.Size = new System.Drawing.Size(444, 34);
            this.txtNgayHoaDon.TabIndex = 6;
            this.txtNgayHoaDon.Leave += new System.EventHandler(this.txtNgayHoaDon_Leave);
            // 
            // btnThemChiTiet
            // 
            this.btnThemChiTiet.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnThemChiTiet.Enabled = false;
            this.btnThemChiTiet.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemChiTiet.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnThemChiTiet.Location = new System.Drawing.Point(291, 424);
            this.btnThemChiTiet.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThemChiTiet.Name = "btnThemChiTiet";
            this.btnThemChiTiet.Size = new System.Drawing.Size(394, 76);
            this.btnThemChiTiet.TabIndex = 10;
            this.btnThemChiTiet.Text = "THÊM CHI TIẾT HÓA ĐƠN";
            this.btnThemChiTiet.UseVisualStyleBackColor = false;
            this.btnThemChiTiet.Click += new System.EventHandler(this.btnThemChiTiet_Click);
            // 
            // lblGioHoaDon
            // 
            this.lblGioHoaDon.AutoSize = true;
            this.lblGioHoaDon.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGioHoaDon.ForeColor = System.Drawing.Color.White;
            this.lblGioHoaDon.Location = new System.Drawing.Point(14, 348);
            this.lblGioHoaDon.Name = "lblGioHoaDon";
            this.lblGioHoaDon.Size = new System.Drawing.Size(192, 27);
            this.lblGioHoaDon.TabIndex = 7;
            this.lblGioHoaDon.Text = "Giờ lập hoá đơn:";
            // 
            // lblNgayHoaDon
            // 
            this.lblNgayHoaDon.AutoSize = true;
            this.lblNgayHoaDon.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgayHoaDon.ForeColor = System.Drawing.Color.White;
            this.lblNgayHoaDon.Location = new System.Drawing.Point(14, 246);
            this.lblNgayHoaDon.Name = "lblNgayHoaDon";
            this.lblNgayHoaDon.Size = new System.Drawing.Size(212, 27);
            this.lblNgayHoaDon.TabIndex = 5;
            this.lblNgayHoaDon.Text = "Ngày lập hoá đơn:";
            // 
            // txtMaKhachHang
            // 
            this.txtMaKhachHang.BackColor = System.Drawing.Color.White;
            this.txtMaKhachHang.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaKhachHang.ForeColor = System.Drawing.Color.Black;
            this.txtMaKhachHang.Location = new System.Drawing.Point(241, 139);
            this.txtMaKhachHang.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMaKhachHang.Multiline = true;
            this.txtMaKhachHang.Name = "txtMaKhachHang";
            this.txtMaKhachHang.Size = new System.Drawing.Size(214, 43);
            this.txtMaKhachHang.TabIndex = 3;
            this.txtMaKhachHang.Leave += new System.EventHandler(this.txtTenKhachHang_Leave);
            // 
            // lblMaKhachHang
            // 
            this.lblMaKhachHang.AutoSize = true;
            this.lblMaKhachHang.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaKhachHang.ForeColor = System.Drawing.Color.White;
            this.lblMaKhachHang.Location = new System.Drawing.Point(14, 139);
            this.lblMaKhachHang.Name = "lblMaKhachHang";
            this.lblMaKhachHang.Size = new System.Drawing.Size(186, 27);
            this.lblMaKhachHang.TabIndex = 2;
            this.lblMaKhachHang.Text = "Mã khách hàng:";
            // 
            // txtMaHoaDon
            // 
            this.txtMaHoaDon.BackColor = System.Drawing.Color.White;
            this.txtMaHoaDon.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaHoaDon.ForeColor = System.Drawing.Color.Black;
            this.txtMaHoaDon.Location = new System.Drawing.Point(241, 38);
            this.txtMaHoaDon.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMaHoaDon.Multiline = true;
            this.txtMaHoaDon.Name = "txtMaHoaDon";
            this.txtMaHoaDon.Size = new System.Drawing.Size(444, 50);
            this.txtMaHoaDon.TabIndex = 1;
            this.txtMaHoaDon.Leave += new System.EventHandler(this.txtMaHoaDon_Leave);
            // 
            // lblMaHoaDon
            // 
            this.lblMaHoaDon.AutoSize = true;
            this.lblMaHoaDon.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaHoaDon.ForeColor = System.Drawing.Color.White;
            this.lblMaHoaDon.Location = new System.Drawing.Point(18, 42);
            this.lblMaHoaDon.Name = "lblMaHoaDon";
            this.lblMaHoaDon.Size = new System.Drawing.Size(148, 27);
            this.lblMaHoaDon.TabIndex = 0;
            this.lblMaHoaDon.Text = "Mã hoá đơn:";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.lblMaHoaDonChiTiet);
            this.panel4.Controls.Add(this.lblChiTietHoaDon);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(724, 112);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(814, 91);
            this.panel4.TabIndex = 45;
            // 
            // lblMaHoaDonChiTiet
            // 
            this.lblMaHoaDonChiTiet.BackColor = System.Drawing.Color.LightSeaGreen;
            this.lblMaHoaDonChiTiet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMaHoaDonChiTiet.Font = new System.Drawing.Font("Tahoma", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaHoaDonChiTiet.ForeColor = System.Drawing.Color.White;
            this.lblMaHoaDonChiTiet.Location = new System.Drawing.Point(440, 0);
            this.lblMaHoaDonChiTiet.Name = "lblMaHoaDonChiTiet";
            this.lblMaHoaDonChiTiet.Size = new System.Drawing.Size(374, 91);
            this.lblMaHoaDonChiTiet.TabIndex = 1;
            this.lblMaHoaDonChiTiet.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblChiTietHoaDon
            // 
            this.lblChiTietHoaDon.BackColor = System.Drawing.Color.LightSeaGreen;
            this.lblChiTietHoaDon.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblChiTietHoaDon.Font = new System.Drawing.Font("Tahoma", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChiTietHoaDon.ForeColor = System.Drawing.Color.White;
            this.lblChiTietHoaDon.Location = new System.Drawing.Point(0, 0);
            this.lblChiTietHoaDon.Name = "lblChiTietHoaDon";
            this.lblChiTietHoaDon.Size = new System.Drawing.Size(440, 91);
            this.lblChiTietHoaDon.TabIndex = 0;
            this.lblChiTietHoaDon.Text = "CHI TIẾT HÓA ĐƠN";
            this.lblChiTietHoaDon.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(724, 518);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(814, 112);
            this.panel3.TabIndex = 3;
            // 
            // dgwHoaDonThemChiTiet
            // 
            this.dgwHoaDonThemChiTiet.BackgroundColor = System.Drawing.Color.LightSeaGreen;
            this.dgwHoaDonThemChiTiet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwHoaDonThemChiTiet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgwHoaDonThemChiTiet.Location = new System.Drawing.Point(724, 203);
            this.dgwHoaDonThemChiTiet.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgwHoaDonThemChiTiet.Name = "dgwHoaDonThemChiTiet";
            this.dgwHoaDonThemChiTiet.RowHeadersWidth = 62;
            this.dgwHoaDonThemChiTiet.RowTemplate.Height = 28;
            this.dgwHoaDonThemChiTiet.Size = new System.Drawing.Size(814, 315);
            this.dgwHoaDonThemChiTiet.TabIndex = 2;
            this.dgwHoaDonThemChiTiet.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwHoaDonThemChiTiet_CellContentClick);
            // 
            // frmHoaDonThemMoi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(1538, 752);
            this.Controls.Add(this.dgwHoaDonThemChiTiet);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblDienThongTin);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmHoaDonThemMoi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phần mềm quản lí nhà sách";
            this.Load += new System.EventHandler(this.frmHoaDonThemMoi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwThanhTien)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgwHoaDonThemChiTiet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblDienThongTin;
        private System.Windows.Forms.Button btnThemHoaDon;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblGioHoaDon;
        private System.Windows.Forms.Label lblNgayHoaDon;
        private System.Windows.Forms.TextBox txtMaKhachHang;
        private System.Windows.Forms.Label lblMaKhachHang;
        private System.Windows.Forms.TextBox txtMaHoaDon;
        private System.Windows.Forms.Label lblMaHoaDon;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblChiTietHoaDon;
        private System.Windows.Forms.Label lblMaHoaDonChiTiet;
        private System.Windows.Forms.DataGridView dgwHoaDonThemChiTiet;
        private System.Windows.Forms.Button btnHoanTat;
        private System.Windows.Forms.Button btnThemChiTiet;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnHuyThemHoaDon;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.DataGridView dgwThanhTien;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.Label lblDonGia;
        private System.Windows.Forms.MaskedTextBox txtNgayHoaDon;
        private System.Windows.Forms.MaskedTextBox txtGioLapHoaDon;
        private System.Windows.Forms.Button btnThemKhachHang;
    }
}