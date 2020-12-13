using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;

namespace K8STest.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TestController : ControllerBase
    {
        private readonly ILogger<TestController> _logger;

        public TestController(ILogger<TestController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public Task<IActionResult> Get()
        {
            _logger.LogInformation("Successfully received request!");
            return Task.FromResult((IActionResult)Ok("Test success!"));
        }
    }
}
