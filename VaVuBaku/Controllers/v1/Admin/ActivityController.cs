using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VaVuBaku.Data;
using VaVuBaku.Models;

namespace VaVuBaku.Controllers.v1.Admin
{
    [Route("api/order")]
    [ApiController]
    public class ActivityController : ControllerBase
    {
        private readonly AdminContext _db;
        public ActivityController(AdminContext db)
        {
            _db = db;
        }
        [HttpGet("[action]/{id}/{quantity}/{roomId}")]
        public IActionResult Meal(int id, int quantity, int roomId)
        {
            Meal meal = _db.Meals.Where(a => a.Id == id).FirstOrDefault();

            Room room = _db.Rooms.Where(a => a.Id == roomId).FirstOrDefault();

            if (meal is object)
            {
                if (quantity > 0)
                {
                    for (int i = 0; i < quantity; i++)
                    {
                        List<MealDetail> ingredients = _db.MealDetails.Where(a => a.MealId == id).ToList();
                        foreach (var item in ingredients)
                        {
                            Product product = _db.Products.Where(a => a.Id == item.ProductId).FirstOrDefault();
                            if (product.Weight - item.Weight > 0 || product.Quantity - item.Quantity > 0)
                            {
                                product.Weight = product.Weight - item.Weight;
                                product.Quantity = product.Quantity - item.Quantity;
                                room.IsEmpty = 0;
                            }
                            else
                            {
                                return BadRequest("Ingredientlər kifayet deyil");
                            }
                        }
                        _db.ActivityLogs.Add(new ActivityLog { IsActive = 0, OrderTime = DateTime.Now, EndTime = DateTime.Now, CategoryId = 3, ActivityId = meal.Id, RoomId = roomId });
                    }
                }
            }
            _db.SaveChanges();
            return Ok("Uğurlu Əməliyyat");

        }
        [HttpGet("[action]/{id}/{quantity}/{roomId}")]
        public IActionResult Product(int id, int quantity, int roomId)
        {
            Product product = _db.Products.Where(a => a.Id == id && a.IsServed == 1).FirstOrDefault();

            Room room = _db.Rooms.Where(a => a.Id == roomId).FirstOrDefault();
            if (product is object)
            {
                if (quantity > 0)
                {
                    if (product.Quantity - quantity > 0)
                    {
                        product.Quantity = product.Quantity - quantity;
                        room.IsEmpty = 0;
                    }
                    else
                    {
                        return BadRequest("Ingredientlər kifayet deyil");
                    }
                    for (int i = 0; i < quantity; i++)
                    {
                        _db.ActivityLogs.Add(new ActivityLog { IsActive = 0, OrderTime = DateTime.Now, EndTime = DateTime.Now, CategoryId = 1, ActivityId = product.Id, RoomId = roomId });
                    }
                }
            }
            _db.SaveChanges();
            return Ok("Uğurlu Əməliyyat");

        }
        [HttpGet("[action]/{id}/{roomId}")]
        public IActionResult Service(int id, int roomId)
        {
            Room room = _db.Rooms.Where(a => a.Id == roomId).FirstOrDefault();
            Activities activity = _db.Activities.Where(a => a.Id == id).FirstOrDefault();
            if (room is object && activity is object)
            {
                room.IsEmpty = 0;
                _db.ActivityLogs.Add(new ActivityLog { IsActive = 0, OrderTime = DateTime.Now, EndTime = DateTime.Now, CategoryId = 2, ActivityId = activity.Id, RoomId = room.Id });
            }
            _db.SaveChanges();
            return Ok("Uğurlu Əməliyyat");

        }
        [HttpGet("[action]")]
        public IActionResult AddRoom([FromBody] Room request)
        {
            _db.Rooms.Add(request);
            _db.SaveChanges();
            return Ok("Uğurlu əməliyyat");
        }
        public IActionResult Rooms()
        {
            var data = _db.Rooms.ToList();
            return Ok(data);
        }
    }
}
