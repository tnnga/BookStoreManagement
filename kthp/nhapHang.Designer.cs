namespace kthp
{
    partial class nhapHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(nhapHang));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.chiTiếtNhậpHàngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cậpNhậtThôngTinNhậpHàngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xóaThôngTinNhậpHàngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnTim = new System.Windows.Forms.Button();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.cbTimKiemTheo = new System.Windows.Forms.ComboBox();
            this.lblTimKiemTheo = new System.Windows.Forms.Label();
            this.btnTaoNhapHang = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgwNhapHang = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwNhapHang)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chiTiếtNhậpHàngToolStripMenuItem,
            this.cậpNhậtThôngTinNhậpHàngToolStripMenuItem,
            this.xóaThôngTinNhậpHàngToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(276, 76);
            // 
            // chiTiếtNhậpHàngToolStripMenuItem
            // 
            this.chiTiếtNhậpHàngToolStripMenuItem.Name = "chiTiếtNhậpHàngToolStripMenuItem";
            this.chiTiếtNhậpHàngToolStripMenuItem.Size = new System.Drawing.Size(275, 24);
            this.chiTiếtNhậpHàngToolStripMenuItem.Text = "Chi tiết nhập hàng";
            this.chiTiếtNhậpHàngToolStripMenuItem.Click += new System.EventHandler(this.chiTietNhapHangToolStripMenuItem_Click);
            // 
            // cậpNhậtThôngTinNhậpHàngToolStripMenuItem
            // 
            this.cậpNhậtThôngTinNhậpHàngToolStripMenuItem.Name = "cậpNhậtThôngTinNhậpHàngToolStripMenuItem";
            this.cậpNhậtThôngTinNhậpHàngToolStripMenuItem.Size = new System.Drawing.Size(275, 24);
            this.cậpNhậtThôngTinNhậpHàngToolStripMenuItem.Text = "Cập nhật thông tin nhập hàng";
            this.cậpNhậtThôngTinNhậpHàngToolStripMenuItem.Click += new System.EventHandler(this.capNhatThongTinNhapHangToolStripMenuItem_Click);
            // 
            // xóaThôngTinNhậpHàngToolStripMenuItem
            // 
            this.xóaThôngTinNhậpHàngToolStripMenuItem.Name = "xóaThôngTinNhậpHàngToolStripMenuItem";
            this.xóaThôngTinNhậpHàngToolStripMenuItem.Size = new System.Drawing.Size(275, 24);
            this.xóaThôngTinNhậpHàngToolStripMenuItem.Text = "Xóa thông tin nhập hàng";
            this.xóaThôngTinNhậpHàngToolStripMenuItem.Click += new System.EventHandler(this.xoaThongTinNhapHangToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnTim);
            this.panel1.Controls.Add(this.txtTimKiem);
            this.panel1.Controls.Add(this.cbTimKiemTheo);
            this.panel1.Controls.Add(this.lblTimKiemTheo);
            this.panel1.Controls.Add(this.btnTaoNhapHang);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(9, 8);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1014, 75);
            this.panel1.TabIndex = 30;
            // 
            // btnTim
            // 
            this.btnTim.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTim.ForeColor = System.Drawing.Color.Black;
            this.btnTim.Image = global::kthp.Properties.Resources.Search_24x24;
            this.btnTim.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTim.Location = new System.Drawing.Point(773, 29);
            this.btnTim.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(89, 36);
            this.btnTim.TabIndex = 34;
            this.btnTim.Text = "Tìm";
            this.btnTim.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimKiem.Location = new System.Drawing.Point(189, 37);
            this.txtTimKiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(533, 28);
            this.txtTimKiem.TabIndex = 33;
            // 
            // cbTimKiemTheo
            // 
            this.cbTimKiemTheo.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTimKiemTheo.FormattingEnabled = true;
            this.cbTimKiemTheo.Items.AddRange(new object[] {
            "Mã nhập hàng",
            "Tên nhân viên",
            "Ngày nhập hàng"});
            this.cbTimKiemTheo.Location = new System.Drawing.Point(14, 37);
            this.cbTimKiemTheo.Name = "cbTimKiemTheo";
            this.cbTimKiemTheo.Size = new System.Drawing.Size(158, 29);
            this.cbTimKiemTheo.TabIndex = 32;
            this.cbTimKiemTheo.Text = "(Lựa chọn)";
            // 
            // lblTimKiemTheo
            // 
            this.lblTimKiemTheo.AutoSize = true;
            this.lblTimKiemTheo.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimKiemTheo.ForeColor = System.Drawing.Color.White;
            this.lblTimKiemTheo.Location = new System.Drawing.Point(10, 6);
            this.lblTimKiemTheo.Name = "lblTimKiemTheo";
            this.lblTimKiemTheo.Size = new System.Drawing.Size(137, 21);
            this.lblTimKiemTheo.TabIndex = 31;
            this.lblTimKiemTheo.Text = "Tìm kiếm theo:";
            // 
            // btnTaoNhapHang
            // 
            this.btnTaoNhapHang.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTaoNhapHang.ForeColor = System.Drawing.Color.Black;
            this.btnTaoNhapHang.Image = global::kthp.Properties.Resources.Add_24x24;
            this.btnTaoNhapHang.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTaoNhapHang.Location = new System.Drawing.Point(893, 29);
            this.btnTaoNhapHang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTaoNhapHang.Name = "btnTaoNhapHang";
            this.btnTaoNhapHang.Size = new System.Drawing.Size(86, 36);
            this.btnTaoNhapHang.TabIndex = 30;
            this.btnTaoNhapHang.Text = "Tạo";
            this.btnTaoNhapHang.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTaoNhapHang.UseVisualStyleBackColor = true;
            this.btnTaoNhapHang.Click += new System.EventHandler(this.btnTaoNhapHang_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgwNhapHang);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(9, 83);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1014, 450);
            this.panel2.TabIndex = 31;
            // 
            // dgwNhapHang
            // 
            this.dgwNhapHang.BackgroundColor = System.Drawing.Color.LightSeaGreen;
            this.dgwNhapHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwNhapHang.ContextMenuStrip = this.contextMenuStrip1;
            this.dgwNhapHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgwNhapHang.Location = new System.Drawing.Point(0, 0);
            this.dgwNhapHang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgwNhapHang.Name = "dgwNhapHang";
            this.dgwNhapHang.RowHeadersWidth = 62;
            this.dgwNhapHang.RowTemplate.Height = 28;
            this.dgwNhapHang.Size = new System.Drawing.Size(1014, 450);
            this.dgwNhapHang.TabIndex = 31;
            // 
            // nhapHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(1032, 541);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "nhapHang";
            this.Padding = new System.Windows.Forms.Padding(9, 8, 9, 8);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phần mềm quản lí nhà sách";
            this.Load += new System.EventHandler(this.nhapHang_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgwNhapHang)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem chiTiếtNhậpHàngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cậpNhậtThôngTinNhậpHàngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xóaThôngTinNhậpHàngToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.ComboBox cbTimKiemTheo;
        private System.Windows.Forms.Label lblTimKiemTheo;
        private System.Windows.Forms.Button btnTaoNhapHang;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgwNhapHang;
    }
}