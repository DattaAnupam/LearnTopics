using DependencyInjection.DiDemo.Interfaces;
using DependencyInjection.Models;

namespace DependencyInjection.DiDemo
{
    public class DIDemo : IDiDemo
    {
        private readonly ILogger<DIDemo> _logger;

        public DIDemo(ILogger<DIDemo> logger)
        {
            _logger = logger;
        }
        public DiSucessModel TestDependencyInjection()
        {
            _logger.LogInformation("Inside Test Dependency Injection");
            var obj = new DiSucessModel()
            {
                Status = "Success",
                Message = "DI is Tested Successfully."
            };

            _logger.LogInformation("response received: {@obj}", obj);

            return obj;
        }
    }
}
