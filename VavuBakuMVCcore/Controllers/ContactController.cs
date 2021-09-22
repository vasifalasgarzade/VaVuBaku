using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using VavuBakuMVCcore.Models;

namespace VavuBakuMVCcore.Controllers
{
    public class ContactController : Controller
    {
        private readonly VavuDbContext _context;
   
        public ContactController(VavuDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            Setting setting = new Setting();
            using (var httpclient = new HttpClient())
            {
                using var request = await httpclient.GetAsync("http://localhost:62914/api/v1/setting");
                string response = await request.Content.ReadAsStringAsync();

                setting = JsonConvert.DeserializeObject<Setting>(response);
            }
           
            return View(setting);
        }

        //BAZAYA KLIENT MESAJ ELAVE ETMESI UCHUN
        [HttpPost]
        public async Task<IActionResult> SendMessage (ContactMessage msg)
        {


            using (var httpClient = new HttpClient())
            {
                var content = new StringContent(JsonConvert.SerializeObject(msg), Encoding.UTF8, "application/json");

                using var reguest = await httpClient.PostAsync($"http://localhost:62914/api/v1/contact/message", content);
                string response = await reguest.Content.ReadAsStringAsync();

            }

            return RedirectToAction("index");

            //if(!_context.ContactMessages.Any(x=>            x.Email == msg.Email && 
            //                                                x.Subject == msg.Subject &&
            //                                                x.Message == msg.Message &&
            //                                                x.Phone   == msg.Phone)  && ModelState.IsValid)
            //{
            //    msg.Date = DateTime.Now;
            //    _context.ContactMessages.Add(msg);
            //    _context.SaveChanges();
            //}

        }
    }
}
