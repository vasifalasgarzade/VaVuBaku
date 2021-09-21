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
    [Route("api/v1/reservation")]
    [ApiController]
    public class ReservationController : ControllerBase
    {
        private readonly VaVuDb _context;

        public ReservationController(VaVuDb context)
        {
            _context = context;
        }
        [HttpGet]
        [Route("rezervlist")]
        public IActionResult Getlist()
        {
         var data =    _context.Books.ToList();
            return Ok(data);
        }

        [HttpPost]
        [Route("sendrezerv")]
        public IActionResult CreateRezerv([FromBody] Book book)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest("Invalid Data");
            }
            book.Date = DateTime.Now;
            var data = _context.Books.Add(book);
            _context.SaveChanges();
            return Ok("Emeliyyat Ugurla bawa catdi");
        }
    }
}
