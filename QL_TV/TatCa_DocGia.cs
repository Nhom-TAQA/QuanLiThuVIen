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
     public partial class TatCa_DocGia : UserControl
     {
          QLTV ql = new QLTV();
          List<HocVien> listHV = new List<HocVien>();
          DS_DocGia dsHV;
          CT_HocVien ctHV;
          public TatCa_DocGia()
          {
               InitializeComponent();
          }
     }
}
