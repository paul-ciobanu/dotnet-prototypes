using MediatR;
using Microsoft.Extensions.DependencyInjection;

namespace DotNetPrototypes.Core;

public static class ServiceConfiguration
{
    public static void ConfigureCoreServices(this IServiceCollection services)
    {
        services.AddMediatR(typeof(ServiceConfiguration));
    }
}
