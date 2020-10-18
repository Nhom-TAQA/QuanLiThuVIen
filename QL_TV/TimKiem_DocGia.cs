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
    }
}
