﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebApi.Models;

namespace WebApi.Migrations.Warehouse
{
    [DbContext(typeof(WarehouseContext))]
    [Migration("20191026125828_warehouse")]
    partial class warehouse
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
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
                            Id = new Guid("72465a96-36e7-4649-bc15-31da8250c7de"),
                            Name = "glowna",
                            RoomId = new Guid("b374df7e-024c-4fb7-8919-5c0cbe41a4da")
                        });
                });

            modelBuilder.Entity("WebApi.Models.ItemModel", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid?>("ColumnId");

                    b.Property<string>("ItemName");

                    b.Property<Guid?>("PlaceId");

                    b.Property<int>("Quantity");

                    b.Property<Guid?>("RackId");

                    b.Property<Guid?>("RoomId");

                    b.Property<Guid?>("ShelfId");

                    b.Property<Guid?>("WarehouseId");

                    b.HasKey("Id");

                    b.HasIndex("ColumnId");

                    b.HasIndex("PlaceId");

                    b.HasIndex("RackId");

                    b.HasIndex("RoomId");

                    b.HasIndex("ShelfId");

                    b.HasIndex("WarehouseId");

                    b.ToTable("Item");

                    b.HasData(
                        new
                        {
                            Id = new Guid("ae6b843c-f784-49dc-9ec8-e5e9f06d5e01"),
                            ItemName = "Przedmiot",
                            PlaceId = new Guid("a15d5759-1b4c-4d0d-911e-b73bf3e19001"),
                            Quantity = 20
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
                            Id = new Guid("a15d5759-1b4c-4d0d-911e-b73bf3e19001"),
                            Name = "srodek",
                            ShelfId = new Guid("7d9276e3-514e-4cbc-9c73-cb131a2f8dc3")
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
                            Id = new Guid("0c93db94-0862-4987-bb71-02d87e548c73"),
                            ColumnsId = new Guid("72465a96-36e7-4649-bc15-31da8250c7de"),
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
                            Id = new Guid("b374df7e-024c-4fb7-8919-5c0cbe41a4da"),
                            Name = "duzy",
                            WarehouseId = new Guid("55ec8da9-910f-4794-a142-aad7cc39d32f")
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
                            Id = new Guid("7d9276e3-514e-4cbc-9c73-cb131a2f8dc3"),
                            Name = "2",
                            RackId = new Guid("0c93db94-0862-4987-bb71-02d87e548c73")
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
                            Id = new Guid("55ec8da9-910f-4794-a142-aad7cc39d32f"),
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
                    b.HasOne("WebApi.Models.ColumnModel", "Column")
                        .WithMany("Item")
                        .HasForeignKey("ColumnId");

                    b.HasOne("WebApi.Models.PlaceModel", "Place")
                        .WithMany()
                        .HasForeignKey("PlaceId");

                    b.HasOne("WebApi.Models.RackModel", "Rack")
                        .WithMany()
                        .HasForeignKey("RackId");

                    b.HasOne("WebApi.Models.RoomModel", "Room")
                        .WithMany()
                        .HasForeignKey("RoomId");

                    b.HasOne("WebApi.Models.ShelfModel", "Shelf")
                        .WithMany()
                        .HasForeignKey("ShelfId");

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