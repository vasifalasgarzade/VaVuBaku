using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using VavuBakuMVCcore.Models;

namespace VavuBakuMVCcore.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class MenuController : Controller
    {
        private readonly VavuDbContext _context;
        private List<FoodCategory> _categories;

        public MenuController(VavuDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Index()
        {
            _categories = _context.FoodCategories.OrderBy(x => x.Order).ToList();
            return View(_categories);
        }

        [HttpPost]
        public IActionResult Order(List<byte> orders)
        {

            for (int i = 0; i < orders.Count; i++)
            {
                _context.FoodCategories.Where(x => x.Order == orders[i]).FirstOrDefault().Order = (byte)(i + 1);
            }

            _context.SaveChanges();

            _categories = _context.FoodCategories.ToList();

            return RedirectToAction("Index","Menu",_categories);
        }
    }
}
