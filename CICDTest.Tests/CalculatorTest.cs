namespace CICDTest.Tests
{
    public class CalculatorTest(Calculator calculator)
    {
        private readonly Calculator _calculator = calculator;
        [Fact]
        public void Add_ReturnsCorrectSum()
        {
            // Arrange
            var calc = new Calculator();

            // Act
            int result = calc.Add(3, 5);

            // Assert
            Assert.Equal(8, result);
        }

        [Theory]
        [InlineData(2, 3, 6)]
        [InlineData(0, 5, 0)]
        [InlineData(-2, 4, -8)]
        public void Multiply_ReturnsCorrectProduct(int a, int b, int expected)
        {
            var calc = new Calculator();
            int result = calc.Multiply(a, b);
            Assert.Equal(expected, result);
        }

    }
}
