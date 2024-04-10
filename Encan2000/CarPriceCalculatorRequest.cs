using Encan2000.Domain;

namespace Encan2000;

public class CarPriceCalculatorRequest
{
    public decimal BasePrice {get; set;}
    public string CarType {get; set;} = string.Empty;

    public CarInfo MapToCarInfo()
    {
        return new CarInfo(BasePrice, CarType == "LUXURY" ? Domain.CarType.Luxury : Domain.CarType.Ordinary);
    }
}