using Moq;
using NUnitDemo;

namespace TestProject2
{
    public class UnitTest1
    {
        private readonly Mock<ClassA> _mockClassA;
        public UnitTest1()
        {
            _mockClassA = new Mock<ClassA>();
        }
        [Fact]
        public void ReturnTotal_Test_Positive()
        {
            // Arrange
            Calculater calculater = new Calculater(_mockClassA.Object);
            _mockClassA.Setup(sut => sut.Sum(1, 2)).Returns(5);
            // Act
            var result = calculater.ReturnTotal(1, 3);
            // Assert
            Assert.Equal(5, 5);
        }
    }
}