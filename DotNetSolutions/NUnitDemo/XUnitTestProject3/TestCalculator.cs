using Moq;
using NUnitDemo;
using NUnitDemo.Interfaces;

namespace XUnitTestProject3
{
    public class TestCalculator
    {
        private readonly Mock<IUtilities> mockUtilities;
        private readonly ICalculator calculator;

        public TestCalculator()
        {
            mockUtilities = new Mock<IUtilities>();
            calculator = new Calculator(mockUtilities.Object);
        }

        [Fact]
        public void Sum_OnCorrectInput_ReturnsSum()
        {
            // Arrange
            int num1 = 2;
            int num2 = 3;
            int expected = 5;

            mockUtilities.Setup(u => u.GetGreater(num1, num2)).Returns(8);

            // Act
            var result = calculator.GetSum(num1, num2);

            // Assert
            Assert.Equal(expected, result);
        }
    }
}