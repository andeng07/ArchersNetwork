using ArchersNetwork.Backend.Core.Endpoint;

namespace ArchersNetwork.Backend.Features.Video.Endpoints;

public class SelectAllVideosEndpoint : IEndpoint
{
    public void MapEndpoint(IEndpointRouteBuilder builder)
    {
        builder.MapGet("/select-all",
            async (VideoService service, string series) =>
            {
                var result = await service.SelectBySeries(series);
                
                return Results.Ok(result);
            }
        );
    }
}