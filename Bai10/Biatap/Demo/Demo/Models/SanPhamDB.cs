using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Demo.Models
{
    public partial class SanPhamDB : DbContext
    {
        public SanPhamDB()
            : base("name=SanPhamDB")
        {
        }

        public virtual DbSet<Hang> Hangs { get; set; }
        public virtual DbSet<nguoidung> nguoidungs { get; set; }
        public virtual DbSet<Nha_CC> Nha_CC { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Hang>()
                .Property(e => e.MaHang)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Hang>()
                .Property(e => e.MaNCC)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Hang>()
                .Property(e => e.Gia)
                .HasPrecision(8, 2);

            modelBuilder.Entity<Hang>()
                .Property(e => e.LuongCo)
                .HasPrecision(8, 2);

            modelBuilder.Entity<Hang>()
                .Property(e => e.ChietKhau)
                .HasPrecision(8, 2);

            modelBuilder.Entity<Nha_CC>()
                .Property(e => e.MaNCC)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Nha_CC>()
                .Property(e => e.DienThoai)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Nha_CC>()
                .HasMany(e => e.Hangs)
                .WithRequired(e => e.Nha_CC)
                .WillCascadeOnDelete(false);
        }
    }
}
