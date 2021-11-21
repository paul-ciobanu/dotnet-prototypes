using DotNetPrototypes.Core.UseCases.AddStudent;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace DotNetPrototypes.API.Controllers;

[ApiController]
[Route("[controller]")]
public class StudentController : ControllerBase
{
    private readonly ILogger<StudentController> _logger;
    private readonly IMediator _mediator;

    public StudentController(ILogger<StudentController> logger, IMediator mediator)
    {
        _logger = logger;
        _mediator = mediator;
    }

    [HttpPost]
    public async Task Add()
    {
        var command = new AddStudentCommand
        {
            Name = "test"
        };
        await _mediator.Send(command);
    }
}
