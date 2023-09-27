using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Globalization;

namespace digital_signature_api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CallBackController : ControllerBase
    {
        private readonly ILogger<CallBackController> _logger;

        public CallBackController(ILogger<CallBackController> logger)
        {
            _logger = logger;
        }

        //[HttpGet("Call/{base64}")]
        [HttpPost("Call")]
        public DS CallBack(DS base64)
        {
            _logger.LogInformation(base64.ToString());
            return base64;
        }
        [HttpGet]
        public string Get()
        {
            return "hi";
        }
    }
}