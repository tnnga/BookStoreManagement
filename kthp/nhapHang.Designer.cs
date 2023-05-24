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
            this.dgwNhapHang = new System.Windows.Forms.DataGridView();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.cbTimKiemTheo = new System.Windows.Forms.ComboBox();
            this.lblTimKiemTheo = new System.Windows.Forms.Label();
            this.btnTaoNhapHang = new System.Windows.Forms.Button();
            this.btnTim = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgwNhapHang)).BeginInit();
            this.SuspendLayout();
            // 
            // dgwNhapHang
            // 
            this.dgwNhapHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwNhapHang.Location = new System.Drawing.Point(12, 115);
            this.dgwNhapHang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgwNhapHang.Name = "dgwNhapHang";
            this.dgwNhapHang.RowHeadersWidth = 62;
            this.dgwNhapHang.RowTemplate.Height = 28;
            this.dgwNhapHang.Size = new System.Drawing.Size(1014, 494);
            this.dgwNhapHang.TabIndex = 28;
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimKiem.Location = new System.Drawing.Point(223, 54);
            this.txtTimKiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(442, 32);
            this.txtTimKiem.TabIndex = 27;
            // 
            // cbTimKiemTheo
            // 
            this.cbTimKiemTheo.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTimKiemTheo.FormattingEnabled = true;
            this.cbTimKiemTheo.Items.AddRange(new object[] {
            "Mã nhập hàng",
            "Tên nhân viên",
            "Ngày nhập hàng"});
            this.cbTimKiemTheo.Location = new System.Drawing.Point(12, 54);
            this.cbTimKiemTheo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbTimKiemTheo.Name = "cbTimKiemTheo";
            this.cbTimKiemTheo.Size = new System.Drawing.Size(177, 32);
            this.cbTimKiemTheo.TabIndex = 26;
            this.cbTimKiemTheo.Text = "(Lựa chọn)";
            // 
            // lblTimKiemTheo
            // 
            this.lblTimKiemTheo.AutoSize = true;
            this.lblTimKiemTheo.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimKiemTheo.ForeColor = System.Drawing.Color.White;
            this.lblTimKiemTheo.Location = new System.Drawing.Point(8, 15);
            this.lblTimKiemTheo.Name = "lblTimKiemTheo";
            this.lblTimKiemTheo.Size = new System.Drawing.Size(160, 24);
            this.lblTimKiemTheo.TabIndex = 25;
            this.lblTimKiemTheo.Text = "Tìm kiếm theo:";
            // 
            // btnTaoNhapHang
            // 
            this.btnTaoNhapHang.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTaoNhapHang.ForeColor = System.Drawing.Color.Black;
            this.btnTaoNhapHang.Location = new System.Drawing.Point(910, 48);
            this.btnTaoNhapHang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTaoNhapHang.Name = "btnTaoNhapHang";
            this.btnTaoNhapHang.Size = new System.Drawing.Size(115, 45);
            this.btnTaoNhapHang.TabIndex = 24;
            this.btnTaoNhapHang.Text = "Tạo";
            this.btnTaoNhapHang.UseVisualStyleBackColor = true;
            this.btnTaoNhapHang.Click += new System.EventHandler(this.btnTaoNhapHang_Click);
            // 
            // btnTim
            // 
            this.btnTim.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTim.ForeColor = System.Drawing.Color.Black;
            this.btnTim.Location = new System.Drawing.Point(762, 48);
            this.btnTim.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(115, 45);
            this.btnTim.TabIndex = 29;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // nhapHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(1040, 622);
            this.Controls.Add(this.btnTim);
            this.Controls.Add(this.dgwNhapHang);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.cbTimKiemTheo);
            this.Controls.Add(this.lblTimKiemTheo);
            this.Controls.Add(this.btnTaoNhapHang);
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "nhapHang";
            this.Text = "nhapHang";
            this.Load += new System.EventHandler(this.nhapHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwNhapHang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwNhapHang;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.ComboBox cbTimKiemTheo;
        private System.Windows.Forms.Label lblTimKiemTheo;
        private System.Windows.Forms.Button btnTaoNhapHang;
        private System.Windows.Forms.Button btnTim;
    }
}