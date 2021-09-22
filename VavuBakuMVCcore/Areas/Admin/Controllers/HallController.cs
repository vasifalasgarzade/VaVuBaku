using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using VavuBakuMVCcore.Areas.Admin.ViewModels;
using VavuBakuMVCcore.Models;

namespace VavuBakuMVCcore.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class HallController : Controller
    {
        private readonly VavuDbContext _context;

        public HallController(VavuDbContext context) { _context = context; }

        public IActionResult Index() => View();

        public IActionResult Halls() => View(_context.Halls.ToList());

        public IActionResult Rooms() => View(_context.Rooms.ToList());

        public IActionResult Orders() => View(_context.FoodCategories.Include("Foods").ToList());



    }
}
