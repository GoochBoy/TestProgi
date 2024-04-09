using Encan2000.Domain;

namespace Encan2000.Tests;

public class AuctionPriceCalculatorTests
{
    [Fact]
    public void Calculate_1000_Ordinary()
    {
        var calculator = new AuctionPriceCalculator();
        var input = new CarInfo(1000m, CarType.Ordinary);
        var result = calculator.Calculate(input);

        Assert.Equal<decimal>(50m, result.BaseCost);
        Assert.Equal<decimal>(20m, result.SpecialCost);
        Assert.Equal<decimal>(10m, result.AssociationCost);
        Assert.Equal<decimal>(100m, result.StorageCost);
        Assert.Equal<decimal>(1180m, result.Total);
    }
    
    [Fact]
    public void Calculate_398_Ordinary()
    {
        var calculator = new AuctionPriceCalculator();
        var input = new CarInfo(398m, CarType.Ordinary);
        var result = calculator.Calculate(input);

        Assert.Equal<decimal>(39.8m, result.BaseCost);
        Assert.Equal<decimal>(7.96m, result.SpecialCost);
        Assert.Equal<decimal>(5m, result.AssociationCost);
        Assert.Equal<decimal>(100m, result.StorageCost);
        Assert.Equal<decimal>(550.76m, result.Total);
    }

    [Fact]
    public void Calculate_501_Ordinary()
    {
        var calculator = new AuctionPriceCalculator();
        var input = new CarInfo(501m, CarType.Ordinary);
        var result = calculator.Calculate(input);

        Assert.Equal<decimal>(50m, result.BaseCost);
        Assert.Equal<decimal>(10.02m, result.SpecialCost);
        Assert.Equal<decimal>(10m, result.AssociationCost);
        Assert.Equal<decimal>(100m, result.StorageCost);
        Assert.Equal<decimal>(671.02m, result.Total);
    }

    [Fact]
    public void Calculate_57_Ordinary()
    {
        var calculator = new AuctionPriceCalculator();
        var input = new CarInfo(57m, CarType.Ordinary);
        var result = calculator.Calculate(input);

        Assert.Equal<decimal>(10m, result.BaseCost);
        Assert.Equal<decimal>(1.14m, result.SpecialCost);
        Assert.Equal<decimal>(5m, result.AssociationCost);
        Assert.Equal<decimal>(100m, result.StorageCost);
        Assert.Equal<decimal>(173.14m, result.Total);
    }

    [Fact]
    public void Calculate_1800_Luxury()
    {
        var calculator = new AuctionPriceCalculator();
        var input = new CarInfo(1800m, CarType.Luxury);
        var result = calculator.Calculate(input);

        Assert.Equal<decimal>(180m, result.BaseCost);
        Assert.Equal<decimal>(72m, result.SpecialCost);
        Assert.Equal<decimal>(15m, result.AssociationCost);
        Assert.Equal<decimal>(100m, result.StorageCost);
        Assert.Equal<decimal>(2167m, result.Total);
    }

    [Fact]
    public void Calculate_1100_Ordinary()
    {
        var calculator = new AuctionPriceCalculator();
        var input = new CarInfo(1100m, CarType.Ordinary);
        var result = calculator.Calculate(input);

        Assert.Equal<decimal>(50m, result.BaseCost);
        Assert.Equal<decimal>(22m, result.SpecialCost);
        Assert.Equal<decimal>(15m, result.AssociationCost);
        Assert.Equal<decimal>(100m, result.StorageCost);
        Assert.Equal<decimal>(1287m, result.Total);
    }

    [Fact]
    public void Calculate_1000000_Luxury()
    {
        var calculator = new AuctionPriceCalculator();
        var input = new CarInfo(1000000m, CarType.Luxury);
        var result = calculator.Calculate(input);

        Assert.Equal<decimal>(200m, result.BaseCost);
        Assert.Equal<decimal>(40000m, result.SpecialCost);
        Assert.Equal<decimal>(20m, result.AssociationCost);
        Assert.Equal<decimal>(100m, result.StorageCost);
        Assert.Equal<decimal>(1040320m, result.Total);
    }
}