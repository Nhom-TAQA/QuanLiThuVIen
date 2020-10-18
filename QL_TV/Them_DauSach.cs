using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using QL_TV.DAL;
using QL_TV.Entity;

namespace QL_TV
{
     public partial class Them_DauSach : UserControl
     {
        QLTV ql = new QLTV();
        List<DauSach> listDS = new List<DauSach>();
        List<Sach> listS = new List<Sach>();
        DAL_DauSach dal = new DAL_DauSach();
        public Them_DauSach()
        {
            InitializeComponent();
            txbMaDauSach.Text = TaoMa();
        }
        private string TaoMa()
        {
            listDS = ql.DauSaches.ToList();
            int newest = 0;
            foreach (DauSach ds in listDS)
            {
                int ma = Int32.Parse(ds.Ma_DauSach.Substring(6));
                if (ma > newest)
                {
                    newest = ma;
                }
            }

            string ma_moi = (newest + 1).ToString();
            string ma_moi1 = "DS";
            int x = 8 - ma_moi.Length - 2;
            for (int i = 0; i < x; i++)
            {
                ma_moi1 += "0";
            }
            ma_moi1 += ma_moi;
            return ma_moi1;
        }
        //private string TaoMaSach()
        //{
        //    listS = ql.Saches.ToList();
        //    int newest = 0;
        //    foreach (Sach s in listS)
        //    {
        //        int ma = Int32.Parse(s.Ma_Sach.Substring(6));
        //        if (ma > newest)
        //        {
        //            newest = ma;
        //        }
        //    }

        //    string ma_moi = (newest + 1).ToString();
        //    string ma_moi1 = "S";
        //    int x = 7 - ma_moi.Length - 2;
        //    for (int i = 0; i < x; i++)
        //    {
        //        ma_moi1 += "0";
        //    }
        //    ma_moi1 += ma_moi;
        //    return ma_moi1;
        //}
        private string TaoMaSach()
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            DauSach ds = new DauSach();
            ds.Ma_DauSach = txbMaDauSach.Text;
            ds.Ten_DauSach = txbTenDauSach.Text;
            ds.TacGia = txbTacGia.Text;
            ds.Ma_NXB = ql.NXBs.FirstOrDefault(n => n.Ten_NXB == txbNXB.Text).Ma_NXB;
            ds.DanhMuc = ql.DanhMucs.FirstOrDefault(n => n.Ten_DanhMuc == cbbDanhMuc.Text).Ma_DanhMuc;
            ds.SoLuong = Convert.ToInt32(txbSoLuong.Text);
            ds.Anh = ArrByte_Anh;
            for (int i = 0; i < ds.SoLuong; i++)
            {
                Sach s = new Sach();
                s.Ma_Sach = TaoMaSach();
                s.Ma_DauSach = ds.Ma_DauSach;
                s.Ma_ThuVien = ql.ThuViens.FirstOrDefault(n => n.ViTri == 1).Ma_ThuVien;
                ql.Saches.Add(s);
            }
            bool rs = dal.Insert(ds);
            if (rs == true)
            {
                MessageBox.Show("Thêm thành công", "Thông báo");
            }
            else
            {
                MessageBox.Show("Thêm không thành công", "Thông báo");
            }
        }
        byte[] ArrByte_Anh;
        private void btnThemAnh_Click(object sender, EventArgs e)
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

            ptbAnhDauSach.Image = HinhAnh.ByteToImage(arrByte);
        }
    }
}
