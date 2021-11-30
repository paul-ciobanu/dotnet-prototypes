namespace DotNetPrototypes.Core.UseCases.Coolers.AddCooler;

public record struct AddCoolerResponse(Guid Id, string Name, int Rpm);
