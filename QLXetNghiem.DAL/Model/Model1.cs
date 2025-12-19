using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace QLXetNghiem.DAL.Model
{
    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model11")
        {
        }

        public virtual DbSet<CONGTY> CONGTies { get; set; }
        public virtual DbSet<NHANVIEN> NHANVIENs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CONGTY>()
                .HasMany(e => e.NHANVIENs)
                .WithRequired(e => e.CONGTY)
                .WillCascadeOnDelete(false);
        }
    }
}
