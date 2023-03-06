using AbstractFactory.Interfaces;

namespace AbstractFactory.Entities;

internal class Coffe : IHotDrink
{
    public void Consume()
    {
        Console.WriteLine("This coffe is sensational!");
    }
}
