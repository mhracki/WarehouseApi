using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebApi.Models
{
    public class ColumnModel
    {
        [Key]
        public Guid Id { get; set; }
        public string Name { get; set; }
        public virtual RoomModel Room { get; set; }
        public virtual ICollection<RackModel> Rack { get; set; }
        public virtual ICollection<ItemModel> Item { get; set; }

    }
}
