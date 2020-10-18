using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QL_TV.DAL;
using QL_TV.Entity;

namespace QL_TV
{
    public partial class CT_PhieuMuon : UserControl
    {
        QLTV ql = new QLTV();
        DAL_PhieuMuon dal = new DAL_PhieuMuon();
        string Ma;
        public CT_PhieuMuon(string _Ma)
        {
            Ma = _Ma;
            InitializeComponent();
            Load_CTPM(Ma);
            Load_ChiTiet(Ma);
        }
        void Load_CTPM(string Ma)
        {
            PhieuMuon pm = ql.PhieuMuons.FirstOrDefault(n => n.Ma_PhieuMuon == Ma);
            if (pm != null)
            {
                txbMaPhieuMuon.Text = pm.Ma_PhieuMuon;
                txbMaNhanVien.Text = pm.Ma_ThuThu;
                txbMaHocVien.Text = pm.Ma_HocVien;
                dtpNgayMuon.Value = pm.NgayMuon;

            }
        }
        void Load_ChiTiet(string Ma)
        {
            dtgvSach.Rows.Clear();
            List<ChiTiet_PhieuMuon1> listCT = new List<ChiTiet_PhieuMuon1>();
            listCT = ql.ChiTiet_PhieuMuon1.Where(n => n.Ma_PhieuMuon == Ma).ToList();
            int i = 1;
            foreach (ChiTiet_PhieuMuon1 ct in listCT)
            {
                if (ct.TinhTrang == true)
                {
                    dtgvSach.Rows.Add(i, ct.Ma_Sach, ct.TinhTrang, ct.NgayTra.ToString("dd/MM/yyyy"));
                }
                else
                {
                    dtgvSach.Rows.Add(i, ct.Ma_Sach, ct.TinhTrang, "");
                }
                i++;
            }

        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            DAL_ChiTiet dalCT = new DAL_ChiTiet();
            PhieuMuon pm = new PhieuMuon();
            pm.Ma_PhieuMuon = txbMaPhieuMuon.Text;
            pm.Ma_HocVien = txbMaHocVien.Text;
            pm.Ma_ThuThu = txbMaNhanVien.Text;
            pm.NgayMuon = dtpNgayMuon.Value;

            foreach (DataGridViewRow row in dtgvSach.Rows)
            {
                string MaSach = row.Cells["Ma_Sach"].Value.ToString();
                bool check = Convert.ToBoolean(row.Cells["TinhTrang"].Value.ToString());
                if (check == true)
                {
                    DateTime ntra = DateTime.Now;
                    dalCT.Update(MaSach, check, ntra);
                }
            }

            bool rs = dal.Update(pm);
            if (rs == true)
            {
                MessageBox.Show("Sửa thông tin thành công", "Thông báo");
                Load_ChiTiet(Ma);
            }
            else
            {
                MessageBox.Show("Sửa thông tin không thành công", "Thông báo");
            }
        }
    }
}
