using Microsoft.EntityFrameworkCore;
using StockMonitoring.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace StockMonitoring.Data
{
    public class SqliteDbContext : DbContext
    {
        //public DbSet<ScanInput> ScanInputs { get; set; }

        //public DbSet<MasterPiece> MasterPieces { get; set; }

        public DbSet<Pattern> Patterns { get; set; }

        //public DbSet<PortSetting> PortSettings { get; set; }

        //public DbSet<Account> Accounts { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
           => options.UseSqlite(@"Data Source=C:\stock\db\login.db3");


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Thai_100_CI_AS");

            modelBuilder.Entity<Pattern>(entity =>
            {

                entity.ToTable("Pattern");

                entity.HasKey(e => e.SectionCode);

                entity.Property(e => e.SectionCode)
                .HasColumnName("SectionCode")
                    .IsRequired();


                entity.Property(e => e.TotalLength)
                .HasColumnName("TotalLength")
                    .IsRequired();

                entity.Property(e => e.Start)
                .HasColumnName("Start")
                    .IsRequired();


                entity.Property(e => e.Length)
                .HasColumnName("Length")
                    .IsRequired();

                entity.Property(e => e.Example)
                  .HasColumnName("Example");
            });




           


         

           // OnModelCreatingPartial(modelBuilder);
        }

      //  partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
