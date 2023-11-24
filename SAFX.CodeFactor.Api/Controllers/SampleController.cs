using Microsoft.AspNetCore.Mvc;

namespace SAFX.CodeFactor.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class SampleController (ILogger<SampleController> logger) : ControllerBase
{

    [HttpGet]
    public IActionResult Get()
    {
        var guid = Guid.NewGuid();
        logger.LogInformation($"SampleController.Get() called and {guid} generated");

        return Ok(guid);
    }
}
