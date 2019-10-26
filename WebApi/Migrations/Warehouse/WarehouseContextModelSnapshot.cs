﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebApi.Models;

namespace WebApi.Migrations.Warehouse
{
    [DbContext(typeof(WarehouseContext))]
    partial class WarehouseContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.3-servicing-35854")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WebApi.Models.ColumnModel", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.Property<Guid?>("RoomId");

                    b.HasKey("Id");

                    b.HasIndex("RoomId");

                    b.ToTable("Columns");

                    b.HasData(
                        new
                        {
                            Id = new Guid("3564fc79-9cb7-46e6-9772-c34f6a6c5903"),
                            Name = "glowna",
                            RoomId = new Guid("a3715067-98a1-443b-856d-3618c56379a2")
                        });
                });

            modelBuilder.Entity("WebApi.Models.ItemModel", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid?>("ColumnModelId");

                    b.Property<string>("ItemName");

                    b.Property<int>("Quantity");

                    b.Property<Guid?>("WarehouseId");

                    b.HasKey("Id");

                    b.HasIndex("ColumnModelId");

                    b.HasIndex("WarehouseId");

                    b.ToTable("Item");

                    b.HasData(
                        new
                        {
                            Id = new Guid("31bfa0c9-e1b9-43c6-91e0-fe6f86b6b504"),
                            ItemName = "Przedmiot",
                            Quantity = 20,
                            WarehouseId = new Guid("30638fc5-bb6a-4605-aff8-9bce1c596c5c")
                        });
                });

            modelBuilder.Entity("WebApi.Models.PlaceModel", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.Property<Guid?>("ShelfId");

                    b.HasKey("Id");

                    b.HasIndex("ShelfId");

                    b.ToTable("Place");

                    b.HasData(
                        new
                        {
                            Id = new Guid("30b9a620-64cf-4850-b5e3-152e6210265e"),
                            Name = "srodek",
                            ShelfId = new Guid("9b0b9a80-80da-465a-930d-7d2e5d7ee30f")
                        });
                });

            modelBuilder.Entity("WebApi.Models.RackModel", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid?>("ColumnsId");

                    b.Property<string>("Name");

                    b.Property<bool>("Side");

                    b.HasKey("Id");

                    b.HasIndex("ColumnsId");

                    b.ToTable("Rack");

                    b.HasData(
                        new
                        {
                            Id = new Guid("a12195de-0a15-42e3-becc-4748b0b56d88"),
                            ColumnsId = new Guid("3564fc79-9cb7-46e6-9772-c34f6a6c5903"),
                            Name = "1",
                            Side = false
                        });
                });

            modelBuilder.Entity("WebApi.Models.RoomModel", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.Property<Guid?>("WarehouseId");

                    b.HasKey("Id");

                    b.HasIndex("WarehouseId");

                    b.ToTable("Room");

                    b.HasData(
                        new
                        {
                            Id = new Guid("a3715067-98a1-443b-856d-3618c56379a2"),
                            Name = "duzy",
                            WarehouseId = new Guid("30638fc5-bb6a-4605-aff8-9bce1c596c5c")
                        });
                });

            modelBuilder.Entity("WebApi.Models.ShelfModel", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.Property<Guid?>("RackId");

                    b.HasKey("Id");

                    b.HasIndex("RackId");

                    b.ToTable("Shelf");

                    b.HasData(
                        new
                        {
                            Id = new Guid("9b0b9a80-80da-465a-930d-7d2e5d7ee30f"),
                            Name = "2",
                            RackId = new Guid("a12195de-0a15-42e3-becc-4748b0b56d88")
                        });
                });

            modelBuilder.Entity("WebApi.Models.WarehouseModel", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Warehouse");

                    b.HasData(
                        new
                        {
                            Id = new Guid("30638fc5-bb6a-4605-aff8-9bce1c596c5c"),
                            Name = "Martyna"
                        });
                });

            modelBuilder.Entity("WebApi.Models.ColumnModel", b =>
                {
                    b.HasOne("WebApi.Models.RoomModel", "Room")
                        .WithMany("Columns")
                        .HasForeignKey("RoomId");
                });

            modelBuilder.Entity("WebApi.Models.ItemModel", b =>
                {
                    b.HasOne("WebApi.Models.ColumnModel")
                        .WithMany("Item")
                        .HasForeignKey("ColumnModelId");

                    b.HasOne("WebApi.Models.WarehouseModel", "Warehouse")
                        .WithMany()
                        .HasForeignKey("WarehouseId");
                });

            modelBuilder.Entity("WebApi.Models.PlaceModel", b =>
                {
                    b.HasOne("WebApi.Models.ShelfModel", "Shelf")
                        .WithMany("Place")
                        .HasForeignKey("ShelfId");
                });

            modelBuilder.Entity("WebApi.Models.RackModel", b =>
                {
                    b.HasOne("WebApi.Models.ColumnModel", "Columns")
                        .WithMany("Rack")
                        .HasForeignKey("ColumnsId");
                });

            modelBuilder.Entity("WebApi.Models.RoomModel", b =>
                {
                    b.HasOne("WebApi.Models.WarehouseModel", "Warehouse")
                        .WithMany("Room")
                        .HasForeignKey("WarehouseId");
                });

            modelBuilder.Entity("WebApi.Models.ShelfModel", b =>
                {
                    b.HasOne("WebApi.Models.RackModel", "Rack")
                        .WithMany("Shelf")
                        .HasForeignKey("RackId");
                });
#pragma warning restore 612, 618
        }
    }
}