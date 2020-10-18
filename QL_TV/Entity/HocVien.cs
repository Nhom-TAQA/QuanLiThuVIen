namespace QL_TV.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HocVien")]
    public partial class HocVien
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HocVien()
        {
            PhieuMuons = new HashSet<PhieuMuon>();
        }

        [Key]
        [StringLength(10)]
        public string Ma_HocVien { get; set; }

        [StringLength(50)]
        public string Ten_HocVien { get; set; }

        [Column(TypeName = "date")]
        public DateTime NgaySinh { get; set; }

        [StringLength(50)]
        public string Lop { get; set; }

        public int Khoa { get; set; }

        [StringLength(15)]
        public string SDT { get; set; }

        [Column(TypeName = "image")]
        public byte[] Anh { get; set; }

        [StringLength(10)]
        public string ID { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PhieuMuon> PhieuMuons { get; set; }
    }
}
