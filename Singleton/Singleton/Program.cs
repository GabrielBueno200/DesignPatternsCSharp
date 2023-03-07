using Singleton.Singletons;

var db = SingletonDatabase.Instance;
Console.WriteLine($"Database instances: {SingletonDatabase.Count}"); // Should be 1

var city = "Tokyo";
Console.WriteLine($"{city} has population {db.GetPopulation(city)}");