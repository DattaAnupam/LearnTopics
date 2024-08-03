using BloodDonationApp.Contexts;
using BloodDonationApp.Models;
using BloodDonationApp.Utilitis;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BloodDonationApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DonersController : ControllerBase
    {
        #region Method Variables
        private readonly BloodDonationDBContext _bdContext;
        #endregion

        public DonersController(BloodDonationDBContext bdContext)
        {
            _bdContext = bdContext;
        }

        // Get all the Doners
        [HttpGet]
        [Route(StringConstants.GetDoners)]
        public async Task<IEnumerable<Doners>> GetDoners()
        {
            return await _bdContext.Doners.ToListAsync();
        }

        // Get Doner by ID
        [HttpGet]
        [Route(StringConstants.GetDoner)]
        public async Task<Doners?> GetDoner([FromQuery] int id)
        {
            Doners? doner = await _bdContext.Doners.FindAsync(id);
            return doner;
        }

        // Add new Doner
        [HttpPost]
        [Route(StringConstants.CreateDoner)]
        public async Task<string> CreateDoner([FromBody] Doners request)
        {
            await _bdContext.Doners.AddAsync(request);
            await _bdContext.SaveChangesAsync();

            return "done";
        }

        // Delete Doner By ID
        [HttpDelete]
        [Route(StringConstants.DeleteDoner)]
        public async Task<string> DeleteDoner([FromQuery] int id)
        {
            var donerToDelete = await _bdContext.Doners.FindAsync(id);
            _bdContext.Doners.Remove(donerToDelete);
            await _bdContext.SaveChangesAsync();

            return "Deleted";
        }
    }
}
