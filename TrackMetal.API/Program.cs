using DotNetEnv;
using Microsoft.EntityFrameworkCore;
using TrackMetal.API.Data;

Env.Load();


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var connectionStringTemplate = builder.Configuration.GetConnectionString("DefaultConnection")
                               ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");
var connectionString = connectionStringTemplate
    .Replace("{DB_SERVER}", Environment.GetEnvironmentVariable("DB_SERVER")!)
    .Replace("{DB_NAME}", Environment.GetEnvironmentVariable("DB_NAME")!);

builder.Services.AddDbContext<TrackMetalDbContext>(option => option.UseSqlServer(connectionString));

builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
    app.UseSwaggerUI(options =>
    {
        options.SwaggerEndpoint("/openapi/v1.json", "Open Api");
        options.RoutePrefix = "";
    });

}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();