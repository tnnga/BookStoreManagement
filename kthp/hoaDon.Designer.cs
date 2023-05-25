namespace kthp
{
    partial class hoaDon
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
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.cbBoLoc = new System.Windows.Forms.ComboBox();
            this.cbTimKiemTheo = new System.Windows.Forms.ComboBox();
            this.lblBoLoc = new System.Windows.Forms.Label();
            this.lblTimKiemTheo = new System.Windows.Forms.Label();
            this.btnTim = new System.Windows.Forms.Button();
            this.btnThemHoaDon = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgwHoaDon = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.chiTiếtHóaĐơnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chỉnhSửaThôngTinHóaĐơnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xóaThôngTinHóaĐơnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwHoaDon)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtTimKiem);
            this.panel1.Controls.Add(this.cbBoLoc);
            this.panel1.Controls.Add(this.cbTimKiemTheo);
            this.panel1.Controls.Add(this.lblBoLoc);
            this.panel1.Controls.Add(this.lblTimKiemTheo);
            this.panel1.Controls.Add(this.btnTim);
            this.panel1.Controls.Add(this.btnThemHoaDon);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(10, 10);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1141, 108);
            this.panel1.TabIndex = 24;
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimKiem.Location = new System.Drawing.Point(471, 59);
            this.txtTimKiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(336, 32);
            this.txtTimKiem.TabIndex = 29;
            // 
            // cbBoLoc
            // 
            this.cbBoLoc.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbBoLoc.FormattingEnabled = true;
            this.cbBoLoc.Items.AddRange(new object[] {
            "(Lựa chọn)",
            "Hóa đơn có giá trị MAX",
            "Hóa đơn có giá trị MIN",
            "Sắp xếp tên KH từ A - Z",
            "Giá trị hóa đơn tăng dần",
            "Giá trị hóa đơn giảm dần"});
            this.cbBoLoc.Location = new System.Drawing.Point(3, 58);
            this.cbBoLoc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbBoLoc.Name = "cbBoLoc";
            this.cbBoLoc.Size = new System.Drawing.Size(291, 32);
            this.cbBoLoc.TabIndex = 27;
            this.cbBoLoc.Text = "(Lựa chọn)";
            // 
            // cbTimKiemTheo
            // 
            this.cbTimKiemTheo.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTimKiemTheo.FormattingEnabled = true;
            this.cbTimKiemTheo.Items.AddRange(new object[] {
            "(Lựa chọn)",
            "Mã hóa đơn",
            "Tên khách hàng",
            "Ngày hóa đơn"});
            this.cbTimKiemTheo.Location = new System.Drawing.Point(300, 58);
            this.cbTimKiemTheo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbTimKiemTheo.Name = "cbTimKiemTheo";
            this.cbTimKiemTheo.Size = new System.Drawing.Size(165, 32);
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
            this.lblTimKiemTheo.Location = new System.Drawing.Point(305, 20);
            this.lblTimKiemTheo.Name = "lblTimKiemTheo";
            this.lblTimKiemTheo.Size = new System.Drawing.Size(160, 24);
            this.lblTimKiemTheo.TabIndex = 26;
            this.lblTimKiemTheo.Text = "Tìm kiếm theo:";
            // 
            // btnTim
            // 
            this.btnTim.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTim.ForeColor = System.Drawing.Color.Black;
            this.btnTim.Location = new System.Drawing.Point(813, 51);
            this.btnTim.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(100, 45);
            this.btnTim.TabIndex = 23;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // btnThemHoaDon
            // 
            this.btnThemHoaDon.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemHoaDon.ForeColor = System.Drawing.Color.Black;
            this.btnThemHoaDon.Location = new System.Drawing.Point(919, 51);
            this.btnThemHoaDon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThemHoaDon.Name = "btnThemHoaDon";
            this.btnThemHoaDon.Size = new System.Drawing.Size(97, 45);
            this.btnThemHoaDon.TabIndex = 24;
            this.btnThemHoaDon.Text = "Tạo";
            this.btnThemHoaDon.UseVisualStyleBackColor = true;
            this.btnThemHoaDon.Click += new System.EventHandler(this.btnThemHoaDon_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgwHoaDon);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(10, 118);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1141, 548);
            this.panel2.TabIndex = 25;
            // 
            // dgwHoaDon
            // 
            this.dgwHoaDon.BackgroundColor = System.Drawing.Color.LightSeaGreen;
            this.dgwHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwHoaDon.ContextMenuStrip = this.contextMenuStrip1;
            this.dgwHoaDon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgwHoaDon.Location = new System.Drawing.Point(0, 0);
            this.dgwHoaDon.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgwHoaDon.Name = "dgwHoaDon";
            this.dgwHoaDon.RowHeadersWidth = 51;
            this.dgwHoaDon.RowTemplate.Height = 24;
            this.dgwHoaDon.Size = new System.Drawing.Size(1141, 548);
            this.dgwHoaDon.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chiTiếtHóaĐơnToolStripMenuItem,
            this.chỉnhSửaThôngTinHóaĐơnToolStripMenuItem,
            this.xóaThôngTinHóaĐơnToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(313, 100);
            // 
            // chiTiếtHóaĐơnToolStripMenuItem
            // 
            this.chiTiếtHóaĐơnToolStripMenuItem.Name = "chiTiếtHóaĐơnToolStripMenuItem";
            this.chiTiếtHóaĐơnToolStripMenuItem.Size = new System.Drawing.Size(312, 32);
            this.chiTiếtHóaĐơnToolStripMenuItem.Text = "Chi tiết thông tin hóa đơn";
            this.chiTiếtHóaĐơnToolStripMenuItem.Click += new System.EventHandler(this.chiTietHoaĐonToolStripMenuItem_Click);
            // 
            // chỉnhSửaThôngTinHóaĐơnToolStripMenuItem
            // 
            this.chỉnhSửaThôngTinHóaĐơnToolStripMenuItem.Name = "chỉnhSửaThôngTinHóaĐơnToolStripMenuItem";
            this.chỉnhSửaThôngTinHóaĐơnToolStripMenuItem.Size = new System.Drawing.Size(312, 32);
            this.chỉnhSửaThôngTinHóaĐơnToolStripMenuItem.Text = "Chỉnh sửa thông tin hóa đơn";
            this.chỉnhSửaThôngTinHóaĐơnToolStripMenuItem.Click += new System.EventHandler(this.chinhSuaThongTinHoaĐonToolStripMenuItem_Click);
            // 
            // xóaThôngTinHóaĐơnToolStripMenuItem
            // 
            this.xóaThôngTinHóaĐơnToolStripMenuItem.Name = "xóaThôngTinHóaĐơnToolStripMenuItem";
            this.xóaThôngTinHóaĐơnToolStripMenuItem.Size = new System.Drawing.Size(312, 32);
            this.xóaThôngTinHóaĐơnToolStripMenuItem.Text = "Xóa thông tin hóa đơn";
            this.xóaThôngTinHóaĐơnToolStripMenuItem.Click += new System.EventHandler(this.xoaThongTinHoaĐonToolStripMenuItem_Click);
            // 
            // hoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(1161, 676);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "hoaDon";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Text = "Hóa đơn";
            this.Load += new System.EventHandler(this.hoaDon_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgwHoaDon)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.ComboBox cbBoLoc;
        private System.Windows.Forms.ComboBox cbTimKiemTheo;
        private System.Windows.Forms.Label lblBoLoc;
        private System.Windows.Forms.Label lblTimKiemTheo;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.Button btnThemHoaDon;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgwHoaDon;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem chiTiếtHóaĐơnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chỉnhSửaThôngTinHóaĐơnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xóaThôngTinHóaĐơnToolStripMenuItem;
    }
}