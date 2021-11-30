using MediatR;

namespace DotNetPrototypes.Core.UseCases.Coolers.AddCooler;

public class AddCoolerCommand : IRequest<AddCoolerResponse>
{
    public AddCoolerRequest Data { get; init; }
}
