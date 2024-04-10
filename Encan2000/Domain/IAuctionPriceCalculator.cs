namespace Encan2000.Domain;

public interface IAuctionPriceCalculator
{
    PriceInfo Calculate(CarInfo carinfo);
}