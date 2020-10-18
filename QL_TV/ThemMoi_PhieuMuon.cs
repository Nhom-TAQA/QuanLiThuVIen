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
    public partial class ThemMoi_PhieuMuon : UserControl
    {
        QLTV ql = new QLTV();
        List<PhieuMuon> listPM = new List<PhieuMuon>();
        DAL_PhieuMuon dal = new DAL_PhieuMuon();
        DAL_ChiTiet dalCT = new DAL_ChiTiet();
        NhanVien nv = new NhanVien();
        public ThemMoi_PhieuMuon(string ma)
        {
            InitializeComponent();
            txbMaPhieuMuon.Text = TaoMa();
            dtpNgayMuon.Value = DateTime.Now;
            nv = ql.NhanViens.Where(n => n.Ma_NhanVien == ma).FirstOrDefault();
            txbNV.Text = nv.Ma_NhanVien;
        }
        private string TaoMa()
        {
            listPM = ql.PhieuMuons.ToList();
            int newest = 0;
            foreach (PhieuMuon pm in listPM)
            {
                int ma = Int32.Parse(pm.Ma_PhieuMuon.Substring(6));
                if (ma > newest)
                {
                    newest = ma;
                }
            }

            string ma_moi = (newest + 1).ToString();
            string ma_moi1 = "PM";
            int x = 8 - ma_moi.Length - 2;
            for (int i = 0; i < x; i++)
            {
                ma_moi1 += "0";
            }
            ma_moi1 += ma_moi;
            return ma_moi1;
        }
        List<ChiTiet_PhieuMuon1> listCT = new List<ChiTiet_PhieuMuon1>();
        private string TaoMaChiTiet()
        {
            listCT = ql.ChiTiet_PhieuMuon1.ToList();
            int newest = 0;
            foreach (ChiTiet_PhieuMuon1 ctpm in listCT)
            {
                int ma = Int32.Parse(ctpm.Ma_ChiTiet.Substring(6));
                if (ma > newest)
                {
                    newest = ma;
                }
            }

            string ma_moi = (newest + 1).ToString();
            string ma_moi1 = "CT";
            int x = 8 - ma_moi.Length - 2;
            for (int i = 0; i < x; i++)
            {
                ma_moi1 += "0";
            }
            ma_moi1 += ma_moi;
            return ma_moi1;
        }
        string ma;
        List<ChiTiet_PhieuMuon1> listCTPM = new List<ChiTiet_PhieuMuon1>();
        int index = 1;
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txbMaSach.Text == "")
            {
                MessageBox.Show("Nhập lại mã sách", "Thông báo");
            }
            else
            {
                ma = txbMaSach.Text;
                dtgvSach.Rows.Add(index, ma);
                index++;
            }
        }
        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            PhieuMuon pm = new PhieuMuon();
            pm.Ma_PhieuMuon = txbMaPhieuMuon.Text;
            pm.NgayMuon = dtpNgayMuon.Value;
            pm.Ma_HocVien = txbHV.Text;
            pm.Ma_ThuThu = txbNV.Text;
            bool rs = dal.Insert(pm);
            if (rs == true)
            {
                ThemChiTiet();
                MessageBox.Show("Thêm thành công", "Thông báo");
            }
            else
            {
                MessageBox.Show("Thêm không thành công", "Thông báo");
            }
        }
        private void ThemChiTiet()
        {
            foreach (DataGridViewRow row in dtgvSach.Rows)
            {
                ChiTiet_PhieuMuon1 ct = new ChiTiet_PhieuMuon1();
                string MaSach = row.Cells["Ma_Sach"].Value.ToString();
                ct.Ma_ChiTiet = TaoMaChiTiet();
                ct.Ma_PhieuMuon = txbMaPhieuMuon.Text;
                ct.Ma_Sach = MaSach;
                ct.TinhTrang = false;
                ct.NgayTra = DateTime.Now;
                bool rs2 = dalCT.Insert(ct);
            }
        }
    }
}
