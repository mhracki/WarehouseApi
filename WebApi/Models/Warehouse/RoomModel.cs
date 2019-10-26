﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebApi.Models
{
    public class RoomModel
    {
        [Key]
        public Guid Id { get; set; }
        public string Name { get; set; }
        public virtual WarehouseModel Warehouse { get; set; }
        public virtual ICollection<ColumnModel> Columns { get; set; }
    }
}