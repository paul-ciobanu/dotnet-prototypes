using DotNetPrototypes.Core.Entities;
using DotNetPrototypes.Core.Interfaces.Repositories;

namespace DotNetPrototypes.Infrastructure.Persistence.Repositories;

internal class CoolerRepository : ICoolerRepository
{
    public CoolerRepository()
    {
    }

    public Task<Guid> Add(Cooler student)
    {
        throw new NotImplementedException();
    }
}
