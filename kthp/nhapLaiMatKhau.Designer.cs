namespace kthp
{
    partial class frmNhapLaiMatKhau
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
            this.btnLuu = new System.Windows.Forms.Button();
            this.lblNewPassword = new System.Windows.Forms.Label();
            this.txtMatKhau2 = new System.Windows.Forms.TextBox();
            this.lblMatKhau = new System.Windows.Forms.Label();
            this.txtMatKhau1 = new System.Windows.Forms.TextBox();
            this.lblMatKhau1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnLuu.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.ForeColor = System.Drawing.Color.White;
            this.btnLuu.Location = new System.Drawing.Point(227, 288);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(202, 54);
            this.btnLuu.TabIndex = 14;
            this.btnLuu.Text = "LƯU";
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // lblNewPassword
            // 
            this.lblNewPassword.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblNewPassword.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewPassword.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.lblNewPassword.Location = new System.Drawing.Point(0, 0);
            this.lblNewPassword.Name = "lblNewPassword";
            this.lblNewPassword.Size = new System.Drawing.Size(441, 47);
            this.lblNewPassword.TabIndex = 13;
            this.lblNewPassword.Text = "Vui lòng điền mật khẩu mới";
            this.lblNewPassword.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtMatKhau2
            // 
            this.txtMatKhau2.BackColor = System.Drawing.Color.LightSeaGreen;
            this.txtMatKhau2.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMatKhau2.ForeColor = System.Drawing.Color.White;
            this.txtMatKhau2.Location = new System.Drawing.Point(12, 194);
            this.txtMatKhau2.Multiline = true;
            this.txtMatKhau2.Name = "txtMatKhau2";
            this.txtMatKhau2.Size = new System.Drawing.Size(417, 54);
            this.txtMatKhau2.TabIndex = 12;
            // 
            // lblMatKhau
            // 
            this.lblMatKhau.AutoSize = true;
            this.lblMatKhau.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMatKhau.Location = new System.Drawing.Point(8, 164);
            this.lblMatKhau.Name = "lblMatKhau";
            this.lblMatKhau.Size = new System.Drawing.Size(205, 27);
            this.lblMatKhau.TabIndex = 11;
            this.lblMatKhau.Text = "Điền lại mật khẩu";
            // 
            // txtMatKhau1
            // 
            this.txtMatKhau1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.txtMatKhau1.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMatKhau1.ForeColor = System.Drawing.Color.White;
            this.txtMatKhau1.Location = new System.Drawing.Point(12, 92);
            this.txtMatKhau1.Multiline = true;
            this.txtMatKhau1.Name = "txtMatKhau1";
            this.txtMatKhau1.Size = new System.Drawing.Size(417, 54);
            this.txtMatKhau1.TabIndex = 10;
            // 
            // lblMatKhau1
            // 
            this.lblMatKhau1.AutoSize = true;
            this.lblMatKhau1.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMatKhau1.Location = new System.Drawing.Point(8, 62);
            this.lblMatKhau1.Name = "lblMatKhau1";
            this.lblMatKhau1.Size = new System.Drawing.Size(220, 27);
            this.lblMatKhau1.TabIndex = 9;
            this.lblMatKhau1.Text = "Điền mật khẩu mới";
            // 
            // frmNhapLaiMatKhau
            // 
            this.AcceptButton = this.btnLuu;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 354);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.lblNewPassword);
            this.Controls.Add(this.txtMatKhau2);
            this.Controls.Add(this.lblMatKhau);
            this.Controls.Add(this.txtMatKhau1);
            this.Controls.Add(this.lblMatKhau1);
            this.Name = "frmNhapLaiMatKhau";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "nhapLaiMatKhau";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Label lblNewPassword;
        private System.Windows.Forms.TextBox txtMatKhau2;
        private System.Windows.Forms.Label lblMatKhau;
        private System.Windows.Forms.TextBox txtMatKhau1;
        private System.Windows.Forms.Label lblMatKhau1;
    }
}