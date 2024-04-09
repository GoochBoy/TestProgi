using Encan2000;
using Encan2000.Domain;

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

    var carInfo = new CarInfo(request.BasePrice, request.CarType == "LUXURY" ? CarType.Luxury : CarType.Ordinary);

    var result = calculator.Calculate(carInfo);

    return Results.Ok(result);
})
.WithOpenApi();

app.Run();
