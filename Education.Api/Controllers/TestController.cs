using Microsoft.AspNetCore.Mvc;

namespace Education.Api.Controllers;

[Route("api/tests")]
public class TestController : ControllerBase
{
    [HttpGet]
    public IActionResult Get()
    {
        return Ok("Test endpoint is working.");
    }
    
    [HttpGet("error")]
    public IActionResult GetWithError()
    {
        return BadRequest("This is a test error response.");
    }
}