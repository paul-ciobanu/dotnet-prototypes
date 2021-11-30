using Microsoft.Extensions.Configuration;
using MongoDB.Driver;

namespace DotNetPrototypes.Infrastructure.Persistence.Services;

internal class MongoClientProvider : IMongoClientProvider
{
    public MongoClientProvider(IConfiguration configuration)
    {
        var conn = configuration.GetConnectionString("MongoDB");
        Client = new MongoClient(conn);
    }

    public IMongoClient Client { get; init; }
}
