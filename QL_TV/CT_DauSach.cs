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
     public partial class CT_DauSach : UserControl
     {

        QLTV ql = new QLTV();
        DAL_DauSach dal = new DAL_DauSach();
        public CT_DauSach(string Ma)
        {
            InitializeComponent();
            List<DanhMuc> listDM = ql.DanhMucs.ToList();
            foreach (DanhMuc dm in listDM)
            {
                cbbDanhMuc.Items.Add(dm.Ten_DanhMuc);
            }
            Load_CTDS(Ma);
            Load_Sach(Ma);
        }
        void Load_CTDS(string Ma)
        {
            DauSach ds = ql.DauSaches.FirstOrDefault(n => n.Ma_DauSach == Ma);
            txbMaDauSach.Text = ds.Ma_DauSach;
            txbTenDauSach.Text = ds.Ten_DauSach;
            txbTacGia.Text = ds.TacGia;
            txbNXB.Text = ds.NXB.Ten_NXB;
            txbSoLuong.Text = ds.SoLuong.ToString();
            cbbDanhMuc.Text = ds.DanhMuc1.Ten_DanhMuc;
            if (ds.Anh != null)
            {
                ptbAnhSach.Image = HinhAnh.ByteToImage(ds.Anh);
            }
        }
        void Load_Sach(string Ma)
        {
            List<Sach> listS = new List<Sach>();
            listS = ql.Saches.Where(n => n.Ma_DauSach == Ma).ToList();
            int i = 1;
            foreach (Sach s in listS)
            {
                dtgvSach.Rows.Add(i, s.Ma_Sach, s.ThuVien.ViTri, s.TinhTrang);
                i++;
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            DanhMuc _dm = ql.DanhMucs.FirstOrDefault(n => n.Ten_DanhMuc == cbbDanhMuc.Text);
            string dm = _dm.Ma_DanhMuc;
            NXB _nxb = ql.NXBs.FirstOrDefault(n => n.Ten_NXB == txbNXB.Text);
            if (_nxb == null)
            {

            }
            string ma_nxb = _nxb.Ma_NXB;
            DauSach ds = new DauSach();
            ds.Ma_DauSach = txbMaDauSach.Text;
            if (txbTenDauSach.Text == "")
            {
                MessageBox.Show("Hãy nhập tên đầu sách", "Thông báo");
            }
            else
            {
                ds.Ten_DauSach = txbTenDauSach.Text;
            }
            if (txbTacGia.Text == "")
            {
                MessageBox.Show("Hãy nhập tên đầu sách", "Thông báo");
            }
            else
            {
                ds.TacGia = txbTacGia.Text;
            }
            ds.Ma_NXB = ma_nxb;
            if (Convert.ToInt32(txbSoLuong.Text) <= 0)
            {
                MessageBox.Show("Hãy nhập một số lượng dương", "Thông báo");
            }
            else
            {
                ds.SoLuong = Convert.ToInt32(txbSoLuong.Text);
            }
            ds.DanhMuc = dm;
            ds.Anh = ArrByte_Anh;
            bool rs = dal.Update(ds);
            if (rs == true)
            {
                MessageBox.Show("Sửa thông tin thành công", "Thông báo");
            }
            else
            {
                MessageBox.Show("Sửa thông tin không thành công", "Thông báo");
            }
        }
        byte[] ArrByte_Anh;
        private void ptbAnhSach_Click(object sender, EventArgs e)
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

            ptbAnhSach.Image = HinhAnh.ByteToImage(arrByte);
        }
    }
}