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
            this.txtGioLapHoaDon = new System.Windows.Forms.TextBox();
            this.lblGioHoaDon = new System.Windows.Forms.Label();
            this.txtNgayHoaDon = new System.Windows.Forms.TextBox();
            this.lblNgayHoaDon = new System.Windows.Forms.Label();
            this.txtTenKhachHang = new System.Windows.Forms.TextBox();
            this.lblTenKhachHang = new System.Windows.Forms.Label();
            this.txtMaHoaDon = new System.Windows.Forms.TextBox();
            this.lblMaHoaDon = new System.Windows.Forms.Label();
            this.btnThemHoaDon = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDienThongTin
            // 
            this.lblDienThongTin.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblDienThongTin.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDienThongTin.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.lblDienThongTin.Location = new System.Drawing.Point(0, 0);
            this.lblDienThongTin.Name = "lblDienThongTin";
            this.lblDienThongTin.Size = new System.Drawing.Size(745, 78);
            this.lblDienThongTin.TabIndex = 38;
            this.lblDienThongTin.Text = "Vui lòng điền thông tin";
            this.lblDienThongTin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtDonGia
            // 
            this.txtDonGia.BackColor = System.Drawing.Color.LightSeaGreen;
            this.txtDonGia.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDonGia.ForeColor = System.Drawing.Color.White;
            this.txtDonGia.Location = new System.Drawing.Point(253, 519);
            this.txtDonGia.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDonGia.Multiline = true;
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(444, 50);
            this.txtDonGia.TabIndex = 28;
            this.txtDonGia.Leave += new System.EventHandler(this.txtDonGia_Leave);
            // 
            // lblDonGia
            // 
            this.lblDonGia.AutoSize = true;
            this.lblDonGia.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDonGia.Location = new System.Drawing.Point(26, 505);
            this.lblDonGia.Name = "lblDonGia";
            this.lblDonGia.Size = new System.Drawing.Size(105, 27);
            this.lblDonGia.TabIndex = 36;
            this.lblDonGia.Text = "Đơn giá:";
            // 
            // txtGioLapHoaDon
            // 
            this.txtGioLapHoaDon.BackColor = System.Drawing.Color.LightSeaGreen;
            this.txtGioLapHoaDon.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGioLapHoaDon.ForeColor = System.Drawing.Color.White;
            this.txtGioLapHoaDon.Location = new System.Drawing.Point(253, 412);
            this.txtGioLapHoaDon.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtGioLapHoaDon.Multiline = true;
            this.txtGioLapHoaDon.Name = "txtGioLapHoaDon";
            this.txtGioLapHoaDon.Size = new System.Drawing.Size(444, 50);
            this.txtGioLapHoaDon.TabIndex = 27;
            this.txtGioLapHoaDon.Leave += new System.EventHandler(this.txtGioLapHoaDon_Leave);
            // 
            // lblGioHoaDon
            // 
            this.lblGioHoaDon.AutoSize = true;
            this.lblGioHoaDon.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGioHoaDon.Location = new System.Drawing.Point(26, 416);
            this.lblGioHoaDon.Name = "lblGioHoaDon";
            this.lblGioHoaDon.Size = new System.Drawing.Size(192, 27);
            this.lblGioHoaDon.TabIndex = 37;
            this.lblGioHoaDon.Text = "Giờ lập hoá đơn:";
            // 
            // txtNgayHoaDon
            // 
            this.txtNgayHoaDon.BackColor = System.Drawing.Color.LightSeaGreen;
            this.txtNgayHoaDon.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNgayHoaDon.ForeColor = System.Drawing.Color.White;
            this.txtNgayHoaDon.Location = new System.Drawing.Point(253, 310);
            this.txtNgayHoaDon.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNgayHoaDon.Multiline = true;
            this.txtNgayHoaDon.Name = "txtNgayHoaDon";
            this.txtNgayHoaDon.Size = new System.Drawing.Size(444, 50);
            this.txtNgayHoaDon.TabIndex = 26;
            this.txtNgayHoaDon.Leave += new System.EventHandler(this.txtNgayHoaDon_Leave);
            // 
            // lblNgayHoaDon
            // 
            this.lblNgayHoaDon.AutoSize = true;
            this.lblNgayHoaDon.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgayHoaDon.Location = new System.Drawing.Point(26, 314);
            this.lblNgayHoaDon.Name = "lblNgayHoaDon";
            this.lblNgayHoaDon.Size = new System.Drawing.Size(212, 27);
            this.lblNgayHoaDon.TabIndex = 34;
            this.lblNgayHoaDon.Text = "Ngày lập hoá đơn:";
            // 
            // txtTenKhachHang
            // 
            this.txtTenKhachHang.BackColor = System.Drawing.Color.LightSeaGreen;
            this.txtTenKhachHang.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenKhachHang.ForeColor = System.Drawing.Color.White;
            this.txtTenKhachHang.Location = new System.Drawing.Point(253, 204);
            this.txtTenKhachHang.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTenKhachHang.Multiline = true;
            this.txtTenKhachHang.Name = "txtTenKhachHang";
            this.txtTenKhachHang.Size = new System.Drawing.Size(444, 50);
            this.txtTenKhachHang.TabIndex = 25;
            this.txtTenKhachHang.Leave += new System.EventHandler(this.txtTenKhachHang_Leave);
            // 
            // lblTenKhachHang
            // 
            this.lblTenKhachHang.AutoSize = true;
            this.lblTenKhachHang.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenKhachHang.Location = new System.Drawing.Point(26, 208);
            this.lblTenKhachHang.Name = "lblTenKhachHang";
            this.lblTenKhachHang.Size = new System.Drawing.Size(193, 27);
            this.lblTenKhachHang.TabIndex = 33;
            this.lblTenKhachHang.Text = "Tên khách hàng:";
            // 
            // txtMaHoaDon
            // 
            this.txtMaHoaDon.BackColor = System.Drawing.Color.LightSeaGreen;
            this.txtMaHoaDon.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaHoaDon.ForeColor = System.Drawing.Color.White;
            this.txtMaHoaDon.Location = new System.Drawing.Point(253, 106);
            this.txtMaHoaDon.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMaHoaDon.Multiline = true;
            this.txtMaHoaDon.Name = "txtMaHoaDon";
            this.txtMaHoaDon.Size = new System.Drawing.Size(444, 50);
            this.txtMaHoaDon.TabIndex = 24;
            this.txtMaHoaDon.Leave += new System.EventHandler(this.txtMaHoaDon_Leave);
            // 
            // lblMaHoaDon
            // 
            this.lblMaHoaDon.AutoSize = true;
            this.lblMaHoaDon.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaHoaDon.Location = new System.Drawing.Point(30, 110);
            this.lblMaHoaDon.Name = "lblMaHoaDon";
            this.lblMaHoaDon.Size = new System.Drawing.Size(148, 27);
            this.lblMaHoaDon.TabIndex = 32;
            this.lblMaHoaDon.Text = "Mã hoá đơn:";
            // 
            // btnThemHoaDon
            // 
            this.btnThemHoaDon.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnThemHoaDon.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemHoaDon.ForeColor = System.Drawing.Color.White;
            this.btnThemHoaDon.Location = new System.Drawing.Point(392, 612);
            this.btnThemHoaDon.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnThemHoaDon.Name = "btnThemHoaDon";
            this.btnThemHoaDon.Size = new System.Drawing.Size(306, 62);
            this.btnThemHoaDon.TabIndex = 39;
            this.btnThemHoaDon.Text = "THÊM CHI TIẾT";
            this.btnThemHoaDon.UseVisualStyleBackColor = false;
            this.btnThemHoaDon.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmHoaDonThemMoi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(745, 709);
            this.Controls.Add(this.btnThemHoaDon);
            this.Controls.Add(this.lblDienThongTin);
            this.Controls.Add(this.txtDonGia);
            this.Controls.Add(this.lblDonGia);
            this.Controls.Add(this.txtGioLapHoaDon);
            this.Controls.Add(this.lblGioHoaDon);
            this.Controls.Add(this.txtNgayHoaDon);
            this.Controls.Add(this.lblNgayHoaDon);
            this.Controls.Add(this.txtTenKhachHang);
            this.Controls.Add(this.lblTenKhachHang);
            this.Controls.Add(this.txtMaHoaDon);
            this.Controls.Add(this.lblMaHoaDon);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmHoaDonThemMoi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HoaDonThemMoi";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDienThongTin;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.Label lblDonGia;
        private System.Windows.Forms.TextBox txtGioLapHoaDon;
        private System.Windows.Forms.Label lblGioHoaDon;
        private System.Windows.Forms.TextBox txtNgayHoaDon;
        private System.Windows.Forms.Label lblNgayHoaDon;
        private System.Windows.Forms.TextBox txtTenKhachHang;
        private System.Windows.Forms.Label lblTenKhachHang;
        private System.Windows.Forms.TextBox txtMaHoaDon;
        private System.Windows.Forms.Label lblMaHoaDon;
        private System.Windows.Forms.Button btnThemHoaDon;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}