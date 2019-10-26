using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebApi.Models
{
    public class ShelfModel
    {
        [Key]
        public Guid Id { get; set; }
        public string Name { get; set; }
        public virtual RackModel Rack{ get; set; }
        public virtual ICollection<PlaceModel> Place { get; set; }
    }
}
