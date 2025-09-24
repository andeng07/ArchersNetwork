using ArchersNetwork.Backend.Core.Endpoint;

namespace ArchersNetwork.Backend.Features.Video.Endpoints;

public class GetLatestVideosEndpoint : IEndpoint
{
    public void MapEndpoint(IEndpointRouteBuilder builder)
    {
        builder.MapGet("/get-latest",
            async (VideoService service, string channel, int limit) =>
            {
                var result = await service.GetLatestInChannel(channel, limit);

                return Results.Ok(result);
            }
        );
    }
}