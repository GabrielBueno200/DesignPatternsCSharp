using Prototype.Entities;
using Prototype.Extensions;

var john = new Employee();

john.Names = new[] { "John", "Doe" };
john.Address = new Address
{
    HouseNumber = 123,
    StreetName = "London Road"
};
john.Salary = 321000;

var copy = john.DeepCopy();

copy.Names[0] = "Jane";
copy.Address.HouseNumber++;
copy.Salary = 123000;

Console.WriteLine(john);
Console.WriteLine(copy);