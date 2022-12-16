using Microsoft.AspNetCore.Mvc;

namespace TempSensor.Controllers;

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

    [HttpGet]
    //public async Task<ActionResult> Get([FromBody] Dictionary<string, string> jsonObject)
        public async Task<ActionResult> Get()
    {
        //var data = jsonObject["data"];
        return Ok("data");
    }
}