using Microsoft.AspNetCore.Mvc;

namespace digital_signature_api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DigitalSignatureController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching", "cristian", "juan"
    };

        private readonly ILogger<DigitalSignatureController> _logger;

        public DigitalSignatureController(ILogger<DigitalSignatureController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<WeatherForecast> Get()
        {
            return Enumerable.Range(1, 13).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
        }
    }
}