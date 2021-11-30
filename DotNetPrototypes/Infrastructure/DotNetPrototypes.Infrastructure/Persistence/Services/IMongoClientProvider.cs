using MongoDB.Driver;

namespace DotNetPrototypes.Infrastructure.Persistence.Services;

public interface IMongoClientProvider
{
    IMongoClient Client { get; }
}
