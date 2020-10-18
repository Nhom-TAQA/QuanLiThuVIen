namespace QL_TV.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ThuVien")]
    public partial class ThuVien
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ThuVien()
        {
            Saches = new HashSet<Sach>();
        }

        [Key]
        [StringLength(10)]
        public string Ma_ThuVien { get; set; }

        [StringLength(50)]
        public string Ten_ThuVien { get; set; }

        public int? ViTri { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Sach> Saches { get; set; }
    }
}
