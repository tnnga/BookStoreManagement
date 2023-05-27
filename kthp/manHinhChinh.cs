using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kthp
{
    public partial class frmManHinhChinh : Form
    {
        public frmManHinhChinh()
        {
            InitializeComponent();
        }
        private Form currentFormChild;
        private void OpenChildForm(Form childForm)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }

            currentFormChild = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pnlManHinhChinh.Controls.Add(childForm);
            pnlManHinhChinh.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private void lblDangXuat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn chắc chắn muốn đăng xuất", "Nhắc nhờ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                    this.Close();
            }

        }

        private void lblDangXuat_MouseEnter(object sender, EventArgs e)
        {
            lblDangXuat.BackColor = Color.LightSeaGreen;
            Cursor = Cursors.Hand;
        }

        private void lblDangXuat_MouseLeave(object sender, EventArgs e)
        {
            lblDangXuat.BackColor = Color.Black;
            Cursor = Cursors.Default;
        }

        private void lblTrangChu_Click(object sender, EventArgs e)
        {
            OpenChildForm(new trangChu());
            lblMucLon.Text = lblTrangChu.Text.ToUpper();
        }

        private void lblSanPham_Click(object sender, EventArgs e)
        {
            OpenChildForm(new sanPham());
            lblMucLon.Text = lblSanPham.Text.ToUpper();
        }

        private void lblHoaDon_Click(object sender, EventArgs e)
        {
            OpenChildForm(new hoaDon());
            lblMucLon.Text = lblHoaDon.Text.ToUpper();
        }

        private void lblNhapHang_Click(object sender, EventArgs e)
        {
            OpenChildForm(new nhapHang());
            lblMucLon.Text = lblNhapHang.Text.ToUpper();
        }

        private void lblCaiDat_Click(object sender, EventArgs e)
        {
            OpenChildForm(new caiDat());
            lblMucLon.Text = lblCaiDat.Text.ToUpper();
        }

        private void lblKhachHang_Click(object sender, EventArgs e)
        {
            OpenChildForm(new khachHang());
            lblMucLon.Text = lblKhachHang.Text.ToUpper();
        }
    }
}
