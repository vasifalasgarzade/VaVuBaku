using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using VaVuBaku.Data;

namespace VaVuBaku.Controllers
{
    [Route("api/v1/setting")]
    [ApiController]
    public class SettingController : ControllerBase
    {
        private readonly VaVuDb _context;

        public SettingController(VaVuDb context)
        {
            _context = context;
        }
        [HttpGet]
        [Route("")]
        public IActionResult Setting()
        {
            var data = _context.Settings.FirstOrDefault();
            if (data == null)
            {
                return BadRequest();
            }
            return Ok(data);
        }
    }
}
