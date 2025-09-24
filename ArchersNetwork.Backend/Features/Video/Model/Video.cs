namespace ArchersNetwork.Backend.Features.Video.Model;

/// <summary>
/// Represents a video stored in the database.
///
/// Requirements: Title, Date, Description, Link, Channel, Series
/// </summary>
public class Video
{
    public int Id { get; set; }
    public string Title { get; set; }
    public DateTime Date { get; set; }
    public string Description { get; set; }
    public string Link { get; set; }
    public string Channel { get; set; }
    public string Series { get; set; }
}