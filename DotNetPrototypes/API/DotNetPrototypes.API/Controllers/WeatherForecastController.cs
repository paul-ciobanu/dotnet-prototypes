using Microsoft.AspNetCore.Mvc;

namespace DotNetPrototypes.API.Controllers;

[ApiController]
[Route("[controller]")]
public class StudentController : ControllerBase
{
    private readonly ILogger<StudentController> _logger;

    public StudentController(ILogger<StudentController> logger)
    {
        _logger = logger;
    }

    [HttpPost]
    public Task Add()
    {
    }
}
