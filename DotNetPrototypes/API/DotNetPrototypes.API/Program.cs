using DotNetPrototypes.API.Configuration;

var builder = WebApplication.CreateBuilder(args);
builder.Services.Configure();

var app = builder.Build();
app.Configure();

app.Run();
