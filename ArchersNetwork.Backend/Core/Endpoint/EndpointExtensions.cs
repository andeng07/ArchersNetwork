using System.Reflection;
using Microsoft.Extensions.DependencyInjection.Extensions;

namespace ArchersNetwork.Backend.Core.Endpoint;

/// <summary>
/// Provides extension methods for automatically discovering, registering, 
/// and mapping endpoints that implement <see cref="IEndpoint"/>.
/// </summary>
public static class EndpointExtensions
{
    /// <summary>
    /// Scans the current executing assembly for all implementations of <see cref="IEndpoint"/>,
    /// registers them with the dependency injection container, and makes them available
    /// for mapping later via <see cref="MapEndpoints"/>.
    /// </summary>
    /// <param name="services">The DI service collection.</param>
    /// <returns>The updated <see cref="IServiceCollection"/> with discovered endpoints registered.</returns>
    public static IServiceCollection AddEndpoints(this IServiceCollection services) =>
        services.AddEndpoints(Assembly.GetExecutingAssembly());

    /// <summary>
    /// Scans the specified assembly for all non-abstract, non-interface classes that implement <see cref="IEndpoint"/>,
    /// registers them as <see cref="ServiceLifetime.Transient"/> in the dependency injection container, 
    /// and makes them available for mapping later via <see cref="MapEndpoints"/>.
    /// </summary>
    /// <param name="services">The DI service collection.</param>
    /// <param name="assembly">The assembly to scan for <see cref="IEndpoint"/> implementations.</param>
    /// <returns>The updated <see cref="IServiceCollection"/> with discovered endpoints registered.</returns>
    public static IServiceCollection AddEndpoints(this IServiceCollection services, Assembly assembly)
    {
        var serviceDescriptors = assembly.DefinedTypes
            .Where(type =>
                type is { IsAbstract: false, IsInterface: false } && typeof(IEndpoint).IsAssignableFrom(type))
            .Select(type => ServiceDescriptor.Transient(typeof(IEndpoint), type))
            .ToArray();

        services.TryAddEnumerable(serviceDescriptors);
        
        return services;
    }

    /// <summary>
    /// Maps all registered <see cref="IEndpoint"/> implementations into the application's request pipeline.
    /// Each endpoint defines its own routes using <see cref="IEndpoint.MapEndpoint"/>.
    /// </summary>
    /// <param name="app">The <see cref="WebApplication"/> used to configure the HTTP pipeline.</param>
    /// <param name="routeGroupBuilder">
    /// An optional <see cref="RouteGroupBuilder"/> for grouping routes (e.g., by prefix or shared metadata).
    /// If null, endpoints are mapped directly to the <see cref="WebApplication"/>.
    /// </param>
    /// <returns>The <see cref="IApplicationBuilder"/> for further pipeline configuration.</returns>
    public static IApplicationBuilder MapEndpoints(this WebApplication app, RouteGroupBuilder? routeGroupBuilder = null)
    {
        var endpoints = app.Services.GetRequiredService<IEnumerable<IEndpoint>>();

        IEndpointRouteBuilder builder = routeGroupBuilder == null ? app : routeGroupBuilder;
        
        foreach (var endpoint in endpoints)
        {
            endpoint.MapEndpoint(builder);
        }
        
        return app;
    }
}
