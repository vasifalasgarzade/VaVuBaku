using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VavuBakuMVCcore.Models;

namespace VavuBakuMVCcore.ViewModels
{
    public class MenuViewModel
    {
        public List<FoodCategory> FoodCategories { get; set; }
        public List<Food> Foods { get; set; }
    }
}
