using DotNetPrototypes.API.Configuration.Swagger;
using DotNetPrototypes.API.Middleware;
using DotNetPrototypes.Core;
using DotNetPrototypes.Infrastructure;
using FluentValidation.AspNetCore;
using Microsoft.Extensions.Options;
using Swashbuckle.AspNetCore.SwaggerGen;

namespace DotNetPrototypes.API.Configuration;

internal static class ServiceConfiguration
{
    public static void Configure(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddControllers();

        services.AddApiVersioning(options =>
        {
            options.AssumeDefaultVersionWhenUnspecified = true;
        });

        // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
        services.AddEndpointsApiExplorer();
        services.AddVersionedApiExplorer(options => options.GroupNameFormat = "'v'VVV");
        services.AddTransient<IConfigureOptions<SwaggerGenOptions>, ConfigureSwaggerOptions>();
        services.AddSwaggerGen(options =>
        {
            options.OperationFilter<SwaggerDefaultValues>();
        });

        services.ConfigureCoreServices();
        services.ConfigureInfrastructureServices(configuration);

        services.AddTransient<ExceptionHandlingMiddleware>();
        services.AddMvc().AddFluentValidation();
    }
}
