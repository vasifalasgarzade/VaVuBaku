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
    public class MessageController : Controller
    {
        private readonly VavuDbContext _context;
        List<ContactMessage> messages = new List<ContactMessage>();

        public MessageController(VavuDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            List<ContactMessage> messages = new List<ContactMessage>();
            using (var httpclient = new HttpClient())
            {
                using var request = await httpclient.GetAsync("http://localhost:62914/api/v1/contact/");
                string response = await request.Content.ReadAsStringAsync();

                messages = JsonConvert.DeserializeObject<List<ContactMessage>>(response);
            }
            return View(messages);
        }
    }
}
