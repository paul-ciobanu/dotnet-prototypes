using DotNetPrototypes.Core.UseCases.GetEvent.V2;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace DotNetPrototypes.API.Controllers.Versioning.V2;

[ApiVersion("2.0")]
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
