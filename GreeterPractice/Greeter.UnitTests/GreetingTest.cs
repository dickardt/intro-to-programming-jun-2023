

namespace Greeter.UnitTests;
public class GreetingTest
{
    [Theory]
    [InlineData("Windom")]
    [InlineData("Tyler")]
    public void SingleName(string name)
    {
        var greeter = new GreetingMaker();

        string greeting = greeter.Greet(name);

        Assert.Equal($"Hello, {name}", greeting);
    }
    [Fact]
    public void NullName()
    {
        var greeter = new GreetingMaker();

        string greeting = greeter.Greet(null);

        Assert.Equal("Hello, Buddy", greeting);
    }
}
