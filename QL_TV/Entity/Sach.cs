namespace QL_TV.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Sach")]
    public partial class Sach
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Sach()
        {
            ChiTiet_PhieuMuon1 = new HashSet<ChiTiet_PhieuMuon1>();
        }

        [Key]
        [StringLength(10)]
        public string Ma_Sach { get; set; }

        [StringLength(10)]
        public string Ma_DauSach { get; set; }

        public bool? TinhTrang { get; set; }

        [StringLength(10)]
        public string Ma_ThuVien { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgayNhapKho { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChiTiet_PhieuMuon1> ChiTiet_PhieuMuon1 { get; set; }

        public virtual DauSach DauSach { get; set; }

        public virtual ThuVien ThuVien { get; set; }
    }
}
