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
        public string xSendAPICalls( [FromBody] List<int> values) //from body
        {
            //var rng = new Random();
            //return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            //{
            //    Date = DateTime.Now.AddDays(index),
            //    TemperatureC = rng.Next(-20, 55),
            //    Summary = Summaries[rng.Next(Summaries.Length)]
            //})
            //.ToArray();
            foreach (int item in values)
            {
                Console.WriteLine(item);
            }


            return "hit this" + values;
         }


        [HttpPost]//HttpPost
        public string SendAPICalls([FromForm] string values) //from body
        {
            //var rng = new Random();
            //return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            //{
            //    Date = DateTime.Now.AddDays(index),
            //    TemperatureC = rng.Next(-20, 55),
            //    Summary = Summaries[rng.Next(Summaries.Length)]
            //})
            //.ToArray();


            return "hit this"+ values;
        }

        [HttpGet]//HttpPost
        public string GETSendAPICalls( ) //from body
        {
            //var rng = new Random();
            //return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            //{
            //    Date = DateTime.Now.AddDays(index),
            //    TemperatureC = rng.Next(-20, 55),
            //    Summary = Summaries[rng.Next(Summaries.Length)]
            //})
            //.ToArray();


            return "hit HttpGetHttpGetHttpGet";
        }




    }
}
