

namespace Greeter.UnitTests;
public class GreetingTest
{
    [Theory]
    [InlineData("Windom", "Hello, Windom")]
    [InlineData("Tyler", "Hello, Tyler")]
    public void SingleName(string name, string expected)
    {
        var greeter = new GreetingMaker();

        string greeting = greeter.Greet(name);

        Assert.Equal(expected, greeting);
    }
    [Fact]
    public void NullName()
    {
        var greeter = new GreetingMaker();

        string greeting = greeter.Greet(null);

        Assert.Equal("Hello, Buddy", greeting);
    }
    [Theory]
    [InlineData("TYLER", "HELLO, TYLER")]
    [InlineData("DANA", "HELLO, DANA")]
    public void ShoutingGreeting(string name, string expected)
    {
        var greeter = new GreetingMaker();

        string greeting = greeter.Greet(name);

        Assert.Equal(expected, greeting);
    }
}
