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
            this.lblQuenMatKhau = new System.Windows.Forms.Label();
            this.lblDangKy = new System.Windows.Forms.Label();
            this.btnDangNhap = new System.Windows.Forms.Button();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.txtTenDangNhap = new System.Windows.Forms.TextBox();
            this.lblLoiChao = new System.Windows.Forms.Label();
            this.chkAnHienMatKhau = new System.Windows.Forms.CheckBox();
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
            this.splitContainer1.Location = new System.Drawing.Point(15, 15);
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
            this.splitContainer1.Size = new System.Drawing.Size(1206, 633);
            this.splitContainer1.SplitterDistance = 785;
            this.splitContainer1.TabIndex = 0;
            // 
            // picTuSach
            // 
            this.picTuSach.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.picTuSach.ErrorImage = ((System.Drawing.Image)(resources.GetObject("picTuSach.ErrorImage")));
            this.picTuSach.Image = ((System.Drawing.Image)(resources.GetObject("picTuSach.Image")));
            this.picTuSach.Location = new System.Drawing.Point(137, 217);
            this.picTuSach.Name = "picTuSach";
            this.picTuSach.Size = new System.Drawing.Size(609, 383);
            this.picTuSach.TabIndex = 1;
            this.picTuSach.TabStop = false;
            // 
            // lblTieuDe
            // 
            this.lblTieuDe.Font = new System.Drawing.Font("Tahoma", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTieuDe.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTieuDe.Location = new System.Drawing.Point(12, 19);
            this.lblTieuDe.Name = "lblTieuDe";
            this.lblTieuDe.Size = new System.Drawing.Size(628, 131);
            this.lblTieuDe.TabIndex = 0;
            this.lblTieuDe.Text = "PHẦN MỀM QUẢN LÝ                  NHÀ SÁCH THIÊN AN";
            // 
            // lblQuenMatKhau
            // 
            this.lblQuenMatKhau.AutoSize = true;
            this.lblQuenMatKhau.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuenMatKhau.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblQuenMatKhau.Location = new System.Drawing.Point(217, 517);
            this.lblQuenMatKhau.Name = "lblQuenMatKhau";
            this.lblQuenMatKhau.Size = new System.Drawing.Size(149, 19);
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
            this.lblDangKy.Location = new System.Drawing.Point(45, 517);
            this.lblDangKy.Name = "lblDangKy";
            this.lblDangKy.Size = new System.Drawing.Size(84, 19);
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
            this.btnDangNhap.Location = new System.Drawing.Point(49, 438);
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.Size = new System.Drawing.Size(317, 61);
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
            this.txtMatKhau.Location = new System.Drawing.Point(49, 279);
            this.txtMatKhau.Multiline = true;
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.PasswordChar = '*';
            this.txtMatKhau.Size = new System.Drawing.Size(317, 61);
            this.txtMatKhau.TabIndex = 2;
            this.txtMatKhau.Text = "MẬT KHẨU";
            this.txtMatKhau.Enter += new System.EventHandler(this.txtMatKhau_Enter);
            this.txtMatKhau.Leave += new System.EventHandler(this.txtMatKhau_Leave);
            // 
            // txtTenDangNhap
            // 
            this.txtTenDangNhap.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenDangNhap.ForeColor = System.Drawing.Color.DarkGray;
            this.txtTenDangNhap.Location = new System.Drawing.Point(49, 196);
            this.txtTenDangNhap.Multiline = true;
            this.txtTenDangNhap.Name = "txtTenDangNhap";
            this.txtTenDangNhap.Size = new System.Drawing.Size(317, 61);
            this.txtTenDangNhap.TabIndex = 1;
            this.txtTenDangNhap.Text = "TÊN ĐĂNG NHẬP";
            this.txtTenDangNhap.Enter += new System.EventHandler(this.txtTenDangNhap_Enter);
            this.txtTenDangNhap.Leave += new System.EventHandler(this.txtTenDangNhap_Leave);
            // 
            // lblLoiChao
            // 
            this.lblLoiChao.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoiChao.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.lblLoiChao.Location = new System.Drawing.Point(29, 26);
            this.lblLoiChao.Name = "lblLoiChao";
            this.lblLoiChao.Size = new System.Drawing.Size(337, 124);
            this.lblLoiChao.TabIndex = 0;
            this.lblLoiChao.Text = "CHÀO BẠN            MỪNG TRỞ LẠI";
            // 
            // chkAnHienMatKhau
            // 
            this.chkAnHienMatKhau.AutoSize = true;
            this.chkAnHienMatKhau.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkAnHienMatKhau.ForeColor = System.Drawing.Color.White;
            this.chkAnHienMatKhau.Location = new System.Drawing.Point(212, 362);
            this.chkAnHienMatKhau.Name = "chkAnHienMatKhau";
            this.chkAnHienMatKhau.Size = new System.Drawing.Size(154, 23);
            this.chkAnHienMatKhau.TabIndex = 4;
            this.chkAnHienMatKhau.Text = "Hiện mật khẩu";
            this.chkAnHienMatKhau.UseVisualStyleBackColor = true;
            this.chkAnHienMatKhau.CheckedChanged += new System.EventHandler(this.chkAnHienMatKhau_CheckedChanged);
            // 
            // frmDangNhap
            // 
            this.AcceptButton = this.btnDangNhap;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1236, 663);
            this.Controls.Add(this.splitContainer1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmDangNhap";
            this.Padding = new System.Windows.Forms.Padding(15);
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

