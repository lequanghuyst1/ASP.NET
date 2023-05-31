using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace BaiTest.Models
{
    public partial class QLSanPhamDB : DbContext
    {
        public QLSanPhamDB()
            : base("name=QLSanPhamDB")
        {
        }

        public virtual DbSet<Danhmuc> Danhmucs { get; set; }
        public virtual DbSet<Sanpham> Sanphams { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Danhmuc>()
                .Property(e => e.Mota)
                .IsUnicode(false);

            modelBuilder.Entity<Danhmuc>()
                .HasMany(e => e.Sanphams)
                .WithRequired(e => e.Danhmuc)
                .WillCascadeOnDelete(false);
        }
    }
}
