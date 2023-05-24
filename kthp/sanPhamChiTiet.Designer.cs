namespace kthp
{
    partial class sanPhamChiTiet
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
            this.lblTenSach.Location = new System.Drawing.Point(25, 43);
            this.lblTenSach.Name = "lblTenSach";
            this.lblTenSach.Size = new System.Drawing.Size(576, 66);
            this.lblTenSach.TabIndex = 0;
            // 
            // lblGiaSach
            // 
            this.lblGiaSach.BackColor = System.Drawing.Color.MintCream;
            this.lblGiaSach.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGiaSach.Location = new System.Drawing.Point(669, 43);
            this.lblGiaSach.Name = "lblGiaSach";
            this.lblGiaSach.Size = new System.Drawing.Size(104, 66);
            this.lblGiaSach.TabIndex = 0;
            // 
            // lblLoaiSach
            // 
            this.lblLoaiSach.BackColor = System.Drawing.Color.MintCream;
            this.lblLoaiSach.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoaiSach.Location = new System.Drawing.Point(25, 186);
            this.lblLoaiSach.Name = "lblLoaiSach";
            this.lblLoaiSach.Size = new System.Drawing.Size(273, 87);
            this.lblLoaiSach.TabIndex = 1;
            this.lblLoaiSach.Text = "Loại sách";
            // 
            // lblSoLuongTon
            // 
            this.lblSoLuongTon.BackColor = System.Drawing.Color.MintCream;
            this.lblSoLuongTon.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoLuongTon.Location = new System.Drawing.Point(25, 304);
            this.lblSoLuongTon.Name = "lblSoLuongTon";
            this.lblSoLuongTon.Size = new System.Drawing.Size(273, 85);
            this.lblSoLuongTon.TabIndex = 1;
            this.lblSoLuongTon.Text = "Số lượng";
            // 
            // lblTomTatNoiDung
            // 
            this.lblTomTatNoiDung.BackColor = System.Drawing.Color.MintCream;
            this.lblTomTatNoiDung.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTomTatNoiDung.Location = new System.Drawing.Point(338, 186);
            this.lblTomTatNoiDung.Name = "lblTomTatNoiDung";
            this.lblTomTatNoiDung.Size = new System.Drawing.Size(435, 203);
            this.lblTomTatNoiDung.TabIndex = 1;
            this.lblTomTatNoiDung.Text = "Nội dung chính ";
            // 
            // sanPhamChiTiet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(789, 416);
            this.Controls.Add(this.lblSoLuongTon);
            this.Controls.Add(this.lblTomTatNoiDung);
            this.Controls.Add(this.lblLoaiSach);
            this.Controls.Add(this.lblGiaSach);
            this.Controls.Add(this.lblTenSach);
            this.Name = "sanPhamChiTiet";
            this.Text = "sanPhamChiTiet";
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