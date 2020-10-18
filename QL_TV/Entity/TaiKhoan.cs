namespace QL_TV.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TaiKhoan")]
    public partial class TaiKhoan
    {
        [StringLength(10)]
        public string ID { get; set; }

        [StringLength(20)]
        public string TenDangNhap { get; set; }

        [StringLength(20)]
        public string MatKhau { get; set; }

        public int PhanQuyen { get; set; }
    }
}
