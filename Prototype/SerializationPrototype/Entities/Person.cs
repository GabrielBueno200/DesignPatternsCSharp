namespace Prototype.Entities;

public class Person
{
    public string[] Names { get; set; }

    public Address Address { get; set; }

    public Person() { }

    public Person(string[] names, Address address)
    {
        Names = names;
        Address = address;
    }

    public override string ToString()
    {
        return $"{nameof(Names)}: {string.Join(" ", Names)}, {nameof(Address)}: {Address}";
    }
}
