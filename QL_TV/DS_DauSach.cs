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
     public partial class DS_DauSach : UserControl
     {
          public DS_DauSach(List<DauSach> listDauSach)
          {
               InitializeComponent();
          }
     }
}
