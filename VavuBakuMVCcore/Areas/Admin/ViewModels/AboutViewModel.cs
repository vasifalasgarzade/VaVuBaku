using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VavuBakuMVCcore.Models;

namespace VavuBakuMVCcore.Areas.Admin.ViewModels
{
    public class AboutViewModel
    {
        public List<About> Abouts { get; set; }
        public About About { get; set; }
    }
}
