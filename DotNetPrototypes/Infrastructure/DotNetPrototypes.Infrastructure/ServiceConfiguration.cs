using DotNetPrototypes.Core.Interfaces.Repositories;
using DotNetPrototypes.Infrastructure.Interfaces.Persistence.Services;
using DotNetPrototypes.Infrastructure.Persistence;
using DotNetPrototypes.Infrastructure.Persistence.Repositories;
using DotNetPrototypes.Infrastructure.Persistence.Services;
using FluentMigrator.Runner;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace DotNetPrototypes.Infrastructure;

public static class ServiceConfiguration
{
    public static void ConfigureInfrastructureServices(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddSingleton<DapperContext>();
        services.AddLogging(c => c.AddFluentMigratorConsole());

        services.AddFluentMigratorCore()
            .ConfigureRunner(c => c.AddSqlServer()
            .WithGlobalConnectionString(configuration.GetConnectionString("ComputerPartsSqlConnection"))
            .ScanIn(typeof(AppConfiguration).Assembly).For.Migrations());

        services.AddSingleton<IMongoClientProvider, MongoClientProvider>();
        services.AddScoped<IStudentRepository, StudentRepository>();

        services.AddScoped<ICoolerRepository, CoolerRepository>();
    }
}
