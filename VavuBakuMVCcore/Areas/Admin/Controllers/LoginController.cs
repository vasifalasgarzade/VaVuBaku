using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Helpers;
using Microsoft.AspNetCore.Mvc;
using VavuBakuMVCcore.Models;

namespace VavuBakuMVCcore.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class LoginController : Controller
    {
        private readonly VavuDbContext _context;

        public LoginController(VavuDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(User user)
        {

            User loginUser = _context.Users.Where(x => x.Username == user.Username).FirstOrDefault();

            if (loginUser != null && Crypto.VerifyHashedPassword(loginUser.Password, user.Password))
            {
                return RedirectToAction("Index", "Home");
            }
            else
            {
                ModelState.AddModelError("Password", "Username və ya Şifrə düzgün deyil!");
                return View(user);
            }

        }
    }
}
