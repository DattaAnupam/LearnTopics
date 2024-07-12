using DependencyInjection.DiDemo.Interfaces;
using DependencyInjection.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Net;
using System.Net.Mime;

namespace DependencyInjection.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DIDemoController : ControllerBase
    {
        private readonly IDiDemo _di;

        public DIDemoController(IDiDemo di)
        {
            _di = di;
        }

        [HttpGet]
        [Produces(MediaTypeNames.Application.Json)]
        public IActionResult TestDependecyInjection()
        {
            DiSucessModel response = _di.TestDependencyInjection();
            // Serialize the response
            string content = JsonConvert.SerializeObject(response);

            // Return response
            return new ContentResult()
            {
                ContentType = MediaTypeNames.Application.Json,
                StatusCode = (int) HttpStatusCode.OK,
                Content = content
            };
        }
    }
}
