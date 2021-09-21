using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using VaVuBaku.Data;

namespace VaVuBaku.Controllers
{
    [Route("api/v1/socialmedia")]
    [ApiController]
    public class SocialMediaController : ControllerBase
    {
        private readonly VaVuDb _context;

        public SocialMediaController(VaVuDb context)
        {
            _context = context;
        }
        [HttpGet]
        [Route("")]
        public IActionResult ServicesList()
        {
            var socialMedias = from p in _context.SocialMedias.ToList()
                               select new
                               {
                                   Id = p.Id,
                                   Name = p.Name,
                                   Icon = p.Icon,
                                   Link = p.Link

                               };
            return Ok(socialMedias);
        }
    }
}
