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
        [Route("item/get")]
        //GET : /api/Warehouse/item/get
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
        //PUT : /api/Warehouse/item/put/id
        [Route("item/put/{id}")]
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
        //DELETE : /api/Warehouse/item/delete/id
        [Route("item/delete/{id}")]
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
        [Route("item/post")]
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
        [Route("warehouse/get")]
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
        [Route("warehouse/post")]
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
        [Route("room/get/{warehouseId}")]
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

        [HttpPost]
        [Route("room/post")]
        //POST : /api/Warehouse/room/post
        public async Task<Object> PostRoom(RoomModel model)
        {

            var room = new RoomModel()
            {
                Id = Guid.NewGuid(),
                Name = model.Name,
                WarehouseId = model.WarehouseId

            };

            try
            {
                var result = await _context.Room.AddAsync(room);
                await _context.SaveChangesAsync();
                return Ok(room);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        [HttpPut("{id}")]
        //PUT : /api/Warehouse/room/put/id
        [Route("room/put/{id}")]
        public async Task<IActionResult> PutRoom(Guid id, [FromBody]RoomModel model)
        {

            var room = new RoomModel()
            {
                Id = id,
                Name = model.Name,
                WarehouseId = model.WarehouseId,

            };

            try
            {
                _context.Entry(room).State = EntityState.Modified;
                await _context.SaveChangesAsync();
                return Ok(room);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        [HttpDelete("{id}")]
        //DELETE : /api/Warehouse/room/delete/id
        [Route("room/delete/{id}")]
        public async Task<IActionResult> DeleteRoom(Guid id)
        {

            var room = await _context.Room.FindAsync(id);
            if (room == null)
            {
                return NotFound();
            }

            try
            {
                _context.Room.Remove(room);
                await _context.SaveChangesAsync();
                return Ok();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        [HttpGet("{roomId}")]
        [Route("column/get/{roomId}")]
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
        [HttpPost]
        [Route("column/post")]
        //POST : /api/Warehouse/column/post
        public async Task<Object> PostColumn(ColumnModel model)
        {

            var column = new ColumnModel()
            {
                Id = Guid.NewGuid(),
                Name = model.Name,
                RoomId = model.RoomId,

            };

            try
            {
                var result = await _context.Columns.AddAsync(column);
                await _context.SaveChangesAsync();
                return Ok(column);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        [HttpPut("{id}")]
        //PUT : /api/Warehouse/column/put/id
        [Route("column/put/{id}")]
        public async Task<IActionResult> PutColumn(Guid id, [FromBody]ColumnModel model)
        {

            var column = new ColumnModel()
            {
                Id = id,
                Name = model.Name,
                RoomId = model.RoomId,

            };

            try
            {
                _context.Entry(column).State = EntityState.Modified;
                await _context.SaveChangesAsync();
                return Ok(column);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        [HttpDelete("{id}")]
        //DELETE : /api/Warehouse/column/delete/id
        [Route("column/delete/{id}")]
        public async Task<IActionResult> DeleteColumn(Guid id)
        {

            var column = await _context.Columns.FindAsync(id);
            if (column == null)
            {
                return NotFound();
            }

            try
            {
                _context.Columns.Remove(column);
                await _context.SaveChangesAsync();
                return Ok();
            }
            catch (Exception ex)
            {
                throw ex;
            }
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
        [HttpPost]
        [Route("rack/post")]
        //POST : /api/Warehouse/rack/post
        public async Task<Object> PostRack(RackModel model)
        {

            var rack = new RackModel()
            {
                Id = Guid.NewGuid(),
                Name = model.Name,
                ColumnsId = model.ColumnsId,

            };

            try
            {
                var result = await _context.Rack.AddAsync(rack);
                await _context.SaveChangesAsync();
                return Ok(rack);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        [HttpPut("{id}")]
        //PUT : /api/Warehouse/rack/put/id
        [Route("rack/put/{id}")]
        public async Task<IActionResult> PutRack(Guid id, [FromBody]RackModel model)
        {

            var rack = new RackModel()
            {
                Id = id,
                Name = model.Name,
                ColumnsId = model.ColumnsId

            };

            try
            {
                _context.Entry(rack).State = EntityState.Modified;
                await _context.SaveChangesAsync();
                return Ok(rack);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        [HttpDelete("{id}")]
        //DELETE : /api/Warehouse/rack/delete/id
        [Route("rack/delete/{id}")]
        public async Task<IActionResult> DeleteRack(Guid id)
        {

            var rack = await _context.Rack.FindAsync(id);
            if (rack == null)
            {
                return NotFound();
            }

            try
            {
                _context.Rack.Remove(rack);
                await _context.SaveChangesAsync();
                return Ok();
            }
            catch (Exception ex)
            {
                throw ex;
            }
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
        [HttpPost]
        [Route("side/post")]
        //POST : /api/Warehouse/side/post
        public async Task<Object> PostSide(SideModel model)
        {

            var side = new SideModel()
            {
                Id = Guid.NewGuid(),
                Name = model.Name,
                RackId = model.RackId

            };

            try
            {
                var result = await _context.Side.AddAsync(side);
                await _context.SaveChangesAsync();
                return Ok(side);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        [HttpPut("{id}")]
        //PUT : /api/Warehouse/side/put/id
        [Route("side/put/{id}")]
        public async Task<IActionResult> PutSide(Guid id, [FromBody]SideModel model)
        {

            var side = new SideModel()
            {
                Id = id,
                Name = model.Name,
                RackId = model.RackId,

            };

            try
            {
                _context.Entry(side).State = EntityState.Modified;
                await _context.SaveChangesAsync();
                return Ok(side);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        [HttpDelete("{id}")]
        //DELETE : /api/Warehouse/side/delete/id
        [Route("side/delete/{id}")]
        public async Task<IActionResult> DeleteSide(Guid id)
        {

            var side = await _context.Side.FindAsync(id);
            if (side == null)
            {
                return NotFound();
            }

            try
            {
                _context.Side.Remove(side);
                await _context.SaveChangesAsync();
                return Ok();
            }
            catch (Exception ex)
            {
                throw ex;
            }
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
        [HttpPost]
        [Route("shelf/post")]
        //POST : /api/Warehouse/shelf/post
        public async Task<Object> PostShelf(ShelfModel model)
        {

            var shelf = new ShelfModel()
            {
                Id = Guid.NewGuid(),
                Name = model.Name,
                SideId = model.SideId,

            };

            try
            {
                var result = await _context.Shelf.AddAsync(shelf);
                await _context.SaveChangesAsync();
                return Ok(shelf);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        [HttpPut("{id}")]
        //PUT : /api/Warehouse/shelf/put/id
        [Route("shelf/put/{id}")]
        public async Task<IActionResult> PutShelf(Guid id, [FromBody]ShelfModel model)
        {

            var shelf = new ShelfModel()
            {
                Id = id,
                Name = model.Name,
                SideId = model.SideId,

            };

            try
            {
                _context.Entry(shelf).State = EntityState.Modified;
                await _context.SaveChangesAsync();
                return Ok(shelf);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        [HttpDelete("{id}")]
        //DELETE : /api/Warehouse/shelf/delete/id
        [Route("shelf/delete/{id}")]
        public async Task<IActionResult> DeleteShelf(Guid id)
        {

            var shelf = await _context.Shelf.FindAsync(id);
            if (shelf == null)
            {
                return NotFound();
            }

            try
            {
                _context.Shelf.Remove(shelf);
                await _context.SaveChangesAsync();
                return Ok();
            }
            catch (Exception ex)
            {
                throw ex;
            }
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
        [HttpPost]
        [Route("place/post")]
        //POST : /api/Warehouse/place/post
        public async Task<Object> PostPlace(PlaceModel model)
        {

            var place = new PlaceModel()
            {
                Id = Guid.NewGuid(),
                Name = model.Name,
                ShelfId=model.ShelfId

            };

            try
            {
                var result = await _context.Place.AddAsync(place);
                await _context.SaveChangesAsync();
                return Ok(place);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        [HttpPut("{id}")]
        //PUT : /api/Warehouse/place/put/id
        [Route("place/put/{id}")]
        public async Task<IActionResult> PutPlace(Guid id, [FromBody]PlaceModel model)
        {

            var place = new PlaceModel()
            {
                Id = id,
                Name = model.Name,
                ShelfId = model.ShelfId

            };

            try
            {
                _context.Entry(place).State = EntityState.Modified;
                await _context.SaveChangesAsync();
                return Ok(place);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        [HttpDelete("{id}")]
        //DELETE : /api/Warehouse/place/delete/id
        [Route("place/delete/{id}")]
        public async Task<IActionResult> DeletePlace(Guid id)
        {

            var place = await _context.Place.FindAsync(id);
            if (place == null)
            {
                return NotFound();
            }

            try
            {
                _context.Place.Remove(place);
                await _context.SaveChangesAsync();
                return Ok();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}