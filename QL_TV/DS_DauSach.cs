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
     public partial class DS_DauSach : UserControl
     {
        private string Ma;
        QLTV ql = new QLTV();
        public DS_DauSach(List<DauSach> listDauSach)
        {
            InitializeComponent();
            LoadDS(listDauSach);
        }
        void LoadDS(List<DauSach> listDauSach)
        {
            dtgvViewDL.Rows.Clear();
            int index = 1;
            foreach (Entity.DauSach ds in listDauSach)
            {
                NXB nxb = ql.NXBs.FirstOrDefault(x => x.Ma_NXB == ds.Ma_NXB);
                dtgvViewDL.Rows.Add(index, ds.Ma_DauSach, ds.Ten_DauSach, ds.TacGia, nxb.Ten_NXB, ds.SoLuong.ToString());
                index++;
            }
        }
     }
}
