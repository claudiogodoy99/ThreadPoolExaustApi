namespace ThrealdPoolExaustWebApi.Repositories
{
    public class WatherforecastRepository : IWatherforecastRepository
    {
        private readonly ILogger<WatherforecastRepository> logger;
        public WatherforecastRepository(ILogger<WatherforecastRepository> logger)
        {
            this.logger = logger;
        }
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        public async Task<IEnumerable<WeatherForecast>> GetAsync()
        { 
            Task.Delay(150).Wait();
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
           .ToArray();
        }
    }
}
