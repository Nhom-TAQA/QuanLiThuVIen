using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QL_TV.Entity;

namespace QL_TV.DAL
{
     class DAL_NXB
     {
          QLTV ql = new QLTV();
          public bool Insert(NXB nxb)
          {
               NXB _nxb = ql.NXBs.Find(nxb.Ma_NXB);

               if (_nxb != null)
               {
                    return false;
               }
               ql.NXBs.Add(nxb);
               ql.SaveChanges();

               return true;
          }

     }
}
