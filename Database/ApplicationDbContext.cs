using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace RealEstate.Database
{
    public partial class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext()
        {
        }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<TblProperty> TblProperties { get; set; }
        public virtual DbSet<TblSuburb> TblSuburbs { get; set; }
        public virtual DbSet<ViewOutputSheet> ViewOutputSheets { get; set; }

//        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//        {
//            if (!optionsBuilder.IsConfigured)
//            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
//                optionsBuilder.UseSqlServer("Data Source=DESKTOP-O96UUPQ\\SQLEXPRESS;Initial Catalog=Properties;Integrated Security=True");
//            }
//        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<TblProperty>(entity =>
            {
                entity.HasOne(d => d.Suburb)
                    .WithMany(p => p.TblProperties)
                    .HasForeignKey(d => d.SuburbId)
                    .HasConstraintName("FK_tblProperty_tblSuburb");
            });

            modelBuilder.Entity<TblSuburb>(entity =>
            {
                entity.Property(e => e.Active).HasDefaultValueSql("((1))");

                entity.Property(e => e.Adjustment).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<ViewOutputSheet>(entity =>
            {
                entity.ToView("View_OutputSheet");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
