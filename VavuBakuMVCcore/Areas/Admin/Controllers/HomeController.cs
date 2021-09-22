using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using VavuBakuMVCcore.Models;

namespace VavuBakuMVCcore.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class HomeController : Controller
    {
        private readonly VavuDbContext _context;

        public HomeController(VavuDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

     

    }
}
