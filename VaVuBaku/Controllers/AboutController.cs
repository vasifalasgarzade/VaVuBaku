using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using VaVuBaku.Data;
using VaVuBaku.Models;

namespace VaVuBaku.Controllers
{

    [Route("api/v1/about")]
    [ApiController]
    public class AboutController : ControllerBase
    {
        private readonly VaVuDb _context;
  
        public AboutController(VaVuDb context)
        {
            _context = context;
        }


        public IActionResult AboutBy()
        {
            var data = _context.Abouts.OrderByDescending(o => o.Id).FirstOrDefault();
            if (data == null)
            {
                return BadRequest();
            }
            return Ok(data);
        }

        [Route("aboutlist")]
        public IActionResult About()
        {
            var data = _context.Abouts.OrderByDescending(o=>o.Id).ToList();
            if (data ==null)
            {
                return BadRequest();
            }
            return Ok(data);
        }
       

  // abouts post method
        [HttpPost]
        [Route("create")]
        public IActionResult Create([FromBody] About about)
        {
            var data = _context.Abouts.Any(a => a.Title == about.Title);
            if (data)
            {
                return Conflict();
            }
            _context.Abouts.Add(about);
            _context.SaveChanges();
            return Ok("Succes");
        }

//aboust put method

        [HttpPut]
        [Route("edit")]
        public IActionResult UpdateCategory(About about)
        {

            var about1 = _context.Abouts.Find(about.Id);
            if (about1 == null) return BadRequest();
            about1.Description = about.Description;
            about1.Title = about.Title;
            about1.Photo = about.Photo;
            
            _context.SaveChanges();
            return NoContent();

        }
        [HttpGet]
        [Route("{id}")]
        public IActionResult AboutById(int id)
        {
            var aboutbyid = _context.Abouts.Find(id);
            return Ok(aboutbyid);
            
        }

     //   about delete
     [HttpDelete]
     [Route("delete/{id}")]
        public IActionResult DeleteAbout(int id)
        {
            var data = _context.Abouts.Find(id);
            if (data==null)
            {
                return NotFound();
            }
            _context.Abouts.Remove(data);
            _context.SaveChanges();
            return Ok("mellumat silindi");
        }

       
    }
}
