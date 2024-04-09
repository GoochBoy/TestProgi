namespace Encan2000.Domain;

public record PriceInfo(CarInfo Input, decimal BaseCost, decimal SpecialCost, decimal AssociationCost, decimal StorageCost)
{
    public decimal Total { get; init; } = Input.BasePrice + BaseCost + SpecialCost + AssociationCost + StorageCost;
}