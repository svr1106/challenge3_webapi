using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class McqController : ControllerBase
    {
      

        private readonly ILogger<McqController> _logger;

        public McqController(ILogger<McqController> logger)
        {
            _logger = logger;
        }

        [HttpGet("getmcq")]
        public IActionResult getdata()
        {
            HttpClient http = new HttpClient();
            var result = http.GetAsync("https://opentdb.com/api.php?amount=5&category=11&difficulty=medium&type=multiple").Result.Content.ReadAsStringAsync().Result;

            return Ok(result);
        }
    }
}
