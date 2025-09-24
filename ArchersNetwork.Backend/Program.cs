using ArchersNetwork.Backend.Core.Endpoint;
using ArchersNetwork.Backend.Features.Video;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddOpenApi();
builder.Services.AddEndpoints();

builder.Services.AddScoped<VideoService>();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

var videoEndpointGroup = app.MapGroup("/videos");

app.MapEndpoints(videoEndpointGroup);

app.UseHttpsRedirection();

app.Run();