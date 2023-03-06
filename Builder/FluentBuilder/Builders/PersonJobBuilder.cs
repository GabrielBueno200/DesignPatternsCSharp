namespace FluentBuilder.Builders;

public class PersonJobBuilder<T> : PersonInfoBuilder<T>
    where T : PersonJobBuilder<T>
{
    public T WorkAs(string position)
    {
        person.Position = position;
        return (T)this;
    }
}
