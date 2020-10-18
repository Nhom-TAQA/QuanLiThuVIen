using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QL_TV.Entity;

namespace QL_TV
{
     public partial class DocGia : UserControl
     {
          public DocGia()
          {
               InitializeComponent();
               btnTatCa.BackColor = System.Drawing.Color.ForestGreen;
               btnTatCa.ForeColor = System.Drawing.Color.White;
               panelData.Controls.Add(new TatCa_DocGia());
          }
          private void SetButtonColor()
          {
               btnTatCa.BackColor = System.Drawing.Color.LightYellow;
               btnTatCa.ForeColor = System.Drawing.Color.ForestGreen;
               btnTimKiem.BackColor = System.Drawing.Color.LightYellow;
               btnTimKiem.ForeColor = System.Drawing.Color.ForestGreen;
               btnThemMoi.BackColor = System.Drawing.Color.LightYellow;
               btnThemMoi.ForeColor = System.Drawing.Color.ForestGreen;
          }
          private void btnTatCa_Click(object sender, EventArgs e)
          {
               SetButtonColor();
               btnTatCa.BackColor = System.Drawing.Color.ForestGreen;
               btnTatCa.ForeColor = System.Drawing.Color.White;
               panelData.Controls.Clear();
               panelData.Controls.Add(new TatCa_DocGia());
          }

          private void btnTimKiem_Click(object sender, EventArgs e)
          {
               SetButtonColor();
               btnTimKiem.BackColor = System.Drawing.Color.ForestGreen;
               btnTimKiem.ForeColor = System.Drawing.Color.White;
               panelData.Controls.Clear();
               panelData.Controls.Add(new TimKiem_DocGia());
          }

          private void btnThemMoi_Click(object sender, EventArgs e)
          {
               SetButtonColor();
               btnThemMoi.BackColor = System.Drawing.Color.ForestGreen;
               btnThemMoi.ForeColor = System.Drawing.Color.White;
               panelData.Controls.Clear();
               panelData.Controls.Add(new Them_DocGia());
          }
     }
}
