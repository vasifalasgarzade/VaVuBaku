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
    public class HeaderViewComponent : ViewComponent
    {
        

        public async Task<IViewComponentResult> InvokeAsync()
        {

            LayoutViewModel model = new LayoutViewModel();
            List<Food> foods = new List<Food>();
            using (var httpclient = new HttpClient())
            {
                using var request = await httpclient.GetAsync("http://localhost:62914/api/v1/food");
              foods = await request.Content.ReadAsAsync<List<Food>>();

               
            }
            model.Foods = foods;


            List<SocialMedia> socialMedias = new List<SocialMedia>();
            using (var httpclient = new HttpClient())
            {
                using var request = await httpclient.GetAsync("http://localhost:62914/api/v1/socialmedia");
                socialMedias = await request.Content.ReadAsAsync<List<SocialMedia>>();

               
            }
            model.SocialMedias = socialMedias;


            Setting setting = new Setting();
            using (var httpclient = new HttpClient())
            {
                using var request = await httpclient.GetAsync("http://localhost:62914/api/v1/setting");
                setting = await request.Content.ReadAsAsync<Setting>();

                
            }
            model.Setting = setting;




            return View(model);
        }
    }
}
