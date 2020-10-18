using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QL_TV.Entity;

namespace QL_TV.DAL
{
     class DAL_Sach
     {
          QLTV ql = new QLTV();
          public bool Update(Sach _ds)
          {
               Sach ds = ql.Saches.Find(_ds.Ma_Sach);
               if (ds == null)
               {
                    return false;
               }
               ds.Ma_Sach = _ds.Ma_Sach;
               ds.Ma_DauSach = _ds.Ma_DauSach;
               ds.Ma_ThuVien = _ds.Ma_ThuVien;
               ds.TinhTrang = _ds.TinhTrang;
               ds.NgayNhapKho = _ds.NgayNhapKho;
               ql.SaveChanges();
               return true;
          }
          public bool Insert(Sach ds)
          {
               Sach _ds = ql.Saches.Where(n => n.Ma_Sach == ds.Ma_Sach).FirstOrDefault();

               if (_ds != null)
               {
                    return false;
               }
               ql.Saches.Add(ds);
               ql.SaveChanges();

               return true;
          }
          public bool Delete(string Ma)
          {
               Sach ds = ql.Saches.Where(n => n.Ma_Sach == Ma).FirstOrDefault();
               if (ds == null)
               {
                    return false;
               }
               ql.Saches.Remove(ds);
               ql.SaveChanges();
               return true;
          }
     }
}
