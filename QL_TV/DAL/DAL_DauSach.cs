using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QL_TV.Entity;

namespace QL_TV.DAL
{
     class DAL_DauSach
     {
          QLTV ql = new QLTV();
          public bool Update(DauSach _ds)
          {
               DauSach ds = ql.DauSaches.Find(_ds.Ma_DauSach);
               if (ds == null)
               {
                    return false;
               }
               ds.Ma_DauSach = _ds.Ma_DauSach;
               ds.Ten_DauSach = _ds.Ten_DauSach;
               ds.TacGia = _ds.TacGia;
               ds.Ma_NXB = _ds.Ma_NXB;
               ds.DanhMuc = _ds.DanhMuc;
               ds.SoLuong = ds.SoLuong;
               ds.Anh = _ds.Anh;
               ql.SaveChanges();
               return true;
          }
          public bool Insert(DauSach ds)
          {
               DauSach _ds = ql.DauSaches.Where(n => n.Ma_DauSach == ds.Ma_DauSach).FirstOrDefault();

               if (_ds != null)
               {
                    return false;
               }
               ql.DauSaches.Add(ds);
               ql.SaveChanges();

               return true;
          }
          public bool Delete(string Ma)
          {
               DAL_Sach dals = new DAL_Sach();
               List<Sach> listS = new List<Sach>();
               listS = ql.Saches.Where(n => n.Ma_DauSach == Ma).ToList();
               foreach(Sach s in listS)
               {
                    List<ChiTiet_PhieuMuon1> listCT = new List<ChiTiet_PhieuMuon1>();
                    listCT = ql.ChiTiet_PhieuMuon1.Where(n => n.Ma_Sach == s.Ma_Sach).ToList();
                    foreach(ChiTiet_PhieuMuon1 ct in listCT)
                    {
                         ql.ChiTiet_PhieuMuon1.Remove(ct);
                    }
                    ql.Saches.Remove(s);
               }
               DauSach ds = ql.DauSaches.Where(n=>n.Ma_DauSach == Ma).FirstOrDefault();
               if (ds == null)
               {
                    return false;
               }
               ql.DauSaches.Remove(ds);
               ql.SaveChanges();
               return true;
          }
     }
}
