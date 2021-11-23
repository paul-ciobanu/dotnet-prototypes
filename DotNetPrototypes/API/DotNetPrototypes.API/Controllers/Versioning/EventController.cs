using DotNetPrototypes.Core.UseCases.GetEvent;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace DotNetPrototypes.API.Controllers.Versioning;

[ApiVersion("1.0")]
[ApiController]
[Route("[controller]")]
public class EventController : ControllerBase
{
    private readonly IMediator _mediator;

    public EventController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpGet]
    public async Task<GetEventResponse> Get()
    {
        return await _mediator.Send(new GetEventQuery());
    }
}
