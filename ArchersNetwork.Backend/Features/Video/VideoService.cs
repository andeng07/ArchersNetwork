using System.Collections.Concurrent;
using ArchersNetwork.Backend.Features.Video.Dto;

namespace ArchersNetwork.Backend.Features.Video;

using Model;

public class VideoService
{
    // TODO: convert to database

    private static readonly ConcurrentDictionary<Guid, Video> _videos = new();

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