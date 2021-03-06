﻿using System;
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
    public partial class TimKiem_DauSach : UserControl
    {
        QLTV ql = new QLTV();
        DS_DauSach dsDS;
        CT_DauSach ctDS;
        List<DauSach> listDS = new List<DauSach>();
        public TimKiem_DauSach()
        {
            InitializeComponent();
        }
        private void LayDL()
        {
            listDS = ql.DauSaches.ToList();
            dsDS = new DS_DauSach(listDS);
            dsDS.dtgvViewDL.CellClick += dtgvViewDL_CellClick;
            panelShowKQ.Controls.Clear();
            panelShowKQ.Controls.Add(dsDS);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (txbTimKiem.Text == "")
            {
                MessageBox.Show("Vui lòng nhập nội dung tìm kiếm", "Thông báo");
            }
            if (cbbPhanLoai.SelectedItem == "Mã Đầu Sách")
            {
                listDS = ql.DauSaches.SqlQuery("SELECT * FROM DauSach WHERE Ma_DauSach LIKE '%" + txbTimKiem.Text + "%'").ToList();
                if (listDS.Count == 0)
                {
                    DialogResult result = MessageBox.Show("Không tìm thấy nội dung", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    panelShowKQ.Controls.Clear();
                    panelShowKQ.Controls.Add(new DS_DauSach(listDS));
                }
            }
            if (cbbPhanLoai.SelectedItem == "Tên Đầu Sách")
            {
                listDS = ql.DauSaches.SqlQuery("SELECT * FROM DauSach WHERE Ten_DauSach LIKE N'%" + txbTimKiem.Text.ToString() + "%'").ToList();
                if (listDS.Count == 0)
                {
                    DialogResult result = MessageBox.Show("Không tìm thấy nội dung", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    LayDL();
                }
            }
            if (cbbPhanLoai.SelectedItem == "Tác Giả")
            {
                listDS = ql.DauSaches.SqlQuery("SELECT * FROM DauSach WHERE TacGia LIKE N'%" + txbTimKiem.Text + "%'").ToList();
                if (listDS.Count == 0)
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
            ma = dsDS.dtgvViewDL.Rows[e.RowIndex].Cells["Ma_DauSach"].Value.ToString();
            dsDS = new DS_DauSach(listDS);
            ctDS = new CT_DauSach(dsDS.dtgvViewDL.Rows[e.RowIndex].Cells["Ma_DauSach"].Value.ToString());
            ctDS.btnQuayLai.Click += btnQuayLai_Click;
            ctDS.btnXoa.Click += btnXoa_Click;
            panelShowKQ.Controls.Clear();
            panelShowKQ.Controls.Add(ctDS);

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
                panelShowKQ.Controls.Clear();
                listDS.Remove(ds1);
                panelShowKQ.Controls.Add(new DS_DauSach(listDS));
            }
            else
            {
                MessageBox.Show("Xóa không thành công", "Thông báo");
            }
        }
    }
}
