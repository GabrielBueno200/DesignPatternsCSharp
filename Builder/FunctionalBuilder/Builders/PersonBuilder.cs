using FunctionalBuilder.Entities;

namespace FunctionalBuilder.Builders;

public sealed class PersonBuilder
    : FunctionalBuilder<Person, PersonBuilder>
{
    public PersonBuilder Called(string name)
        => Do(person => person.Name = name);
}
