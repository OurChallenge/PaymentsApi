using Payments.Domain.Models;

namespace Payments.Application.Services;

public interface IWeatherForecastService
{
    IReadOnlyList<WeatherForecast> GetForecasts();
}
