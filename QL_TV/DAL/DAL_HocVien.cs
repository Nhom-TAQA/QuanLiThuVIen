using QL_TV.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_TV.DAL
{
     class DAL_HocVien
     {
          QLTV ql = new QLTV();
          public bool Update(HocVien _hv)
          {
               HocVien hv = ql.HocViens.Find(_hv.Ma_HocVien);
               if (hv == null)
               {
                    return false;
               }
               hv.Ma_HocVien = _hv.Ma_HocVien;
               hv.Ten_HocVien = _hv.Ten_HocVien;
               hv.NgaySinh = _hv.NgaySinh;
               hv.Lop = _hv.Lop;
               hv.Khoa = _hv.Khoa;
               hv.SDT = hv.SDT;
               hv.Anh = _hv.Anh;
               ql.SaveChanges();
               return true;
          }
          public bool Insert(HocVien hv)
          {
               HocVien _hv = ql.HocViens.Where(n => n.Ma_HocVien == hv.Ma_HocVien).FirstOrDefault();

               if (_hv != null)
               {
                    return false;
               }
               ql.HocViens.Add(hv);
               ql.SaveChanges();

               return true;
          }
          public bool Delete(string Ma)
          {
               HocVien hv = ql.HocViens.Where(n => n.Ma_HocVien == Ma).FirstOrDefault();
               if (hv == null)
               {
                    return false;
               }
               ql.HocViens.Remove(hv);
               ql.SaveChanges();
               return true;
          }
     }
}
