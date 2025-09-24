using System.Collections.Concurrent;
using ArchersNetwork.Backend.Features.Video.Dto;

namespace ArchersNetwork.Backend.Features.Video;

using Model;

public class VideoService
{
    // TODO: convert to database

    private static readonly ConcurrentDictionary<Guid, Video> _videos = new();
    
    public static void Populate()
    {
        var seedData = new List<Video>
        {
            new Video
            {
                Id = Guid.Parse("f2f1e1f4-3a7b-45dd-b317-95b3f9d6c001"),
                Title = "Exploring the Arctic - Part 1",
                Date = DateTime.Parse("2025-01-12T14:30:00"),
                Description = "An introduction to our Arctic exploration series.",
                Link = "https://example.com/videos/arctic-part1",
                Channel = "NatureWorld",
                Series = "Arctic Expedition"
            },
            new Video
            {
                Id = Guid.Parse("6b0f2e12-2e94-47c2-92a9-2a3c5b7f3f02"),
                Title = "Exploring the Arctic - Part 2",
                Date = DateTime.Parse("2025-01-15T14:30:00"),
                Description = "We continue deeper into the frozen landscapes.",
                Link = "https://example.com/videos/arctic-part2",
                Channel = "NatureWorld",
                Series = "Arctic Expedition"
            },
            new Video
            {
                Id = Guid.Parse("b5c4a0a6-1d12-493f-b9ec-dc7a2f01c003"),
                Title = "Exploring the Arctic - Part 3",
                Date = DateTime.Parse("2025-01-20T14:30:00"),
                Description = "A look at Arctic wildlife and survival.",
                Link = "https://example.com/videos/arctic-part3",
                Channel = "NatureWorld",
                Series = "Arctic Expedition"
            },
            new Video
            {
                Id = Guid.Parse("c7f8d219-4f25-40ab-b9a6-fd2e5a7c1004"),
                Title = "Basics of C# - Variables",
                Date = DateTime.Parse("2025-02-01T09:00:00"),
                Description = "Learning the fundamentals of variables in C#.",
                Link = "https://example.com/videos/csharp-variables",
                Channel = "CodeAcademy",
                Series = "C# Beginner Guide"
            },
            new Video
            {
                Id = Guid.Parse("d4c6a2ab-8725-40aa-b7b4-39d4b82df005"),
                Title = "Basics of C# - Loops",
                Date = DateTime.Parse("2025-02-03T09:00:00"),
                Description = "An overview of loops in C#.",
                Link = "https://example.com/videos/csharp-loops",
                Channel = "CodeAcademy",
                Series = "C# Beginner Guide"
            },
            new Video
            {
                Id = Guid.Parse("aa92f302-0a34-4b9c-9547-6cfbe1d7a006"),
                Title = "Basics of C# - Functions",
                Date = DateTime.Parse("2025-02-05T09:00:00"),
                Description = "How to write and use functions in C#.",
                Link = "https://example.com/videos/csharp-functions",
                Channel = "CodeAcademy",
                Series = "C# Beginner Guide"
            },
            new Video
            {
                Id = Guid.Parse("0cb0e6ab-7d83-4c9c-9304-c34b7985d007"),
                Title = "Italian Cooking - Pasta 101",
                Date = DateTime.Parse("2025-03-10T17:00:00"),
                Description = "Learn to cook authentic Italian pasta.",
                Link = "https://example.com/videos/pasta-101",
                Channel = "FoodiesHub",
                Series = "Italian Cooking"
            },
            new Video
            {
                Id = Guid.Parse("5ef7a1b2-6b8f-4b10-8c4b-62a7a672f008"),
                Title = "Italian Cooking - Sauces",
                Date = DateTime.Parse("2025-03-15T17:00:00"),
                Description = "The secrets behind rich Italian sauces.",
                Link = "https://example.com/videos/sauces",
                Channel = "FoodiesHub",
                Series = "Italian Cooking"
            },
            new Video
            {
                Id = Guid.Parse("3de4c891-48aa-40b2-8f3a-7e5c8f12f009"),
                Title = "Italian Cooking - Desserts",
                Date = DateTime.Parse("2025-03-20T17:00:00"),
                Description = "A sweet ending with Italian desserts.",
                Link = "https://example.com/videos/desserts",
                Channel = "FoodiesHub",
                Series = "Italian Cooking"
            },
            new Video
            {
                Id = Guid.Parse("72e1d3aa-7c64-456e-830b-2349d09b000a"),
                Title = "Beginner Yoga - Morning Flow",
                Date = DateTime.Parse("2025-04-01T06:00:00"),
                Description = "Start your day with a simple yoga routine.",
                Link = "https://example.com/videos/yoga-morning-flow",
                Channel = "WellnessLife",
                Series = "Beginner Yoga"
            },
            new Video
            {
                Id = Guid.Parse("46f2a4b9-1de3-478f-9173-7c1b2b8a100b"),
                Title = "Beginner Yoga - Evening Relax",
                Date = DateTime.Parse("2025-04-03T06:00:00"),
                Description = "Wind down with calming yoga stretches.",
                Link = "https://example.com/videos/yoga-evening-relax",
                Channel = "WellnessLife",
                Series = "Beginner Yoga"
            },
            new Video
            {
                Id = Guid.Parse("11d0dbe2-51a4-4d9d-95a2-d8b9c7aa200c"),
                Title = "Beginner Yoga - Balance",
                Date = DateTime.Parse("2025-04-05T06:00:00"),
                Description = "Improve stability and posture with balance exercises.",
                Link = "https://example.com/videos/yoga-balance",
                Channel = "WellnessLife",
                Series = "Beginner Yoga"
            },
            new Video
            {
                Id = Guid.Parse("8fa2c9b0-35c9-42c7-a6c0-0cf8e5f9f00d"),
                Title = "Tech Reviews - Laptop 2025",
                Date = DateTime.Parse("2025-05-01T12:00:00"),
                Description = "Hands-on review of the latest 2025 laptops.",
                Link = "https://example.com/videos/laptop-2025",
                Channel = "GadgetZone",
                Series = "Tech Reviews 2025"
            },
            new Video
            {
                Id = Guid.Parse("7b43f12a-5c1b-497d-987e-6d4f5d82f00e"),
                Title = "Tech Reviews - Smartphones 2025",
                Date = DateTime.Parse("2025-05-05T12:00:00"),
                Description = "Comparing flagship smartphones of 2025.",
                Link = "https://example.com/videos/smartphones-2025",
                Channel = "GadgetZone",
                Series = "Tech Reviews 2025"
            },
            new Video
            {
                Id = Guid.Parse("99fda12b-0b8d-4c19-86a5-b51d2873f00f"),
                Title = "Tech Reviews - Smartwatches 2025",
                Date = DateTime.Parse("2025-05-08T12:00:00"),
                Description = "Are the new smartwatches worth it?",
                Link = "https://example.com/videos/smartwatches-2025",
                Channel = "GadgetZone",
                Series = "Tech Reviews 2025"
            },
            new Video
            {
                Id = Guid.Parse("eb10f3a4-8a4b-492b-a8c0-6b7e44c5f010"),
                Title = "History Explained - Ancient Rome",
                Date = DateTime.Parse("2025-06-01T15:00:00"),
                Description = "Exploring the rise and fall of Ancient Rome.",
                Link = "https://example.com/videos/ancient-rome",
                Channel = "HistoryVault",
                Series = "History Explained"
            },
            new Video
            {
                Id = Guid.Parse("57c8f12a-d9e1-4748-bc5f-3c62ad94f011"),
                Title = "History Explained - Medieval Europe",
                Date = DateTime.Parse("2025-06-05T15:00:00"),
                Description = "The fascinating stories of Medieval Europe.",
                Link = "https://example.com/videos/medieval-europe",
                Channel = "HistoryVault",
                Series = "History Explained"
            },
            new Video
            {
                Id = Guid.Parse("12f34a56-7b8c-49a9-9e5a-d2f9c7abf012"),
                Title = "History Explained - World War II",
                Date = DateTime.Parse("2025-06-10T15:00:00"),
                Description = "A deep dive into the events of WWII.",
                Link = "https://example.com/videos/world-war-ii",
                Channel = "HistoryVault",
                Series = "History Explained"
            },
            new Video
            {
                Id = Guid.Parse("c8e6b4a1-13af-47d9-b8c1-3f87e45bc013"),
                Title = "DIY Projects - Build a Bookshelf",
                Date = DateTime.Parse("2025-07-01T10:00:00"),
                Description = "Step-by-step guide to building a wooden bookshelf.",
                Link = "https://example.com/videos/build-bookshelf",
                Channel = "CraftCorner",
                Series = "DIY Projects"
            }
        };

        foreach (var video in seedData)
        {
            _videos.TryAdd(video.Id, video);
        }
    }

    public VideoService()
    {
        Populate();
    }

    public async Task<Video> CreateVideo(VideoCreateDto videoCreateDto)
    {
        var guid = Guid.NewGuid();

        var video = new Video
        {
            Id = guid,
            Title = videoCreateDto.Title,
            Date = videoCreateDto.Date,
            Description = videoCreateDto.Description,
            Link = videoCreateDto.Link,
            Channel = videoCreateDto.Channel,
            Series = videoCreateDto.Series,
        };

        _videos.TryAdd(guid, video);

        return video;
    }

    public async Task<Video?> FindVideo(Guid id)
    {
        var retrieveResult = _videos.TryGetValue(id, out var video);

        return !retrieveResult ? null : video;
    }

    public async Task<Video?> UpdateVideo(Guid id, VideoUpdateDto videoUpdateDto)
    {
        var retrievedVideo = _videos.TryGetValue(id, out var videoToUpdate);

        if (!retrievedVideo) return null;

        var video = new Video
        {
            Id = id,
            Title = videoUpdateDto.Title,
            Date = videoUpdateDto.Date,
            Description = videoUpdateDto.Description,
            Link = videoUpdateDto.Link,
            Channel = videoUpdateDto.Channel,
            Series = videoUpdateDto.Series,
        };

        var updateResult = _videos.TryUpdate(id, video, videoToUpdate!);

        return updateResult ? video : null;
    }

    public async Task<Video?> DeleteVideo(Guid id)
    {
        var retrievedVideo = _videos.TryGetValue(id, out var videoToDelete);

        if (!retrievedVideo) return null;

        _videos.TryRemove(id, out var deleted);
        return deleted;
    }

    public async Task<IEnumerable<Video>> SelectBySeries(string series)
    {
        var retrievedVideos =
            _videos.Values.Where(video => video.Series.Equals(series, StringComparison.OrdinalIgnoreCase));

        return retrievedVideos;
    }

    public async Task<IEnumerable<Video>> GetLatestInChannel(string channel, int limit)
    {
        var retrievedVideos = _videos.Values
            .Where(video => video.Channel.Equals(channel, StringComparison.OrdinalIgnoreCase))
            .Take(limit);

        return retrievedVideos;
    }
}