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
            this.contextMenuStrip1.Size = new System.Drawing.Size(324, 100);
            // 
            // chiTiếtNhậpHàngToolStripMenuItem
            // 
            this.chiTiếtNhậpHàngToolStripMenuItem.Name = "chiTiếtNhậpHàngToolStripMenuItem";
            this.chiTiếtNhậpHàngToolStripMenuItem.Size = new System.Drawing.Size(323, 32);
            this.chiTiếtNhậpHàngToolStripMenuItem.Text = "Chi tiết nhập hàng";
            this.chiTiếtNhậpHàngToolStripMenuItem.Click += new System.EventHandler(this.chiTietNhapHangToolStripMenuItem_Click);
            // 
            // cậpNhậtThôngTinNhậpHàngToolStripMenuItem
            // 
            this.cậpNhậtThôngTinNhậpHàngToolStripMenuItem.Name = "cậpNhậtThôngTinNhậpHàngToolStripMenuItem";
            this.cậpNhậtThôngTinNhậpHàngToolStripMenuItem.Size = new System.Drawing.Size(323, 32);
            this.cậpNhậtThôngTinNhậpHàngToolStripMenuItem.Text = "Cập nhật thông tin nhập hàng";
            this.cậpNhậtThôngTinNhậpHàngToolStripMenuItem.Click += new System.EventHandler(this.capNhatThongTinNhapHangToolStripMenuItem_Click);
            // 
            // xóaThôngTinNhậpHàngToolStripMenuItem
            // 
            this.xóaThôngTinNhậpHàngToolStripMenuItem.Name = "xóaThôngTinNhậpHàngToolStripMenuItem";
            this.xóaThôngTinNhậpHàngToolStripMenuItem.Size = new System.Drawing.Size(323, 32);
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
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1161, 94);
            this.panel1.TabIndex = 30;
            // 
            // btnTim
            // 
            this.btnTim.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTim.ForeColor = System.Drawing.Color.Black;
            this.btnTim.Location = new System.Drawing.Point(759, 39);
            this.btnTim.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(115, 45);
            this.btnTim.TabIndex = 34;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimKiem.Location = new System.Drawing.Point(213, 46);
            this.txtTimKiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(527, 32);
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
            this.cbTimKiemTheo.Location = new System.Drawing.Point(16, 46);
            this.cbTimKiemTheo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbTimKiemTheo.Name = "cbTimKiemTheo";
            this.cbTimKiemTheo.Size = new System.Drawing.Size(177, 32);
            this.cbTimKiemTheo.TabIndex = 32;
            this.cbTimKiemTheo.Text = "(Lựa chọn)";
            // 
            // lblTimKiemTheo
            // 
            this.lblTimKiemTheo.AutoSize = true;
            this.lblTimKiemTheo.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimKiemTheo.ForeColor = System.Drawing.Color.White;
            this.lblTimKiemTheo.Location = new System.Drawing.Point(11, 8);
            this.lblTimKiemTheo.Name = "lblTimKiemTheo";
            this.lblTimKiemTheo.Size = new System.Drawing.Size(160, 24);
            this.lblTimKiemTheo.TabIndex = 31;
            this.lblTimKiemTheo.Text = "Tìm kiếm theo:";
            // 
            // btnTaoNhapHang
            // 
            this.btnTaoNhapHang.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTaoNhapHang.ForeColor = System.Drawing.Color.Black;
            this.btnTaoNhapHang.Location = new System.Drawing.Point(885, 39);
            this.btnTaoNhapHang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTaoNhapHang.Name = "btnTaoNhapHang";
            this.btnTaoNhapHang.Size = new System.Drawing.Size(115, 45);
            this.btnTaoNhapHang.TabIndex = 30;
            this.btnTaoNhapHang.Text = "Tạo";
            this.btnTaoNhapHang.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgwNhapHang);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 94);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1161, 582);
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
            this.dgwNhapHang.Size = new System.Drawing.Size(1161, 582);
            this.dgwNhapHang.TabIndex = 31;
            // 
            // nhapHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(1161, 676);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "nhapHang";
            this.Text = "nhapHang";
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