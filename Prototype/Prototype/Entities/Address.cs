using Prototype.Interfaces;

namespace Prototype.Entities;

public class Address : IDeepCopyable<Address>
{
    public string? StreetName;

    public int HouseNumber;

    public void CopyTo(Address target)
    {
        target.StreetName = StreetName;
        target.HouseNumber = HouseNumber;
    }

    public override string ToString()
    {
        return $"{nameof(StreetName)}: {StreetName}, {nameof(HouseNumber)}: {HouseNumber}";
    }
}