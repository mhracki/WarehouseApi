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
                              a.SideId,
                              a.Side,
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
                SideId = model.SideId,
                Side = model.Side,
                Rack =model.Rack,
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
        public async Task<IActionResult> Delete(Guid id)
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
                RoomId = model.RoomId,
                ColumnId = model.ColumnId,
                RackId = model.RackId,
                SideId = model.SideId,
                ShelfId = model.ShelfId,
                PlaceId = model.PlaceId,

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
        [Route("Warehouse/get")]
        //GET : /api/Warehouse/warehouse/get
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

        [HttpPost]
        [Route("Warehouse/post")]
        //POST : /api/Warehouse/Warehouse/post
        public async Task<Object> PostWarehause(WarehouseModel model)
        {

            var warehouse = new WarehouseModel()
            {
                Id = Guid.NewGuid(),
                Name = model.Name,
               
            };

            try
            {
                var result = await _context.Warehouse.AddAsync(warehouse);
                await _context.SaveChangesAsync();
                return Ok(warehouse);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        [HttpPut("{id}")]
        //PUT : /api/Warehouse/putitem/id
        [Route("warehouse/put/{id}")]
        public async Task<IActionResult> PutWarehouse(Guid id, [FromBody]WarehouseModel model)
        {

            var warehouse = new WarehouseModel()
            {
                Id = id,
                Name = model.Name,
              
            };

            try
            {
                _context.Entry(warehouse).State = EntityState.Modified;
                await _context.SaveChangesAsync();
                return Ok(warehouse);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        [HttpDelete("{id}")]
        //DELETE : /api/Warehouse/item/id
        [Route("warehouse/delete/{id}")]
        public async Task<IActionResult> DeleteWarehouse(Guid id)
        {

            var warehouse = await _context.Warehouse.FindAsync(id);
            if (warehouse == null)
            {
                return NotFound();
            }
             
            try
            {
                _context.Warehouse.Remove(warehouse);
                await _context.SaveChangesAsync();
                return Ok();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpGet("{warehouseId}")]
        [Route("Room/get/{warehouseId}")]
        //GET : /api/Warehouse/room/get/{id}
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
        [Route("Column/get/{roomId}")]
        //GET : /api/Warehouse/column/get/{id}
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
        [Route("Rack/get/{columnId}")]
        //GET : /api/Warehouse/rack/get/{id}
        public ActionResult<IEnumerable<string>> GetRack(Guid columnId)
        {

            var result = (from a in _context.Rack.Where(x => x.ColumnsId == columnId)
                          select new
                          {
                              a.Id,
                              a.Name,
                            

                          }).ToList();

            return Ok(result);

        }
        [HttpGet("{rackId}")]
        [Route("Side/get/{rackId}")]
        //GET : /api/Warehouse/side/get/{id}
        public ActionResult<IEnumerable<string>> GetSide(Guid rackId)
        {

            var result = (from a in _context.Side.Where(x => x.RackId == rackId)
                          select new
                          {
                              a.Id,
                              a.Name,


                          }).ToList();

            return Ok(result);

        }
        [HttpGet("{sackId}")]
        [Route("Shelf/get/{sideId}")]
        //GET : /api/Warehouse/shelf/get/{id}
        public ActionResult<IEnumerable<string>> GetShelf(Guid sideId)
        {

            var result = (from a in _context.Shelf.Where(x => x.SideId == sideId)
                          select new
                          {
                              a.Id,
                              a.Name,


                          }).ToList();

            return Ok(result);

        }
        [HttpGet("{shelfId}")]
        [Route("Place/get/{shelfId}")]
        //GET : /api/Warehouse/place/get/{id}
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