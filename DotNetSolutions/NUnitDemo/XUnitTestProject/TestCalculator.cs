using Moq;
using NUnitDemo.Interfaces;
using NUnitDemo;

namespace XUnitTestProject
{
    public class TestCalculator
    {
        private readonly Mock<IUtilities> mockUtilities;
        private readonly ICalculator _calculator;

        public TestCalculator()
        {
            mockUtilities = new Mock<IUtilities>();
            _calculator = new Calculator(mockUtilities.Object);
        }

        [Fact]
        public void GetSum_OnValidInput_ReturnsSum()
        {
            // Arrange
            int num1 = 2, num2 = 3 , expected = 5;

            mockUtilities.Setup(u => u.GetGreater(num1, num2)).Returns(8);

            // Act
            var result = _calculator.GetSum(num1, num2);

            // Assert
            Assert.Equal(expected, result);
        }
    }
}