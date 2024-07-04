using DependencyInjection.DiDemo.Interfaces;
using DependencyInjection.Models;
using Newtonsoft.Json;

namespace DependencyInjection.DiDemo
{
    public class DIDemo : IDiDemo
    {
        public string TestDependencyInjection()
        {
            var obj = new DiSucessModel()
            {
                Status = "Success",
                Message = "DI is Tested Successfully."
            };

            return JsonConvert.SerializeObject(obj);
        }
    }
}
