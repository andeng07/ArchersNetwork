namespace ArchersNetwork.Backend.Features.Video.Dto;

/// <summary>
/// DTO for creating a new video.
/// </summary>
public record VideoCreateDto(
    string Title,
    DateTime Date,
    string Description,
    string Link,
    string Channel,
    string Series
);