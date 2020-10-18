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
using QL_TV.Entity;
using QL_TV.DAL;

namespace QL_TV
{
    public partial class Them_DocGia : UserControl
    {
        QLTV ql = new QLTV();
        List<HocVien> listHV = new List<HocVien>();
        DAL_HocVien dal = new DAL_HocVien();
        public Them_DocGia()
        {
            InitializeComponent();
            txbMaHocVien.Text = TaoMa();
        }
        private string TaoMa()
        {
            listHV = ql.HocViens.ToList();
            int newest = 0;
            foreach (HocVien hv in listHV)
            {
                int ma = Int32.Parse(hv.Ma_HocVien.Substring(6));
                if (ma > newest)
                {
                    newest = ma;
                }
            }

            string ma_moi = (newest + 1).ToString();
            string ma_moi1 = "QS";
            int x = 8 - ma_moi.Length - 2;
            for (int i = 0; i < x; i++)
            {
                ma_moi1 += "0";
            }
            ma_moi1 += ma_moi;
            return ma_moi1;
        }
        private string TaoMaHocVien()
        {
            listHV = ql.HocViens.ToList();
            int newest = 0;
            foreach (HocVien hv in listHV)
            {
                int ma = Int32.Parse(hv.Ma_HocVien.Substring(6));
                if (ma > newest)
                {
                    newest = ma;
                }
            }

            string ma_moi = (newest + 1).ToString();
            string ma_moi1 = "QS";
            int x = 8 - ma_moi.Length - 2;
            for (int i = 0; i < x; i++)
            {
                ma_moi1 += "0";
            }
            ma_moi1 += ma_moi;
            return ma_moi1;
        }
        byte[] ArrByte_Anh;

        private void btnThemAnh_Click(object sender, MouseEventArgs e)
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

        private void btnThem_Click_1(object sender, EventArgs e)
        {
            HocVien hv = new HocVien();
            hv.Ma_HocVien = txbMaHocVien.Text;
            hv.Ten_HocVien = txbTenHocVien.Text;
            hv.NgaySinh = dtpNgaySinh.Value;
            hv.Lop = txbLop.Text;
            hv.Khoa = Convert.ToInt32(txbSDT.Text);
            hv.SDT = txbSDT.Text;
            hv.Anh = ArrByte_Anh;
            bool rs = dal.Insert(hv);
            if (rs == true)
            {
                MessageBox.Show("Thêm thành công", "Thông báo");
            }
            else
            {
                MessageBox.Show("Thêm không thành công", "Thông báo");
            }
        }
    }
}
