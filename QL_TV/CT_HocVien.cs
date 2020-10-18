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
using System.Threading;

namespace QL_TV
{
    public partial class CT_HocVien : UserControl
    {
        QLTV ql = new QLTV();
        DAL_HocVien dal = new DAL_HocVien();
        public CT_HocVien(string Ma)
        {
            InitializeComponent();
            Load_CTHV(Ma);
        }
        void Load_CTHV(string Ma)
        {
            HocVien hv = ql.HocViens.FirstOrDefault(n => n.Ma_HocVien == Ma);
            if (hv != null)
            {
                txbMaHocVien.Text = hv.Ma_HocVien;
                txbTenHocVien.Text = hv.Ten_HocVien;
                txbSDT.Text = hv.SDT;
                txbLop.Text = hv.Lop;
                txbKhoa.Text = hv.Khoa.ToString();
                dtpNgaySinh.Value = hv.NgaySinh;
                if (hv.Anh != null)
                {
                    ptbAnh.Image = HinhAnh.ByteToImage(hv.Anh);
                }
            }
            List<ChiTiet_PhieuMuon1> listCTPM = new List<ChiTiet_PhieuMuon1>();
            listCTPM = ql.ChiTiet_PhieuMuon1.Where(n => n.PhieuMuon.Ma_HocVien == Ma).ToList();
            int i = 1;
            foreach (ChiTiet_PhieuMuon1 ct in listCTPM)
            {
                dtgvDangMuon.Rows.Add(i, ct.Ma_Sach, ct.PhieuMuon.NgayMuon.ToString("dd/MM/yyyy"));
                i++;
            }
        }
        byte[] ArrByte_Anh;
        private void btnSua_Click(object sender, EventArgs e)
        {
            HocVien hv = new HocVien();
            hv.Ma_HocVien = txbMaHocVien.Text;
            if (txbTenHocVien.Text == "")
            {
                MessageBox.Show("Hãy nhập tên học viên", "Thông báo");
            }
            else
            {
                hv.Ten_HocVien = txbTenHocVien.Text;
            }
            hv.NgaySinh = dtpNgaySinh.Value;
            if (txbLop.Text == "")
            {
                MessageBox.Show("Hãy nhập tên lớp", "Thông báo");
            }
            else
            {
                hv.Lop = txbLop.Text;
            }
            if (txbKhoa.Text == "")
            {
                MessageBox.Show("Hãy nhập khóa", "Thông báo");
            }
            else
            {
                hv.Khoa = Convert.ToInt32(txbKhoa.Text);
            }
            hv.SDT = txbSDT.Text;
            bool rs = dal.Update(hv);
            if (rs == true)
            {
                MessageBox.Show("Sửa thông tin thành công", "Thông báo");
            }
            else
            {
                MessageBox.Show("Sửa thông tin không thành công", "Thông báo");
            }
            hv.Anh = ArrByte_Anh;
        }

        private void ptbAnh_Click(object sender, EventArgs e)
        {
            string filename = "";
            Thread thr = new Thread((ThreadStart)(() =>
            {
                OpenFileDialog open = new OpenFileDialog();
                open.Multiselect = false;
                if (open.ShowDialog() == DialogResult.OK)
                {
                    filename = open.FileName.ToString();
                }
            }));
            thr.SetApartmentState(ApartmentState.STA);
            thr.Start();
            thr.Join();

            if (filename == "")
            {
                return;
            }

            byte[] arrByte = HinhAnh.StringToByte(filename);
            ArrByte_Anh = arrByte;

            ptbAnh.Image = HinhAnh.ByteToImage(arrByte);
        }
    }
}
