using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace kthp
{
    public partial class frmQuenMatKhau : Form
    {
        public List<string> tenDangNhap = new List<string>();
        public List<string> email = new List<string>();

        public string tenDangNhapMK;
        public string matKhauMoi;

        public frmQuenMatKhau()
        {
            InitializeComponent();
        }
        public frmQuenMatKhau(List<string> tenDangNhap, List<string> email)
        {
            InitializeComponent();
            this.tenDangNhap = tenDangNhap;
            this.email = email;
        }
        private void btnCheck_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < tenDangNhap.Count; i++)
            {
                if (txtTenDangNhap.Text == tenDangNhap[i] && txtEmail.Text == email[i])
                {
                    frmNhapLaiMatKhau nhapLaiMatKhau = new frmNhapLaiMatKhau();
                    nhapLaiMatKhau.FormClosed += new FormClosedEventHandler(nhapLaiMatKhau_FormClosed);
                    nhapLaiMatKhau.ShowDialog();
                    tenDangNhapMK = tenDangNhap[i];
                    Close();
                }
                else if(txtTenDangNhap.Text == "" || txtEmail.Text == "")
                {
                    DialogResult result = MessageBox.Show("Vui lòng điền đủ thông tin!", "Nhắc nhở", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
                else 
                {
                    DialogResult result = MessageBox.Show("Không tim thấy tài khoản, vui lòng kiểm tra lại!", "Nhắc nhở", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }

            }
        }
        private void nhapLaiMatKhau_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmNhapLaiMatKhau nhapLai = (frmNhapLaiMatKhau)sender;
            string valueMatKhauMoi = nhapLai.matKhauMoi;

            matKhauMoi = valueMatKhauMoi;
        }
    }
}
