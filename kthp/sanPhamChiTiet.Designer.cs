namespace kthp
{
    partial class frmSanPhamChiTiet
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
            this.lblTenSach = new System.Windows.Forms.Label();
            this.lblGiaSach = new System.Windows.Forms.Label();
            this.lblLoaiSach = new System.Windows.Forms.Label();
            this.lblSoLuongTon = new System.Windows.Forms.Label();
            this.lblTomTatNoiDung = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTenSach
            // 
            this.lblTenSach.BackColor = System.Drawing.Color.MintCream;
            this.lblTenSach.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenSach.Location = new System.Drawing.Point(22, 34);
            this.lblTenSach.Name = "lblTenSach";
            this.lblTenSach.Size = new System.Drawing.Size(512, 53);
            this.lblTenSach.TabIndex = 0;
            this.lblTenSach.Text = "Tên sách";
            // 
            // lblGiaSach
            // 
            this.lblGiaSach.BackColor = System.Drawing.Color.MintCream;
            this.lblGiaSach.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGiaSach.Location = new System.Drawing.Point(22, 258);
            this.lblGiaSach.Name = "lblGiaSach";
            this.lblGiaSach.Size = new System.Drawing.Size(243, 53);
            this.lblGiaSach.TabIndex = 0;
            this.lblGiaSach.Text = "Giá tiền";
            // 
            // lblLoaiSach
            // 
            this.lblLoaiSach.BackColor = System.Drawing.Color.MintCream;
            this.lblLoaiSach.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoaiSach.Location = new System.Drawing.Point(22, 149);
            this.lblLoaiSach.Name = "lblLoaiSach";
            this.lblLoaiSach.Size = new System.Drawing.Size(243, 70);
            this.lblLoaiSach.TabIndex = 1;
            this.lblLoaiSach.Text = "Loại sách";
            // 
            // lblSoLuongTon
            // 
            this.lblSoLuongTon.BackColor = System.Drawing.Color.MintCream;
            this.lblSoLuongTon.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoLuongTon.Location = new System.Drawing.Point(558, 34);
            this.lblSoLuongTon.Name = "lblSoLuongTon";
            this.lblSoLuongTon.Size = new System.Drawing.Size(129, 53);
            this.lblSoLuongTon.TabIndex = 1;
            this.lblSoLuongTon.Text = "Số lượng";
            // 
            // lblTomTatNoiDung
            // 
            this.lblTomTatNoiDung.BackColor = System.Drawing.Color.MintCream;
            this.lblTomTatNoiDung.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTomTatNoiDung.Location = new System.Drawing.Point(300, 149);
            this.lblTomTatNoiDung.Name = "lblTomTatNoiDung";
            this.lblTomTatNoiDung.Size = new System.Drawing.Size(387, 162);
            this.lblTomTatNoiDung.TabIndex = 1;
            this.lblTomTatNoiDung.Text = "Nội dung chính ";
            // 
            // frmSanPhamChiTiet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(701, 333);
            this.Controls.Add(this.lblSoLuongTon);
            this.Controls.Add(this.lblTomTatNoiDung);
            this.Controls.Add(this.lblLoaiSach);
            this.Controls.Add(this.lblGiaSach);
            this.Controls.Add(this.lblTenSach);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmSanPhamChiTiet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "sanPhamChiTiet";
            this.Load += new System.EventHandler(this.frmSanPhamChiTiet_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTenSach;
        private System.Windows.Forms.Label lblGiaSach;
        private System.Windows.Forms.Label lblLoaiSach;
        private System.Windows.Forms.Label lblSoLuongTon;
        private System.Windows.Forms.Label lblTomTatNoiDung;
    }
}