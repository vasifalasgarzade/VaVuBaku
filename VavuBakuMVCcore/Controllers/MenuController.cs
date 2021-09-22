using System;
using System.Collections.Generic;
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
    public class MenuController : Controller
    {
      

        public async Task<IActionResult> GetMenu()
        {
            MenuViewModel model = new MenuViewModel();

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
            return View(model);

            //model.FoodCategories = _context.FoodCategories
            //                            .OrderBy(x => x.Order)
            //                                            .Include("Foods").ToList();
            //model.Foods = _context.Foods.ToList();

            //return View(model);
        }
    }
}
