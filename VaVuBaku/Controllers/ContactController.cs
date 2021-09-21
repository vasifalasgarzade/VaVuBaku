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
    [Route("api/v1/contact")]
    [ApiController]
    public class ContactController : ControllerBase
    {
        private readonly VaVuDb _context;

        public ContactController(VaVuDb context)
        {
            _context = context;
        }
        [HttpGet]
        [Route("")]
        public IActionResult MsgList()
        {
            var msg = _context.ContactMessages.ToList();
            return Ok(msg);
        }

        [HttpPost]
        [Route("message")]
        public IActionResult SendMessage([FromBody] ContactMessage message)
        {
            var send = _context.ContactMessages.Add(message);
            _context.SaveChanges();
            return Ok("Message gonderildi tessekurler");
        }

    }
}
