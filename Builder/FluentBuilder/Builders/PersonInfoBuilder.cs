namespace FluentBuilder.Builders;

public class PersonInfoBuilder<T> : PersonBuilder
    where T : PersonInfoBuilder<T>
{
    public T Called(string personName)
    {
        person.Name = personName;
        return (T)this;
    }
}
