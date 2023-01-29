using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace StockMonitoring.Models.dblocal
{
    public partial class WGRContext : DbContext
    {
        public WGRContext()
        {
        }

        public WGRContext(DbContextOptions<WGRContext> options)
            : base(options)
        {
        }

        public virtual DbSet<StockDataInput> StockDataInputs { get; set; }
        public virtual DbSet<StockList> StockLists { get; set; }
        public virtual DbSet<StockListLog> StockListLogs { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=localhost\\SQLEXPRESS;Database=WGR;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<StockDataInput>(entity =>
            {
                entity.HasKey(e => e.Run);

                entity.ToTable("StockDataInput");

                entity.Property(e => e.PartNumber)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.RegistDateTime).HasColumnType("datetime");

                entity.Property(e => e.SectionCode)
                    .IsRequired()
                    .HasMaxLength(10);
            });

            modelBuilder.Entity<StockList>(entity =>
            {
                entity.HasKey(e => new { e.SectionCode, e.PartNumber });

                entity.ToTable("StockList");

                entity.Property(e => e.SectionCode).HasMaxLength(10);

                entity.Property(e => e.PartNumber).HasMaxLength(20);

                entity.Property(e => e.ActivePn).HasColumnName("ActivePN");

                entity.Property(e => e.Hhlimit).HasColumnName("HHLimit");

                entity.Property(e => e.Hlimit).HasColumnName("HLimit");

                entity.Property(e => e.Llimit).HasColumnName("LLimit");

                entity.Property(e => e.Lllimt).HasColumnName("LLLimt");
            });

            modelBuilder.Entity<StockListLog>(entity =>
            {
                entity.HasKey(e => e.Run);

                entity.ToTable("StockListLog");

                entity.Property(e => e.Run).HasColumnName("run");

                entity.Property(e => e.PartNumber)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.Registdatetime)
                    .HasColumnType("datetime")
                    .HasColumnName("registdatetime");

                entity.Property(e => e.SectionCode)
                    .IsRequired()
                    .HasMaxLength(10);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
