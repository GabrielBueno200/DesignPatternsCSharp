namespace FunctionalBuilder.Entities;

public class Person
{
    public string? Name, Position;

    public override string ToString()
     => $"{nameof(Name)}: {Name}, {nameof(Position)}: {Position}";
}
