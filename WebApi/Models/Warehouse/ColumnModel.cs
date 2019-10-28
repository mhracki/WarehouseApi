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
        public Guid RoomId { get; set; }
       

    }
}
