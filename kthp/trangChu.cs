﻿using System;
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
    public partial class trangChu : Form
    {
        public trangChu()
        {
            InitializeComponent();
        }

        private void btnTaiKhoan_Click(object sender, EventArgs e)
        {
            chiTietTaiKhoan chiTietTaiKhoan = new chiTietTaiKhoan();
            chiTietTaiKhoan.Show();
        }
    }
}
