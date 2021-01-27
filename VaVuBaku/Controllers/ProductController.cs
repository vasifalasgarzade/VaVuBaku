using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using VaVuBaku.Data;
using VaVuBaku.Models;

namespace VaVuBaku.Controllers
{
    [Route("api/v1/product")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly VaVuDb _context;
        public ProductController(VaVuDb context)
        {
            _context = context;
        }
        [HttpGet]
        [Route("productlist")]
      public ActionResult Productlist()
        {
            var product = _context.Products.ToList();
            return Ok(product);
        }
        [HttpGet]
        [Route("productlist/{id}")]
        public object ProductId(int id)
        {
            var productid = _context.Products.Find(id);
            if (productid == null)
            {
                return NotFound("bele bir id movcud deil");
            }
            else
            {
                return productid;
            }
            

        }



        [HttpPost]
        [Route("productcreate")]
        public ActionResult ProductCreate([FromBody] Product product)
        {
            var data = _context.Products.FirstOrDefault(p=>p.Name ==product.Name);
            if (data != null )
            {
                return Conflict();


            }
            else
            {
                _context.Products.Add(product);
                _context.SaveChanges(); 
                return Ok("succes");
            }
         
           
            

        }


        [HttpPut]
        [Route("productedit/{id}")]
        
        public ActionResult ProductEdit(int id, Product product)
        {
            var data = _context.Products.Find(id);
            data.Name = product.Name;
            data.Price = product.Price;
            _context.SaveChanges();
            return Ok("deyisiklik ugurla bawa catdi");

        }

        [HttpDelete]
        [Route("productdelete/{id}")]
        public ActionResult ProductDelete(int id)
        {
            var data = _context.Products.Find(id);
            _context.Products.Remove(data);
            _context.SaveChanges();
            return Ok("Product ugurla silindi");
        }
    }
}
