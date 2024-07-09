﻿// <auto-generated />
using System;
using Cashly.Server.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Cashly.Server.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Cashly.Server.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Income"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Expenditure"
                        });
                });

            modelBuilder.Entity("Cashly.Server.Models.Expense", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<decimal>("Amount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Expenses");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Amount = 5600m,
                            CategoryId = 1,
                            Date = new DateTime(2024, 7, 9, 11, 59, 34, 70, DateTimeKind.Local).AddTicks(3572),
                            Title = "Salary"
                        },
                        new
                        {
                            Id = 2,
                            Amount = 200m,
                            CategoryId = 1,
                            Date = new DateTime(2024, 7, 9, 11, 59, 34, 70, DateTimeKind.Local).AddTicks(3577),
                            Title = "gift"
                        },
                        new
                        {
                            Id = 3,
                            Amount = 50.76m,
                            CategoryId = 2,
                            Date = new DateTime(2024, 7, 9, 11, 59, 34, 70, DateTimeKind.Local).AddTicks(3650),
                            Title = "Lunch"
                        },
                        new
                        {
                            Id = 4,
                            Amount = 1200m,
                            CategoryId = 2,
                            Date = new DateTime(2024, 7, 9, 11, 59, 34, 70, DateTimeKind.Local).AddTicks(3652),
                            Title = "rent"
                        });
                });

            modelBuilder.Entity("Cashly.Server.Models.Expense", b =>
                {
                    b.HasOne("Cashly.Server.Models.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });
#pragma warning restore 612, 618
        }
    }
}
