using ArchersNetwork.Backend.Core.Endpoint;
using ArchersNetwork.Backend.Features.Video.Dto;

namespace ArchersNetwork.Backend.Features.Video.Endpoints;

public class GetVideoEndpoint : IEndpoint
{
    public void MapEndpoint(IEndpointRouteBuilder builder)
    {
        builder.MapGet("/{id:guid}",
            async (VideoService service, Guid id) =>
            {
                var result = await service.FindVideo(id);
                
                if (result == null) return  Results.NotFound();
                
                var response = new VideoResponseDto(
                    result.Id,
                    result.Title,
                    result.Date,
                    result.Description,
                    result.Link,
                    result.Channel,
                    result.Series
                );

                return TypedResults.Ok(response);
            }
        );
    }
}