using DotNetPrototypes.Core.Entities;
using DotNetPrototypes.Core.UseCases.AddStudent;
using DotNetPrototypes.Core.UseCases.GetAllStudents;
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
    public async Task<Guid> Add()
    {
        var command = new AddStudentCommand
        {
            Name = "test"
        };
        return await _mediator.Send(command);
    }

    [HttpGet(Name = "GetAll")]
    public async Task<List<Student>> GetAll()
    {
        var command = new GetAllStudentsCommand();
        return await _mediator.Send(command);
    }
}
