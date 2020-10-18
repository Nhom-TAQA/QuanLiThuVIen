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

namespace QL_TV
{
     public partial class DS_DocGia : UserControl
     {
          public DS_DocGia(List<HocVien> listHV)
          {
               InitializeComponent();
          }
     }
}
