using Microsoft.AspNetCore.Mvc;

namespace BloodDonationApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DonersController : ControllerBase
    {
        [HttpGet]
        public IActionResult Index()
        {
            return Ok(new { Message = "Success" });
        }
    }
}
