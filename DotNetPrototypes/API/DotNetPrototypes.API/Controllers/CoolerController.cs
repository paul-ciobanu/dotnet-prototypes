using DotNetPrototypes.Core.UseCases.Coolers.AddCooler;
using DotNetPrototypes.Core.UseCases.Coolers.GetAllCoolers;
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

    [HttpGet]
    [Route("GetAll")]
    public async Task<GetAllCoolersResponse> GetAll()
    {
        var command = new GetAllCoolersQuery();
        return await _mediator.Send(command);
    }
}
