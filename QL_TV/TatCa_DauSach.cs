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
     public partial class TatCa_DauSach : UserControl
     {
        QLTV ql = new QLTV();
        List<DauSach> listDS = new List<DauSach>();
        DS_DauSach dsDS;
        CT_DauSach ctDS;
        public TatCa_DauSach()
        {
            InitializeComponent();
            LayDL();
        }
        void LayDL()
        {
            listDS = ql.DauSaches.ToList();
            dsDS = new DS_DauSach(listDS);
            dsDS.dtgvViewDL.CellClick += dtgvViewDL_CellClick;
            panelData.Controls.Clear();
            panelData.Controls.Add(dsDS);
        }
        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            LayDL();
        }
        private string ma;
        private void dtgvViewDL_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ma = dsDS.dtgvViewDL.Rows[e.RowIndex].Cells["Ma_DauSach"].Value.ToString();
            dsDS = new DS_DauSach(listDS);
            ctDS = new CT_DauSach(dsDS.dtgvViewDL.Rows[e.RowIndex].Cells["Ma_DauSach"].Value.ToString());
            ctDS.btnQuayLai.Click += btnQuayLai_Click;
            ctDS.btnXoa.Click += btnXoa_Click;
            panelData.Controls.Clear();
            panelData.Controls.Add(ctDS);

        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            ctDS = new CT_DauSach(ma);
            DAL_DauSach dal = new DAL_DauSach();
            DauSach ds1 = ql.DauSaches.FirstOrDefault(n => n.Ma_DauSach == ctDS.txbMaDauSach.Text);
            bool rs = dal.Delete(ctDS.txbMaDauSach.Text);
            if (rs == true)
            {
                MessageBox.Show("Xóa thành công", "Thông báo");
                panelData.Controls.Clear();
                listDS.Remove(ds1);
                panelData.Controls.Add(new DS_DauSach(listDS));
            }
            else
            {
                MessageBox.Show("Xóa không thành công", "Thông báo");
            }
        }
    }
}
