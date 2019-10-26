using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;



namespace WebApi.Models
{
    public class Item
    {
        

        public int Id { get; set; }
        public string ItemName { get; set; }
        public int Quantity { get; set; }
        public string Warehouse { get; set; }
        public string Room { get; set; }
        public string Column { get; set; }
        public string Rack { get; set; }
        public string Side { get; set; }
        public string Shelf { get; set; }
        public string Place { get; set; }
    }
}
