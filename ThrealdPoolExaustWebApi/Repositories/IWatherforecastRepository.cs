namespace ThrealdPoolExaustWebApi.Repositories
{
    public interface IWatherforecastRepository
    {
        public Task<IEnumerable<WeatherForecast>> GetAsync();
    }
}
