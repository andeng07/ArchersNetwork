namespace ArchersNetwork.Backend.Features.Video.Dto;

/// <summary>
/// DTO for updating an existing video.
/// </summary>
public record VideoUpdateDto(
    string Title,
    DateTime Date,
    string Description,
    string Link,
    string Channel,
    string Series
);