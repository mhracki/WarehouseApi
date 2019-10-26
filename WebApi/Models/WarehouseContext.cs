
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
        public DbSet<ShelfModel> Shelf { get; set; }
        public DbSet<PlaceModel> Place { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var wId = Guid.NewGuid();
            var roId = Guid.NewGuid();
            var cId = Guid.NewGuid();
            var raId = Guid.NewGuid();
            var shId = Guid.NewGuid();
            var pId = Guid.NewGuid();
            var iId = Guid.NewGuid();





            modelBuilder.Entity<WarehouseModel>().HasData(new WarehouseModel { Id = wId, Name = "Martyna" });
            modelBuilder.Entity<RoomModel>().HasData(new  { Id = roId, Name = "duzy",WarehouseId = wId, });
            modelBuilder.Entity<ColumnModel>().HasData(new  { Id = cId, Name = "glowna",RoomId = roId });
            modelBuilder.Entity<RackModel>().HasData(new { Id = raId, Name = "1", Side = false, ColumnsId= cId });
            modelBuilder.Entity<ShelfModel>().HasData(new  { Id = shId, Name = "2", RackId= raId });
            modelBuilder.Entity<PlaceModel>().HasData(new  { Id = pId, Name = "srodek",ShelfId=shId, RackId = raId, ColumnsId = cId, RoomId = roId, WarehouseId = wId });
            modelBuilder.Entity<ItemModel>().HasData(new {
                Id = iId, ItemName = "Przedmiot",
                Quantity =20,
                WarehouseId = wId,
               

            });





        }

    }

}
