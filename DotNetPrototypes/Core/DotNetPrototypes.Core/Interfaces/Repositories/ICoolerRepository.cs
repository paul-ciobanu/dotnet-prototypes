using DotNetPrototypes.Core.Entities;

namespace DotNetPrototypes.Core.Interfaces.Repositories;

public interface ICoolerRepository
{
    Task<Guid> Add(Cooler student);
    Task<Cooler[]> GetAll();
}
