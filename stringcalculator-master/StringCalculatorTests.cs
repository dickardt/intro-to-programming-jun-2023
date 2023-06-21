
namespace StringCalculator;

public class StringCalculatorTests
{
    [Fact]
    public void EmptyStringReturnsZero()
    {
        var calculator = new StringCalculator();

        var result = calculator.Add("");

        Assert.Equal(0, result);
    }
    [Theory]
    [InlineData("", 0)]
    [InlineData("1", 1)]
    [InlineData("2", 2)]
    public void SingleDigit(string str, int expected)
    {
        var calculator = new StringCalculator();

        var result = calculator.Add(str);

        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData("1,2", 3)]
    [InlineData("1\n2", 3)]
    public void SingleString(string str, int expected)
    {
        var calculator = new StringCalculator();

        var result = calculator.Add(str);

        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData("1,2,3", 6)]
    [InlineData("1\n2,3", 6)]
    public void MultipleString(string str, int expected)
    {
        var calculator = new StringCalculator();

        var result = calculator.Add(str);

        Assert.Equal(expected, result);
    }
    [Theory]
    [InlineData("//;\n1;2", 3)]
    public void CustomDelimiterTest(string str, int expected)
    {
        var calculator = new StringCalculator();

        var result = calculator.Add(str);

        Assert.Equal(expected, result);
    }

}
