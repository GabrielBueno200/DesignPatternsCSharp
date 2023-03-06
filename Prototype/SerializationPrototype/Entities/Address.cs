namespace Prototype.Entities;

public class Address
{
    public string? StreetName { get; set; }

    public int HouseNumber { get; set; }

    public override string ToString()
    {
        return $"{nameof(StreetName)}: {StreetName}, {nameof(HouseNumber)}: {HouseNumber}";
    }
}