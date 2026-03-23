using Microsoft.AspNetCore.Mvc;
using Payments.Application.Services;
using Payments.Domain.Models;

namespace Payments.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class WeatherForecastController : ControllerBase
{
    private readonly IWeatherForecastService _weatherForecastService;

    public WeatherForecastController(IWeatherForecastService weatherForecastService)
    {
        _weatherForecastService = weatherForecastService;
    }

    [HttpGet(Name = "GetWeatherForecast")]
    public ActionResult<IEnumerable<WeatherForecast>> Get()
    {
        return Ok(_weatherForecastService.GetForecasts());
    }
}
