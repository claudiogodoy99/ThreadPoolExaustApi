

using ThrealdPoolExaustWebApi.Repositories;

namespace ThrealdPoolExaustWebApi.Services
{
    public class WatherforecastService : IWatherforecastService
    {
        private readonly IWatherforecastRepository repository;
        public WatherforecastService(IWatherforecastRepository repository)
        {
            this.repository = repository;
        }

        public async Task<IEnumerable<WeatherForecast>> GetAsync()
        {

            var array = await repository.GetAsync();
            return array.Where(x => x.TemperatureC > 0);
        }
    }
}
