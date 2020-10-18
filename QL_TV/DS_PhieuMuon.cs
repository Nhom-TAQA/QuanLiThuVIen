using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QL_TV.DAL;
using QL_TV.Entity;

namespace QL_TV
{
    public partial class DS_PhieuMuon : UserControl
    {
        private string Ma;
        QLTV ql = new QLTV();
        List<PhieuMuon> listPM = new List<PhieuMuon>();
        public DS_PhieuMuon(List<PhieuMuon> listPM)
        {
            InitializeComponent();
            LoadDS(listPM);
        }
        void LoadDS(List<PhieuMuon> listPM)
        {
            dtgvViewDL.Rows.Clear();
            int index = 1;
            foreach (PhieuMuon pm in listPM)
            {
                dtgvViewDL.Rows.Add(index, pm.Ma_PhieuMuon, pm.Ma_ThuThu, pm.Ma_HocVien, pm.NgayMuon.ToString("dd/MM/yyyy"));
                index++;
            }
        }
    }
}
