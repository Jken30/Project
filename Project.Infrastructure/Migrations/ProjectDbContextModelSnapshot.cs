﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Project.Infrastructure.Persistence;

#nullable disable

namespace Project.Infrastructure.Migrations
{
    [DbContext(typeof(ProjectDbContext))]
    partial class ProjectDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Project.Domain.Entities.Category", b =>
                {
                    b.Property<Guid>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("CategoryId");

                    b.HasIndex("CategoryName")
                        .IsUnique();

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("Project.Domain.Entities.Product", b =>
                {
                    b.Property<Guid>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("BarcodeData")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("CategoryId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ProductCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("ProductPreOrder")
                        .HasColumnType("int");

                    b.Property<decimal>("ProductPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("ProductQuantity")
                        .HasColumnType("int");

                    b.Property<DateTime>("ScannedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("ProductId");

                    b.HasIndex("CategoryId");

                    b.HasIndex("ProductCode")
                        .IsUnique();

                    b.HasIndex("ProductName")
                        .IsUnique();

                    b.ToTable("Products");
                });

            modelBuilder.Entity("Project.Domain.Entities.StockRecord", b =>
                {
                    b.Property<Guid>("StockRecordId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ProductId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ReferenceNum")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateOnly>("StockInDate")
                        .HasColumnType("date");

                    b.Property<int>("StockInQty")
                        .HasColumnType("int");

                    b.HasKey("StockRecordId");

                    b.HasIndex("ProductId");

                    b.ToTable("StockRecords");
                });

            modelBuilder.Entity("Project.Domain.Entities.Product", b =>
                {
                    b.HasOne("Project.Domain.Entities.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("Project.Domain.Entities.StockRecord", b =>
                {
                    b.HasOne("Project.Domain.Entities.Product", "Product")
                        .WithMany("StockRecords")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");
                });

            modelBuilder.Entity("Project.Domain.Entities.Category", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("Project.Domain.Entities.Product", b =>
                {
                    b.Navigation("StockRecords");
                });
#pragma warning restore 612, 618
        }
    }
}
