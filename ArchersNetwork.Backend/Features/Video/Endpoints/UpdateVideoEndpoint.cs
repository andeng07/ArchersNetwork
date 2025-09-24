using ArchersNetwork.Backend.Core.Endpoint;
using ArchersNetwork.Backend.Features.Video.Dto;
using Microsoft.AspNetCore.Mvc;

namespace ArchersNetwork.Backend.Features.Video.Endpoints;

public class UpdateVideoEndpoint : IEndpoint
{
    public void MapEndpoint(IEndpointRouteBuilder builder)
    {
        builder.MapPut("/{id:guid}",
            async (VideoService service, Guid id, [FromBody] VideoUpdateDto request) =>
            {
                var result = await service.UpdateVideo(id, request);
                
                if (result == null) return Results.NotFound();
                
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