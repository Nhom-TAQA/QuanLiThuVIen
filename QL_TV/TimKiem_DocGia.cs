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
    public partial class TimKiem_DocGia : UserControl
    {
        QLTV ql = new QLTV();

        List<HocVien> listHV = new List<HocVien>();
        public TimKiem_DocGia()
        {
            InitializeComponent();
        }
        DS_DocGia dsHV;
        CT_HocVien ctHV;
        public void AddKQ(List<HocVien> _listHV)
        {
            dsHV = new DS_DocGia(listHV);
            dsHV.dtgvDocGia.CellClick += dtgvDocGia_CellClick;
            panelShowKQ.Controls.Clear();
            panelShowKQ.Controls.Add(dsHV);
        }
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (txbTimKiem.Text == "" && cbbPhanLoai.Text != "")
            {
                MessageBox.Show("Vui lòng nhập nội dung tìm kiếm", "Thông báo");
            }
            if (txbTimKiem.Text == "" && cbbPhanLoai.Text == "")
            {
                MessageBox.Show("Vui lòng nhập nội dung tìm kiếm", "Thông báo");
            }
            if (cbbPhanLoai.Text == "")
            {
                MessageBox.Show("Vui lòng chọn một nhánh tìm kiếm", "Thông báo");
            }
            if (cbbPhanLoai.SelectedItem == "Mã Học Viên")
            {
                listHV = null;
                listHV = ql.HocViens.SqlQuery("SELECT * FROM HocVien WHERE Ma_HocVien LIKE '%" + txbTimKiem.Text + "%'").ToList();
                if (listHV.Count == 0)
                {
                    MessageBox.Show("Không tìm thấy nội dung", "Thông báo");
                }
                else
                {
                    AddKQ(listHV);
                }
            }
            if (cbbPhanLoai.SelectedItem == "Tên Học Viên")
            {
                listHV = null;
                listHV = ql.HocViens.SqlQuery("SELECT * FROM HocVien WHERE Ten_HocVien LIKE N'%" + txbTimKiem.Text + "%'").ToList();
                if (listHV.Count == 0)
                {
                    panelShowKQ.Controls.Clear();
                    MessageBox.Show("Không tìm thấy nội dung", "Thông báo");
                }
                else
                {
                    AddKQ(listHV);
                }
            }
        }
        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            dsHV = new DS_DocGia(listHV);
            AddKQ(listHV);
        }
        string ma;
        private void dtgvDocGia_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dsHV = new DS_DocGia(listHV);
            HocVien hv = new HocVien();
            ma = dsHV.dtgvDocGia.Rows[e.RowIndex].Cells["Ma_HocVien"].Value.ToString();
            hv = ql.HocViens.FirstOrDefault(n => n.Ma_HocVien == ma);
            ctHV = new CT_HocVien(ma);
            ctHV.btnQuayLai.Click += btnQuayLai_Click;
            panelShowKQ.Controls.Clear();
            panelShowKQ.Controls.Add(ctHV);
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
                panelShowKQ.Controls.Clear();
                listHV.Remove(hv1);
                panelShowKQ.Controls.Add(new DS_DocGia(listHV));
            }
            else
            {
                MessageBox.Show("Xóa không thành công", "Thông báo");
            }
        }
    }
}
