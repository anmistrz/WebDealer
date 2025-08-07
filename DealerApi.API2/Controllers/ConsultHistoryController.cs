using DealerApi.Application.DTO;
using DealerApi.Application.Interface;
using DealerApi.Entities.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DealerApi.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ConsultHistoryController : ControllerBase
    {
        private readonly IConsultHistoryServices _consultHistoryServices;

        public ConsultHistoryController(IConsultHistoryServices consultHistoryServices)
        {
            _consultHistoryServices = consultHistoryServices ?? throw new ArgumentNullException(nameof(consultHistoryServices));
        }

        [HttpPost("create-guest")]
        public async Task<IActionResult> CreateConsultHistoryGuest([FromBody] ConsultHistoryGuestDTO consultHistoryGuestDto)
        {
            try
            {
                if (consultHistoryGuestDto == null)
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
                    FirstName = consultHistoryGuestDto.FirstName,
                    LastName = consultHistoryGuestDto.LastName,
                    Email = consultHistoryGuestDto.Email,
                    PhoneNumber = consultHistoryGuestDto.PhoneNumber,
                    IsGuest = true // Assuming this is a guest
                };

                var dtConsultHistory = new ConsultHistory
                {
                    DealerCarUnitId = consultHistoryGuestDto.DealerCarUnitId,
                    ConsultDate = consultHistoryGuestDto.ConsultDate,
                    Note = consultHistoryGuestDto.Note,
                    SalesPersonId = consultHistoryGuestDto.SalesPersonId,
                    Budget = consultHistoryGuestDto.Budget
                };

                var dtDealerCar = new DealerCar
                {
                    DealerId = consultHistoryGuestDto.DealerId,
                    CarId = consultHistoryGuestDto.DealerCarUnitId // Assuming DealerCarUnitId maps to CarId
                };

                var result = await _consultHistoryServices.CreateAsyncConsultHistoryGuest(
                    dtCustomer, 
                    dtConsultHistory, 
                    dtDealerCar
                );
                return CreatedAtAction(nameof(CreateConsultHistoryGuest), new { id = result.Id }, result);
            }
            catch (Exception ex)
            {
                // Log the exception as needed
                return StatusCode(StatusCodes.Status500InternalServerError, new { error = "Internal server error", message = ex.Message });
            }
        }
    }
}
