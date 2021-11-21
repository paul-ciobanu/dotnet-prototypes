using DotNetPrototypes.Core.Interfaces.Repositories;
using DotNetPrototypes.Infrastructure.Interfaces.Persistence.Services;
using DotNetPrototypes.Infrastructure.Persistence.Repositories;
using DotNetPrototypes.Infrastructure.Persistence.Services;
using Microsoft.Extensions.DependencyInjection;

namespace DotNetPrototypes.Infrastructure;

public static class ServiceConfiguration
{
    public static void ConfigureInfrastructureServices(this IServiceCollection services)
    {
        services.AddSingleton<IMongoClientProvider, MongoClientProvider>();
        services.AddScoped<IStudentRepository, StudentRepository>();
    }
}
