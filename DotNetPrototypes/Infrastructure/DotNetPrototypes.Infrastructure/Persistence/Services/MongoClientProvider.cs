using DotNetPrototypes.Infrastructure.Interfaces.Persistence.Services;
using Microsoft.Extensions.Configuration;
using MongoDB.Driver;

namespace DotNetPrototypes.Infrastructure.Persistence.Services;

internal class MongoClientProvider : IMongoClientProvider
{
    public MongoClientProvider(IConfiguration configuration)
    {
        Client = new MongoClient("");
    }

    public IMongoClient Client { get; init; }
}
