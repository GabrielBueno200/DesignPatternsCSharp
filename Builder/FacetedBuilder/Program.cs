using FacetedBuilder.Builders;
using FacetedBuilder.Entities;

Person person = new PersonBuilder()
                .Lives.At("Paulista Avenue")
                      .In("Brazil")
                      .WithPostCode("12345-678")
                .Works.At("Microsoft")
                    .AsA("Dev")
                    .Earning(123000);

Console.WriteLine(person);