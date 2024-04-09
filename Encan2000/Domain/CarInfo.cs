namespace Encan2000.Domain;

public enum CarType
{
    Ordinary,
    Luxury
}

public record CarInfo(decimal BasePrice, CarType CarType);
