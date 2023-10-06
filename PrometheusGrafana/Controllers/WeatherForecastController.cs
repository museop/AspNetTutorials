using Microsoft.AspNetCore.Mvc;

namespace dotnet_prometheus_grafana.Controllers;

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

    [HttpGet("home")]
    public IEnumerable<WeatherForecast> Home()
    {
        return Enumerable.Range(1, 5).Select(index => new WeatherForecast
        {
            Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
            TemperatureC = Random.Shared.Next(-20, 55),
            Summary = Summaries[Random.Shared.Next(Summaries.Length)]
        })
        .ToArray();
    }

    [HttpGet("city")]
    public ActionResult<string> City()
    {
        Thread.Sleep(TimeSpan.FromSeconds(5));
        return "Melbourne";
    }

    [HttpGet("country")]
    public ActionResult<string> Country()
    {
        var rng = new Random().Next(1, 10);
        if (rng > 5)
        {
            return Unauthorized();
        }

        return "Australia";
    }
}
