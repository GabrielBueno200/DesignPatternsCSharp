using FunctionalBuilder.Builders;
using FunctionalBuilder.Extensions;

var person = new PersonBuilder()
                .Called("Gabriel")
                .WorksAs("Dev")
                .Build();

Console.WriteLine(person);