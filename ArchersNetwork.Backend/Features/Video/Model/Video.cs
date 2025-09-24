namespace ArchersNetwork.Backend.Features.Video.Model;

/// <summary>
/// Represents a video stored in the database.
///
/// Requirements: Title, Date, Description, Link, Channel, Series
/// </summary>
public class Video
{
    public required Guid Id { get; init; }
    public required string Title { get; set; }
    public required DateTime Date { get; set; }
    public required string Description { get; set; }
    public required string Link { get; set; }
    public required string Channel { get; set; }
    public required string Series { get; set; }
}