namespace FunctionalBuilder.Builders;

public abstract class FunctionalBuilder<TSubject, TSelf>
    where TSelf : FunctionalBuilder<TSubject, TSelf>
    where TSubject : new()
{
    private readonly List<Func<TSubject, TSubject>> actions
        = new List<Func<TSubject, TSubject>>();

    public TSelf Do(Action<TSubject> action)
        => AddAction(action);

    public TSubject Build()
        => actions.Aggregate(new TSubject(), (p, f) => f(p));

    private TSelf AddAction(Action<TSubject> action)
    {
        actions.Add(subject =>
        {
            action(subject);
            return subject;
        });

        return (TSelf)this;
    }
}
