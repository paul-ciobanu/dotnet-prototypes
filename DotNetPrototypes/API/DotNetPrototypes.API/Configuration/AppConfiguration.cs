using DotNetPrototypes.API.Middleware;
using DotNetPrototypes.Infrastructure;
using Microsoft.AspNetCore.Mvc.ApiExplorer;

namespace DotNetPrototypes.API.Configuration;

internal static class AppConfiguration
{
    public static void Configure(this WebApplication app)
    {
        app.Services.MigrateDatabases();

        // Configure the HTTP request pipeline.
        if (app.Environment.IsDevelopment())
        {
            var provider = app.Services.GetService<IApiVersionDescriptionProvider>();

            app.UseSwagger();
            app.UseSwaggerUI(
                options =>
                {
                    foreach (var description in provider.ApiVersionDescriptions)
                    {
                        options.SwaggerEndpoint(
                            $"/swagger/{description.GroupName}/swagger.json",
                            description.GroupName.ToUpperInvariant());
                    }
                });
        }

        app.UseMiddleware<ExceptionHandlingMiddleware>();

        app.UseHttpsRedirection();

        app.UseAuthorization();

        app.MapControllers();
    }
}
