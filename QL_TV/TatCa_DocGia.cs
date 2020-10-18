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
    public partial class TatCa_DocGia : UserControl
    {
        QLTV ql = new QLTV();
        List<HocVien> listHV = new List<HocVien>();
        DS_DocGia dsHV;
        CT_HocVien ctHV;
        public TatCa_DocGia()
        {
            InitializeComponent();
            LoadDL();
        }

        void LoadDL()
        {
            listHV = ql.HocViens.ToList();
            panelData.Controls.Clear();
            dsHV = new DS_DocGia(listHV);
            dsHV.dtgvDocGia.CellClick += dtgvDocGia_CellClick;
            panelData.Controls.Add(dsHV);
        }
        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            panelData.Controls.Clear();
            LoadDL();
        }
        string ma;
        private void dtgvDocGia_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dsHV = new DS_DocGia(listHV);
            ma = dsHV.dtgvDocGia.Rows[e.RowIndex].Cells["Ma_HocVien"].Value.ToString();
            ctHV = new CT_HocVien(ma);
            ctHV.btnQuayLai.Click += btnQuayLai_Click;
            ctHV.btnXoa.Click += btnXoa_Click;
            panelData.Controls.Clear();
            panelData.Controls.Add(ctHV);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            ctHV = new CT_HocVien(ma);
            DAL_HocVien dal = new DAL_HocVien();
            HocVien hv1 = ql.HocViens.FirstOrDefault(n => n.Ma_HocVien == ctHV.txbMaHocVien.Text);
            bool rs = dal.Delete(ctHV.txbMaHocVien.Text);
            if (rs == true)
            {
                MessageBox.Show("Xóa thành công", "Thông báo");
                panelData.Controls.Clear();
                listHV.Remove(hv1);
                panelData.Controls.Add(new DS_DocGia(listHV));
            }
            else
            {
                MessageBox.Show("Xóa không thành công", "Thông báo");
            }
        }
    }
}
