namespace Encan2000.Domain;

public interface IAuctionPriceCalculator
{
    PriceInfo Calculate(CarInfo carinfo);
}

public sealed class AuctionPriceCalculator : IAuctionPriceCalculator
{
    public PriceInfo Calculate(CarInfo carinfo)
    {

        return new PriceInfo(
            carinfo, 
            GetBaseCost(carinfo),
            GetSpecialCost(carinfo),
            GetAssociationCost(carinfo.BasePrice),
            100m);
    }

    private static decimal GetBaseCost(CarInfo carinfo)
    {
        var result = carinfo.BasePrice * 0.1m;
        return carinfo.CarType == CarType.Luxury ? 
            Math.Max(Math.Min(200m, result), 25m) :
            Math.Max(Math.Min(50m, result), 10m);
    }

    private static decimal GetSpecialCost(CarInfo carinfo)
    {
        return carinfo.CarType == CarType.Luxury ? 
            carinfo.BasePrice * 0.04m :
            carinfo.BasePrice * 0.02m;
    }

    private static decimal GetAssociationCost(decimal carPrice) =>
        carPrice switch
        {
            (>= 1m) and (<= 500m) => 5m,
            (> 500m) and (<= 1000m) => 10m,
            (> 1000m) and (<= 3000m) => 15m,
            > 3000m => 20m,
            _ => 0m
        };
}
