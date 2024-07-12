using DependencyInjection.Controllers;
using DependencyInjection.DiDemo.Interfaces;
using DependencyInjection.Models;
using Microsoft.AspNetCore.Mvc;
using Moq;
using System.Net.Mime;

namespace DependencyInjectionTest.ControllersTest
{
    public class DIDemoControllerTests
    {
        private readonly Mock<IDiDemo> _diMock;
        private readonly DIDemoController _controller;

        public DIDemoControllerTests()
        {
            _diMock = new Mock<IDiDemo>();
            _controller = new DIDemoController(_diMock.Object);
        }

        [Fact]
        public void TestDependecyInjection_Success()
        {
            // Arrage
            DiSucessModel model = new DiSucessModel()
            {
                Status = "test",
                Message = "test message"
            };

            // mock TestDependencyInjection()
            _diMock.Setup(d => d.TestDependencyInjection()).Returns(model);

            // Act
            var result = _controller.TestDependecyInjection();

            // Assert
            Assert.IsType<ContentResult>(result);
            var contentResult = Assert.IsType<ContentResult>(result);
            Assert.Equal(200, contentResult.StatusCode);
            Assert.Equal(MediaTypeNames.Application.Json, contentResult.ContentType);
            Assert.True(contentResult.Content?.Contains("test", StringComparison.OrdinalIgnoreCase));
        }
    }
}
