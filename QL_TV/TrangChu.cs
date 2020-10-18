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
          public TrangChu(string id)
          {
               InitializeComponent();
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

<<<<<<< HEAD
        private void btnQuanLy_Click(object sender, EventArgs e)
        {
            panelControl.Controls.Clear();
            panelControl.Controls.Add(new QuanLy(nv.Ma_NhanVien));
        }
=======
          private void btnQuanLy_Click(object sender, EventArgs e)
          {
               panelControl.Controls.Clear();
               panelControl.Controls.Add(new QuanLy());
          }
>>>>>>> parent of fe9ebb6... Hoang Anh

          private void btnLogOut_Click(object sender, EventArgs e)
          {

          }
          private void Logout()
          {
               DangNhap dn = new DangNhap();
               dn.ShowDialog();
          }
     }
}
