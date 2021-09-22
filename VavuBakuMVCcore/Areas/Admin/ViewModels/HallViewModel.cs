using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VavuBakuMVCcore.Models;

namespace VavuBakuMVCcore.Areas.Admin.ViewModels
{
    public class HallViewModel
    {
        public List<Hall> Halls { get; set; }
        public List<Room> Rooms { get; set; }
        public List<FoodCategory> FoodCategories { get; set; }
    }
}
