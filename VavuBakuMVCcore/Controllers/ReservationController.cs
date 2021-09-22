using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using VavuBakuMVCcore.Models;

namespace VavuBakuMVCcore.Controllers
{
    public class ReservationController : Controller
    {
        public IActionResult Index()
        {
            return  View();
        }
        //BAZAYA REZERVASIYA ELAVE ETMEK UCHUN     
        [HttpPost]
        public async Task<IActionResult> SendRezerv([FromForm]Book book)
        {            
            using (var httpClient = new HttpClient())
            {              
                var content = new StringContent(JsonConvert.SerializeObject(book), Encoding.UTF8, "application/json");
                using var reguest = await httpClient.PostAsync($"http://localhost:62914/api/v1/reservation/sendrezerv", content);
                string response = await reguest.Content.ReadAsStringAsync();               
            }
            return RedirectToAction("index");
        }
    }
}
