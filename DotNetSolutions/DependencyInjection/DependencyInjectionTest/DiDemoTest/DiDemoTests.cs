using DependencyInjection.DiDemo;

namespace DependencyInjectionTest.DiDemoTest
{
    public class DiDemoTests
    {
        [Fact]
        public void TestDependencyInjection_Success()
        {
            // Arrange
            var obj = new DIDemo();

            // Act
            var result = obj.TestDependencyInjection();

            // Assert
            Assert.Equal("Success", result.Status);
            Assert.Equal("DI is Tested Successfully.", result.Message);
        }
    }
}
