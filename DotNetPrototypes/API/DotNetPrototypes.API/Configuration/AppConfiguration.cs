using DotNetPrototypes.API.Middleware;

namespace DotNetPrototypes.API.Configuration;

internal static class AppConfiguration
{
    public static void Configure(this WebApplication app)
    {
        // Configure the HTTP request pipeline.
        if (app.Environment.IsDevelopment())
        {
            app.UseSwagger();
            app.UseSwaggerUI();
        }

        app.UseMiddleware<ExceptionHandlingMiddleware>();

        app.UseHttpsRedirection();

        app.UseAuthorization();

        app.MapControllers();
    }
}
