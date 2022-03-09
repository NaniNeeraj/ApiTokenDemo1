using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Microsoft.AspNetCore.Authentication;

namespace ApiTokenDemo1.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class NameController : ControllerBase
    {
        [HttpGet("GetNames")]
        public IActionResult GetNames()
        {
            var token = HttpContext.GetTokenAsync("access.token").Result;
            return Ok(new List<string> { "Nani", "Neeraj" });
        }
    }
}
