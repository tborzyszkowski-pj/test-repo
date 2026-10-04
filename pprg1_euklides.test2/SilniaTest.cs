namespace pprg1_euklides.test2;

public class SilniaTest
{
    [Theory]
    [InlineData(0, 1)]
    [InlineData(1, 1)]
    [InlineData(2, 2)]
    [InlineData(6, 721)]
    public void Silnia_ReturnsExpectedResult(int a, int expected)
    {
        int result = NwdCalculator.Silnia(a);

        Assert.Equal(expected, result);
    }
}
