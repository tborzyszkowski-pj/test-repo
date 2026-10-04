namespace pprg1_euklides.test2;

public class NwdTest
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

}
