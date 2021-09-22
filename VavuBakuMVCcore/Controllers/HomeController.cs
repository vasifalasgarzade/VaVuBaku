using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using VavuBakuMVCcore.Models;
using VavuBakuMVCcore.ViewModels;

namespace VavuBakuMVCcore.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly VavuDbContext _context;
        

        public HomeController(ILogger<HomeController> logger, VavuDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            HomeViewModel model = new HomeViewModel();
            

            List<Slider> slider = new List<Slider>();
            using (var httpclient = new HttpClient())
            {
                using var request = await httpclient.GetAsync("http://localhost:62914/api/v1/slider");
                string response = await request.Content.ReadAsStringAsync();

                slider = JsonConvert.DeserializeObject<List<Slider>>(response);
            }
            model.Sliders = slider;

            List<Service> service = new List<Service>();
            using (var httpclient = new HttpClient())
            {
                using var request = await httpclient.GetAsync("http://localhost:62914/api/v1/service");
                string response = await request.Content.ReadAsStringAsync();

                service = JsonConvert.DeserializeObject<List<Service>>(response);
            }
            model.Services = service;


            List<Food> foods = new List<Food>();
            using (var httpclient = new HttpClient())
            {
                using var request = await httpclient.GetAsync("http://localhost:62914/api/v1/food");
                string response = await request.Content.ReadAsStringAsync();

                foods = JsonConvert.DeserializeObject<List<Food>>(response);
            }
            model.Foods = foods;

            List<FoodCategory> foodCategories = new List<FoodCategory>();
            using (var httpclient = new HttpClient())
            {
                using var request = await httpclient.GetAsync("http://localhost:62914/api/v1/foodcategory");
                string response = await request.Content.ReadAsStringAsync();

                foodCategories = JsonConvert.DeserializeObject<List<FoodCategory>>(response);
            }
            model.FoodCategories = foodCategories;

            List<Campaign> campaigns = new List<Campaign>();
            using (var httpclient = new HttpClient())
            {
                using var request = await httpclient.GetAsync("http://localhost:62914/api/v1/campaign");
                string response = await request.Content.ReadAsStringAsync();

                campaigns = JsonConvert.DeserializeObject<List<Campaign>>(response);
            }
            model.Campaigns = campaigns;

            List<Chef> chefs = new List<Chef>();
            using (var httpclient = new HttpClient())
            {
                using var request = await httpclient.GetAsync("http://localhost:62914/api/v1/chef");
                string response = await request.Content.ReadAsStringAsync();

                chefs = JsonConvert.DeserializeObject<List<Chef>>(response);
            }
            model.Chefs = chefs;


            List<Models.Activity> activity = new List<Models.Activity>();
            using (var httpclient = new HttpClient())
            {
                using var request = await httpclient.GetAsync("http://localhost:62914/api/v1/activity");
                string response = await request.Content.ReadAsStringAsync();

                activity = JsonConvert.DeserializeObject<List<Models.Activity>>(response);
            }
            model.Activ = activity;



            return View(model);

            //model.Services = _context.Services.ToList();
            //model.Sliders = _context.Sliders.ToList();
            //model.FoodCategories = _context.FoodCategories
            //                                        .OrderBy(x => x.Order)
            //                                                        .Include("Foods").ToList();
            //model.Foods = _context.Foods.ToList();
            //model.Campaigns = _context.Campaigns.ToList();
            //model.Activities = _context.Activities.ToList();        
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = System.Diagnostics.Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
