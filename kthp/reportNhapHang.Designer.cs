namespace kthp
{
    partial class reportNhapHang
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
            this.crwNhapHang = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crwNhapHang
            // 
            this.crwNhapHang.ActiveViewIndex = -1;
            this.crwNhapHang.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crwNhapHang.Cursor = System.Windows.Forms.Cursors.Default;
            this.crwNhapHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crwNhapHang.Location = new System.Drawing.Point(0, 0);
            this.crwNhapHang.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.crwNhapHang.Name = "crwNhapHang";
            this.crwNhapHang.Size = new System.Drawing.Size(1806, 1050);
            this.crwNhapHang.TabIndex = 0;
            this.crwNhapHang.ToolPanelWidth = 225;
            this.crwNhapHang.Load += new System.EventHandler(this.crwNhapHang_Load);
            // 
            // reportNhapHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1806, 1050);
            this.Controls.Add(this.crwNhapHang);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "reportNhapHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phần mềm quản lý thư viện";
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crwNhapHang;
    }
}