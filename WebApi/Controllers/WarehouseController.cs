using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using WebApi.Models;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WarehouseController : Controller
    {

        //private UserManager<WarehouseController> _userManager;
        //private SignInManager<WarehouseController> _singInManager;
        //private readonly ApplicationSettings _appSettings;

        //public WarehouseController(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager, IOptions<ApplicationSettings> appSettings)
        //{
        //    _userManager = userManager;
        //    _singInManager = signInManager;
        //    _appSettings = appSettings.Value;
        //}

        private readonly WarehouseContext _context;
        public WarehouseController(WarehouseContext context)
        {
            _context = context;
        }

        // private WarehouseContext db = new WarehouseContext();



        [HttpGet]
        [Route("List")]
        //GET : /api/Warehouse/Item
        public ActionResult<IEnumerable<string>> Get()
        {
            //string connectionString = configuration.GetConnectionString("IdentityConnection");
            //SqlConnection connection = new SqlConnection(connectionString);
            //var item = new Item();

            //connection.Open();
            //SqlCommand com = new SqlCommand("Select * from Items", connection);

            //connection.Close();
            //return Ok(com);
            var result = (from a in _context.Item
                          select new
                          {
                              a.Id,
                              a.ItemName,
                              a.Quantity,
                              a.WarehouseId,
                              a.Warehouse,
                              a.RoomId,
                              a.Room,
                              a.ColumnId,
                              a.Column,
                              a.RackId,
                              a.Rack,
                              a.ShelfId,
                              a.Shelf,
                              a.PlaceId,
                              a.Place
                              
                          }).ToList();

            //var result = _context.Place.Include(b => b.Items).Select(b => new
            //{
            //    Id = b.Id,
            //    Name = b.Name,
            //    Shelf = b.Shelf,
            //    Rack = b.Rack,
            //    Room = b.Room,
            //    Warehouse = b.Warehouse,
            //    Item = b.Items.Select(a => new
            //    {
            //        Id = a.Id,
            //        ItemName = a.ItemName,
            //        Quantity = a.Quantity,


            //    })
            //}).ToList();


            return Ok(result);





        }

        [HttpPut("{id}")]
        //PUT : /api/Warehouse/putitem/id
        [Route("PutItem/{id}")]
        public async Task<IActionResult> PutItem(Guid id,[FromBody]ItemModel model)
        {

            var item = new ItemModel()
            {
                Id= id,
                ItemName = model.ItemName,
                Quantity = model.Quantity,
                WarehouseId = model.WarehouseId,
                Warehouse= model.Warehouse,
                RoomId= model.RoomId,
                Room=model.Room,
                ColumnId=model.ColumnId,
                Column=model.Column,
                RackId=model.RackId,
                Rack=model.Rack,
                ShelfId=model.ShelfId,
                Shelf=model.Shelf,
                PlaceId=model.PlaceId,
                Place=model.Place


                
               

            };
            //item = await _context.Items.FindAsync(id);
           

            try
            {
                _context.Entry(item).State = EntityState.Modified;
                await _context.SaveChangesAsync();
                return Ok(item);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpDelete("{id}")]
        //DELETE : /api/Warehouse/item/id
        [Route("DelItem/{id}")]
        public async Task<IActionResult> Delete( int id)
        {

            var item = await _context.Item.FindAsync(id);
            if (item == null)
            {
                return NotFound();
            }

            try
            {
                _context.Item.Remove(item);
                await _context.SaveChangesAsync();
                return Ok();
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        [HttpPost]
        [Route("Item")]
        //POST : /api/Warehouse/newItem
        public async Task<Object> PostWarehauseItem (ItemModel model)
        {

            var item = new ItemModel()
            {
                Id = Guid.NewGuid(),
                ItemName = model.ItemName,
                Quantity = model.Quantity,
                WarehouseId = model.WarehouseId,
               // Warehouse = model.Warehouse,
                RoomId = model.RoomId,
              //  Room = model.Room,
                ColumnId = model.ColumnId,
             //   Column = model.Column,
                RackId = model.RackId,
               // Rack = model.Rack,
                ShelfId = model.ShelfId,
               // Shelf = model.Shelf,
                PlaceId = model.PlaceId,
             //   Place = model.Place


            };

            try
            {
                var result = await _context.Item.AddAsync(item);
                await _context.SaveChangesAsync();
                return Ok(item);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        [HttpGet]
        [Route("Warehouse")]
        //GET : /api/Warehouse/warehouse
        public ActionResult<IEnumerable<string>> GetWarehouse()
        {
         
            var result = (from a in _context.Warehouse
                          select new
                          {
                              a.Id,
                              a.Name,
                             
                          }).ToList();

            return Ok(result);
                                             
        }

        [HttpGet("{warehouseId}")]
        [Route("Room/{warehouseId}")]
        //GET : /api/Warehouse/room/{id}
        public ActionResult<IEnumerable<string>> GetRoom(Guid warehouseId)
        {

            var result = (from a in _context.Room.Where(x=>x.WarehouseId==warehouseId)
                          select new
                          {
                              a.Id,
                              a.Name,
                              

                          }).ToList();

            return Ok(result);

        }

        [HttpGet("{roomId}")]
        [Route("Column/{roomId}")]
        //GET : /api/Warehouse/column/{id}
        public ActionResult<IEnumerable<string>> GetColumn(Guid roomId)
        {

            var result = (from a in _context.Columns.Where(x => x.RoomId == roomId)
                          select new
                          {
                              a.Id,
                              a.Name,


                          }).ToList();

            return Ok(result);

        }
        [HttpGet("{columnId}")]
        [Route("Rack/{columnId}")]
        //GET : /api/Warehouse/rack/{id}
        public ActionResult<IEnumerable<string>> GetRack(Guid columnId)
        {

            var result = (from a in _context.Rack.Where(x => x.ColumnsId == columnId)
                          select new
                          {
                              a.Id,
                              a.Name,
                              a.Side


                          }).ToList();

            return Ok(result);

        }
        [HttpGet("{rackId}")]
        [Route("Shelf/{rackId}")]
        //GET : /api/Warehouse/shelf/{id}
        public ActionResult<IEnumerable<string>> GetShelf(Guid rackId)
        {

            var result = (from a in _context.Shelf.Where(x => x.RackId == rackId)
                          select new
                          {
                              a.Id,
                              a.Name,


                          }).ToList();

            return Ok(result);

        }
        [HttpGet("{shelfId}")]
        [Route("Place/{shelfId}")]
        //GET : /api/Warehouse/place/{id}
        public ActionResult<IEnumerable<string>> GetPlace(Guid shelfId)
        {

            var result = (from a in _context.Place.Where(x => x.ShelfId == shelfId)
                          select new
                          {
                              a.Id,
                              a.Name,


                          }).ToList();

            return Ok(result);

        }
    }
}