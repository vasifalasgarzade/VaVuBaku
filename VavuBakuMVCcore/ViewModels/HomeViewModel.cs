using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VavuBakuMVCcore.Models;

namespace VavuBakuMVCcore.ViewModels
{
    public class HomeViewModel
    {
        public List<Service> Services { get; set; }
        public List<Slider> Sliders { get; set; }
        public List<FoodCategory> FoodCategories { get; set; }
        public List<Food> Foods { get; set; }
        public List<Campaign> Campaigns { get; set; }
        public List<Chef> Chefs { get; set; }
        public List<Activity> Activ { get; set; }
    }
}
