namespace kthp
{
    partial class frmDangNhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDangNhap));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.picTuSach = new System.Windows.Forms.PictureBox();
            this.lblTieuDe = new System.Windows.Forms.Label();
            this.chkAnHienMatKhau = new System.Windows.Forms.CheckBox();
            this.lblQuenMatKhau = new System.Windows.Forms.Label();
            this.lblDangKy = new System.Windows.Forms.Label();
            this.btnDangNhap = new System.Windows.Forms.Button();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.txtTenDangNhap = new System.Windows.Forms.TextBox();
            this.lblLoiChao = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picTuSach)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(13, 12);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.splitContainer1.Panel1.Controls.Add(this.picTuSach);
            this.splitContainer1.Panel1.Controls.Add(this.lblTieuDe);
            this.splitContainer1.Panel1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.Black;
            this.splitContainer1.Panel2.Controls.Add(this.chkAnHienMatKhau);
            this.splitContainer1.Panel2.Controls.Add(this.lblQuenMatKhau);
            this.splitContainer1.Panel2.Controls.Add(this.lblDangKy);
            this.splitContainer1.Panel2.Controls.Add(this.btnDangNhap);
            this.splitContainer1.Panel2.Controls.Add(this.txtMatKhau);
            this.splitContainer1.Panel2.Controls.Add(this.txtTenDangNhap);
            this.splitContainer1.Panel2.Controls.Add(this.lblLoiChao);
            this.splitContainer1.Size = new System.Drawing.Size(1073, 506);
            this.splitContainer1.SplitterDistance = 698;
            this.splitContainer1.TabIndex = 0;
            // 
            // picTuSach
            // 
            this.picTuSach.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.picTuSach.ErrorImage = ((System.Drawing.Image)(resources.GetObject("picTuSach.ErrorImage")));
            this.picTuSach.Image = ((System.Drawing.Image)(resources.GetObject("picTuSach.Image")));
            this.picTuSach.Location = new System.Drawing.Point(122, 174);
            this.picTuSach.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picTuSach.Name = "picTuSach";
            this.picTuSach.Size = new System.Drawing.Size(541, 306);
            this.picTuSach.TabIndex = 1;
            this.picTuSach.TabStop = false;
            // 
            // lblTieuDe
            // 
            this.lblTieuDe.Font = new System.Drawing.Font("Tahoma", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTieuDe.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTieuDe.Location = new System.Drawing.Point(11, 15);
            this.lblTieuDe.Name = "lblTieuDe";
            this.lblTieuDe.Size = new System.Drawing.Size(558, 105);
            this.lblTieuDe.TabIndex = 0;
            this.lblTieuDe.Text = "PHẦN MỀM QUẢN LÝ                  NHÀ SÁCH THIÊN AN";
            // 
            // chkAnHienMatKhau
            // 
            this.chkAnHienMatKhau.AutoSize = true;
            this.chkAnHienMatKhau.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkAnHienMatKhau.ForeColor = System.Drawing.Color.White;
            this.chkAnHienMatKhau.Location = new System.Drawing.Point(188, 290);
            this.chkAnHienMatKhau.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkAnHienMatKhau.Name = "chkAnHienMatKhau";
            this.chkAnHienMatKhau.Size = new System.Drawing.Size(130, 21);
            this.chkAnHienMatKhau.TabIndex = 4;
            this.chkAnHienMatKhau.Text = "Hiện mật khẩu";
            this.chkAnHienMatKhau.UseVisualStyleBackColor = true;
            this.chkAnHienMatKhau.CheckedChanged += new System.EventHandler(this.chkAnHienMatKhau_CheckedChanged);
            // 
            // lblQuenMatKhau
            // 
            this.lblQuenMatKhau.AutoSize = true;
            this.lblQuenMatKhau.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuenMatKhau.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblQuenMatKhau.Location = new System.Drawing.Point(193, 414);
            this.lblQuenMatKhau.Name = "lblQuenMatKhau";
            this.lblQuenMatKhau.Size = new System.Drawing.Size(129, 17);
            this.lblQuenMatKhau.TabIndex = 3;
            this.lblQuenMatKhau.Text = "QUÊN MẬT KHẨU";
            this.lblQuenMatKhau.Click += new System.EventHandler(this.lblQuenMatKhau_Click);
            this.lblQuenMatKhau.MouseEnter += new System.EventHandler(this.lblQuenMatKhau_MouseEnter);
            this.lblQuenMatKhau.MouseLeave += new System.EventHandler(this.lblQuenMatKhau_MouseLeave);
            // 
            // lblDangKy
            // 
            this.lblDangKy.AutoSize = true;
            this.lblDangKy.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDangKy.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblDangKy.Location = new System.Drawing.Point(40, 414);
            this.lblDangKy.Name = "lblDangKy";
            this.lblDangKy.Size = new System.Drawing.Size(73, 17);
            this.lblDangKy.TabIndex = 3;
            this.lblDangKy.Text = "ĐĂNG KÝ";
            this.lblDangKy.Click += new System.EventHandler(this.lblDangKy_Click);
            this.lblDangKy.MouseEnter += new System.EventHandler(this.lblDangKy_MouseEnter);
            this.lblDangKy.MouseLeave += new System.EventHandler(this.lblDangKy_MouseLeave);
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnDangNhap.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangNhap.ForeColor = System.Drawing.Color.White;
            this.btnDangNhap.Location = new System.Drawing.Point(44, 350);
            this.btnDangNhap.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.Size = new System.Drawing.Size(282, 49);
            this.btnDangNhap.TabIndex = 3;
            this.btnDangNhap.Text = "ĐĂNG NHẬP";
            this.btnDangNhap.UseVisualStyleBackColor = false;
            this.btnDangNhap.Click += new System.EventHandler(this.btnDangNhap_Click);
            this.btnDangNhap.MouseEnter += new System.EventHandler(this.btnDangNhap_MouseEnter);
            this.btnDangNhap.MouseLeave += new System.EventHandler(this.btnDangNhap_MouseLeave);
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMatKhau.ForeColor = System.Drawing.Color.DarkGray;
            this.txtMatKhau.Location = new System.Drawing.Point(44, 223);
            this.txtMatKhau.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMatKhau.Multiline = true;
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.Size = new System.Drawing.Size(282, 50);
            this.txtMatKhau.TabIndex = 2;
            this.txtMatKhau.Text = "MẬT KHẨU";
            this.txtMatKhau.TextChanged += new System.EventHandler(this.txtMatKhau_TextChanged);
            this.txtMatKhau.Enter += new System.EventHandler(this.txtMatKhau_Enter);
            this.txtMatKhau.Leave += new System.EventHandler(this.txtMatKhau_Leave);
            // 
            // txtTenDangNhap
            // 
            this.txtTenDangNhap.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenDangNhap.ForeColor = System.Drawing.Color.DarkGray;
            this.txtTenDangNhap.Location = new System.Drawing.Point(44, 157);
            this.txtTenDangNhap.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTenDangNhap.Multiline = true;
            this.txtTenDangNhap.Name = "txtTenDangNhap";
            this.txtTenDangNhap.Size = new System.Drawing.Size(282, 50);
            this.txtTenDangNhap.TabIndex = 1;
            this.txtTenDangNhap.Text = "TÊN ĐĂNG NHẬP";
            this.txtTenDangNhap.Enter += new System.EventHandler(this.txtTenDangNhap_Enter);
            this.txtTenDangNhap.Leave += new System.EventHandler(this.txtTenDangNhap_Leave);
            // 
            // lblLoiChao
            // 
            this.lblLoiChao.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoiChao.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.lblLoiChao.Location = new System.Drawing.Point(26, 21);
            this.lblLoiChao.Name = "lblLoiChao";
            this.lblLoiChao.Size = new System.Drawing.Size(300, 99);
            this.lblLoiChao.TabIndex = 0;
            this.lblLoiChao.Text = "CHÀO BẠN            MỪNG TRỞ LẠI";
            // 
            // frmDangNhap
            // 
            this.AcceptButton = this.btnDangNhap;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1099, 530);
            this.Controls.Add(this.splitContainer1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmDangNhap";
            this.Padding = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phần mềm quản lý thư viện";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picTuSach)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label lblTieuDe;
        private System.Windows.Forms.PictureBox picTuSach;
        private System.Windows.Forms.Label lblLoiChao;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.TextBox txtTenDangNhap;
        private System.Windows.Forms.Button btnDangNhap;
        private System.Windows.Forms.Label lblDangKy;
        private System.Windows.Forms.Label lblQuenMatKhau;
        private System.Windows.Forms.CheckBox chkAnHienMatKhau;
    }
}

