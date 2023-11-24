using Microsoft.AspNetCore.Mvc;

namespace SAFX.CodeFactor.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class SampleController(ILogger<SampleController> logger) : ControllerBase
{

    [HttpGet]
    public IActionResult Get()
    {
        var guid = Guid.NewGuid();
        logger.LogInformation($"SampleController.Get() called and {guid} generated");

        return Ok(guid);
    }

    [HttpDelete]
    public IActionResult Delete(bool first, bool second)
    {
        if (second)
        {
            return BadRequest();
        }
        else if (first)
        {
            return BadRequest();
        }
        else
        {
            return BadRequest();
        }

        logger.LogInformation("SampleController.Delete() called");

        return Ok();
    }
}
