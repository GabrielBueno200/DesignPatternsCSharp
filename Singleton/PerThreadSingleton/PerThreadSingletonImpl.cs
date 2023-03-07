namespace PerThreadSingleton;

public sealed class PerThreadSingletonImpl
{
    private static ThreadLocal<PerThreadSingletonImpl> _instance
      = new ThreadLocal<PerThreadSingletonImpl>(() => new PerThreadSingletonImpl());

    public int Id;

    private PerThreadSingletonImpl()
    {
        Id = Thread.CurrentThread.ManagedThreadId;
    }

    public static PerThreadSingletonImpl? Instance => _instance.Value;
}
