using DependencyInjection.Models;
using DependencyInjection.Models.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace DependencyInjection.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DiController : ControllerBase
    {
        private readonly IAddSingleTon _addSingleTon1;
        private readonly IAddSingleTon _addSingleTon2;

        public DiController(IAddSingleTon addSingleTon1, IAddSingleTon addSingleTon2)
        {
            _addSingleTon1 = addSingleTon1;
            _addSingleTon2 = addSingleTon2;
        }

        [HttpGet]
        public IActionResult Index()
        {

            var singletonOperationID_1 = _addSingleTon1.GetOperationID();
            var singletonOperationID_2 = _addSingleTon1.GetOperationID();

            // Set Final Response
            var response = new FinalResponse()
            {
                AddSingleTonID_1 = singletonOperationID_1,
                AddSingleTonID_2 = singletonOperationID_2,
            };

            var options = new JsonSerializerOptions()
            {
                WriteIndented = true,      // Pretty print the output Json
            };

            var content = JsonSerializer.Serialize(response, options);

            return Ok(content);
        }
    }
}
