using MoreLinq;
using Singleton.Interfaces;

namespace Singleton.Singletons;

public class SingletonDatabase : IDatabase
{
    private Dictionary<string, int> capitals;
    private static int instanceCount;
    public static int Count => instanceCount;

    private SingletonDatabase()
    {
        Console.WriteLine("Initializing database");

        capitals = File.ReadAllLines(
            Path.Combine(
                Directory.GetCurrentDirectory(), "capitals.txt")
            )
            .Batch(2)
            .ToDictionary(
                list => list.ElementAt(0).Trim(),
                list => int.Parse(list.ElementAt(1))
            );
    }

    public int GetPopulation(string name)
    {
        return capitals[name];
    }

    private static Lazy<SingletonDatabase> instance = new Lazy<SingletonDatabase>(() =>
    {
        instanceCount++;
        return new SingletonDatabase();
    });

    public static IDatabase Instance => instance.Value;
}
