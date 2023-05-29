namespace kthp
{
    partial class hoaDonChiTiet
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
            this.lblMaHoaDon = new System.Windows.Forms.Label();
            this.txtMaHoaDon = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgwChiTietHoaDon = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwChiTietHoaDon)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblMaHoaDon);
            this.panel1.Controls.Add(this.txtMaHoaDon);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(870, 116);
            this.panel1.TabIndex = 0;
            // 
            // lblMaHoaDon
            // 
            this.lblMaHoaDon.AutoSize = true;
            this.lblMaHoaDon.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaHoaDon.ForeColor = System.Drawing.Color.White;
            this.lblMaHoaDon.Location = new System.Drawing.Point(164, 37);
            this.lblMaHoaDon.Name = "lblMaHoaDon";
            this.lblMaHoaDon.Size = new System.Drawing.Size(288, 34);
            this.lblMaHoaDon.TabIndex = 16;
            this.lblMaHoaDon.Text = "CHI TIẾT HÓA ĐƠN";
            // 
            // txtMaHoaDon
            // 
            this.txtMaHoaDon.BackColor = System.Drawing.Color.MintCream;
            this.txtMaHoaDon.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaHoaDon.Location = new System.Drawing.Point(548, 20);
            this.txtMaHoaDon.Name = "txtMaHoaDon";
            this.txtMaHoaDon.Size = new System.Drawing.Size(197, 66);
            this.txtMaHoaDon.TabIndex = 15;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgwChiTietHoaDon);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 116);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(870, 411);
            this.panel2.TabIndex = 1;
            // 
            // dgwChiTietHoaDon
            // 
            this.dgwChiTietHoaDon.BackgroundColor = System.Drawing.Color.LightSeaGreen;
            this.dgwChiTietHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwChiTietHoaDon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgwChiTietHoaDon.GridColor = System.Drawing.Color.LightSeaGreen;
            this.dgwChiTietHoaDon.Location = new System.Drawing.Point(0, 0);
            this.dgwChiTietHoaDon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgwChiTietHoaDon.Name = "dgwChiTietHoaDon";
            this.dgwChiTietHoaDon.RowHeadersWidth = 62;
            this.dgwChiTietHoaDon.RowTemplate.Height = 28;
            this.dgwChiTietHoaDon.Size = new System.Drawing.Size(870, 411);
            this.dgwChiTietHoaDon.TabIndex = 1;
            // 
            // hoaDonChiTiet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(870, 527);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "hoaDonChiTiet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phần mềm quản lí nhà sách";
            this.Load += new System.EventHandler(this.hoaDonChiTiet_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgwChiTietHoaDon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgwChiTietHoaDon;
        private System.Windows.Forms.Label lblMaHoaDon;
        private System.Windows.Forms.Label txtMaHoaDon;
    }
}