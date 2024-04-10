using Encan2000;
using Encan2000.Domain;
using Microsoft.Extensions.FileProviders;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddSingleton<IAuctionPriceCalculator, AuctionPriceCalculator>();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.MapPost("auction/carprice/calculate", (CarPriceCalculatorRequest request, IAuctionPriceCalculator calculator) =>
{
    if (request.BasePrice < 0)
        return Results.BadRequest("Invalid car price.");

    if (request.CarType != "ORDINARY" && request.CarType != "LUXURY")
        return Results.BadRequest("Invalid car type.");

    var result = calculator.Calculate(request.MapToCarInfo());
    
    var response = new CarPriceCalculatorResponse(result);
    return Results.Ok(response);
})
.WithOpenApi();

app.UseFileServer(new FileServerOptions{
    FileProvider= new PhysicalFileProvider(Path.Combine(Directory.GetCurrentDirectory(), "Ui")),
    EnableDefaultFiles=true
});

app.Run();
