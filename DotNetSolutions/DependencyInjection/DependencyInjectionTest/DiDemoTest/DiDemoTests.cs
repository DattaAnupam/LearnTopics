using DependencyInjection.DiDemo;
using Microsoft.Extensions.Logging;
using Moq;

namespace DependencyInjectionTest.DiDemoTest
{
    public class DiDemoTests
    {
        private readonly Mock<ILogger<DIDemo>> _loggerMock;

        public DiDemoTests()
        {
            _loggerMock = new Mock<ILogger<DIDemo>>();
        }

        [Fact]
        public void TestDependencyInjection_Success()
        {
            // Arrange
            var obj = new DIDemo(_loggerMock.Object);

            // Act
            var result = obj.TestDependencyInjection();

            // Assert
            Assert.Equal("Success", result.Status);
            Assert.Equal("DI is Tested Successfully.", result.Message);
        }
    }
}
