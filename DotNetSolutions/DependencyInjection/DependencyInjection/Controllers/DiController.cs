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

        private readonly IAddScoped _addScoped1;
        private readonly IAddScoped _addScoped2;

        public DiController(
            IAddSingleTon addSingleTon1, IAddSingleTon addSingleTon2,
            IAddScoped addScoped1, IAddScoped addScoped2
            )
        {
            _addSingleTon1 = addSingleTon1;
            _addSingleTon2 = addSingleTon2;

            _addScoped1 = addScoped1;
            _addScoped2 = addScoped2;
        }

        [HttpGet]
        public IActionResult Index()
        {

            // Call to Singleton class' method
            var singletonOperationID_1 = _addSingleTon1.GetOperationID();
            var singletonOperationID_2 = _addSingleTon1.GetOperationID();

            // Call to scoped class' method
            var scopedOperationID_1 = _addScoped1.GetAddScopedOperationID();
            var scopedOperatonID_2 = _addScoped2.GetAddScopedOperationID();

            // Set Final Response
            var response = new FinalResponse()
            {
                AddSingleTonID_1 = singletonOperationID_1,
                AddSingleTonID_2 = singletonOperationID_2,

                AddScopedID_1 = scopedOperationID_1,
                AddScopedID_2 = scopedOperatonID_2,
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
