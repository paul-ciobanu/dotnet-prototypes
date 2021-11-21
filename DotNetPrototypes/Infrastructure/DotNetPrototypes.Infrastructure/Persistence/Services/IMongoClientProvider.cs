using MongoDB.Driver;

namespace DotNetPrototypes.Infrastructure.Interfaces.Persistence.Services;

public interface IMongoClientProvider
{
    IMongoClient Client { get; }
}
