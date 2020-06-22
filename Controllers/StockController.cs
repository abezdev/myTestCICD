using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace myTestCICD.Controllers
{
    [ApiController]
    //[Route("[controller]")]  //change to api?? 
    [Route("api/[controller]/[action]")]
    public class StockController : ControllerBase
    {
        //public StockController( )
        //{
             
        //}

        private static readonly string[] Summaries = new[]
        {
            "asdasdasdasd", "bbbbbbb", "cccccccc", "ddddddddd", "111111", "222222222", "333333333", "444444444", "5555555", "66666666"
        };
        //HttpGet
        [HttpPost]//HttpPost
        public string SendAPICalls()//[FromBody] string values) //from body
        {
            //var rng = new Random();
            //return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            //{
            //    Date = DateTime.Now.AddDays(index),
            //    TemperatureC = rng.Next(-20, 55),
            //    Summary = Summaries[rng.Next(Summaries.Length)]
            //})
            //.ToArray();


            return "hit this";
         }







    }
}
