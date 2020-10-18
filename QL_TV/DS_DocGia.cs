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
    public partial class DS_DocGia : UserControl
    {
        QLTV ql = new QLTV();
        public string MaHV;
        internal static object panelData;

        public DS_DocGia(List<HocVien> listHV)
        {
            InitializeComponent();
            HVLoad(listHV);
        }

        void HVLoad(List<HocVien> listHV)
        {
            dtgvDocGia.Rows.Clear();
            int index = 1;
            foreach (HocVien hv in listHV)
            {
                dtgvDocGia.Rows.Add(index, hv.Ma_HocVien, hv.Ten_HocVien, hv.NgaySinh.ToString("dd/MM/yyyy"), hv.Lop, hv.Khoa);
                index++;
            }
        }
    }
}
