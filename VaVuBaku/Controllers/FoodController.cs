using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using VaVuBaku.Data;

namespace VaVuBaku.Controllers
{
    [Route("api/v1/food")]
    [ApiController]
    public class FoodController : ControllerBase
    {
        private readonly VaVuDb _context;

        public FoodController(VaVuDb context)
        {
            _context = context;
        }
        [HttpGet]
        [Route("")]
        public IActionResult FoodList()
        {
            var foods = from p in _context.Foods.ToList()
                        join pc in _context.FoodCategory on p.FoodCategoryId equals pc.Id                      
                        select new
                        {
                            Id = p.Id,
                            Name = p.Name,
                            Price = p.Price,
                            Photo = p.Name,
                            Description = p.Description,
                            FoodCategoryId =p.FoodCategoryId,
                            FoodCategory = new
                            {
                                Id = p.FoodCategory.Id,
                                Name= p.FoodCategory.Name,
                                Order = p.FoodCategory.Order

                            }
                           
                        };
            return Ok(foods);
        }


      
       

    }
}
