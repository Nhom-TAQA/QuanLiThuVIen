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
    public partial class QuanLy : UserControl
    {
        string ma;
        public QuanLy(string _ma)
        {
            InitializeComponent();
            btnTatCa.BackColor = System.Drawing.Color.ForestGreen;
            btnTatCa.ForeColor = System.Drawing.Color.White;
            panelData.Controls.Add(new TatCa_PhieuMuon());
            ma = _ma;
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

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            SetButtonColor();
            btnThemMoi.BackColor = System.Drawing.Color.ForestGreen;
            btnThemMoi.ForeColor = System.Drawing.Color.White;
            panelData.Controls.Clear();
            panelData.Controls.Add(new ThemMoi_PhieuMuon(ma));
        }

        private void btnTatCa_Click_1(object sender, EventArgs e)
        {
            SetButtonColor();
            btnTatCa.BackColor = System.Drawing.Color.ForestGreen;
            btnTatCa.ForeColor = System.Drawing.Color.White;
            panelData.Controls.Clear();
            panelData.Controls.Add(new TatCa_PhieuMuon());
        }

        private void btnTimKiem_Click_1(object sender, EventArgs e)
        {
            SetButtonColor();
            btnTimKiem.BackColor = System.Drawing.Color.ForestGreen;
            btnTimKiem.ForeColor = System.Drawing.Color.White;
            panelData.Controls.Clear();
            panelData.Controls.Add(new TimKiem_PhieuMuon());
        }
    }
}
