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
    public partial class TimKiem_PhieuMuon : UserControl
    {
        QLTV ql = new QLTV();
        DS_PhieuMuon dsPM;
        CT_PhieuMuon ctPM;
        List<PhieuMuon> listPM = new List<PhieuMuon>();
        public TimKiem_PhieuMuon()
        {
            InitializeComponent();
        }
        private void LayDL()
        {
            dsPM = new DS_PhieuMuon(listPM);
            dsPM.dtgvViewDL.CellClick += dtgvViewDL_CellClick;
            panelShowKQ.Controls.Clear();
            panelShowKQ.Controls.Add(dsPM);
        }
        private void btnTimKiem_MouseClick(object sender, MouseEventArgs e)
        {
            if (txbTimKiem.Text == "")
            {
                MessageBox.Show("Vui lòng nhập nội dung tìm kiếm", "Thông báo");
            }
            if (cbbPhanLoai.SelectedItem == "Mã Phiếu Mượn")
            {
                listPM = ql.PhieuMuons.SqlQuery("SELECT * FROM PhieuMuon WHERE Ma_PhieuMuon LIKE '%" + txbTimKiem.Text + "%'").ToList();
                if (listPM.Count == 0)
                {
                    DialogResult result = MessageBox.Show("Không tìm thấy nội dung", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    LayDL();
                }
            }
            if (cbbPhanLoai.SelectedItem == "Mã Học Viên")
            {
                listPM = ql.PhieuMuons.SqlQuery("SELECT * FROM PhieuMuon WHERE Ma_HocVien LIKE '%" + txbTimKiem.Text.ToString() + "%'").ToList();
                if (listPM.Count == 0)
                {
                    DialogResult result = MessageBox.Show("Không tìm thấy nội dung", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    LayDL();
                }
            }
            if (cbbPhanLoai.SelectedItem == "Ngày Mượn")
            {
                listPM = ql.PhieuMuons.SqlQuery("SELECT * FROM PhieuMuon WHERE NgayMuon LIKE '%" + txbTimKiem.Text + "%'").ToList();
                if (listPM.Count == 0)
                {
                    DialogResult result = MessageBox.Show("Không tìm thấy nội dung", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    LayDL();
                }
            }
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
            panelShowKQ.Controls.Clear();
            panelShowKQ.Controls.Add(ctPM);
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
                panelShowKQ.Controls.Clear();
                listPM.Remove(pm1);
                panelShowKQ.Controls.Add(new DS_PhieuMuon(listPM));
            }
            else
            {
                MessageBox.Show("Xóa không thành công", "Thông báo");
            }
        }
    }
}
