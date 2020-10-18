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
     public partial class DS_PhieuMuon : UserControl
     {
          public DS_PhieuMuon(List<PhieuMuon> listPM)
          {
               InitializeComponent();
          }
     }
}
