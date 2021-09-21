using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using VaVuBaku.Data;
using VaVuBaku.Models;

namespace VaVuBaku.Controllers
{
    [Route("api/v1/service")]
    [ApiController]
    public class ServiceController : ControllerBase
    {
        private readonly VaVuDb _context;

        public ServiceController(VaVuDb context)
        {
            _context = context;
        }
        [HttpGet("[action]")]
        public IActionResult ServicesList()
        {
            var services = _context.Services.ToList();
            return Ok(services);
        }

    }
}
