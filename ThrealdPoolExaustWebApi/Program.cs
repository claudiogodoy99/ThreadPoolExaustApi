using ThrealdPoolExaustWebApi.Repositories;
using ThrealdPoolExaustWebApi.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddScoped<IWatherforecastRepository, WatherforecastRepository>();
builder.Services.AddScoped<IWatherforecastService, WatherforecastService>();
builder.Services.AddApplicationInsightsTelemetry(builder.Configuration["APPLICATIONINSIGHTS_CONNECTION_STRING"]);

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
