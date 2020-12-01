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
using QL_TV.Entity;

namespace QL_TV
{
    public partial class TrangChu : Form
    {
        QLTV ql = new QLTV();
        NhanVien nv = new NhanVien();
        public TrangChu(string id)
        {
            InitializeComponent();
            panelControl.Controls.Add(new Home());
            nv = ql.NhanViens.FirstOrDefault(n => n.ID == id);
            btnAccount.Text = nv.Ten_NhanVien;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDocGia_Click(object sender, EventArgs e)
        {
            panelControl.Controls.Clear();
            panelControl.Controls.Add(new DocGia());
        }

        private void btnDauSach_Click(object sender, EventArgs e)
        {
            panelControl.Controls.Clear();
            panelControl.Controls.Add(new UserDauSach());
        }

        private void btnQuanLy_Click(object sender, EventArgs e)
        {
            panelControl.Controls.Clear();
            panelControl.Controls.Add(new QuanLy(nv.Ma_NhanVien));
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            Thread thr = new Thread(Logout);
            thr.SetApartmentState(ApartmentState.STA);
            thr.Start();
            this.Close();
        }
        private void Logout()
        {
            DangNhap dn = new DangNhap();
            dn.ShowDialog();
        }
    }
}
