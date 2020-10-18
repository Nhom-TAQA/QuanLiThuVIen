using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QL_TV.Entity;

namespace QL_TV.DAL
{
     class DAL_ChiTiet
     {
          QLTV ql = new QLTV();
          public void Update(string Ma, bool check, DateTime date)
          {
               ChiTiet_PhieuMuon1 ct = ql.ChiTiet_PhieuMuon1.Where(n=>n.Ma_Sach == Ma).FirstOrDefault();
               ct.TinhTrang = check;
               ct.NgayTra = date;
               ql.SaveChanges();
          }
          public bool Insert(ChiTiet_PhieuMuon1 ct)
          {
               ChiTiet_PhieuMuon1 _ct = ql.ChiTiet_PhieuMuon1.Where(n => n.Ma_ChiTiet == ct.Ma_ChiTiet).FirstOrDefault();

               if (_ct != null)
               {
                    return false;
               }
               ql.ChiTiet_PhieuMuon1.Add(ct);
               ql.SaveChanges();

               return true;
          }
          public bool Delete(string Ma)
          {
               ChiTiet_PhieuMuon1 ct = ql.ChiTiet_PhieuMuon1.Where(n => n.Ma_ChiTiet == Ma).FirstOrDefault();
               if (ct == null)
               {
                    return false;
               }
               ql.ChiTiet_PhieuMuon1.Remove(ct);
               ql.SaveChanges();
               return true;
          }
     }
}
