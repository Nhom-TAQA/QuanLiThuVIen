using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QL_TV.Entity;

namespace QL_TV.DAL
{
     class DAL_PhieuMuon
     {
          QLTV ql = new QLTV();
          public bool Update(PhieuMuon _pm)
          {
               PhieuMuon pm = ql.PhieuMuons.Find(_pm.Ma_PhieuMuon);
               if (pm == null)
               {
                    return false;
               }
               pm.Ma_PhieuMuon = _pm.Ma_PhieuMuon;
               pm.Ma_ThuThu = _pm.Ma_ThuThu;
               pm.Ma_HocVien= _pm.Ma_HocVien;
               pm.NgayMuon = _pm.NgayMuon;
               ql.SaveChanges();
               return true;
          }
          public bool Insert(PhieuMuon pm)
          {
               PhieuMuon _pm = ql.PhieuMuons.Where(n => n.Ma_PhieuMuon == pm.Ma_PhieuMuon).FirstOrDefault();
               if (_pm != null)
               {
                    return false;
               }
               ql.PhieuMuons.Add(pm);
               ql.SaveChanges();

               return true;
          }
          public bool Delete(string Ma)
          {
               DAL_ChiTiet dals = new DAL_ChiTiet();
               List<ChiTiet_PhieuMuon1> listCT = new List<ChiTiet_PhieuMuon1>();
               listCT = ql.ChiTiet_PhieuMuon1.Where(n => n.Ma_PhieuMuon == Ma).ToList();
               foreach (ChiTiet_PhieuMuon1 s in listCT)
               {
                    ql.ChiTiet_PhieuMuon1.Remove(s);
               }
               PhieuMuon pm = ql.PhieuMuons.Where(n => n.Ma_PhieuMuon == Ma).FirstOrDefault();
               if (pm == null)
               {
                    return false;
               }
               ql.PhieuMuons.Remove(pm);
               ql.SaveChanges();
               return true;
          }
     }
}
