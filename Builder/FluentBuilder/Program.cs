using FluentBuilder.Entities;

var person = Person.New
                .Called("Gabriel")
                .WorkAs("Dev")
                .Build();

Console.WriteLine(person);