using Microsoft.AspNetCore.Mvc;
using ThrealdPoolExaustWebApi.Services;

namespace ThrealdPoolExaustWebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly IWatherforecastService _watherforecastService;

        public WeatherForecastController( IWatherforecastService watherforecastService)
        { 
            _watherforecastService = watherforecastService;
        }

        [HttpGet]
        public async Task<IEnumerable<WeatherForecast>> Get()
        {
            return await _watherforecastService.GetAsync();
        }
    }
}