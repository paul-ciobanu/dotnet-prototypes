using MediatR;

namespace DotNetPrototypes.Core.UseCases.Cooler.AddCooler;

public class AddCoolerCommand : IRequest<AddCoolerResponse>
{
    public AddCoolerRequest Data { get; init; }
}
