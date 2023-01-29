﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using StockMonitoring.Data;

namespace StockMonitoring.Migrations
{
    [DbContext(typeof(SqliteDbContext))]
    partial class SqliteDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.7");

            modelBuilder.Entity("StockMonitoring.Models.MasterPiece", b =>
                {
                    b.Property<string>("PartNumberId")
                        .HasColumnType("TEXT");

                    b.Property<int>("PiecePerKanban")
                        .HasColumnType("INTEGER");

                    b.HasKey("PartNumberId");

                    b.ToTable("MasterPieces");
                });

            modelBuilder.Entity("StockMonitoring.Models.ScanInput", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("PartNumberId")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("RegistDate")
                        .HasColumnType("TEXT");

                    b.Property<int>("SectionCode")
                        .HasColumnType("INTEGER");

                    b.Property<int>("UserId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("ScanInputs");
                });
#pragma warning restore 612, 618
        }
    }
}