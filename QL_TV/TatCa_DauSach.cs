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
     public partial class TatCa_DauSach : UserControl
     {
        QLTV ql = new QLTV();
        List<DauSach> listDS = new List<DauSach>();
        DS_DauSach dsDS;
        CT_DauSach ctDS;
        public TatCa_DauSach()
        {
            InitializeComponent();
            LayDL();
        }
        void LayDL()
        {
            listDS = ql.DauSaches.ToList();
            dsDS = new DS_DauSach(listDS);
            panelData.Controls.Clear();
            panelData.Controls.Add(dsDS);
        }     
        
    }
}
