namespace FacetedBuilder.Entities;

public class Person
{
    public string? StreetAddress, PostCode, City;

    public string? CompanyName, Position;

    public int AnnualCome;

    public override string ToString()
    {
        return $"{nameof(StreetAddress)}: {StreetAddress}, {nameof(PostCode)}: {PostCode}, {nameof(City)}: {City}, {nameof(CompanyName)}: {CompanyName}, {nameof(Position)}: {Position}, {nameof(AnnualCome)}: {AnnualCome}";
    }
}
