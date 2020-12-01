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
        
    }
}
