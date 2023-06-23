

namespace Greeter.UnitTests;
public class GreetingTest
{
    //Single name test Req 1 
    [Theory]
    [InlineData("Windom", "Hello, Windom!")]
    [InlineData("Tyler", "Hello, Tyler!")]
    public void SingleName(string name, string expected)
    {
        var greeter = new GreetingMaker();

        string greeting = greeter.Greet(name);

        Assert.Equal(expected, greeting);
    }
    //If name is null, return a default Req 2
    [Fact]
    public void NullName()
    {
        var greeter = new GreetingMaker();

        string greeting = greeter.Greet(null);

        Assert.Equal("Hello, Buddy!", greeting);
    }
    //If somebody is shouting, shout back Req 3
    [Theory]
    [InlineData("TYLER", "HELLO, TYLER!")]
    [InlineData("DANA", "HELLO, DANA!")]
    public void ShoutingGreeting(string name, string expected)
    {
        var greeter = new GreetingMaker();

        string greeting = greeter.Greet(name);

        Assert.Equal(expected, greeting);
    }
    //If two names are provided print a greeting for that Req 4
    [Theory]
    [InlineData("Tyler", "Dana", "Hello, Tyler and Dana!")]
    [InlineData("Mom", "Dad", "Hello, Mom and Dad!")]
    public void TwoNameGreeting(string name1, string name2, string expected)
    {
        var greeter = new GreetingMaker();

        string greeting = greeter.Greet(name1, name2);

        Assert.Equal(expected, greeting);
    }
    //Handle an unknown length of names in a greeting Req 5
    [Theory]
    [InlineData("Hello, Tyler, Dana, and Anala!", "Tyler", "Dana", "Anala")]
    [InlineData("Hello, Tyler, Dana, Cecelia, and Anala!", "Tyler", "Dana", "Cecelia", "Anala" )]
    public void MultipleNameGreeting(string expected, string name, params string[] names)
    {
        var greeter = new GreetingMaker();

        string greeting = greeter.Greet(name, names);

        Assert.Equal(expected, greeting);
    }
}
