using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace TrieuVuKhuong.Models
{
    public partial class LTQLDb : DbContext
    {
        public LTQLDb():base("name=LTQLDb")
            {
            }
            public virtual DbSet<Lophoc> LopHocs { get; set; }
            public virtual DbSet<Sinhvien> Sinhviens { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Sinhvien>()
                .Property(e => e.MaSinhVien)
                .IsUnicode(false);
        }
    }
}