using FluentAssertions;

namespace CICDTest.Tests;

public class CalculatorTest
{
    private readonly Calculator _calculator = new();
    [Fact]
    public void Add_ReturnsCorrectSum()
    {
        var result = _calculator.Add(3, 5);
        result.Should().Be(8);
    }

    [Theory]
    [InlineData(2, 3, 6)]
    [InlineData(0, 5, 0)]
    [InlineData(-2, 4, -8)]
    public void Multiply_ReturnsCorrectProduct(int a, int b, int expected)
    {
        var result = _calculator.Multiply(a, b);
        result.Should().Be(expected);
    }

}
