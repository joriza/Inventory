﻿// <auto-generated />
using System;
using DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DataAccess.Migrations
{
    [DbContext(typeof(InventaryContext))]
    [Migration("20230126185734_AddData2")]
    partial class AddData2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Entities.CategoryEntity", b =>
                {
                    b.Property<string>("CategoryId")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            CategoryId = "ASH",
                            CategoryName = "Aseo Hogar"
                        },
                        new
                        {
                            CategoryId = "ASP",
                            CategoryName = "Aseo Personal"
                        },
                        new
                        {
                            CategoryId = "HGR",
                            CategoryName = "Hogar"
                        },
                        new
                        {
                            CategoryId = "PRF",
                            CategoryName = "Perfumería"
                        },
                        new
                        {
                            CategoryId = "SLD",
                            CategoryName = "Salud"
                        },
                        new
                        {
                            CategoryId = "VDJ",
                            CategoryName = "Video Juegos"
                        });
                });

            modelBuilder.Entity("Entities.InputOutputEntity", b =>
                {
                    b.Property<string>("InOutId")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<DateTime>("InOutDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsInput")
                        .HasColumnType("bit");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<string>("StorageId")
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("InOutId");

                    b.HasIndex("StorageId");

                    b.ToTable("InOuts");
                });

            modelBuilder.Entity("Entities.ProductEntity", b =>
                {
                    b.Property<string>("ProductId")
                        .HasColumnType("nvarchar(10)")
                        .HasMaxLength(10);

                    b.Property<string>("CategoryId")
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("ProductDescription")
                        .HasColumnType("nvarchar(600)")
                        .HasMaxLength(600);

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<int>("TotalQuantity")
                        .HasColumnType("int");

                    b.HasKey("ProductId");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            ProductId = "ASJ-98745",
                            CategoryId = "PRF",
                            ProductDescription = "",
                            ProductName = "Crema para manos marca Tersa",
                            TotalQuantity = 0
                        },
                        new
                        {
                            ProductId = "RPT-546587",
                            CategoryId = "SLD",
                            ProductDescription = "",
                            ProductName = "Pastillas para la garganta LESUS",
                            TotalQuantity = 0
                        });
                });

            modelBuilder.Entity("Entities.StorageEntity", b =>
                {
                    b.Property<string>("StorageId")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<DateTime>("LastUpdate")
                        .HasColumnType("datetime2");

                    b.Property<int>("PartialQuantity")
                        .HasColumnType("int");

                    b.Property<string>("ProductId")
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("WarehouseId")
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("StorageId");

                    b.HasIndex("ProductId");

                    b.HasIndex("WarehouseId");

                    b.ToTable("Storages");
                });

            modelBuilder.Entity("Entities.WarehouseEntity", b =>
                {
                    b.Property<string>("WarehouseId")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("WarehouseAddress")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("WarehouseName")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.HasKey("WarehouseId");

                    b.ToTable("Warehouses");

                    b.HasData(
                        new
                        {
                            WarehouseId = "4c41b504-18f6-4012-95c4-3792b74f8762",
                            WarehouseAddress = "Calle 8 con 23",
                            WarehouseName = "Bodega Central"
                        },
                        new
                        {
                            WarehouseId = "05218caa-d6d6-4573-b06f-61355da42d8d",
                            WarehouseAddress = "Calle norte con occidente",
                            WarehouseName = "Bodega Norte"
                        });
                });

            modelBuilder.Entity("Entities.InputOutputEntity", b =>
                {
                    b.HasOne("Entities.StorageEntity", "Storage")
                        .WithMany("InputOutputs")
                        .HasForeignKey("StorageId");
                });

            modelBuilder.Entity("Entities.ProductEntity", b =>
                {
                    b.HasOne("Entities.CategoryEntity", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId");
                });

            modelBuilder.Entity("Entities.StorageEntity", b =>
                {
                    b.HasOne("Entities.ProductEntity", "Product")
                        .WithMany("Storages")
                        .HasForeignKey("ProductId");

                    b.HasOne("Entities.WarehouseEntity", "Warehouse")
                        .WithMany("Storages")
                        .HasForeignKey("WarehouseId");
                });
#pragma warning restore 612, 618
        }
    }
}
