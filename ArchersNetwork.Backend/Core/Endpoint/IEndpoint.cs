namespace ArchersNetwork.Backend.Core.Endpoint;

/// <summary>
/// Defines a contract for minimal API endpoints that can be mapped into the request pipeline.
/// </summary>
public interface IEndpoint
{
    void MapEndpoint(IEndpointRouteBuilder builder);
}