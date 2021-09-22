using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using VavuBakuMVCcore.Models;

namespace VavuBakuMVCcore.ViewComponents
{
    public class ChefViewComponent:ViewComponent
    {
        

        public async Task<IViewComponentResult> InvokeAsync()
        {
            List<Chef> chefs = new List<Chef>();
            using (var httpclient = new HttpClient())
            {
                using var request = await httpclient.GetAsync("http://localhost:62914/api/v1/chef");
                string response = await request.Content.ReadAsStringAsync();

                chefs = JsonConvert.DeserializeObject<List<Chef>>(response);
            }
            return View(chefs);
        }
    }
}
