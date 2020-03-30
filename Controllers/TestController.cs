using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestBlazor.Controllers {
    [Route("api/[controller]")]
    public class TestController : ControllerBase {
        [HttpGet("GetTest")]
        public IActionResult GetTest() {
            return Ok("OK");
        }
    }
}
