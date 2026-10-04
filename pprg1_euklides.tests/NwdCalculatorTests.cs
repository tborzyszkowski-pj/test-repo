using Xunit;

public class NwdCalculatorTests
{
    [Theory]
    [InlineData(48, 18, 6)]
    [InlineData(17, 5, 1)]
    [InlineData(100, 25, 25)]
    [InlineData(270, 192, 6)]
    public void Nwd_ReturnsExpectedResult(int a, int b, int expected)
    {
        int result = NwdCalculator.Nwd(a, b);

        Assert.Equal(expected, result);
    }

    [Fact]
    public void Nwd_IsCommutative()
    {
        int result = NwdCalculator.Nwd(84, 30);

        Assert.Equal(NwdCalculator.Nwd(30, 84), result);
    }

    [Theory]
    [InlineData(0, 5)]
    [InlineData(5, 0)]
    [InlineData(-12, 8)]
    [InlineData(12, -8)]
    public void Nwd_ThrowsForNonPositiveNumbers(int a, int b)
    {
        Assert.Throws<ArgumentOutOfRangeException>(() => NwdCalculator.Nwd(a, b));
    }
}
