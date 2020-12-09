using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_TV
{
     public partial class UserDauSach : UserControl
     {
          public UserDauSach()
          {
               InitializeComponent();
               btnDauSach.BackColor = System.Drawing.Color.ForestGreen;
               btnDauSach.ForeColor = System.Drawing.Color.White;
               panelData.Controls.Add(new TatCa_DauSach());
          }
          private void SetButtonColor()
          {
               btnDauSach.BackColor = System.Drawing.Color.LightYellow;
               btnDauSach.ForeColor = System.Drawing.Color.ForestGreen;
               btnTimKiem.BackColor = System.Drawing.Color.LightYellow;
               btnTimKiem.ForeColor = System.Drawing.Color.ForestGreen;
               btnThemMoi.BackColor = System.Drawing.Color.LightYellow;
               btnThemMoi.ForeColor = System.Drawing.Color.ForestGreen;
          }
          private void btnDauSach_Click(object sender, EventArgs e)
          {
               SetButtonColor();
               btnDauSach.BackColor = System.Drawing.Color.ForestGreen;
               btnDauSach.ForeColor = System.Drawing.Color.White;
               panelData.Controls.Clear();
               panelData.Controls.Add(new TatCa_DauSach());
          }

          private void btnTimKiem_Click(object sender, EventArgs e)
          {
               SetButtonColor();
               btnTimKiem.BackColor = System.Drawing.Color.ForestGreen;
               btnTimKiem.ForeColor = System.Drawing.Color.White;
               panelData.Controls.Clear();
               panelData.Controls.Add(new TimKiem_DauSach());
          }

          private void btnThemMoi_Click(object sender, EventArgs e)
          {
               SetButtonColor();
               btnThemMoi.BackColor = System.Drawing.Color.ForestGreen;
               btnThemMoi.ForeColor = System.Drawing.Color.White;
               panelData.Controls.Clear();
               panelData.Controls.Add(new Them_DauSach());
          }
     }
}
