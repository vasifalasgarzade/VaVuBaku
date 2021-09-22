using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using VavuBakuMVCcore.Models;

namespace VavuBakuMVCcore.Controllers
{
    public class AboutController : Controller
    {
        public async Task<IActionResult> Index()
        {
            About abouts = new About();
            using (var httpclient = new HttpClient())
            {
                using var request = await httpclient.GetAsync("http://localhost:62914/api/v1/about");
                string response = await request.Content.ReadAsStringAsync();

                abouts = JsonConvert.DeserializeObject<About>(response);
            }
            return View(abouts);
        }

        

        
    }
}
