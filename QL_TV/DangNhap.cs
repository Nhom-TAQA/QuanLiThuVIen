using QL_TV.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_TV
{
    public partial class DangNhap : Form
    {
        QLTV ql = new QLTV();
        private string ID;
        public DangNhap()
        {
            InitializeComponent();
            txbMatKhau.UseSystemPasswordChar = true;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            TaiKhoan tk = ql.TaiKhoans.Where(n => n.TenDangNhap == txbTenDangNhap.Text && n.MatKhau == txbMatKhau.Text).FirstOrDefault();
            if (tk != null)
            {
                DialogResult result = MessageBox.Show("Đăng nhập thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Thread thr = new Thread(NewForm);
                thr.SetApartmentState(ApartmentState.STA);
                thr.Start();
                this.Close();

            }
            else
            {
                DialogResult result = MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        void NewForm()
        {
            TrangChu tc = new TrangChu(ID);
            tc.ShowDialog();
        }

        private void checkBoxShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxShowPass.Checked == true)
            {
                txbMatKhau.UseSystemPasswordChar = false;
            }
            else
            {
                txbMatKhau.UseSystemPasswordChar = true;
            }
        }
    }
}
