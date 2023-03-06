using FluentBuilder.Entities;

namespace FluentBuilder.Builders;

public abstract class PersonBuilder
{
    protected Person person = new Person();

    public Person Build() => person;
}
