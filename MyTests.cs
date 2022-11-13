using Xunit;

public class MyTests
{
    [Fact]
    public void TestSomething()
    {
        Assert.True(5 == 5);
    }

    [Fact]
    public void SomethingTrue()
    {
        var calc = (int first, int second) => first + second;

        Assert.Equal(5, calc(2, 3));
    }

    [Fact]
    public void BadCalculator()
    {
        var calc = (int first, int second) => first + second + 9999;

        Assert.Equal(5, calc(2, 3));
    }
}