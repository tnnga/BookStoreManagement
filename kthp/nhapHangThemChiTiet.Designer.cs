namespace kthp
{
    partial class frmNhapHangThemChiTiet
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
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblMaHoaDon = new System.Windows.Forms.Label();
            this.lblChiTietNhapHang = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnHoanTat = new System.Windows.Forms.Button();
            this.btnThemChiTiet = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgwNhapHangThemChiTiet = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwNhapHangThemChiTiet)).BeginInit();
            this.SuspendLayout();
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblMaHoaDon);
            this.panel1.Controls.Add(this.lblChiTietNhapHang);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(723, 100);
            this.panel1.TabIndex = 0;
            // 
            // lblMaHoaDon
            // 
            this.lblMaHoaDon.BackColor = System.Drawing.Color.MintCream;
            this.lblMaHoaDon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMaHoaDon.Font = new System.Drawing.Font("Tahoma", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaHoaDon.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.lblMaHoaDon.Location = new System.Drawing.Point(486, 0);
            this.lblMaHoaDon.Name = "lblMaHoaDon";
            this.lblMaHoaDon.Size = new System.Drawing.Size(237, 100);
            this.lblMaHoaDon.TabIndex = 7;
            this.lblMaHoaDon.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblChiTietNhapHang
            // 
            this.lblChiTietNhapHang.BackColor = System.Drawing.Color.MintCream;
            this.lblChiTietNhapHang.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblChiTietNhapHang.Font = new System.Drawing.Font("Tahoma", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChiTietNhapHang.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.lblChiTietNhapHang.Location = new System.Drawing.Point(0, 0);
            this.lblChiTietNhapHang.Name = "lblChiTietNhapHang";
            this.lblChiTietNhapHang.Size = new System.Drawing.Size(486, 100);
            this.lblChiTietNhapHang.TabIndex = 6;
            this.lblChiTietNhapHang.Text = "CHI TIẾT NHẬP HÀNG";
            this.lblChiTietNhapHang.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnHoanTat);
            this.panel2.Controls.Add(this.btnThemChiTiet);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 345);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(723, 100);
            this.panel2.TabIndex = 1;
            // 
            // btnHoanTat
            // 
            this.btnHoanTat.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnHoanTat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnHoanTat.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHoanTat.ForeColor = System.Drawing.Color.White;
            this.btnHoanTat.Location = new System.Drawing.Point(284, 0);
            this.btnHoanTat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnHoanTat.Name = "btnHoanTat";
            this.btnHoanTat.Size = new System.Drawing.Size(439, 100);
            this.btnHoanTat.TabIndex = 12;
            this.btnHoanTat.Text = "HOÀN THÀNH THÊM CHI TIẾT";
            this.btnHoanTat.UseVisualStyleBackColor = false;
            this.btnHoanTat.Click += new System.EventHandler(this.btnHoanTat_Click);
            // 
            // btnThemChiTiet
            // 
            this.btnThemChiTiet.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnThemChiTiet.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnThemChiTiet.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemChiTiet.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnThemChiTiet.Location = new System.Drawing.Point(0, 0);
            this.btnThemChiTiet.Name = "btnThemChiTiet";
            this.btnThemChiTiet.Size = new System.Drawing.Size(284, 100);
            this.btnThemChiTiet.TabIndex = 13;
            this.btnThemChiTiet.Text = "Thêm";
            this.btnThemChiTiet.UseVisualStyleBackColor = false;
            this.btnThemChiTiet.Click += new System.EventHandler(this.btnThemChiTiet_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dgwNhapHangThemChiTiet);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 100);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(723, 245);
            this.panel3.TabIndex = 2;
            // 
            // dgwNhapHangThemChiTiet
            // 
            this.dgwNhapHangThemChiTiet.BackgroundColor = System.Drawing.Color.MintCream;
            this.dgwNhapHangThemChiTiet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwNhapHangThemChiTiet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgwNhapHangThemChiTiet.Location = new System.Drawing.Point(0, 0);
            this.dgwNhapHangThemChiTiet.Name = "dgwNhapHangThemChiTiet";
            this.dgwNhapHangThemChiTiet.RowHeadersWidth = 62;
            this.dgwNhapHangThemChiTiet.RowTemplate.Height = 28;
            this.dgwNhapHangThemChiTiet.Size = new System.Drawing.Size(723, 245);
            this.dgwNhapHangThemChiTiet.TabIndex = 12;
            // 
            // frmNhapHangThemChiTiet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 445);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frmNhapHangThemChiTiet";
            this.Text = "nhapHangThemChiTiet";
            this.Load += new System.EventHandler(this.frmNhapHangThemChiTiet_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgwNhapHangThemChiTiet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblMaHoaDon;
        private System.Windows.Forms.Label lblChiTietNhapHang;
        private System.Windows.Forms.DataGridView dgwNhapHangThemChiTiet;
        private System.Windows.Forms.Button btnHoanTat;
        private System.Windows.Forms.Button btnThemChiTiet;
    }
}