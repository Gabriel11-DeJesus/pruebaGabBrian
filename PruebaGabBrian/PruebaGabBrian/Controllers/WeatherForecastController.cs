using Microsoft.AspNetCore.Mvc;

namespace PruebaGabBrian.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static int _counter = 0;

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IActionResult Get()
        {
            _counter++;

            return Ok(new
            {
                contador = _counter,
                fecha = DateTime.Now
            });
        }
    }
}
