var builder = WebApplication.CreateBuilder(args);

var configuration = builder.Configuration;

builder.Services.AddControllers();
builder.Services.AddSwaggerGen(
    s=>s.SwaggerDoc("v1", new() { 
        Title = "MarketPlaceListing.Api", Version = "v1" 
        })
    );

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
app.UseHttpsRedirection();

app.Run();

record WeatherForecast(DateOnly Date, int TemperatureC, string? Summary)
{
    public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
}
