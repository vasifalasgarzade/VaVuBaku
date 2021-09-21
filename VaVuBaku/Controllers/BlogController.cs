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
    [Route("api/v1/blog")]
    [ApiController]
    public class BlogController : ControllerBase
    {
        private readonly VaVuDb _context;

        public BlogController(VaVuDb context)
        {
            _context = context;
        }
        [HttpGet]
        [Route("bloglist")]
        public IActionResult BlogList()
        {
            var data = _context.Blogs.OrderByDescending(o=>o.Id).ToList();
            if (data == null)
            {
                return BadRequest();
            }
            return Ok(data);
        }
        [HttpGet]
        [Route("{id}")]
        public IActionResult BlogDetails(int id)
        {
            var data = _context.Blogs.Find(id);
                if (data!=null)
                   {
                return Ok(data);
            }
           return NotFound();
        }
        //api/v1/blog/create
      
         [HttpPost]
         [Route("create")]
        public IActionResult Create([FromBody]Blog blog)
        {
            var data = _context.Blogs.Any(o => o.Tittle == blog.Tittle);
            if (data)
            {
                return Conflict();
            }
            _context.Blogs.Add(blog);
            _context.SaveChanges();
            return Ok("Success");
        }

        [Route("edit/{id}")]
        public IActionResult EditById(int id)
        {
            var aboutbyid = _context.Abouts.Find(id);
            return Ok(aboutbyid);
        }
        [HttpPut]
        [Route("edit")]
        public IActionResult UpdateBlog(Blog blog)
        {
            var blogs = _context.Blogs.Find(blog.Id);
            if (blogs == null) return BadRequest();
            blogs.Description = blog.Description;
            blogs.Tittle = blog.Tittle;
            blogs.Photo = blog.Photo;
            _context.SaveChanges();
            return NoContent();
        }

        [HttpDelete]
        [Route("delete/{id}")]
        public IActionResult DeleteBlog(int id)
        {
            var data = _context.Blogs.Find(id);
            if (data == null)
            {
                return NotFound();
            }
            _context.Blogs.Remove(data);
            _context.SaveChanges();
            return Ok("mellumat silindi");
        }
    }
}
