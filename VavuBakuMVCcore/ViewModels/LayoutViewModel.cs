using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VavuBakuMVCcore.Models;

namespace VavuBakuMVCcore.ViewModels
{
    public class LayoutViewModel
    {
        public Setting Setting { get; set; }
        public List<SocialMedia> SocialMedias { get; set; }
        public List<Food> Foods { get; set; }
    }
}
