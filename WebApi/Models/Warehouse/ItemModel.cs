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
        public Guid WarehouseId { get; set; }
        public virtual WarehouseModel Warehouse { get; set; }
        public Guid RoomId { get; set; }
        public virtual RoomModel Room { get; set; }
        public Guid ColumnId { get; set; }
        public virtual ColumnModel Column { get; set; }
        public Guid RackId { get; set; }
        public virtual RackModel Rack { get; set; }
        public Guid ShelfId { get; set; }
        public virtual ShelfModel Shelf { get; set; }
        public Guid PlaceId { get; set; }
        public virtual PlaceModel Place { get; set; }


    }
}
