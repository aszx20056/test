using System.Collections.Generic;
using corevue.Models;

namespace corevue.Providers
{
    public interface IWeatherProvider
    {
        List<WeatherForecast> GetForecasts();
    }
}
