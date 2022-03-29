namespace ThrealdPoolExaustWebApi.Services
{
    public interface IWatherforecastService
    {
        Task<IEnumerable<WeatherForecast>> GetAsync();
    }
}
