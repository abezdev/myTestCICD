using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace myTestCICD.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TestController : Controller
    {
        //public IActionResult Index()
        //{
        //    return View();
        //}

        private static readonly string[] Summaries = new[]
                {
            "aaaaa", "bbbbbbb", "cccccccc", "ddddddddd", "111111", "222222222", "333333333", "444444444", "5555555", "66666666"
        };

        private readonly ILogger<WeatherForecastController> _logger;

        public TestController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<WeatherForecast> Get()
        {
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)]
            })
            .ToArray();
        }
    }
}