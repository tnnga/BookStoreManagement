using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace kthp
{
    public partial class frmDangNhap : Form
    {
        public List<string> tenDangNhap = new List<string>();
        public List<string> matKhau = new List<string>();
        public List<string> email = new List<string>();

        public bool kiemTra = false;
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void txtTenDangNhap_Enter(object sender, EventArgs e)
        {
            if (txtTenDangNhap.Text == "TÊN ĐĂNG NHẬP")
            {
                txtTenDangNhap.Text = null;
                txtTenDangNhap.ForeColor = Color.Black;
            }
        }

        private void txtTenDangNhap_Leave(object sender, EventArgs e)
        {
            if (txtTenDangNhap.Text == "")
            {
                txtTenDangNhap.Text = "TÊN ĐĂNG NHẬP";
                txtTenDangNhap.ForeColor = Color.DarkGray;
            }
        }

        private void txtMatKhau_Enter(object sender, EventArgs e)
        {
            if (txtMatKhau.Text == "MẬT KHẨU")
            {
                txtMatKhau.Text = null;
                txtMatKhau.ForeColor = Color.Black;
            }
        }

        private void txtMatKhau_Leave(object sender, EventArgs e)
        {
            if (txtMatKhau.Text == "")
            {
                txtMatKhau.Text = "MẬT KHẨU";
                txtMatKhau.ForeColor = Color.DarkGray;
            }
        }

        private void lblDangKy_Click(object sender, EventArgs e)
        {
            frmDangKy dangKy = new frmDangKy();
            dangKy.FormClosed += new FormClosedEventHandler(dangKy_FormClosed);
            dangKy.ShowDialog();
            kiemTra = true;
        }
        private void dangKy_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmDangKy form2 = (frmDangKy)sender;
            string valueTenDangNhap = form2.tenDangNhap;
            string valueMatKhau = form2.matKhau;
            string valueEmail = form2.email;

            tenDangNhap.Add(valueTenDangNhap);
            matKhau.Add(valueMatKhau);
            email.Add(valueEmail);
        }

        private void lblDangKy_MouseEnter(object sender, EventArgs e)
        {
            lblDangKy.ForeColor = Color.LightSeaGreen;
            lblDangKy.Font = new Font(lblDangKy.Font.FontFamily, lblDangKy.Font.Size + 1, FontStyle.Bold);
            Cursor = Cursors.Hand;
        }

        private void lblDangKy_MouseLeave(object sender, EventArgs e)
        {
            lblDangKy.ForeColor = Color.White;
            lblDangKy.Font = new Font(lblDangKy.Font.FontFamily, lblDangKy.Font.Size - 1, FontStyle.Bold);
            Cursor = Cursors.Default;
        }

        private void btnDangNhap_MouseEnter(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
            btnDangNhap.Font = new Font(btnDangNhap.Font.FontFamily, btnDangNhap.Font.Size + 2, btnDangNhap.Font.Style);
            btnDangNhap.ForeColor = Color.Cyan;
        }

        private void btnDangNhap_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
            btnDangNhap.Font = new Font(btnDangNhap.Font.FontFamily, btnDangNhap.Font.Size - 2, btnDangNhap.Font.Style);
            btnDangNhap.ForeColor = Color.White;
        }

        private void lblQuenMatKhau_Click(object sender, EventArgs e)
        {
            Form quenMatKhau = new frmQuenMatKhau(tenDangNhap, email);
            quenMatKhau.FormClosed += new FormClosedEventHandler(quenMatKhau_FormClosed);
            quenMatKhau.ShowDialog();
            
        }
        private void quenMatKhau_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmQuenMatKhau layMKMoi = (frmQuenMatKhau)sender;
            string valueMatKhauMoi = layMKMoi.matKhauMoi;
            string valueTenDangNhap = layMKMoi.tenDangNhapMK;

            for(int i = 0; i < tenDangNhap.Count; i++)
            {
                if(tenDangNhap[i] == valueTenDangNhap)
                {
                    matKhau.Remove(matKhau[i]);
                    matKhau.Insert(i, valueMatKhauMoi);
                }
            }
        }

        private void lblQuenMatKhau_MouseEnter(object sender, EventArgs e)
        {
            lblQuenMatKhau.ForeColor = Color.LightSeaGreen;
            lblQuenMatKhau.Font = new Font(lblQuenMatKhau.Font.FontFamily, lblQuenMatKhau.Font.Size + 1, FontStyle.Bold);
            Cursor = Cursors.Hand;
        }

        private void lblQuenMatKhau_MouseLeave(object sender, EventArgs e)
        {
            lblQuenMatKhau.ForeColor = Color.White;
            lblQuenMatKhau.Font = new Font(lblQuenMatKhau.Font.FontFamily, lblQuenMatKhau.Font.Size - 1, FontStyle.Bold);
            Cursor = Cursors.Default;
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (kiemTra == false)
            {
                DialogResult result = MessageBox.Show("Bạn chưa đăng kí tài khoản, vui lòng đăng kí!", "Nhắc nhờ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                for (int i = 0; i < tenDangNhap.Count; i++)
                {
                    if (txtTenDangNhap.Text == tenDangNhap[i] && txtMatKhau.Text == matKhau[i])
                    {
                        this.Hide();

                        frmManHinhChinh trangChu = new frmManHinhChinh();
                        trangChu.ShowDialog();
                    }
                    else
                    {
                        DialogResult result = MessageBox.Show("Không tim thấy tài khoản, vui lòng kiểm tra lại!", "Nhắc nhở", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    }
                }
            }
        }
        private void frmDangNhap_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc muốn thoát chương trình không?", "Xác nhận thoát chương trình", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.No)
            {
                e.Cancel = true; 
            }
        }
    }
}
