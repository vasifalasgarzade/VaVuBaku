using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using VavuBakuMVCcore.Models;

namespace VavuBakuMVCcore.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ReservationController : Controller
    {
        public async Task<IActionResult> Index()
        {
            List<Book> book1 = new List<Book>();
            using (var httpclient = new HttpClient())
            {
                using var request = await httpclient.GetAsync("http://localhost:62914/api/v1/reservation/rezervlist");
                string response = await request.Content.ReadAsStringAsync();

                book1 = JsonConvert.DeserializeObject<List<Book>>(response);
            }
            return View(book1);
        }
    }
}
