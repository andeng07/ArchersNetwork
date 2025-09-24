using ArchersNetwork.Backend.Core.Endpoint;
using ArchersNetwork.Backend.Features.Video;
using MongoDB.Driver;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddOpenApi();
builder.Services.AddEndpoints();

builder.Services.AddSingleton<IMongoClient>(provider =>
{
    var config = provider.GetRequiredService<IConfiguration>();
    return new MongoClient(config["MongoDB:ConnectionString"]);
});

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