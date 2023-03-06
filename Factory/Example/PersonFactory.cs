namespace Example;

public class PersonFactory
{
    private static int LastId = 0;

    public Person CreatePerson(string name) => new Person { Id = LastId++, Name = name };
}
