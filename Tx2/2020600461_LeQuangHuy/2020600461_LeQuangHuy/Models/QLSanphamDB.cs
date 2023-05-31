using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace _2020600461_LeQuangHuy.Models
{
    public partial class QLSanphamDB : DbContext
    {
        public QLSanphamDB()
            : base("name=QLSanphamDB")
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
