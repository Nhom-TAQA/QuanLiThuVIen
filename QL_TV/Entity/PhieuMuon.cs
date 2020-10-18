namespace QL_TV.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PhieuMuon")]
    public partial class PhieuMuon
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PhieuMuon()
        {
            ChiTiet_PhieuMuon1 = new HashSet<ChiTiet_PhieuMuon1>();
        }

        [Key]
        [StringLength(10)]
        public string Ma_PhieuMuon { get; set; }

        [StringLength(10)]
        public string Ma_HocVien { get; set; }

        [StringLength(10)]
        public string Ma_ThuThu { get; set; }

        [Column(TypeName = "date")]
        public DateTime NgayMuon { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChiTiet_PhieuMuon1> ChiTiet_PhieuMuon1 { get; set; }

        public virtual HocVien HocVien { get; set; }

        public virtual NhanVien NhanVien { get; set; }
    }
}
