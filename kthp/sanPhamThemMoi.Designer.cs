namespace kthp
{
    partial class frmSanPhamThemMoi
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
            this.txtGiaTien = new System.Windows.Forms.TextBox();
            this.lblTonKho = new System.Windows.Forms.Label();
            this.btnThem = new System.Windows.Forms.Button();
            this.txtSoLuongTon = new System.Windows.Forms.TextBox();
            this.lblGiaBan = new System.Windows.Forms.Label();
            this.txtTenSach = new System.Windows.Forms.TextBox();
            this.lblLoaiSP = new System.Windows.Forms.Label();
            this.txtMaSach = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaSP = new System.Windows.Forms.TextBox();
            this.lblMaSP = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtLoaiSach = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNoiDungChinh = new System.Windows.Forms.TextBox();
            this.lblDienThongTin = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtGiaTien
            // 
            this.txtGiaTien.BackColor = System.Drawing.Color.LightSeaGreen;
            this.txtGiaTien.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGiaTien.ForeColor = System.Drawing.Color.White;
            this.txtGiaTien.Location = new System.Drawing.Point(232, 353);
            this.txtGiaTien.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtGiaTien.Multiline = true;
            this.txtGiaTien.Name = "txtGiaTien";
            this.txtGiaTien.Size = new System.Drawing.Size(444, 50);
            this.txtGiaTien.TabIndex = 4;
            this.txtGiaTien.Leave += new System.EventHandler(this.txtGiaTien_Leave);
            // 
            // lblTonKho
            // 
            this.lblTonKho.AutoSize = true;
            this.lblTonKho.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTonKho.Location = new System.Drawing.Point(26, 367);
            this.lblTonKho.Name = "lblTonKho";
            this.lblTonKho.Size = new System.Drawing.Size(97, 27);
            this.lblTonKho.TabIndex = 21;
            this.lblTonKho.Text = "Giá tiền";
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnThem.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.Location = new System.Drawing.Point(460, 670);
            this.btnThem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(216, 62);
            this.btnThem.TabIndex = 7;
            this.btnThem.Text = "THÊM";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            this.btnThem.Leave += new System.EventHandler(this.btnThem_Leave);
            // 
            // txtSoLuongTon
            // 
            this.txtSoLuongTon.BackColor = System.Drawing.Color.LightSeaGreen;
            this.txtSoLuongTon.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoLuongTon.ForeColor = System.Drawing.Color.White;
            this.txtSoLuongTon.Location = new System.Drawing.Point(232, 265);
            this.txtSoLuongTon.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSoLuongTon.Multiline = true;
            this.txtSoLuongTon.Name = "txtSoLuongTon";
            this.txtSoLuongTon.Size = new System.Drawing.Size(444, 50);
            this.txtSoLuongTon.TabIndex = 3;
            this.txtSoLuongTon.Leave += new System.EventHandler(this.txtSoLuongTon_Leave);
            // 
            // lblGiaBan
            // 
            this.lblGiaBan.AutoSize = true;
            this.lblGiaBan.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGiaBan.Location = new System.Drawing.Point(26, 280);
            this.lblGiaBan.Name = "lblGiaBan";
            this.lblGiaBan.Size = new System.Drawing.Size(111, 27);
            this.lblGiaBan.TabIndex = 18;
            this.lblGiaBan.Text = "Số lượng";
            // 
            // txtTenSach
            // 
            this.txtTenSach.BackColor = System.Drawing.Color.LightSeaGreen;
            this.txtTenSach.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenSach.ForeColor = System.Drawing.Color.White;
            this.txtTenSach.Location = new System.Drawing.Point(232, 175);
            this.txtTenSach.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTenSach.Multiline = true;
            this.txtTenSach.Name = "txtTenSach";
            this.txtTenSach.Size = new System.Drawing.Size(444, 50);
            this.txtTenSach.TabIndex = 2;
            this.txtTenSach.Leave += new System.EventHandler(this.txtTenSach_Leave);
            // 
            // lblLoaiSP
            // 
            this.lblLoaiSP.AutoSize = true;
            this.lblLoaiSP.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoaiSP.Location = new System.Drawing.Point(26, 190);
            this.lblLoaiSP.Name = "lblLoaiSP";
            this.lblLoaiSP.Size = new System.Drawing.Size(108, 27);
            this.lblLoaiSP.TabIndex = 16;
            this.lblLoaiSP.Text = "Tên sách";
            // 
            // txtMaSach
            // 
            this.txtMaSach.BackColor = System.Drawing.Color.LightSeaGreen;
            this.txtMaSach.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaSach.ForeColor = System.Drawing.Color.White;
            this.txtMaSach.Location = new System.Drawing.Point(232, 83);
            this.txtMaSach.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMaSach.Multiline = true;
            this.txtMaSach.Name = "txtMaSach";
            this.txtMaSach.Size = new System.Drawing.Size(444, 50);
            this.txtMaSach.TabIndex = 1;
            this.txtMaSach.Leave += new System.EventHandler(this.txtMaSach_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 27);
            this.label2.TabIndex = 14;
            this.label2.Text = "Mã sách";
            // 
            // txtMaSP
            // 
            this.txtMaSP.Location = new System.Drawing.Point(219, -26);
            this.txtMaSP.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMaSP.Name = "txtMaSP";
            this.txtMaSP.Size = new System.Drawing.Size(174, 26);
            this.txtMaSP.TabIndex = 13;
            // 
            // lblMaSP
            // 
            this.lblMaSP.AutoSize = true;
            this.lblMaSP.Location = new System.Drawing.Point(137, -26);
            this.lblMaSP.Name = "lblMaSP";
            this.lblMaSP.Size = new System.Drawing.Size(60, 20);
            this.lblMaSP.TabIndex = 12;
            this.lblMaSP.Text = "Mã SP:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 456);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 27);
            this.label1.TabIndex = 21;
            this.label1.Text = "Loại sách";
            // 
            // txtLoaiSach
            // 
            this.txtLoaiSach.BackColor = System.Drawing.Color.LightSeaGreen;
            this.txtLoaiSach.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLoaiSach.ForeColor = System.Drawing.Color.White;
            this.txtLoaiSach.Location = new System.Drawing.Point(232, 439);
            this.txtLoaiSach.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtLoaiSach.Multiline = true;
            this.txtLoaiSach.Name = "txtLoaiSach";
            this.txtLoaiSach.Size = new System.Drawing.Size(444, 50);
            this.txtLoaiSach.TabIndex = 5;
            this.txtLoaiSach.Leave += new System.EventHandler(this.txtLoaiSach_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 564);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(179, 27);
            this.label3.TabIndex = 21;
            this.label3.Text = "Nội dung chính";
            // 
            // txtNoiDungChinh
            // 
            this.txtNoiDungChinh.BackColor = System.Drawing.Color.LightSeaGreen;
            this.txtNoiDungChinh.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNoiDungChinh.ForeColor = System.Drawing.Color.White;
            this.txtNoiDungChinh.Location = new System.Drawing.Point(232, 526);
            this.txtNoiDungChinh.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNoiDungChinh.Multiline = true;
            this.txtNoiDungChinh.Name = "txtNoiDungChinh";
            this.txtNoiDungChinh.Size = new System.Drawing.Size(444, 102);
            this.txtNoiDungChinh.TabIndex = 6;
            // 
            // lblDienThongTin
            // 
            this.lblDienThongTin.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblDienThongTin.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDienThongTin.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.lblDienThongTin.Location = new System.Drawing.Point(0, 0);
            this.lblDienThongTin.Name = "lblDienThongTin";
            this.lblDienThongTin.Size = new System.Drawing.Size(719, 64);
            this.lblDienThongTin.TabIndex = 23;
            this.lblDienThongTin.Text = "Vui lòng điền thông tin";
            this.lblDienThongTin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmSanPhamThemMoi
            // 
            this.AcceptButton = this.btnThem;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 745);
            this.Controls.Add(this.lblDienThongTin);
            this.Controls.Add(this.txtNoiDungChinh);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtLoaiSach);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtGiaTien);
            this.Controls.Add(this.lblTonKho);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.txtSoLuongTon);
            this.Controls.Add(this.lblGiaBan);
            this.Controls.Add(this.txtTenSach);
            this.Controls.Add(this.lblLoaiSP);
            this.Controls.Add(this.txtMaSach);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMaSP);
            this.Controls.Add(this.lblMaSP);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmSanPhamThemMoi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "sanPhamThemMoi";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmSanPhamThemMoi_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtGiaTien;
        private System.Windows.Forms.Label lblTonKho;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.TextBox txtSoLuongTon;
        private System.Windows.Forms.Label lblGiaBan;
        private System.Windows.Forms.TextBox txtTenSach;
        private System.Windows.Forms.Label lblLoaiSP;
        private System.Windows.Forms.TextBox txtMaSach;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaSP;
        private System.Windows.Forms.Label lblMaSP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLoaiSach;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNoiDungChinh;
        private System.Windows.Forms.Label lblDienThongTin;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}