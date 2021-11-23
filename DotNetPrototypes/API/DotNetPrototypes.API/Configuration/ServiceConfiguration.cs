using DotNetPrototypes.API.Middleware;
using DotNetPrototypes.Core;
using DotNetPrototypes.Infrastructure;
using FluentValidation.AspNetCore;

namespace DotNetPrototypes.API.Configuration;

internal static class ServiceConfiguration
{
    public static void Configure(this IServiceCollection services)
    {
        services.AddControllers();
        // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
        services.AddEndpointsApiExplorer();
        services.AddSwaggerGen();

        services.ConfigureCoreServices();
        services.ConfigureInfrastructureServices();

        services.AddTransient<ExceptionHandlingMiddleware>();
        services.AddMvc().AddFluentValidation();
    }
}
