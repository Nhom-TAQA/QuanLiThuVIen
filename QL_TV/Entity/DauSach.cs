namespace QL_TV.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DauSach")]
    public partial class DauSach
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DauSach()
        {
            Saches = new HashSet<Sach>();
        }

        [Key]
        [StringLength(10)]
        public string Ma_DauSach { get; set; }

        [StringLength(200)]
        public string Ten_DauSach { get; set; }

        [StringLength(10)]
        public string Ma_NXB { get; set; }

        public int? SoLuong { get; set; }

        [StringLength(10)]
        public string DanhMuc { get; set; }

        [StringLength(1000)]
        public string TacGia { get; set; }

        [Column(TypeName = "image")]
        public byte[] Anh { get; set; }

        public virtual DanhMuc DanhMuc1 { get; set; }

        public virtual NXB NXB { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Sach> Saches { get; set; }
    }
}
