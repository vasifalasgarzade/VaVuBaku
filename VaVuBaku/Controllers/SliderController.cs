using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using VaVuBaku.Data;

namespace VaVuBaku.Controllers
{
    [Route("api/v1/slider")]
    [ApiController]
    public class SliderController : ControllerBase
    {
        private readonly VaVuDb _context;

        public SliderController(VaVuDb context)
        {
            _context = context;
        }

        // Slider model 
        [HttpGet]
        [Route("")]
        public IActionResult SLiderList()
        {
            var slider = _context.Sliders.ToList();
            return Ok(slider);
        }

        

      

    }
}
