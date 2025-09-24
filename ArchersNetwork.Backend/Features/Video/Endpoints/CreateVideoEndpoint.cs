using ArchersNetwork.Backend.Core.Endpoint;
using ArchersNetwork.Backend.Features.Video.Dto;
using Microsoft.AspNetCore.Mvc;

namespace ArchersNetwork.Backend.Features.Video.Endpoints;

public class CreateVideoEndpoint : IEndpoint
{
    public void MapEndpoint(IEndpointRouteBuilder builder)
    {
        builder.MapPost("/",
            async (VideoService service, [FromBody] VideoCreateDto request) =>
            {
                var result = await service.CreateVideo(request);

                var response = new VideoResponseDto(
                    result.Id,
                    result.Title,
                    result.Date,
                    result.Description,
                    result.Link,
                    result.Channel,
                    result.Series
                );
                
                return TypedResults.Created($"/videos/{result.Id}", response);
            }
        );
    }
}