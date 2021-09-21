using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using VaVuBaku.Data;

namespace VaVuBaku.Controllers
{
    [Route("api/v1/chef")]
    [ApiController]
    public class ChefController : ControllerBase
    {
        private readonly VaVuDb _context;

        public ChefController
            (VaVuDb context)
        {
            _context = context;
        }
        [HttpGet]
        [Route("")]
        public IActionResult ChefList()
        {
            var chef = _context.Chefs.ToList();
            return Ok(chef);

        }
    }
}
