using Microsoft.AspNetCore.Mvc;

namespace DependencyInjection.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DIDemoController : ControllerBase
    {
        public IActionResult Index()
        {
            return Ok();
        }
    }
}
