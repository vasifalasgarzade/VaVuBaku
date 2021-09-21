using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using VaVuBaku.Data;

namespace VaVuBaku.Controllers
{
    [Route("api/v1/campaign")]
    [ApiController]
    public class CampaignController : ControllerBase
    {
        private readonly VaVuDb _context;

        public CampaignController(VaVuDb context)
        {
            _context = context;
        }

        [HttpGet]
        [Route("")]
        public IActionResult CampaignList()
        {
            var campaign = _context.Campaigns.ToList();
            return Ok(campaign);

        }
    }
}
