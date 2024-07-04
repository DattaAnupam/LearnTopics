using Microsoft.AspNetCore.Mvc;

namespace DependencyInjection.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DIDemoController : ControllerBase
    {
        [HttpGet]
        public IActionResult TestDependecyInjection()
        {
            return Ok();
        }
    }
}
