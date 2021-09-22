using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using VavuBakuMVCcore.Models;

namespace VavuBakuMVCcore.Controllers
{
    public class BlogController : Controller
    {
        private readonly ILogger<BlogController> _logger;

        public BlogController(ILogger<BlogController> logger)
        {
            _logger = logger;
        }

     
        public async Task <IActionResult> Index()
        {
           List<Blog> blogs =new List<Blog>() ;
            using (var httpclient = new HttpClient())
            {
                using var request = await httpclient.GetAsync("http://localhost:62914/api/v1/blog/bloglist");
                string response = await request.Content.ReadAsStringAsync();

                blogs = JsonConvert.DeserializeObject<List<Blog>>(response);
            }
            return View(blogs);
        }
        

        public async Task<IActionResult> Details(int id)
        {
            Blog blog = new Blog();
            using (var httpclient = new HttpClient())
            {
                using var request = await httpclient.GetAsync($"http://localhost:62914/api/v1/blog/"+id);
                string response = await request.Content.ReadAsStringAsync();

                blog = JsonConvert.DeserializeObject<Blog>(response);
            }
            return View(blog);
        }

       
    }
}
