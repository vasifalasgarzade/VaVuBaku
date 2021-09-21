using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using VaVuBaku.Data;

namespace VaVuBaku.Controllers
{
    [Route("api/v1/foodcategory")]
    [ApiController]
    public class FoodCategoryController : ControllerBase
    {
        private readonly VaVuDb _context;

        public FoodCategoryController(VaVuDb context)
        {
            _context = context;
        }

        [HttpGet]
        [Route("")]
        public IActionResult FoodCategoryGet()
        {
            var foodcategory = from p in _context.FoodCategory.ToList()
                               select new
                               {
                                   Id = p.Id,
                                   Name = p.Name,
                                   Order = p.Order

                               };
            return Ok(foodcategory);
        }
    }
}
