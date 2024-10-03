using NUnitDemo;

namespace TestProject1
{
    [TestFixture]
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
            
        }

        [Test]
        public void Sum_ReceivesTwoValue_ReturnsSum()
        {
            // Arrange
            Calculater _calc = new Calculater();
            int num1 = 2;
            int num2 = 3;
            int expected = 5;

            // Act
            var result = _calc.Sum(num1, num2);

            // Assert
            Assert.AreEqual(expected, result);
        }
    }
}