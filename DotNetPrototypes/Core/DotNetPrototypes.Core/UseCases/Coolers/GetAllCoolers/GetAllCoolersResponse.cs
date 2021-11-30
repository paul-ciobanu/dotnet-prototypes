namespace DotNetPrototypes.Core.UseCases.Coolers.GetAllCoolers;

public record struct GetAllCoolersResponse(List<CoolerDto> Coolers);

public record struct CoolerDto(Guid Id, string Name, int Rpm);
