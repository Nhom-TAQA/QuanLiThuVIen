namespace QL_TV.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ChiTiet_PhieuMuon1
    {
        [Key]
        [StringLength(10)]
        public string Ma_ChiTiet { get; set; }

        [StringLength(10)]
        public string Ma_PhieuMuon { get; set; }

        [StringLength(10)]
        public string Ma_Sach { get; set; }

        public bool? TinhTrang { get; set; }

        [Column(TypeName = "date")]
        public DateTime NgayTra { get; set; }

        public virtual PhieuMuon PhieuMuon { get; set; }

        public virtual Sach Sach { get; set; }
    }
}
