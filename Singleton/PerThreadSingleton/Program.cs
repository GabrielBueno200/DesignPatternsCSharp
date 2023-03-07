using PerThreadSingleton;

var thread1 = Task.Factory.StartNew(
    () => Console.WriteLine($"t1: " + PerThreadSingletonImpl.Instance?.Id));

var thread2 = Task.Factory.StartNew(() =>
{
    Console.WriteLine($"t2: " + PerThreadSingletonImpl.Instance?.Id);
    Console.WriteLine($"t2 again: " + PerThreadSingletonImpl.Instance?.Id);
});

Task.WaitAll(thread1, thread2);
