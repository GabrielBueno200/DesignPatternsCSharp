using Singleton.Singletons;
using FluentAssertions;
using Xunit;

namespace Singleton.Tests;

public class SingletonTest
{
    [Fact]
    public void IsSingletonTest()
    {
        var db = SingletonDatabase.Instance;
        var db2 = SingletonDatabase.Instance;

        db.Should().BeSameAs(db2);
        SingletonDatabase.Count.Should().Be(1);
    }
}
