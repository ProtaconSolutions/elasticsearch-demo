using System;
using Data;
using Microsoft.AspNetCore.Mvc;
using Nest;
using Newtonsoft.Json.Linq;

namespace Controllers
{
    public class DemoController : Controller
    {
        [HttpGet("v1/alarm")]
        public Alarm[] Alarm()
        {
            return new[]
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
            return 
                DeviceData.Create(body)
                    .FlatMap<string>(
                        data => ElasticSearch.Create().Index(data, "deviceX"))
                    .Match<IActionResult>(
                        some: _ => Ok(),
                        none: e => BadRequest(e)
                    );
        }
    }
}