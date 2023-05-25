namespace kthp
{
    partial class khachHang
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgwKhachHang = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cậpNhậtThôngTinKháchHàngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xóaThôngTinKháchHàngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.cbBoLoc = new System.Windows.Forms.ComboBox();
            this.cbTimKiemTheo = new System.Windows.Forms.ComboBox();
            this.lblBoLoc = new System.Windows.Forms.Label();
            this.lblTimKiemTheo = new System.Windows.Forms.Label();
            this.btnTim = new System.Windows.Forms.Button();
            this.btnThemSanPham = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwKhachHang)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgwKhachHang);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(10, 118);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1141, 548);
            this.panel2.TabIndex = 27;
            // 
            // dgwKhachHang
            // 
            this.dgwKhachHang.BackgroundColor = System.Drawing.Color.LightSeaGreen;
            this.dgwKhachHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwKhachHang.ContextMenuStrip = this.contextMenuStrip1;
            this.dgwKhachHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgwKhachHang.Location = new System.Drawing.Point(0, 0);
            this.dgwKhachHang.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgwKhachHang.Name = "dgwKhachHang";
            this.dgwKhachHang.RowHeadersWidth = 51;
            this.dgwKhachHang.RowTemplate.Height = 24;
            this.dgwKhachHang.Size = new System.Drawing.Size(1141, 548);
            this.dgwKhachHang.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cậpNhậtThôngTinKháchHàngToolStripMenuItem,
            this.xóaThôngTinKháchHàngToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(330, 68);
            // 
            // cậpNhậtThôngTinKháchHàngToolStripMenuItem
            // 
            this.cậpNhậtThôngTinKháchHàngToolStripMenuItem.Name = "cậpNhậtThôngTinKháchHàngToolStripMenuItem";
            this.cậpNhậtThôngTinKháchHàngToolStripMenuItem.Size = new System.Drawing.Size(329, 32);
            this.cậpNhậtThôngTinKháchHàngToolStripMenuItem.Text = "Cập nhật thông tin khách hàng";
            this.cậpNhậtThôngTinKháchHàngToolStripMenuItem.Click += new System.EventHandler(this.capNhatThongTinKhachHangToolStripMenuItem_Click);
            // 
            // xóaThôngTinKháchHàngToolStripMenuItem
            // 
            this.xóaThôngTinKháchHàngToolStripMenuItem.Name = "xóaThôngTinKháchHàngToolStripMenuItem";
            this.xóaThôngTinKháchHàngToolStripMenuItem.Size = new System.Drawing.Size(329, 32);
            this.xóaThôngTinKháchHàngToolStripMenuItem.Text = "Xóa thông tin khách hàng";
            this.xóaThôngTinKháchHàngToolStripMenuItem.Click += new System.EventHandler(this.xoaThongTinKhachHangToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panel1.Controls.Add(this.txtTimKiem);
            this.panel1.Controls.Add(this.cbBoLoc);
            this.panel1.Controls.Add(this.cbTimKiemTheo);
            this.panel1.Controls.Add(this.lblBoLoc);
            this.panel1.Controls.Add(this.lblTimKiemTheo);
            this.panel1.Controls.Add(this.btnTim);
            this.panel1.Controls.Add(this.btnThemSanPham);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(10, 10);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1141, 108);
            this.panel1.TabIndex = 26;
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimKiem.Location = new System.Drawing.Point(436, 58);
            this.txtTimKiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(373, 32);
            this.txtTimKiem.TabIndex = 29;
            // 
            // cbBoLoc
            // 
            this.cbBoLoc.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbBoLoc.FormattingEnabled = true;
            this.cbBoLoc.Items.AddRange(new object[] {
            "(Lựa chọn)",
            "Chỉ hiện KH nam",
            "Chỉ hiện KH nữ",
            "Sắp xếp tên KH từ A-Z"});
            this.cbBoLoc.Location = new System.Drawing.Point(7, 58);
            this.cbBoLoc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbBoLoc.Name = "cbBoLoc";
            this.cbBoLoc.Size = new System.Drawing.Size(251, 32);
            this.cbBoLoc.TabIndex = 27;
            this.cbBoLoc.Text = "(Lựa chọn)";
            // 
            // cbTimKiemTheo
            // 
            this.cbTimKiemTheo.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTimKiemTheo.FormattingEnabled = true;
            this.cbTimKiemTheo.Items.AddRange(new object[] {
            "(Lựa chọn)",
            "Mã khách hàng",
            "Tên khách hàng",
            "Số điện thoại"});
            this.cbTimKiemTheo.Location = new System.Drawing.Point(264, 58);
            this.cbTimKiemTheo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbTimKiemTheo.Name = "cbTimKiemTheo";
            this.cbTimKiemTheo.Size = new System.Drawing.Size(166, 32);
            this.cbTimKiemTheo.TabIndex = 28;
            this.cbTimKiemTheo.Text = "(Lựa chọn)";
            // 
            // lblBoLoc
            // 
            this.lblBoLoc.AutoSize = true;
            this.lblBoLoc.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBoLoc.ForeColor = System.Drawing.Color.White;
            this.lblBoLoc.Location = new System.Drawing.Point(3, 20);
            this.lblBoLoc.Name = "lblBoLoc";
            this.lblBoLoc.Size = new System.Drawing.Size(78, 24);
            this.lblBoLoc.TabIndex = 25;
            this.lblBoLoc.Text = "Bộ lọc:";
            // 
            // lblTimKiemTheo
            // 
            this.lblTimKiemTheo.AutoSize = true;
            this.lblTimKiemTheo.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimKiemTheo.ForeColor = System.Drawing.Color.White;
            this.lblTimKiemTheo.Location = new System.Drawing.Point(255, 20);
            this.lblTimKiemTheo.Name = "lblTimKiemTheo";
            this.lblTimKiemTheo.Size = new System.Drawing.Size(160, 24);
            this.lblTimKiemTheo.TabIndex = 26;
            this.lblTimKiemTheo.Text = "Tìm kiếm theo:";
            // 
            // btnTim
            // 
            this.btnTim.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTim.ForeColor = System.Drawing.Color.Black;
            this.btnTim.Location = new System.Drawing.Point(815, 51);
            this.btnTim.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(96, 45);
            this.btnTim.TabIndex = 23;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // btnThemSanPham
            // 
            this.btnThemSanPham.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemSanPham.ForeColor = System.Drawing.Color.Black;
            this.btnThemSanPham.Location = new System.Drawing.Point(917, 51);
            this.btnThemSanPham.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThemSanPham.Name = "btnThemSanPham";
            this.btnThemSanPham.Size = new System.Drawing.Size(101, 45);
            this.btnThemSanPham.TabIndex = 24;
            this.btnThemSanPham.Text = "Tạo";
            this.btnThemSanPham.UseVisualStyleBackColor = true;
            this.btnThemSanPham.Click += new System.EventHandler(this.btnThemSanPham_Click);
            // 
            // khachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(1161, 676);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "khachHang";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Text = "KhachHang";
            this.Load += new System.EventHandler(this.khachHang_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgwKhachHang)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.ComboBox cbBoLoc;
        private System.Windows.Forms.ComboBox cbTimKiemTheo;
        private System.Windows.Forms.Label lblBoLoc;
        private System.Windows.Forms.Label lblTimKiemTheo;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.Button btnThemSanPham;
        private System.Windows.Forms.DataGridView dgwKhachHang;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cậpNhậtThôngTinKháchHàngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xóaThôngTinKháchHàngToolStripMenuItem;
    }
}