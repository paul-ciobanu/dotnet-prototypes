using DotNetPrototypes.Core.UseCases.Students.AddStudent;
using DotNetPrototypes.Core.UseCases.Students.DeleteStudent;
using DotNetPrototypes.Core.UseCases.Students.GetAllStudents;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace DotNetPrototypes.API.Controllers;

[ApiController]
[Route("[controller]")]
public class StudentController : ControllerBase
{
    private readonly IMediator _mediator;

    public StudentController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpPost]
    public async Task<AddStudentResponse> Add([FromBody] AddStudentRequest data)
    {
        var command = new AddStudentCommand { Data = data };
        return await _mediator.Send(command);
    }

    [HttpDelete]
    public async Task<DeleteStudentResponse> Delete([FromBody] DeleteStudentRequest data)
    {
        var command = new DeleteStudentCommand { Data = data };
        return await _mediator.Send(command);
    }

    [HttpGet]
    [Route("GetAll")]
    public async Task<GetAllStudentsResponse> GetAll()
    {
        var command = new GetAllStudentsQuery();
        return await _mediator.Send(command);
    }
}
