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
            this.crwNhapHang.Name = "crwNhapHang";
            this.crwNhapHang.Size = new System.Drawing.Size(1605, 1055);
            this.crwNhapHang.TabIndex = 0;
            this.crwNhapHang.Load += new System.EventHandler(this.crwNhapHang_Load);
            // 
            // reportNhapHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1605, 1055);
            this.Controls.Add(this.crwNhapHang);
            this.Name = "reportNhapHang";
            this.Text = "reportNhapHang";
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crwNhapHang;
    }
}