using System;
using Data;
using Microsoft.AspNetCore.Mvc;
using Nest;
using Newtonsoft.Json.Linq;

namespace Controllers
{

    public class Person
    {
        public string Id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
    }

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
            dynamic json = DeviceData.Crea;


            ElasticSearch.Create().Index(body, "deviceX");

            return Ok();
        }
    }
}