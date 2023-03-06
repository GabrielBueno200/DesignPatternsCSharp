using FacetedBuilder.Entities;

namespace FacetedBuilder.Builders;

public class PersonBuilder
{
    protected Person person = new Person();

    public PersonJobBuilder Works => new PersonJobBuilder(person);

    public PersonAddressBuilder Lives => new PersonAddressBuilder(person);

    public static implicit operator Person(PersonBuilder builder)
        => builder.person;
}
