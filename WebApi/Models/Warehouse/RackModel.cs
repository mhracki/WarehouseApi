using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebApi.Models
{
    public class RackModel
    {
        [Key]
        public Guid Id { get; set; }
        public string Name { get; set; }
        public bool Side { get; set; }
        public Guid ColumnsId { get; set; }
       
    }
}
