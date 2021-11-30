using DotNetPrototypes.Core.Interfaces.Requests;

namespace DotNetPrototypes.Core.UseCases.Coolers.AddCooler;

public class AddCoolerCommand : ICommand<AddCoolerRequest, AddCoolerResponse>
{
    public AddCoolerRequest Data { get; init; }
}
