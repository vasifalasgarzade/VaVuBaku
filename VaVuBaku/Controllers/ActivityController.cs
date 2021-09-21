using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using VaVuBaku.Data;

namespace VaVuBaku.Controllers
{
    [Route("api/v1/activity")]
    [ApiController]
    public class ActivityController : ControllerBase
    {
        private readonly VaVuDb _context;

        public ActivityController(VaVuDb context)
        {
            _context = context;
        }

        [HttpGet]
        [Route("")]
        public IActionResult ActivityList()
        {
            var activities = _context.Activities.ToList();
            return Ok(activities);

        }
    }
}
