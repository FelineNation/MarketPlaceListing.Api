using MarketPlaceListing.Core.Services;
using MarketPlaceListing.Core.Interfaces;
using MarketPlaceListing.EventHub;
using Microsoft.OpenApi.Models;
using System.Text.Json.Serialization;

// Purpose: Entry point for the application. This file is responsible for setting up the application and registering services. 

var builder = WebApplication.CreateBuilder(args);

var configuration = builder.Configuration;

builder.Services.AddControllers()
    .AddJsonOptions(options =>
    {
        options.JsonSerializerOptions.Converters.Add(new JsonStringEnumConverter());
    });
builder.Services.AddSwaggerGen(sg=>
{
    sg.SwaggerDoc("v1", new OpenApiInfo { Title = "MarketPlaceListing.Api", Version = "v1"});
});

// Register services
builder.Services.AddScoped<IListingService, MarketPlaceListingService>();

// Register event hub
builder.Services.AddKafkaTopicProducer(configuration);

// Register AutoMapper
builder.Services.AddAutoMapper(typeof(MarketPlaceListingService).Assembly);

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(s =>
    {
        s.SwaggerEndpoint("/swagger/v1/swagger.json", "MarketPlaceListing.Api v1");
        s.RoutePrefix = configuration["OPENAPI_BASEPATH"] ?? string.Empty;
    });
}

app.UsePathBase(configuration["BASE_PATH"] ?? "/");

app.MapControllers();

app.Run();
