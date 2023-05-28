namespace kthp
{
    partial class hoaDonCapNhat
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtMaHoaDon = new System.Windows.Forms.TextBox();
            this.lblCapNhatThongTinHoaDon = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dgwCapNhatChiTietHoaDon = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.chỉnhSửaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xóaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thêmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.lblGioHoaDon = new System.Windows.Forms.Label();
            this.lblNgayHoaDon = new System.Windows.Forms.Label();
            this.lblTenKhachHang = new System.Windows.Forms.Label();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.txtTenKhachHang = new System.Windows.Forms.TextBox();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.txtNgayHoaDon = new System.Windows.Forms.MaskedTextBox();
            this.txtGioHoaDon = new System.Windows.Forms.MaskedTextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwCapNhatChiTietHoaDon)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtMaHoaDon);
            this.panel1.Controls.Add(this.lblCapNhatThongTinHoaDon);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(10, 10);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1034, 100);
            this.panel1.TabIndex = 0;
            // 
            // txtMaHoaDon
            // 
            this.txtMaHoaDon.BackColor = System.Drawing.Color.PaleTurquoise;
            this.txtMaHoaDon.Enabled = false;
            this.txtMaHoaDon.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaHoaDon.ForeColor = System.Drawing.Color.White;
            this.txtMaHoaDon.Location = new System.Drawing.Point(839, 28);
            this.txtMaHoaDon.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMaHoaDon.Multiline = true;
            this.txtMaHoaDon.Name = "txtMaHoaDon";
            this.txtMaHoaDon.ReadOnly = true;
            this.txtMaHoaDon.Size = new System.Drawing.Size(167, 50);
            this.txtMaHoaDon.TabIndex = 7;
            // 
            // lblCapNhatThongTinHoaDon
            // 
            this.lblCapNhatThongTinHoaDon.AutoSize = true;
            this.lblCapNhatThongTinHoaDon.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCapNhatThongTinHoaDon.ForeColor = System.Drawing.Color.Azure;
            this.lblCapNhatThongTinHoaDon.Location = new System.Drawing.Point(143, 28);
            this.lblCapNhatThongTinHoaDon.Name = "lblCapNhatThongTinHoaDon";
            this.lblCapNhatThongTinHoaDon.Size = new System.Drawing.Size(517, 43);
            this.lblCapNhatThongTinHoaDon.TabIndex = 6;
            this.lblCapNhatThongTinHoaDon.Text = "Cập nhật thông tin hóa đơn";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.btnCapNhat);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(10, 110);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1034, 588);
            this.panel2.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.dgwCapNhatChiTietHoaDon);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 212);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1034, 302);
            this.panel4.TabIndex = 33;
            // 
            // dgwCapNhatChiTietHoaDon
            // 
            this.dgwCapNhatChiTietHoaDon.BackgroundColor = System.Drawing.Color.LightSeaGreen;
            this.dgwCapNhatChiTietHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwCapNhatChiTietHoaDon.ContextMenuStrip = this.contextMenuStrip1;
            this.dgwCapNhatChiTietHoaDon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgwCapNhatChiTietHoaDon.Location = new System.Drawing.Point(0, 0);
            this.dgwCapNhatChiTietHoaDon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgwCapNhatChiTietHoaDon.Name = "dgwCapNhatChiTietHoaDon";
            this.dgwCapNhatChiTietHoaDon.RowHeadersWidth = 62;
            this.dgwCapNhatChiTietHoaDon.RowTemplate.Height = 28;
            this.dgwCapNhatChiTietHoaDon.Size = new System.Drawing.Size(1034, 302);
            this.dgwCapNhatChiTietHoaDon.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chỉnhSửaToolStripMenuItem,
            this.xóaToolStripMenuItem,
            this.thêmToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(163, 100);
            // 
            // chỉnhSửaToolStripMenuItem
            // 
            this.chỉnhSửaToolStripMenuItem.Name = "chỉnhSửaToolStripMenuItem";
            this.chỉnhSửaToolStripMenuItem.Size = new System.Drawing.Size(162, 32);
            this.chỉnhSửaToolStripMenuItem.Text = "Chỉnh sửa";
            this.chỉnhSửaToolStripMenuItem.Click += new System.EventHandler(this.chinhSuaToolStripMenuItem_Click);
            // 
            // xóaToolStripMenuItem
            // 
            this.xóaToolStripMenuItem.Name = "xóaToolStripMenuItem";
            this.xóaToolStripMenuItem.Size = new System.Drawing.Size(162, 32);
            this.xóaToolStripMenuItem.Text = "Xóa";
            this.xóaToolStripMenuItem.Click += new System.EventHandler(this.xoaToolStripMenuItem_Click);
            // 
            // thêmToolStripMenuItem
            // 
            this.thêmToolStripMenuItem.Name = "thêmToolStripMenuItem";
            this.thêmToolStripMenuItem.Size = new System.Drawing.Size(162, 32);
            this.thêmToolStripMenuItem.Text = "Thêm";
            this.thêmToolStripMenuItem.Click += new System.EventHandler(this.themToolStripMenuItem_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txtGioHoaDon);
            this.panel3.Controls.Add(this.txtNgayHoaDon);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.lblGioHoaDon);
            this.panel3.Controls.Add(this.lblNgayHoaDon);
            this.panel3.Controls.Add(this.lblTenKhachHang);
            this.panel3.Controls.Add(this.txtDonGia);
            this.panel3.Controls.Add(this.txtTenKhachHang);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1034, 212);
            this.panel3.TabIndex = 32;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.LightSeaGreen;
            this.label2.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.MintCream;
            this.label2.Location = new System.Drawing.Point(534, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 27);
            this.label2.TabIndex = 36;
            this.label2.Text = "Đơn giá:";
            // 
            // lblGioHoaDon
            // 
            this.lblGioHoaDon.AutoSize = true;
            this.lblGioHoaDon.BackColor = System.Drawing.Color.LightSeaGreen;
            this.lblGioHoaDon.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGioHoaDon.ForeColor = System.Drawing.Color.MintCream;
            this.lblGioHoaDon.Location = new System.Drawing.Point(17, 148);
            this.lblGioHoaDon.Name = "lblGioHoaDon";
            this.lblGioHoaDon.Size = new System.Drawing.Size(152, 27);
            this.lblGioHoaDon.TabIndex = 37;
            this.lblGioHoaDon.Text = "Giờ hóa đơn:";
            // 
            // lblNgayHoaDon
            // 
            this.lblNgayHoaDon.AutoSize = true;
            this.lblNgayHoaDon.BackColor = System.Drawing.Color.LightSeaGreen;
            this.lblNgayHoaDon.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgayHoaDon.ForeColor = System.Drawing.Color.MintCream;
            this.lblNgayHoaDon.Location = new System.Drawing.Point(534, 56);
            this.lblNgayHoaDon.Name = "lblNgayHoaDon";
            this.lblNgayHoaDon.Size = new System.Drawing.Size(172, 27);
            this.lblNgayHoaDon.TabIndex = 38;
            this.lblNgayHoaDon.Text = "Ngày hóa đơn:";
            // 
            // lblTenKhachHang
            // 
            this.lblTenKhachHang.AutoSize = true;
            this.lblTenKhachHang.BackColor = System.Drawing.Color.LightSeaGreen;
            this.lblTenKhachHang.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenKhachHang.ForeColor = System.Drawing.Color.MintCream;
            this.lblTenKhachHang.Location = new System.Drawing.Point(15, 56);
            this.lblTenKhachHang.Name = "lblTenKhachHang";
            this.lblTenKhachHang.Size = new System.Drawing.Size(186, 27);
            this.lblTenKhachHang.TabIndex = 35;
            this.lblTenKhachHang.Text = "Mã khách hàng:";
            // 
            // txtDonGia
            // 
            this.txtDonGia.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDonGia.Location = new System.Drawing.Point(711, 122);
            this.txtDonGia.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDonGia.Multiline = true;
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(295, 53);
            this.txtDonGia.TabIndex = 32;
            // 
            // txtTenKhachHang
            // 
            this.txtTenKhachHang.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenKhachHang.Location = new System.Drawing.Point(214, 38);
            this.txtTenKhachHang.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTenKhachHang.Multiline = true;
            this.txtTenKhachHang.Name = "txtTenKhachHang";
            this.txtTenKhachHang.Size = new System.Drawing.Size(295, 53);
            this.txtTenKhachHang.TabIndex = 31;
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnCapNhat.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnCapNhat.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapNhat.ForeColor = System.Drawing.Color.White;
            this.btnCapNhat.Location = new System.Drawing.Point(0, 514);
            this.btnCapNhat.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Padding = new System.Windows.Forms.Padding(10, 10, 10, 10);
            this.btnCapNhat.Size = new System.Drawing.Size(1034, 74);
            this.btnCapNhat.TabIndex = 31;
            this.btnCapNhat.Text = "CẬP NHẬT";
            this.btnCapNhat.UseVisualStyleBackColor = false;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // txtNgayHoaDon
            // 
            this.txtNgayHoaDon.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNgayHoaDon.Location = new System.Drawing.Point(711, 47);
            this.txtNgayHoaDon.Mask = "00-00-0000";
            this.txtNgayHoaDon.Name = "txtNgayHoaDon";
            this.txtNgayHoaDon.Size = new System.Drawing.Size(295, 41);
            this.txtNgayHoaDon.TabIndex = 39;
            this.txtNgayHoaDon.ValidatingType = typeof(System.DateTime);
            // 
            // txtGioHoaDon
            // 
            this.txtGioHoaDon.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGioHoaDon.Location = new System.Drawing.Point(214, 139);
            this.txtGioHoaDon.Mask = "00:00";
            this.txtGioHoaDon.Name = "txtGioHoaDon";
            this.txtGioHoaDon.Size = new System.Drawing.Size(295, 41);
            this.txtGioHoaDon.TabIndex = 40;
            this.txtGioHoaDon.ValidatingType = typeof(System.DateTime);
            // 
            // hoaDonCapNhat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(1054, 708);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "hoaDonCapNhat";
            this.Padding = new System.Windows.Forms.Padding(10, 10, 10, 10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phần mềm quản lý thư viện";
            this.Load += new System.EventHandler(this.hoaDonCapNhat_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgwCapNhatChiTietHoaDon)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtMaHoaDon;
        private System.Windows.Forms.Label lblCapNhatThongTinHoaDon;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView dgwCapNhatChiTietHoaDon;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblGioHoaDon;
        private System.Windows.Forms.Label lblNgayHoaDon;
        private System.Windows.Forms.Label lblTenKhachHang;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.TextBox txtTenKhachHang;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem chỉnhSửaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xóaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thêmToolStripMenuItem;
        private System.Windows.Forms.MaskedTextBox txtNgayHoaDon;
        private System.Windows.Forms.MaskedTextBox txtGioHoaDon;
    }
}