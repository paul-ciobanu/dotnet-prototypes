using DotNetPrototypes.Core.UseCases.Cooler.AddCooler;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace DotNetPrototypes.API.Controllers;

[ApiController]
[Route("[controller]")]
public class CoolerController : ControllerBase
{
    private readonly IMediator _mediator;

    public CoolerController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpPost]
    public async Task<AddCoolerResponse> Add([FromBody] AddCoolerRequest data)
    {
        var command = new AddCoolerCommand { Data = data };
        return await _mediator.Send(command);
    }
}
