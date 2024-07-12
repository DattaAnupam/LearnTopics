using DependencyInjection.DiDemo.Interfaces;
using DependencyInjection.Models;

namespace DependencyInjection.DiDemo
{
    public class DIDemo : IDiDemo
    {
        public DiSucessModel TestDependencyInjection()
        {
            var obj = new DiSucessModel()
            {
                Status = "Success",
                Message = "DI is Tested Successfully."
            };

            return obj;
        }
    }
}
