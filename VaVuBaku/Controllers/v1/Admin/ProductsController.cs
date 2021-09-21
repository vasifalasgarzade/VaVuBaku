using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VaVuBaku.Data;
using VaVuBaku.Dto.Product;
using VaVuBaku.Filter;
using VaVuBaku.Models;
using VaVuBaku.Repositories.Abstracts;
using Mapster;
using VaVuBaku.Repositories.Abstracts.Product;

namespace VaVuBaku.Controllers.v1.Admin
{
   // [ExceptionFilter]
    [Route("api/v1/admin/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly AdminContext _db;
        private readonly ITransactions<Product> _products;
        private readonly IProduct<Product> _productExtension;
        public ProductsController(AdminContext db, ITransactions<Product> products, IProduct<Product> productExtension)
        {
            _db = db;
            _products = products;
            _productExtension = productExtension;
        }
        
        [HttpPost("[action]")]
        public IActionResult AddProduct([FromBody] ProductDto request)
        {
            var result = _products.Add(request.Adapt<Product>());
            return StatusCode(result.Code, result);
        }
        [HttpPost("[action]/{Id}")]
        public IActionResult AddQuantity(int Id, [FromBody] ProductDto request)
        {
            var result = _productExtension.AddQuantity(request.Adapt<Product>(), Id);
            return StatusCode(result.Code, result.Message);

        }
        [HttpPost("[action]")]
        public IActionResult CreateFood([FromBody] Meal request)
        {
            try
            {
                int count = request.MealDetails.Count;
                if (count <= 0)
                {
                    return BadRequest("Product elave etmelsiniz");
                }
                Meal meal = new Meal { Name = request.Name, Price = request.Price};
                foreach (var item in request.MealDetails.ToList())
                {
                    _db.MealDetails.Add(new MealDetail {Meal= meal, ProductId = item.ProductId, Quantity = item.Quantity, Weight = item.Weight });
                }
                _db.SaveChanges();

                return Ok("Uğurlu Əməliyyat");
            }
            catch (Exception)
            {

                throw;
            }

        }


    }
}
