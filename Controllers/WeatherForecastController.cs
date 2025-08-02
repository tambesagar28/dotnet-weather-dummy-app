using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("[controller]")]
public class WeatherForecastController : ControllerBase
{
    [HttpGet]
    public IActionResult Get()
    {
        var result = new[]
        {
            new { Date = DateTime.Now, TemperatureC = 25, Summary = "Hot" },
            new { Date = DateTime.Now.AddDays(1), TemperatureC = 22, Summary = "Warm" },
            new { Date = DateTime.Now.AddDays(2), TemperatureC = 19, Summary = "Mild" },
        };

        return Ok(result);
    }
}
