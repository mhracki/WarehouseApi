using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebApi.Models
{
    public class ItemModel
    {
        [Key]
        public Guid Id { get; set; }
        public string ItemName { get; set; }
        public int Quantity { get; set; }
        public virtual WarehouseModel Warehouse { get; set; }
        public virtual RoomModel Room { get; set; }
        public virtual ColumnModel Column { get; set; }
        public virtual RackModel Rack { get; set; }
        public virtual ShelfModel Shelf { get; set; }
        public virtual PlaceModel Place { get; set; }


    }
}
