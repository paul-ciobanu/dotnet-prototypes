using Dapper;
using DotNetPrototypes.Infrastructure.Persistence;
using FluentMigrator.Runner;
using Microsoft.Extensions.DependencyInjection;

namespace DotNetPrototypes.Infrastructure;

public static class AppConfiguration
{
    public static void MigrateDatabases(this IServiceProvider serviceProvider)
    {
        using var scope = serviceProvider.CreateScope();
        var context = scope.ServiceProvider.GetService<DapperContext>();
        context.CreateDatabase("ComputerParts");

        var migrationService = scope.ServiceProvider.GetRequiredService<IMigrationRunner>();
        migrationService.MigrateUp();
    }

    private static void CreateDatabase(this DapperContext context, string dbName)
    {
        var query = "SELECT * FROM sys.databases WHERE name = @name";
        var parameters = new DynamicParameters();
        parameters.Add("name", dbName);

        using var connection = context?.CreateMasterConnection();

        var records = connection.Query(query, parameters);
        if (!records.Any())
            connection.Execute($"CREATE DATABASE {dbName}");
    }
}
