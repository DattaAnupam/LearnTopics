using Microsoft.AspNetCore.Mvc;
using System.Net;
using System.Net.Mime;

namespace DependencyInjection.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DIDemoController : ControllerBase
    {
        [HttpGet]
        [Produces(MediaTypeNames.Application.Json)]
        public IActionResult TestDependecyInjection()
        {

            // Return response
            return new ContentResult()
            {
                ContentType = MediaTypeNames.Application.Json,
                StatusCode = (int) HttpStatusCode.OK,
                Content = "Success"
            };
        }
    }
}
