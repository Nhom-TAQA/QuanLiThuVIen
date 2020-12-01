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
using QL_TV.DAL;

namespace QL_TV
{
    public partial class TatCa_PhieuMuon : UserControl
    {
        QLTV ql = new QLTV();
        List<PhieuMuon> listPM = new List<PhieuMuon>();
        DS_PhieuMuon dsPM;
        CT_PhieuMuon ctPM;
        public TatCa_PhieuMuon()
        {
            InitializeComponent();
            LayDL();
        }
        void LayDL()
        {
            listPM = ql.PhieuMuons.ToList();
            dsPM = new DS_PhieuMuon(listPM);
            dsPM.dtgvViewDL.CellClick += dtgvViewDL_CellClick;
            panelData.Controls.Clear();
            panelData.Controls.Add(dsPM);
        }
        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            LayDL();
        }
        private string ma;
        private void dtgvViewDL_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ma = dsPM.dtgvViewDL.Rows[e.RowIndex].Cells["Ma_PhieuMuon"].Value.ToString();
            dsPM = new DS_PhieuMuon(listPM);
            ctPM = new CT_PhieuMuon(ma);
            ctPM.btnQuayLai.Click += btnQuayLai_Click;
            ctPM.btnXoa.Click += btnXoa_Click;
            panelData.Controls.Clear();
            panelData.Controls.Add(ctPM);
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            ctPM = new CT_PhieuMuon(ma);
            DAL_PhieuMuon dal = new DAL_PhieuMuon();
            PhieuMuon pm1 = ql.PhieuMuons.FirstOrDefault(n => n.Ma_PhieuMuon == ctPM.txbMaPhieuMuon.Text);
            bool rs = dal.Delete(ma);
            if (rs == true)
            {
                MessageBox.Show("Xóa thành công", "Thông báo");
                panelData.Controls.Clear();
                listPM.Remove(pm1);
                panelData.Controls.Add(new DS_PhieuMuon(listPM));
            }
            else
            {
                MessageBox.Show("Xóa không thành công", "Thông báo");
            }
        }
    }
}
