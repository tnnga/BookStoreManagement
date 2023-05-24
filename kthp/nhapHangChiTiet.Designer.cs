namespace kthp
{
    partial class nhapHangChiTiet
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblMaNhapHang = new System.Windows.Forms.Label();
            this.txtMaNhapHang = new System.Windows.Forms.Label();
            this.dgwChiTietNhapHang = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwChiTietNhapHang)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panel1.Controls.Add(this.lblMaNhapHang);
            this.panel1.Controls.Add(this.txtMaNhapHang);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 100);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgwChiTietNhapHang);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 100);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 350);
            this.panel2.TabIndex = 1;
            // 
            // lblMaNhapHang
            // 
            this.lblMaNhapHang.AutoSize = true;
            this.lblMaNhapHang.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaNhapHang.ForeColor = System.Drawing.Color.White;
            this.lblMaNhapHang.Location = new System.Drawing.Point(19, 38);
            this.lblMaNhapHang.Name = "lblMaNhapHang";
            this.lblMaNhapHang.Size = new System.Drawing.Size(167, 27);
            this.lblMaNhapHang.TabIndex = 14;
            this.lblMaNhapHang.Text = "Mã nhập hàng";
            // 
            // txtMaNhapHang
            // 
            this.txtMaNhapHang.BackColor = System.Drawing.Color.MintCream;
            this.txtMaNhapHang.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaNhapHang.Location = new System.Drawing.Point(222, 17);
            this.txtMaNhapHang.Name = "txtMaNhapHang";
            this.txtMaNhapHang.Size = new System.Drawing.Size(559, 66);
            this.txtMaNhapHang.TabIndex = 13;
            // 
            // dgwChiTietNhapHang
            // 
            this.dgwChiTietNhapHang.BackgroundColor = System.Drawing.Color.LightSeaGreen;
            this.dgwChiTietNhapHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwChiTietNhapHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgwChiTietNhapHang.GridColor = System.Drawing.Color.LightSeaGreen;
            this.dgwChiTietNhapHang.Location = new System.Drawing.Point(0, 0);
            this.dgwChiTietNhapHang.Name = "dgwChiTietNhapHang";
            this.dgwChiTietNhapHang.RowHeadersWidth = 62;
            this.dgwChiTietNhapHang.RowTemplate.Height = 28;
            this.dgwChiTietNhapHang.Size = new System.Drawing.Size(800, 350);
            this.dgwChiTietNhapHang.TabIndex = 0;
            // 
            // nhapHangChiTiet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "nhapHangChiTiet";
            this.Text = "nhapHangChiTiet";
            this.Load += new System.EventHandler(this.nhapHangChiTiet_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgwChiTietNhapHang)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblMaNhapHang;
        private System.Windows.Forms.Label txtMaNhapHang;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgwChiTietNhapHang;
    }
}