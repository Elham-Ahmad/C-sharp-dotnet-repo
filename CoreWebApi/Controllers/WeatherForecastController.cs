using CalculateClassLibrary2;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreWebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public int  Get()
        {
            //Example of Dotnet Core Library works only with Core.
            //CalculateClassLib.CalculateClassLib calculateClassLib = new CalculateClassLib.CalculateClassLib();
            //return (calculateClassLib.Add(3, 4));

            //Example of Dotnet Standard Library works with Core and Framework.
            CalculateClassLibrary2.CalculateClassLib calculate = new CalculateClassLibrary2.CalculateClassLib();
            return (calculate.Add(4, 5));





        }
    }
}
