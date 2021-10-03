using Microsoft.AspNetCore.Mvc;
using TripSharing.Domain.Models;
using TripSharing.Service.Services;

namespace TripSharing.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DriverController : ControllerBase
    {
        private readonly IDriverService _driverService;

        public DriverController(IDriverService driverService)
        {
            _driverService = driverService;
        }

        [HttpGet(nameof(GetAllDrivers))]
        public IActionResult GetAllDrivers()
        {
            var result = _driverService.GetAllDrivers();

            if (result is not null)
            {
                return Ok(result);
            }

            return BadRequest("No records found!");
        }
        
        [HttpGet(nameof(GetDriver))]
        public IActionResult GetDriver(int Id)
        {
            var result = _driverService.GetDriver(Id);

            if (result is not null)
            {
                return Ok(result);
            }

            return BadRequest("No records found!");
        }
        
        [HttpPost(nameof(InsertDriver))]
        public IActionResult InsertDriver(Driver driver)
        {
            _driverService.InsertDriver(driver);
            return Ok("Driver saved");
        }
        
        [HttpPut(nameof(UpdateDriver))]
        public IActionResult UpdateDriver(Driver driver)
        {
            _driverService.UpdateDriver(driver);
            return Ok("Driver updated");
        }
        
        [HttpDelete(nameof(DeleteDriver))]
        public IActionResult DeleteDriver(int Id)
        {
            _driverService.DeleteDriver(Id);
            return Ok("Driver deleted");
        }
    }
}