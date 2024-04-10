using Encan2000.Domain;

namespace Encan2000;

public class CarPriceCalculatorResponse
{
    public CarPriceCalculatorResponse(){}
    public CarPriceCalculatorResponse(PriceInfo priceInfo)
    {
        BaseCost = priceInfo.BaseCost.ToString("C");
        SpecialCost = priceInfo.SpecialCost.ToString("C");
        AssociationCost = priceInfo.AssociationCost.ToString("C");
        StorageCost = priceInfo.StorageCost.ToString("C");
        Total = priceInfo.Total.ToString("C");
    }
    
    public string BaseCost {get; set;}= string.Empty;
    public string SpecialCost {get; set;} = string.Empty;
    public string AssociationCost {get; set;} = string.Empty;
    public string StorageCost {get; set;} = string.Empty;
    public string Total {get; set;} = string.Empty;
}