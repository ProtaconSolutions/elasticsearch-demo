using System;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;

namespace Controllers
{
    public class DemoController : Controller
    {
        [HttpGet("v1/alarm")]
        public Alarm[] Alarm() 
        {
            return new [] 
            {
                new Alarm()
                {
                    Id = Guid.NewGuid(),
                    Type = "DEVICE_VALUE_OVER_LIMIT",
                    Data = new {}
                }
            };
        }

        [HttpPost("v1/data")]
        public IActionResult Add([FromBody] JObject body)
        {
            dynamic json = body;
            
            Console.WriteLine(body);

            if(json.DeviceId == null || json.DeviceName == null) {
                return BadRequest();
            } 

            return Ok();
        }
    }
}
