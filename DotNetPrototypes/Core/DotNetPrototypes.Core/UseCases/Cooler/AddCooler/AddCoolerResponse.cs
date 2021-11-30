namespace DotNetPrototypes.Core.UseCases.Cooler.AddCooler;

public record struct AddCoolerResponse(Guid Id, string Name, int Rpm);
