using DealerApi.Application.DTO;
using DealerApi.Application.Interface;
using DealerApi.Entities.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DealerApi.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestDriveController : ControllerBase
    {
        private readonly ITestDriveServices _testDriveServices;

        public TestDriveController(ITestDriveServices testDriveServices)
        {
            _testDriveServices = testDriveServices ?? throw new ArgumentNullException(nameof(testDriveServices));
        }

        [HttpPost("create-guest")]
        public async Task<IActionResult> CreateTestDriveGuest([FromBody] TestDriveGuestDTO testDriveGuestDto)
        {
            try
            {
                if (testDriveGuestDto == null)
                {
                    return BadRequest(new { error = "Request body cannot be null or empty" });
                }

                if (!ModelState.IsValid)
                {
                    var errors = ModelState
                        .Where(x => x.Value != null && x.Value.Errors.Count > 0)
                        .ToDictionary(
                            kvp => kvp.Key,
                            kvp => kvp.Value!.Errors.Select(e => e.ErrorMessage).ToArray()
                        );
                    return BadRequest(new { errors });
                }

                var dtCustomer = new Customer
                {
                    FirstName = testDriveGuestDto.FirstName,
                    LastName = testDriveGuestDto.LastName,
                    Email = testDriveGuestDto.Email,
                    PhoneNumber = testDriveGuestDto.PhoneNumber,
                    IsGuest = true // Assuming this is a guest
                };

                var dtTestDrive = new TestDrive
                {
                    DealerCarUnitId = testDriveGuestDto.DealerCarUnitId,
                    AppointmentDate = testDriveGuestDto.AppointmentDate,
                    Note = testDriveGuestDto.Note,
                    Status = "Pending" // Default status for guest test drives
                };

                var dtDealerCar = new DealerCar
                {
                    DealerId = testDriveGuestDto.DealerId
                };

                var result = await _testDriveServices.CreateTestDriveGuestAsync(dtCustomer, dtTestDrive, dtDealerCar);
                
                if (result == null)
                {
                    return StatusCode(StatusCodes.Status500InternalServerError, "Failed to create test drive.");
                }

                var response = new
                {
                    message = "Test drive created successfully",
                    data = result
                };

                return Ok(response);
            }
            catch (Exception ex)
            {
                // Log the exception as needed
                return StatusCode(StatusCodes.Status500InternalServerError, "Internal server error: " + ex.Message);
            }
        }
        
    }
}
