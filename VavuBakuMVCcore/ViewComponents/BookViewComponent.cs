using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using VavuBakuMVCcore.Models;
using VavuBakuMVCcore.ViewModels;

namespace VavuBakuMVCcore.ViewComponents
{
    public class BookViewComponent:ViewComponent
    {
       
       
        public async Task<IViewComponentResult> InvokeAsync()
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

    }
}
