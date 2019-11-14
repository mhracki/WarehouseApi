
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Models
{
    public class WarehouseContext: DbContext
    {
        

        public WarehouseContext(DbContextOptions<WarehouseContext> options):base(options)
        {
        }

       

        public DbSet<ItemModel> Item { get; set; }
        public DbSet<WarehouseModel> Warehouse { get; set; }
        public DbSet<RoomModel> Room { get; set; }
        public DbSet<ColumnModel> Columns { get; set; }
        public DbSet<RackModel> Rack { get; set; }
        public DbSet<SideModel> Side { get; set; }
        public DbSet<ShelfModel> Shelf { get; set; }
        public DbSet<PlaceModel> Place { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var wId = Guid.NewGuid();
            var roId = Guid.NewGuid();
            var cId = Guid.NewGuid();
            var raId = Guid.NewGuid();
            var siId = Guid.NewGuid();
            var shId = Guid.NewGuid();
            var pId = Guid.NewGuid();
            var iId = Guid.NewGuid();
            var cId1 = Guid.NewGuid();
            var raId1 = Guid.NewGuid();
            var siId1 = Guid.NewGuid();
            var shId1 = Guid.NewGuid();
            var pId1 = Guid.NewGuid();
            var iId1 = Guid.NewGuid();
            var raId2 = Guid.NewGuid();
            var siId2 = Guid.NewGuid();
            var shId2 = Guid.NewGuid();
            var pId2 = Guid.NewGuid();
            var iId2 = Guid.NewGuid();
            var siId3 = Guid.NewGuid();
            var shId3 = Guid.NewGuid();
            var pId3 = Guid.NewGuid();
            var iId3 = Guid.NewGuid();
            var shId4 = Guid.NewGuid();
            var pId4 = Guid.NewGuid();
            var iId4 = Guid.NewGuid();
            var pId5 = Guid.NewGuid();
            var iId5 = Guid.NewGuid();





            modelBuilder.Entity<WarehouseModel>().HasData(new WarehouseModel { Id = wId, Name = "Martyna" });
            modelBuilder.Entity<RoomModel>().HasData(new  { Id = roId, Name = "duzy",WarehouseId = wId, });
            modelBuilder.Entity<ColumnModel>().HasData(new  { Id = cId, Name = "glowna",RoomId = roId });
            modelBuilder.Entity<RackModel>().HasData(new { Id = raId, Name = "1", ColumnsId = cId });
            modelBuilder.Entity<SideModel>().HasData(new { Id = siId, Name = "1", RackId= raId });
            modelBuilder.Entity<ShelfModel>().HasData(new  { Id = shId, Name = "2", SideId= siId });
            modelBuilder.Entity<PlaceModel>().HasData(new  { Id = pId, Name = "srodek",ShelfId=shId  });
            modelBuilder.Entity<ItemModel>().HasData(new
            {
                Id = iId,
                ItemName = "Przedmiot",
                Quantity = 20,
                WarehouseId = wId,
                RoomId = roId,
                ColumnId = cId,
                RackId = raId,
                SideId = siId,
                ShelfId = shId,
                PlaceId = pId,



            });
            //  modelBuilder.Entity<WarehouseModel>().HasData(new WarehouseModel { Id = wId, Name = "Martyna" });
            modelBuilder.Entity<ColumnModel>().HasData(new { Id = cId1, Name = "boczna", RoomId = roId });
            modelBuilder.Entity<RackModel>().HasData(new { Id = raId1, Name = "1", ColumnsId = cId1 });
            modelBuilder.Entity<SideModel>().HasData(new { Id = siId1, Name = "1", RackId = raId1 });
            modelBuilder.Entity<ShelfModel>().HasData(new { Id = shId1, Name = "2", SideId = siId1 });
            modelBuilder.Entity<PlaceModel>().HasData(new { Id = pId1, Name = "srodek", ShelfId = shId1 });
            modelBuilder.Entity<ItemModel>().HasData(new
            {
                Id = iId1,
                ItemName = "Przedmiot",
                Quantity = 20,
                WarehouseId = wId,
                RoomId = roId,
                ColumnId = cId1,
                RackId = raId1,
                SideId = siId1,
                ShelfId = shId1,
                PlaceId = pId1,

            });
            modelBuilder.Entity<RackModel>().HasData(new { Id = raId2, Name = "2", ColumnsId = cId1 });
            modelBuilder.Entity<SideModel>().HasData(new { Id = siId2, Name = "1", RackId = raId2 });
            modelBuilder.Entity<ShelfModel>().HasData(new { Id = shId2, Name = "2", SideId = siId2 });
            modelBuilder.Entity<PlaceModel>().HasData(new { Id = pId2, Name = "srodek", ShelfId = shId2 });
            modelBuilder.Entity<ItemModel>().HasData(new {
                Id = iId2,
                ItemName = "Przedmiot",
                Quantity = 20,
                WarehouseId = wId,
                RoomId = roId,
                ColumnId = cId1,
                RackId = raId2,
                SideId = siId2,
                ShelfId=shId2,
                PlaceId=pId2,
            });
            modelBuilder.Entity<SideModel>().HasData(new { Id = siId3, Name = "2", RackId = raId2 });
            modelBuilder.Entity<ShelfModel>().HasData(new { Id = shId3, Name = "2", SideId = siId3 });
            modelBuilder.Entity<PlaceModel>().HasData(new { Id = pId3, Name = "srodek", ShelfId = shId3 });
            modelBuilder.Entity<ItemModel>().HasData(new
            {
                Id = iId3,
                ItemName = "Przedmiot",
                Quantity = 20,
                WarehouseId = wId,
                RoomId = roId,
                ColumnId = cId1,
                RackId = raId2,
                SideId = siId3,
                ShelfId = shId3,
                PlaceId = pId3,
            });
            modelBuilder.Entity<ShelfModel>().HasData(new { Id = shId4, Name = "3", SideId = siId3 });
            modelBuilder.Entity<PlaceModel>().HasData(new { Id = pId4, Name = "poczatek", ShelfId = shId4 });
            modelBuilder.Entity<ItemModel>().HasData(new
            {
                Id = iId4,
                ItemName = "Przedmiot",
                Quantity = 20,
                WarehouseId = wId,
                RoomId = roId,
                ColumnId = cId1,
                RackId = raId2,
                SideId = siId3,
                ShelfId = shId4,
                PlaceId = pId4,
            });
            modelBuilder.Entity<PlaceModel>().HasData(new { Id = pId5, Name = "koniec", ShelfId = shId4 });
            modelBuilder.Entity<ItemModel>().HasData(new
            {
                Id = iId5,
                ItemName = "Przedmiot",
                Quantity = 20,
                WarehouseId = wId,
                RoomId = roId,
                ColumnId = cId1,
                RackId = raId2,
                SideId = siId3,
                ShelfId = shId4,
                PlaceId = pId5,
            });





        }

    }

}
