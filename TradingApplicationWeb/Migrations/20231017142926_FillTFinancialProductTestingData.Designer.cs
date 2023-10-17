﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TradingApplicationWeb.Data;

#nullable disable

namespace TradingApplicationWeb.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20231017142926_FillTFinancialProductTestingData")]
    partial class FillTFinancialProductTestingData
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.12")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("TradingApplicationWeb.Models.FinancialProduct", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<double>("Close")
                        .HasColumnType("float");

                    b.Property<string>("From")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("High")
                        .HasColumnType("float");

                    b.Property<double>("Low")
                        .HasColumnType("float");

                    b.Property<double>("Open")
                        .HasColumnType("float");

                    b.Property<string>("Symbol")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Volume")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("FinancialProducts");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Close = 150.87,
                            From = "2023-09-01",
                            High = 154.33000000000001,
                            Low = 150.41999999999999,
                            Open = 153.77500000000001,
                            Symbol = "T",
                            Volume = 123456
                        },
                        new
                        {
                            Id = 2,
                            Close = 150.87,
                            From = "2023-09-01",
                            High = 154.33000000000001,
                            Low = 150.41999999999999,
                            Open = 153.77500000000001,
                            Symbol = "E",
                            Volume = 123456
                        },
                        new
                        {
                            Id = 3,
                            Close = 150.87,
                            From = "2023-09-01",
                            High = 154.33000000000001,
                            Low = 150.41999999999999,
                            Open = 153.77500000000001,
                            Symbol = "S",
                            Volume = 123456
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
