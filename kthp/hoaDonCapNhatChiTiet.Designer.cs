﻿namespace kthp
{
    partial class hoaDonCapNhatChiTiet
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
            this.lblCapNhatThongTinSach = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.lblSoLuong = new System.Windows.Forms.Label();
            this.txtTenSanPham = new System.Windows.Forms.TextBox();
            this.lblTenSanPham = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtMaHoaDon);
            this.panel1.Controls.Add(this.lblCapNhatThongTinSach);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(719, 100);
            this.panel1.TabIndex = 0;
            // 
            // txtMaHoaDon
            // 
            this.txtMaHoaDon.BackColor = System.Drawing.Color.PaleTurquoise;
            this.txtMaHoaDon.Enabled = false;
            this.txtMaHoaDon.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaHoaDon.ForeColor = System.Drawing.Color.White;
            this.txtMaHoaDon.Location = new System.Drawing.Point(534, 28);
            this.txtMaHoaDon.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMaHoaDon.Multiline = true;
            this.txtMaHoaDon.Name = "txtMaHoaDon";
            this.txtMaHoaDon.ReadOnly = true;
            this.txtMaHoaDon.Size = new System.Drawing.Size(167, 50);
            this.txtMaHoaDon.TabIndex = 5;
            // 
            // lblCapNhatThongTinSach
            // 
            this.lblCapNhatThongTinSach.AutoSize = true;
            this.lblCapNhatThongTinSach.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCapNhatThongTinSach.ForeColor = System.Drawing.Color.Azure;
            this.lblCapNhatThongTinSach.Location = new System.Drawing.Point(11, 28);
            this.lblCapNhatThongTinSach.Name = "lblCapNhatThongTinSach";
            this.lblCapNhatThongTinSach.Size = new System.Drawing.Size(517, 43);
            this.lblCapNhatThongTinSach.TabIndex = 4;
            this.lblCapNhatThongTinSach.Text = "Cập nhật thông tin hóa đơn";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnCapNhat);
            this.panel2.Controls.Add(this.txtSoLuong);
            this.panel2.Controls.Add(this.lblSoLuong);
            this.panel2.Controls.Add(this.txtTenSanPham);
            this.panel2.Controls.Add(this.lblTenSanPham);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 100);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(719, 217);
            this.panel2.TabIndex = 1;
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnCapNhat.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnCapNhat.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapNhat.ForeColor = System.Drawing.Color.White;
            this.btnCapNhat.Location = new System.Drawing.Point(0, 144);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(719, 73);
            this.btnCapNhat.TabIndex = 61;
            this.btnCapNhat.Text = "CẬP NHẬT CHI TIẾT";
            this.btnCapNhat.UseVisualStyleBackColor = false;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.BackColor = System.Drawing.Color.MintCream;
            this.txtSoLuong.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoLuong.ForeColor = System.Drawing.Color.Black;
            this.txtSoLuong.Location = new System.Drawing.Point(541, 59);
            this.txtSoLuong.Multiline = true;
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(143, 54);
            this.txtSoLuong.TabIndex = 46;
            // 
            // lblSoLuong
            // 
            this.lblSoLuong.AutoSize = true;
            this.lblSoLuong.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoLuong.ForeColor = System.Drawing.Color.White;
            this.lblSoLuong.Location = new System.Drawing.Point(536, 27);
            this.lblSoLuong.Name = "lblSoLuong";
            this.lblSoLuong.Size = new System.Drawing.Size(111, 27);
            this.lblSoLuong.TabIndex = 50;
            this.lblSoLuong.Text = "Số lượng";
            // 
            // txtTenSanPham
            // 
            this.txtTenSanPham.BackColor = System.Drawing.Color.MintCream;
            this.txtTenSanPham.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenSanPham.ForeColor = System.Drawing.Color.Black;
            this.txtTenSanPham.Location = new System.Drawing.Point(32, 59);
            this.txtTenSanPham.Multiline = true;
            this.txtTenSanPham.Name = "txtTenSanPham";
            this.txtTenSanPham.Size = new System.Drawing.Size(472, 54);
            this.txtTenSanPham.TabIndex = 45;
            // 
            // lblTenSanPham
            // 
            this.lblTenSanPham.AutoSize = true;
            this.lblTenSanPham.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenSanPham.ForeColor = System.Drawing.Color.White;
            this.lblTenSanPham.Location = new System.Drawing.Point(32, 27);
            this.lblTenSanPham.Name = "lblTenSanPham";
            this.lblTenSanPham.Size = new System.Drawing.Size(160, 27);
            this.lblTenSanPham.TabIndex = 54;
            this.lblTenSanPham.Text = "Mã Sản Phẩm";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // hoaDonCapNhatChiTiet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(719, 317);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "hoaDonCapNhatChiTiet";
            this.Text = "hoaDonCapNhatChiTiet";
            this.Load += new System.EventHandler(this.hoaDonCapNhatChiTiet_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtMaHoaDon;
        private System.Windows.Forms.Label lblCapNhatThongTinSach;
        private System.Windows.Forms.Button btnCapNhat;
        public System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.Label lblSoLuong;
        public System.Windows.Forms.TextBox txtTenSanPham;
        private System.Windows.Forms.Label lblTenSanPham;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}