namespace QL_TV.Entity
{
     using System;
     using System.Data.Entity;
     using System.ComponentModel.DataAnnotations.Schema;
     using System.Linq;

     public partial class QLTV : DbContext
     {
          public QLTV()
              : base("name=QLTV")
          {
          }

          public virtual DbSet<ChiTiet_PhieuMuon1> ChiTiet_PhieuMuon1 { get; set; }
          public virtual DbSet<DanhMuc> DanhMucs { get; set; }
          public virtual DbSet<DauSach> DauSaches { get; set; }
          public virtual DbSet<HocVien> HocViens { get; set; }
          public virtual DbSet<NhanVien> NhanViens { get; set; }
          public virtual DbSet<NXB> NXBs { get; set; }
          public virtual DbSet<PhieuMuon> PhieuMuons { get; set; }
          public virtual DbSet<Sach> Saches { get; set; }
          public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
          public virtual DbSet<TaiKhoan> TaiKhoans { get; set; }
          public virtual DbSet<ThuVien> ThuViens { get; set; }

          protected override void OnModelCreating(DbModelBuilder modelBuilder)
          {
               modelBuilder.Entity<ChiTiet_PhieuMuon1>()
                   .Property(e => e.Ma_ChiTiet)
                   .IsUnicode(false);

               modelBuilder.Entity<ChiTiet_PhieuMuon1>()
                   .Property(e => e.Ma_PhieuMuon)
                   .IsUnicode(false);

               modelBuilder.Entity<ChiTiet_PhieuMuon1>()
                   .Property(e => e.Ma_Sach)
                   .IsUnicode(false);

               modelBuilder.Entity<DanhMuc>()
                   .Property(e => e.Ma_DanhMuc)
                   .IsUnicode(false);

               modelBuilder.Entity<DanhMuc>()
                   .HasMany(e => e.DauSaches)
                   .WithOptional(e => e.DanhMuc1)
                   .HasForeignKey(e => e.DanhMuc);

               modelBuilder.Entity<DauSach>()
                   .Property(e => e.Ma_DauSach)
                   .IsUnicode(false);

               modelBuilder.Entity<DauSach>()
                   .Property(e => e.Ma_NXB)
                   .IsUnicode(false);

               modelBuilder.Entity<DauSach>()
                   .Property(e => e.DanhMuc)
                   .IsUnicode(false);

               modelBuilder.Entity<HocVien>()
                   .Property(e => e.Ma_HocVien)
                   .IsUnicode(false);

               modelBuilder.Entity<HocVien>()
                   .Property(e => e.SDT)
                   .IsUnicode(false);

               modelBuilder.Entity<HocVien>()
                   .Property(e => e.ID)
                   .IsUnicode(false);

               modelBuilder.Entity<NhanVien>()
                   .Property(e => e.Ma_NhanVien)
                   .IsUnicode(false);

               modelBuilder.Entity<NhanVien>()
                   .Property(e => e.Email)
                   .IsUnicode(false);

               modelBuilder.Entity<NhanVien>()
                   .Property(e => e.SDT)
                   .IsUnicode(false);

               modelBuilder.Entity<NhanVien>()
                   .Property(e => e.ID)
                   .IsUnicode(false);

               modelBuilder.Entity<NhanVien>()
                   .HasMany(e => e.PhieuMuons)
                   .WithOptional(e => e.NhanVien)
                   .HasForeignKey(e => e.Ma_ThuThu);

               modelBuilder.Entity<NXB>()
                   .Property(e => e.Ma_NXB)
                   .IsUnicode(false);

               modelBuilder.Entity<PhieuMuon>()
                   .Property(e => e.Ma_PhieuMuon)
                   .IsUnicode(false);

               modelBuilder.Entity<PhieuMuon>()
                   .Property(e => e.Ma_HocVien)
                   .IsUnicode(false);

               modelBuilder.Entity<PhieuMuon>()
                   .Property(e => e.Ma_ThuThu)
                   .IsUnicode(false);

               modelBuilder.Entity<Sach>()
                   .Property(e => e.Ma_Sach)
                   .IsUnicode(false);

               modelBuilder.Entity<Sach>()
                   .Property(e => e.Ma_DauSach)
                   .IsUnicode(false);

               modelBuilder.Entity<Sach>()
                   .Property(e => e.Ma_ThuVien)
                   .IsUnicode(false);

               modelBuilder.Entity<TaiKhoan>()
                   .Property(e => e.ID)
                   .IsUnicode(false);

               modelBuilder.Entity<TaiKhoan>()
                   .Property(e => e.TenDangNhap)
                   .IsUnicode(false);

               modelBuilder.Entity<TaiKhoan>()
                   .Property(e => e.MatKhau)
                   .IsUnicode(false);

               modelBuilder.Entity<ThuVien>()
                   .Property(e => e.Ma_ThuVien)
                   .IsUnicode(false);
          }
     }
}
