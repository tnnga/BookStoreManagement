namespace kthp
{
    partial class frmHoaDonThemChiTiet
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
            this.btnThemChiTiet = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnHoanTat = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblChiTietHoaDon = new System.Windows.Forms.Label();
            this.lblMaHoaDon = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgwHoaDonThemChiTiet = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwHoaDonThemChiTiet)).BeginInit();
            this.SuspendLayout();
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
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
            this.btnThemChiTiet.TabIndex = 11;
            this.btnThemChiTiet.Text = "Thêm";
            this.btnThemChiTiet.UseVisualStyleBackColor = false;
            this.btnThemChiTiet.Click += new System.EventHandler(this.btnThemChiTiet_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnHoanTat);
            this.panel1.Controls.Add(this.btnThemChiTiet);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(10, 347);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(750, 100);
            this.panel1.TabIndex = 12;
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
            this.btnHoanTat.Size = new System.Drawing.Size(466, 100);
            this.btnHoanTat.TabIndex = 10;
            this.btnHoanTat.Text = "HOÀN THÀNH THÊM CHI TIẾT";
            this.btnHoanTat.UseVisualStyleBackColor = false;
            this.btnHoanTat.Click += new System.EventHandler(this.btnHoanTat_Click_1);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblMaHoaDon);
            this.panel2.Controls.Add(this.lblChiTietHoaDon);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(10, 10);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(750, 100);
            this.panel2.TabIndex = 13;
            // 
            // lblChiTietHoaDon
            // 
            this.lblChiTietHoaDon.BackColor = System.Drawing.Color.MintCream;
            this.lblChiTietHoaDon.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblChiTietHoaDon.Font = new System.Drawing.Font("Tahoma", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChiTietHoaDon.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.lblChiTietHoaDon.Location = new System.Drawing.Point(0, 0);
            this.lblChiTietHoaDon.Name = "lblChiTietHoaDon";
            this.lblChiTietHoaDon.Size = new System.Drawing.Size(440, 100);
            this.lblChiTietHoaDon.TabIndex = 4;
            this.lblChiTietHoaDon.Text = "CHI TIẾT HÓA ĐƠN";
            this.lblChiTietHoaDon.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblMaHoaDon
            // 
            this.lblMaHoaDon.BackColor = System.Drawing.Color.MintCream;
            this.lblMaHoaDon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMaHoaDon.Font = new System.Drawing.Font("Tahoma", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaHoaDon.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.lblMaHoaDon.Location = new System.Drawing.Point(440, 0);
            this.lblMaHoaDon.Name = "lblMaHoaDon";
            this.lblMaHoaDon.Size = new System.Drawing.Size(310, 100);
            this.lblMaHoaDon.TabIndex = 5;
            this.lblMaHoaDon.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dgwHoaDonThemChiTiet);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(10, 110);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(750, 237);
            this.panel3.TabIndex = 14;
            // 
            // dgwHoaDonThemChiTiet
            // 
            this.dgwHoaDonThemChiTiet.BackgroundColor = System.Drawing.Color.MintCream;
            this.dgwHoaDonThemChiTiet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwHoaDonThemChiTiet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgwHoaDonThemChiTiet.Location = new System.Drawing.Point(0, 0);
            this.dgwHoaDonThemChiTiet.Name = "dgwHoaDonThemChiTiet";
            this.dgwHoaDonThemChiTiet.RowHeadersWidth = 62;
            this.dgwHoaDonThemChiTiet.RowTemplate.Height = 28;
            this.dgwHoaDonThemChiTiet.Size = new System.Drawing.Size(750, 237);
            this.dgwHoaDonThemChiTiet.TabIndex = 11;
            // 
            // frmHoaDonThemChiTiet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 457);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmHoaDonThemChiTiet";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Text = "hoaDonThemChiTiet";
            this.Load += new System.EventHandler(this.frmHoaDonThemChiTiet_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgwHoaDonThemChiTiet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button btnThemChiTiet;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dgwHoaDonThemChiTiet;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblMaHoaDon;
        private System.Windows.Forms.Label lblChiTietHoaDon;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnHoanTat;
    }
}