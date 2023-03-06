using AbstractFactory.Interfaces;

namespace AbstractFactory.Entities;

public class HotDrinkMachine
{
    private List<(string drink, IHotDrinkFactory factory)> factories = new();

    public HotDrinkMachine()
    {
        foreach (var type in typeof(HotDrinkMachine).Assembly.GetTypes())
        {
            if (typeof(IHotDrinkFactory).IsAssignableFrom(type) && !type.IsInterface)
            {
                var drink = type.Name.Replace("Factory", string.Empty);
                factories.Add((drink, (IHotDrinkFactory)Activator.CreateInstance(type)!));
            }
        }
    }

    public IHotDrink MakeDrink()
    {
        Console.WriteLine("Available drinks:");

        foreach (var (factory, index) in factories.Select((f, i) => (f, i)))
        {
            Console.WriteLine($"{index}: {factory.drink}");
        }

        while (true)
        {
            string? s;
            if ((s = Console.ReadLine()) is not null
                && int.TryParse(s, out int i)
                && i >= 0
                && i < factories.Count)
            {
                Console.WriteLine("Specify amount: ");
                s = Console.ReadLine();
                if (s is not null
                    && int.TryParse(s, out int amount)
                    && amount > 0)
                {
                    return factories[i].factory.Prepare(amount);
                }
            }

            Console.WriteLine("Incorrect input, try again!");
        }
    }
}
