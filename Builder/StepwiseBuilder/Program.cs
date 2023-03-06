using StepwiseBuilder;
using StepwiseBuilder.Builders;

var car = CarBuilder.Create()
            .OfType(CarType.Crossover)
            .WithWheels(20)
            .Build();